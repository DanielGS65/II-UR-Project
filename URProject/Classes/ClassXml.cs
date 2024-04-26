using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using URProject.Forms;

namespace URProject.Classes {
    public class ClassXml {
        // ---------------------------
        // Local Variables
        // ---------------------------
        #region LocalVariables

        FormMain mainForm;
        FormGuardarPose formGuardarPose;

        #endregion LocalVariables

        // ---------------------------
        // Init Functions
        // ---------------------------
        #region InitFunctions

        public ClassXml(FormMain mainForm) {
            this.mainForm = mainForm;
        }
        public ClassXml(FormGuardarPose formGuardarPose)
        {
            this.formGuardarPose = formGuardarPose;
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

        public void createPose()
        {
            // [X, Y, Z, Rx, Ry, Rz]


            XmlDocument document = new XmlDocument();

            XmlNode posesRoot = document.CreateElement("Poses");

            
            document.AppendChild(posesRoot);

            document.Save(ClassData.posePath);
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

        public void addPose(string id,double x, double y, double z, double rx, double ry, double rz)
        {

            XmlDocument document = new XmlDocument();
            try
            {
                document.Load(ClassData.posePath);
            }
            catch (Exception err)
            {
                Logging.LogInformation(2, "ClassXml saveConfig - " + err.Message);
                createPose();
                document.Load(ClassData.posePath);
            }
            XmlNode posesRoot = document.SelectSingleNode("//Poses");
            XmlNode poseRobot = document.CreateElement("Pose");

            XmlAttribute attributeId = document.CreateAttribute("Id");
            XmlAttribute attributeX = document.CreateAttribute("X");
            XmlAttribute attributeY = document.CreateAttribute("Y");
            XmlAttribute attributeZ = document.CreateAttribute("Z");
            XmlAttribute attributeRx = document.CreateAttribute("Rx");
            XmlAttribute attributeRy = document.CreateAttribute("Ry");
            XmlAttribute attributeRz = document.CreateAttribute("Rz");

            poseRobot.Attributes.Append(attributeId);
            poseRobot.Attributes.Append(attributeX);
            poseRobot.Attributes.Append(attributeY);
            poseRobot.Attributes.Append(attributeZ);
            poseRobot.Attributes.Append(attributeRx);
            poseRobot.Attributes.Append(attributeRy);
            poseRobot.Attributes.Append(attributeRz);

            poseRobot.Attributes["Id"].Value = id;
            poseRobot.Attributes["X"].Value = x.ToString();
            poseRobot.Attributes["Y"].Value = y.ToString();
            poseRobot.Attributes["Z"].Value = z.ToString();
            poseRobot.Attributes["Rx"].Value = rx.ToString(); ;
            poseRobot.Attributes["Ry"].Value = ry.ToString(); ;
            poseRobot.Attributes["Rz"].Value = rz.ToString(); ;

            posesRoot.AppendChild(poseRobot);
            document.Save(ClassData.posePath);



        }

        #endregion ModifyFunctions

        // ---------------------------
        // Read Functions
        // ---------------------------
        #region ReadFunctions

        public XmlReader readTrajectory()
        {
            XmlDocument document = new XmlDocument();

            try
            {
                //TODO: Change variable to the trajectory path
                document.Load(ClassData.posePath);

                XmlReader data = new XmlNodeReader(document);
                return data;

            }
            catch (Exception err)
            {
                Logging.LogInformation(2, "ClassXml readTrajectory - " + err.Message);
                return null;
            }
        }


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
