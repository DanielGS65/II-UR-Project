using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace URProject.Classes {
    public class ClassXml {
        // ---------------------------
        // Local Variables
        // ---------------------------
        #region LocalVariables

        FormMain mainForm;

        #endregion LocalVariables

        // ---------------------------
        // Init Functions
        // ---------------------------
        #region InitFunctions

        public ClassXml(FormMain mainForm) {
            this.mainForm = mainForm;
        }

        #endregion InitFunctions

        // ---------------------------
        // Create Functions
        // ---------------------------
        #region CreateFunctions

        public void createConfig() {

            XmlDocument document = new XmlDocument();

            XmlNode elementRoot = document.CreateElement("Config");

            XmlNode elementRobot = document.CreateElement("Robot");
            XmlAttribute attributeIp = document.CreateAttribute("Ip");
            XmlAttribute attributePort = document.CreateAttribute("Port");
            elementRobot.Attributes.Append(attributeIp);
            elementRobot.Attributes.Append(attributePort);

            XmlNode elementModbus = document.CreateElement("Modbus");

            XmlNode elementDebug = document.CreateElement("Debug");
            XmlAttribute attributeEnable = document.CreateAttribute("Enable");
            attributeEnable.Value = "false";
            elementDebug.Attributes.Append(attributeEnable);

            XmlNode elementLogging = document.CreateElement("Logging");
            XmlAttribute attributeLevel = document.CreateAttribute("Level");
            attributeLevel.Value = "3";
            elementLogging.Attributes.Append(attributeLevel);

            elementRoot.AppendChild(elementRobot);
            elementRoot.AppendChild(elementModbus);
            elementRoot.AppendChild(elementDebug);
            elementRoot.AppendChild(elementLogging);

            document.AppendChild(elementRoot);

            document.Save(ClassData.configPath);
        }

        #endregion CreateFunctions

        // ---------------------------
        // Modify Functions
        // ---------------------------
        #region ModifyFunctions

        public void saveConfig() {
            XmlDocument document = new XmlDocument();
            try {
                document.Load(ClassData.configPath);

                XmlNode nodeRobot = document.SelectSingleNode("//Config/Robot");
                nodeRobot.Attributes["Ip"].Value = ClassData.robotIp;
                nodeRobot.Attributes["Port"].Value = ClassData.robotPort.ToString();

                XmlNode nodeDebug = document.SelectSingleNode("//Config/Debug");
                nodeDebug.Attributes["Enable"].Value = ClassData.debugMode.ToString();

                XmlNode nodeLogging = document.SelectSingleNode("//Config/Logging");
                nodeLogging.Attributes["Level"].Value = ClassData.logLevel.ToString();

                document.Save(ClassData.configPath);

            } catch (Exception err) {
                Logging.LogInformation(2, "ClassXml saveConfig - " + err.Message);
                createConfig();
            }
        }

        #endregion ModifyFunctions

        // ---------------------------
        // Read Functions
        // ---------------------------
        #region ReadFunctions

        public void readConfig() {
            XmlDocument document = new XmlDocument();

            try {
                document.Load(ClassData.configPath);

                XmlNode nodeRobot = document.SelectSingleNode("//Config/Robot");
                ClassData.robotIp = nodeRobot.Attributes["Ip"].Value.ToString();
                ClassData.robotPort = int.Parse(nodeRobot.Attributes["Port"].Value.ToString());

                XmlNode nodeDebug = document.SelectSingleNode("//Config/Debug");
                ClassData.debugMode = nodeDebug.Attributes["Enable"].Value == "True";

                XmlNode nodeLogging = document.SelectSingleNode("//Config/Logging");
                ClassData.logLevel = int.Parse(nodeLogging.Attributes["Level"].Value.ToString());
            }catch(Exception err) {
                Logging.LogInformation(2, "ClassXml readConfig - " + err.Message);
                createConfig();
            }
            

        }

        #endregion ReadFunctions

    }
}
