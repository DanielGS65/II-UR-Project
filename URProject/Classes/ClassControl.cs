﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

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

        public ClassControl() { }

        public void connectRobotControl() {
            try {
                this.ipAddress = IPAddress.Parse(ClassData.robotIp);
                this.ipEndPoint = new IPEndPoint(ipAddress, 30001);
                ClassData.clientControl = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                ClassData.clientControl.Connect(ipEndPoint);
                Logging.LogInformation(1, "ClassControl connectRobotControl - Socket Created");
            } catch (Exception err) {
                Logging.LogInformation(3, "ClassControl connectRobotControl - " + err.Message);
            }
        }

        #endregion InitFuntions

        // ---------------------------
        // Robot Movement
        // ---------------------------
        #region RobotMovement

        public void moveRobot(double X, double Y, double Z, double RX, double RY, double RZ) {
            try {
                var message = "movej(p[" + X + ", " + Y + ", " + Z + ", " + RX + ", " + RY + ", " + RZ + "], a = 1, v = 0.25, r =0, t =10)" + "\n";
                var messageBytes = Encoding.UTF8.GetBytes(message);
                ClassData.clientControl.Send(messageBytes);
            } catch (Exception err) {
                Logging.LogInformation(3, "FormMain button1_Click - " + err.Message);
            }
        }

        public void ToggleFreeMovement() {
            if (!ClassData.freeDriveMode) {
                try {
                    for (int i = 0; i < 10; i++) {


                        string message = "def freeDrive():\n" +
                            "\tfreedrive_mode()\n " +
                            "\tsleep(100)\n" +
                            "end\n" +
                            "freeDrive()";
                        var messageBytes = Encoding.UTF8.GetBytes(message);
                        ClassData.clientControl.Send(messageBytes);
                        
                    }

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