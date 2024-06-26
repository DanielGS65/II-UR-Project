﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URProject {
    public static class ClassData {
        public static string logPath = Path.Combine(Path.GetPathRoot(Environment.SystemDirectory), "UR-Project", "logs");
        public static string configPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "UR-Project","config.xml");
        public static TcpClient rtdeClient;
        public static string posePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "UR-Project", "pose.xml");
        public static string trajectoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "UR-Project", "trajectory.xml");

        public static Socket clientControl;

        public static double acceleration = 1;
        public static double velocity = 0.5;
        public static double precision = 0;

        public static bool autonomousMode = false;

        public static bool toolStatus = false;

        public static bool freeDriveMode = false;
        public static Socket clientDashboardServer;

        public static string robotIp;
        public static int robotPort;
        public static bool debugMode;
        public static int logLevel = 3;

        public static List<double> currentPos = new List<double> { 0, 0, 0, 0, 0, 0 };

        public static bool toolSuctionCheck;
    }
}
