using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace URProject {
    public static class ClassData {
        public static string logPath = "UR-Proyect";
        public static string ip = "192.168.50.3";
        public static int port = 30002;
        public static int logLevel = 0;
        public static Socket client;
    }
}
