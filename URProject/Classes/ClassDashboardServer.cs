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

        public void playProgram()
        {
            sendCommand("play");
        }

        public void stopProgram()
        {
            sendCommand("stop");
        }

        public void pauseProgram()
        {
            sendCommand("pause");
        }

        public void quitProgram()
        {
            sendCommand("quit");
        }

        public void shutdownProgram()
        {
            sendCommand("shutdown");
        }

        public void runningProgram()
        {
            sendCommand("running");
        }

        private void sendCommand(String command)
        {
            String gerund = chooseGerund(command);
            Logging.LogInformation(1, "ClassDashboardServer " + command + "Program - " + gerund + " program ... ");

            var message = command;
            var messageBytes = Encoding.ASCII.GetBytes(message);
            ClassData.clientDashboardServer.Send(messageBytes);
            Logging.LogInformation(1, "ClassDashboardServer " + command + "Program - Message Send: " + message);

            // byte[] messageReceived = new byte[1024];
            // int byteRecv = ClassData.clientDashboardServer.Receive(messageReceived);

            // Logging.LogInformation(1, "ClassDashboardServer " + command + "Program - Message Received: " + Encoding.ASCII.GetString(messageReceived, 0, byteRecv));
        }

        private String chooseGerund(String verb)
        {
            switch (verb)
            {
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
