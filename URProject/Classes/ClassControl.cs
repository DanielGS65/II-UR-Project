﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace URProject.Classes {
    public class ClassControl {

        // ---------------------------
        // Local Variables
        // ---------------------------
        #region LocalVariables

        IPAddress ipAddress;
        IPEndPoint ipEndPoint;

        #endregion LocalVariables

        // ---------------------------
        // Init Functions
        // ---------------------------
        #region InitFunctions

        public ClassControl() { 
        }

        public void connectRobotControl() {
            try {
                this.ipAddress = IPAddress.Parse(ClassData.robotIp);
                this.ipEndPoint = new IPEndPoint(ipAddress, 30001);
                ClassData.clientControl = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                ClassData.clientControl.Connect(ipEndPoint);
                Logging.LogInformation(1, "ClassControl connectRobotControl - Socket Created");

                //moveRobot(ClassData.currentPos);
            } catch (Exception err) {
                Logging.LogInformation(3, "ClassControl connectRobotControl - " + err.Message);
            }
        }

        #endregion InitFuntions

        // ---------------------------
        // Robot Movement
        // ---------------------------
        #region RobotMovement

        public void moveRobot(List<double> position) {
            try {
                var message = "movej(p[" + position[0] + ", " + position[1] + ", " + position[2] + ", " + position[3] + ", " + position[4] + ", " + position[5] + "], a = " + ClassData.acceleration + ", v = " + ClassData.velocity + ", r = " + ClassData.precision + ", t =10)" + "\n";
                var messageBytes = Encoding.UTF8.GetBytes(message);
                ClassData.clientControl.Send(messageBytes);
            } catch (Exception err) {
                Logging.LogInformation(3, "FormMain button1_Click - " + err.Message);
            }
        }

        public void operateTool(bool activate) {
            if (activate) {
                var message = "\tset_tool_voltage(24)\n";
                var messageBytes = Encoding.UTF8.GetBytes(message);
                ClassData.clientControl.Send(messageBytes);

                Thread.Sleep(1000);

                message = "\tset_tool_digital_out(0,True)\n";
                messageBytes = Encoding.UTF8.GetBytes(message);
                ClassData.clientControl.Send(messageBytes);

                ClassData.toolStatus = true;            
            }
            else{
                var message = "\tset_tool_voltage(0)\n";
                var messageBytes = Encoding.UTF8.GetBytes(message);
                ClassData.clientControl.Send(messageBytes);

                Thread.Sleep(1000);

                message = "\tset_tool_digital_out(0,False)\n";
                messageBytes = Encoding.UTF8.GetBytes(message);
                ClassData.clientControl.Send(messageBytes);

                ClassData.toolStatus = true;
                ClassData.toolStatus = false;
            }
        }

        public void ToggleFreeMovement() {
            if (!ClassData.freeDriveMode) {
                try {
                    string message = "def freeDrive():\n" +
                        "\tfreedrive_mode()\n " +
                        "\tsleep(100)\n" +
                        "end\n" +
                        "freeDrive()";
                    var messageBytes = Encoding.UTF8.GetBytes(message);
                    ClassData.clientControl.Send(messageBytes);
                    ClassData.freeDriveMode = true;
                } catch (Exception err) {
                    Logging.LogInformation(3, "FormMain button1_Click - " + err.Message);
                }
            } else {
                try {
                    string message = "end_freedrive_mode() \n ";
                    var messageBytes = Encoding.UTF8.GetBytes(message);
                    ClassData.clientControl.Send(messageBytes);
                    ClassData.freeDriveMode = false;
                } catch (Exception err) {
                    Logging.LogInformation(3, "FormMain button1_Click - " + err.Message);
                }
            }
        }

        #endregion RobotMovement

    }
}
