using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace URProject.Classes {
    public class ClassRTDE {

        FormMain mainForm;
        IPAddress ipAddress;
        IPEndPoint ipEndPoint;


        public ClassRTDE(FormMain mainForm) {
            this.mainForm = mainForm;
            Logging.LogInformation(1, "ClassRTDE - Initialization Completed");
        }

        public bool checkRobotConnection()
        {
            Logging.LogInformation(1, "ClassRTDE - Checking robot connection...");
            Ping pinger = new Ping();
            PingReply reply = pinger.Send(ClassData.ip);
            return reply.Status == IPStatus.Success;
        }

        public void connectSocket()
        {
            if(!checkRobotConnection())
            {
                // Se muestra la pantalla de Error de Conexión @Dani
                return;
            }

            Debug.WriteLine("Conexion ok");
            this.ipAddress = IPAddress.Parse(ClassData.ip);
            this.ipEndPoint = new IPEndPoint(ipAddress, ClassData.port);
            ClassData.client = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            ClassData.client.Connect(ipEndPoint);
        }

        public void getRobotPos()
        {
            var message = "actual_TCP_pose";
            var messageBytes = Encoding.UTF8.GetBytes(message);
            ClassData.client.Send(messageBytes);
            Debug.WriteLine("Enviado: " + message);

            byte[] messageReceived = new byte[1024];
            int byteRecv = ClassData.client.Receive(messageReceived);

            Debug.WriteLine(Encoding.UTF8.GetString(messageReceived, 0, byteRecv));
        }
    }
}
