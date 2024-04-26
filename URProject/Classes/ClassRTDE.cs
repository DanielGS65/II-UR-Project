using System;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;

namespace URProject.Classes
{
    public class ClassRTDE {
        enum RTDE_Command
        {
            REQUEST_PROTOCOL_VERSION = 86,
            GET_URCONTROL_VERSION = 118,
            TEXT_MESSAGE = 77,
            DATA_PACKAGE = 85,
            CONTROL_PACKAGE_SETUP_OUTPUTS = 79,
            CONTROL_PACKAGE_SETUP_INPUTS = 73,
            CONTROL_PACKAGE_START = 83,
            CONTROL_PACKAGE_PAUSE = 80
        };
        public String ErrorMessage { get; private set; }
        ManualResetEvent receiveDone = new ManualResetEvent(false);

        byte Outputs_Recipe_Id, Inputs_Recipe_Id;
        object UrStructOuput, UrStructInput;
        IEncoderDecoder[] UrStructOuputDecoder, UrStructInputDecoder;

        public event EventHandler OnDataReceive;
        public event EventHandler OnSockClosed;

        FormMain mainForm;

        int TimeOut = 500;

        byte[] bufRecv = new byte[1500]; // Enough to hold a full OK CONTROL_PACKAGE_SETUP_OUTPUTS response

        public ClassRTDE(FormMain mainForm) {
            this.mainForm = mainForm;
            Logging.LogInformation(1, "ClassRTDE - Initialization Completed");
        }

        public ClassRTDE(FormGuardarPose formGuardarPose)
        {
            this.formGuardarPose = formGuardarPose;
            Logging.LogInformation(1, "ClassRTDE (FormGuardarPose) - Initialization Completed ");
        }

        public bool checkRobotConnection()
        {
            Logging.LogInformation(1, "ClassRTDE checkRobotConnection - Checking robot connection...");
            Ping pinger = new Ping();
            PingReply reply = pinger.Send(ClassData.robotIp);
            return reply.Status == IPStatus.Success;
        }

        public bool connectSocket(int timeOut = 500)
        {
            ClassData.client = new TcpClient();
            byte[] InternalbufRecv = new byte[bufRecv.Length];
            TimeOut = timeOut;

            try
            {
                ClassData.client.Connect(ClassData.robotIp, ClassData.robotPort);
                ClassData.client.Client.BeginReceive(InternalbufRecv, 0, InternalbufRecv.Length, SocketFlags.None, AsynchReceive, InternalbufRecv);
                
                return Set_UR_Protocol_Version(2);
            }
            catch { return false;}
        }

        private void AsynchReceive(IAsyncResult ar)
        {
            int bytesRead = ClassData.client.Client.EndReceive(ar);
            byte[] InternalbufRecv = (byte[])ar.AsyncState;

            if (bytesRead > 0)
            {

                lock (bufRecv)
                    Array.Copy(InternalbufRecv, bufRecv, InternalbufRecv.Length);

                if (InternalbufRecv[2] == (byte)RTDE_Command.TEXT_MESSAGE)
                {
                    ErrorMessage = Encoding.ASCII.GetString(InternalbufRecv, 4, InternalbufRecv[3]); // try catch not required
                }

                receiveDone.Set();

                ClassData.client.Client.BeginReceive(InternalbufRecv, 0, InternalbufRecv.Length, SocketFlags.None, AsynchReceive, InternalbufRecv);

                try
                {
                    if (bufRecv[2] == (byte)RTDE_Command.DATA_PACKAGE)
                    {
                        int offset = 3;

                        offset++;
                        if (bufRecv[3] != Outputs_Recipe_Id) return;
                        
                        FieldInfo[] f = UrStructOuput.GetType().GetFields();

                        for (int i = 0; i < f.Length; i++)
                        {
                            object currentvalue = f[i].GetValue(UrStructOuput);

                            if (f[i].FieldType.IsArray)
                                UrStructOuputDecoder[i].Decode(ref currentvalue, bufRecv, ref offset); // value type
                            else
                                f[i].SetValue(UrStructOuput, UrStructOuputDecoder[i].Decode(ref currentvalue, bufRecv, ref offset));
                        }

                        if (OnDataReceive != null)
                            OnDataReceive(this, null);
                    }
                }
                catch { }
            }
            else
                if (OnSockClosed != null)
                OnSockClosed(this, null);
        }
        public void Disconnect()
        {
            ClassData.client.Close();
        }

