using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace URProject.Classes
{
    public class ClassDashboardServer
    {

        IPAddress ipAddress;
        IPEndPoint ipEndPoint;

        public void connectSocket()
        {
            try
            {
                this.ipAddress = IPAddress.Parse(ClassData.robotIp);
                this.ipEndPoint = new IPEndPoint(ipAddress, 29999);
                ClassData.clientDashboardServer = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                ClassData.clientDashboardServer.Connect(ipEndPoint);
                Logging.LogInformation(1, "ClassDashboardServer connectSocket - Socket Created");
            }
            catch (Exception err)
            {
                Logging.LogInformation(3, "ClassDashboardServer connectSocket - " + err.Message);
            }

        }

        public void loadProgram(String program)
        {
            sendCommand("load", program);
        }

        public void playProgram()
        {
            sendCommand("play", null);
        }

        public void stopProgram()
        {
            sendCommand("stop", null);
        }

        public void pauseProgram()
        {
            sendCommand("pause", null);
        }

        public void quitProgram()
        {
            sendCommand("quit", null);
        }

        public void shutdownProgram()
        {
            sendCommand("shutdown", null);
        }

        public void runningProgram()
        {
            sendCommand("running", null);
        }

        private void sendCommand(String command, String program)
        {
            try
            {
                String gerund = chooseGerund(command);
                Logging.LogInformation(1, "ClassDashboardServer " + command + "Program - " + gerund + " program ... ");
                var message = command + '\n';

                if (program != null)
                {
                    message = command + " " + program + '\n';
                }
                
                var messageBytes = Encoding.ASCII.GetBytes(message);
                ClassData.clientDashboardServer.Send(messageBytes);
                Logging.LogInformation(1, "ClassDashboardServer " + command + "Program - Message Send: " + message);

                byte[] messageReceived = new byte[1024];
                int byteRecv = ClassData.clientDashboardServer.Receive(messageReceived);

                Logging.LogInformation(1, "ClassDashboardServer " + command + "Program - Message Received: " + Encoding.ASCII.GetString(messageReceived, 0, byteRecv));
            }
            catch (Exception err)
            {
                Logging.LogInformation(3, "ClassDashboardServer " + command + "Program - " + err.Message);
            }
        }

        private String chooseGerund(String verb)
        {
            switch (verb)
            {
                case "load":
                    return "Loading";
                case "play":
                    return "Playing";
                case "stop":
                    return "Stopping";
                case "pause":
                    return "Pausing";
                case "quit":
                    return "Quitting";
                case "shutdown":
                    return "Shutdowing";
                case "running":
                    return "Running";
                default:
                    return "";
            }
        }
    }
}
