using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace URProject {
    public static class Logging {

        // ---------------------------
        // Global Variables
        // ---------------------------
        #region GlobalVariables

        public static int logLevel;
        public static string logFilePath;
        public static bool logFileBussy;

        #endregion GlobalVariables

        // ---------------------------
        // Logging Functions
        // ---------------------------
        #region LoggingFunctions

        /// <summary>
        /// Creates the new LogFile
        /// </summary>
        public static void CreateLogFile() {
            logFilePath = Path.Combine(ClassData.logPath, DateTime.Now.ToString("yyyy_MM_dd"), "logs_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".txt");
            Directory.CreateDirectory(Path.GetDirectoryName(logFilePath));

            string[] dirs = Directory.GetDirectories(ClassData.logPath, "*", SearchOption.TopDirectoryOnly);

            for (int i = 0; i < dirs.Length; i++) {
                dirs[i] = dirs[i].Replace(ClassData.logPath + "\\", "");
            }

            IOrderedEnumerable<string> list = dirs.OrderByDescending(date => DateTime.ParseExact(date, "yyyy_MM_dd", CultureInfo.InvariantCulture));

            foreach (string folder in list.Skip(5)) {
                System.IO.Directory.Delete(Path.Combine(ClassData.logPath, folder), true);
            }

            LogInformation(4, "Program Version -> " + ClassData.logPath);
        }

        /// <summary>
        /// Display a message in the LogFile depending on the level
        /// </summary>
        /// <param name="level">Level of display<br/>1 Debug - 2 Info - 3 Warning - 4 Error</param>
        /// <param name="message">Message to display</param>
        public static void LogInformation(int level, string message) {
            if (level >= logLevel) {

                string levelText = "System";
                switch (level) {
                    case 0: levelText = "Debug"; break;
                    case 1: levelText = "Info"; break;
                    case 2: levelText = "Warning"; break;
                    case 3: levelText = "Error"; break;
                }
                string text = "[" + levelText + "][" + DateTime.Now.ToString("dd/MM/yyy-HH:mm:ss") + "] - " + message;
                while (logFileBussy) { }
                logFileBussy = true;
                using (FileStream file = new FileStream(logFilePath, FileMode.Append, FileAccess.Write)) {
                    using (StreamWriter writer = new StreamWriter(file)) {
                        writer.WriteLine(text);
                        writer.Close();
                    }
                    file.Close();
                    logFileBussy = false;
                }
            }
        }

        #endregion LoggingFunctions

    }
}