        private void SendRtdePacket(RTDE_Command RTDEType, byte[] payload = null)
        {
            ErrorMessage = null;

            if (payload == null) payload = new byte[0];

            byte[] s = new byte[payload.Length + 3];

            byte[] size = BitConverter.GetBytes(payload.Length + 3);

            s[0] = size[1];
            s[1] = size[0];
            s[2] = (byte)RTDEType;

            if (payload != null)
                Array.Copy(payload, 0, s, 3, payload.Length);

            receiveDone.Reset();
            ClassData.client.Client.BeginSend(s, 0, s.Length, SocketFlags.None, null, null); // not Send() to be thread safe with the BeginReceive

        }
        private bool Send_UR_Command(RTDE_Command Cmd, byte[] payload = null)
        {
            SendRtdePacket(Cmd, payload);
            if (receiveDone.WaitOne(TimeOut))
            {
                lock (bufRecv)
                {
                    return (bufRecv[2] == (byte)Cmd);
                }
            }
            return false;
        }
        public bool Ur_ControlStart()
        {
            return Send_UR_Command(RTDE_Command.CONTROL_PACKAGE_START);
        }

        private bool Setup_Ur_Outputs(RTDE_Command Cmd, object UrStruct, out IEncoderDecoder[] encoder, double Frequency = 20)
        {
            // Get the public fields in the structure 
            FieldInfo[] f = UrStruct.GetType().GetFields();
            encoder = new IEncoderDecoder[f.Length];

            StringBuilder b = new StringBuilder();
            for (int i = 0; i < f.Length; i++)
            {
                b.Append((i == 0 ? "" : ",") + f[i].Name); // build the RTDE request : names and comma

                if (f[i].FieldType.IsArray) // link to the encoder/decoder
                {
                    Array array = f[i].GetValue(UrStruct) as Array;
                    object element = array.GetValue(0);
                    encoder[i] = new EncodeArray(array.Length, element.GetType());
                }
                else
                    encoder[i] = new EncodeValue(f[i].FieldType);
            }

            byte[] payload;

            payload = new byte[b.Length + 8];

            byte[] Freq = BitConverter.GetBytes(Frequency);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(Freq);
            Array.Copy(Freq, 0, payload, 0, 8);
            Array.Copy(Encoding.ASCII.GetBytes(b.ToString()), 0, payload, 8, b.Length);

            if (Send_UR_Command(Cmd, payload) == true)
            {
                Outputs_Recipe_Id = bufRecv[3];

                String s = Encoding.ASCII.GetString(bufRecv, 3, bufRecv.Length - 3);

                if (s.Contains("NOT_FOUND")) return false;
                if (s.Contains("IN_USE")) return false;

                return true;
            }
            return false;
        }

        public bool Setup_Ur_Outputs(object UrStruct, double Frequency = 1)
        {
            this.UrStructOuput = UrStruct;
            return Setup_Ur_Outputs(RTDE_Command.CONTROL_PACKAGE_SETUP_OUTPUTS, UrStruct, out UrStructOuputDecoder, Frequency);
        }

        private bool Set_UR_Protocol_Version(uint Version)
        {
            byte[] V = { 0, (byte)Version };

            bool ret = Send_UR_Command(RTDE_Command.REQUEST_PROTOCOL_VERSION, V);

            return ret;
        }

    }
}
