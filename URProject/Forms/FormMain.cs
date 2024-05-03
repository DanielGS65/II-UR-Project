using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using URProject.Classes;
using URProject.Forms;
using System.Xml;

namespace URProject {
    public partial class FormMain : Form {

        // ---------------------------
        // Local Variables
        // ---------------------------
        #region LocalVariables

        private ClassXml xmlClass;
        private ClassRTDE rtdeClass;
        private ClassControl controlClass;
        private ClassDashboardServer dashboardServerClass;

        private FormManualMove manualMoveForm;
        private FormSettings settingsForm;
        private Form_dioni dioniForm;
        private FormDashboardServer dashboardServerForm;
        private FormArticularMove articularMoveForm;

        private FormMostrarPuntos formMostrarPuntos;
        public static RichTextBox richTextBoxLogger;

        #endregion LocalVariables

        // ---------------------------
        // Init Functions
        // ---------------------------
        #region InitFunctions

        public FormMain() {
            InitializeComponent();

            CreateLogger();
            Logging.CreateLogFile();
            Logging.LogInformation(1,"Logging Started");

            //TrayBar Functions
            notifyIconMain.ContextMenuStrip = new ContextMenuStrip();
            notifyIconMain.ContextMenuStrip.Items.Add("Settings", null, Settings_Click);
            notifyIconMain.ContextMenuStrip.Items.Add("Exit", null, Exit_Click);

            //Start Classes
            xmlClass = new ClassXml(this);
            rtdeClass = new ClassRTDE(this);
            dashboardServerClass = new ClassDashboardServer();
            controlClass = new ClassControl();

            //Forms Init
            dioniForm = new Form_dioni();

            articularMoveForm = new FormArticularMove();
            articularMoveForm.TopLevel = false;
            this.panelMainContainer.Controls.Add(articularMoveForm);

            dashboardServerForm = new FormDashboardServer();
            dashboardServerForm.TopLevel = false;
            this.panelMainContainer.Controls.Add(dashboardServerForm);

            manualMoveForm = new FormManualMove(rtdeClass,controlClass,dashboardServerClass);
            manualMoveForm.TopLevel = false;
            manualMoveForm.Size = panelMainContainer.Size;
            this.panelMainContainer.Controls.Add(manualMoveForm);

            /*formGuardarPose = new FormGuardarPose();
            formGuardarPose.TopLevel = false;
            this.panelMainContainer.Controls.Add(formGuardarPose);*/

            //formInfoSistema = new FormInfoSistema(rtdeClass);


            settingsForm = new FormSettings(this,xmlClass);

            formMostrarPuntos = new FormMostrarPuntos(xmlClass, rtdeClass);
            formMostrarPuntos.TopLevel = false;
            this.panelMainContainer.Controls.Add(formMostrarPuntos);

            //Start Secuence
            xmlClass.readConfig();
            this.labelIP.Text = "IP: " + ClassData.robotIp;
            this.labelPort.Text = "Port: " + ClassData.robotPort.ToString();

            if (ClassData.debugMode) {
                buttonLogging.Visible = true;
            }

            if(ClassData.robotIp == "" || ClassData.robotPort.ToString() == "0") {
                settingsForm.updateConfig();
                settingsForm.Show();
            }

            Logging.LogInformation(1, "FormMain - Initialization Completed");
        }

        public void CreateLogger() {
            richTextBoxLogger = new RichTextBox();
            richTextBoxLogger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            richTextBoxLogger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            richTextBoxLogger.Font = new System.Drawing.Font("Segoe UI", 12F);
            richTextBoxLogger.ForeColor = System.Drawing.SystemColors.WindowText;
            richTextBoxLogger.Location = new System.Drawing.Point(-2, -2);
            richTextBoxLogger.Name = "richTextBoxLogger";
            richTextBoxLogger.Size = panelMainContainer.Size;
            richTextBoxLogger.TabIndex = 0;
            richTextBoxLogger.Text = "";
            richTextBoxLogger.Visible = false;
            richTextBoxLogger.TabStop = false;
            richTextBoxLogger.ReadOnly = true;

            panelMainContainer.Controls.Add(richTextBoxLogger);
        }

        #endregion InitFunctions

        // ---------------------------
        // Form Functions
        // ---------------------------
        #region FormFunctions

        private void buttonConnect_Click(object sender, EventArgs e) {
            if (ClassData.rtdeClient == null || ClassData.clientControl == null || ClassData.clientDashboardServer == null) {
                if (rtdeClass.checkRobotConnection()) {
                    Logging.LogInformation(1, "FormMain buttonConnect_Click - Robot Detected, starting Connection");
                    rtdeClass.connectSocket();
                    dashboardServerClass.connectSocket();
                    controlClass.connectRobotControl();
                    ChangeConnectionStatus(true);
                } else {
                    Logging.LogInformation(1, "FormMain buttonConnect_Click - Robot Not Detected");
                    raiseMessageBox("WARNNING: Robot not connected", "Cannot connect to robot. Check if the Robot is online");
                    ChangeConnectionStatus(false);
                }
            } else {
                Logging.LogInformation(1, "FormMain buttonConnect_Click - Disconnecting");
                ClassData.rtdeClient = null;
                ClassData.clientControl = null;
                ClassData.clientDashboardServer = null;
                ChangeConnectionStatus(false);
            }
        }

        private void buttonArticualMove_Click(object sender, EventArgs e) {
            hideSecondaryForms();
            articularMoveForm.Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            //controlClass.moveRobot();
            //controlClass.operateTool(true);
            controlClass.operateTool(false);
            //controlClass.ToggleFreeMovement();
            
        }

        private void buttonLogging_Click(object sender, EventArgs e) {
            hideSecondaryForms();
            richTextBoxLogger.Visible = true;
        }

        private void buttonManualMove_Click(object sender, EventArgs e) {
            hideSecondaryForms();
            manualMoveForm.Show();
        }
        private void buttonPoseTrayectory_Click(object sender, EventArgs e)
        {
            hideSecondaryForms();
            formMostrarPuntos.Show();
            //formGuardarPose.Show();
        }

        private void buttonDashboardServer_Click(object sender, EventArgs e)
        {
            hideSecondaryForms();
            dashboardServerForm.Show();
        }

        private void buttonAutonomous_Click(object sender, EventArgs e) {
            if (!ClassData.autonomousMode) {
                try {
                    ClassData.autonomousMode = true;
                    string message = "def coop_Project():\r\n" +
                        "\twhile(True):\r\n" +
                        "\t\tmodbus_set_output_register(\"cinta_pot\",1,False)\r\n" +
                        "\t\tboton = modbus_get_signal_status(\"boton\",False)\r\n" +
                        "\t\tsensores = modbus_get_signal_status(\"sensores\",False)\r\n" +
                        "\t\tif(not boton == 0):\r\n" +
                        "\t\t\tmodbus_set_output_register(\"led\",0,False)\r\n" +
                        "\t\t\tmodbus_set_output_register(\"cinta_stop\",0,False)\r\n" +
                        "\t\t\tmodbus_set_output_register(\"cinta_vel\",1,False)\r\n" +
                        "\t\tend\r\n" +
                        "\t\tif(not sensores == 0):\r\n" +
                        "\t\t\tmodbus_set_output_register(\"cinta_stop\",1,False)\r\n" +
                        "\t\t\tmodbus_set_output_register(\"cinta_vel\",0,False)\r\n\r\n";


                    XmlDocument document = new XmlDocument();

                    //TODO: Change variable to the trajectory path
                    document.Load(ClassData.trajectoryPath);

                    //XmlReader data = new XmlNodeReader(document);

                    XmlNode node = document.SelectSingleNode("Trajectory");

                    int count = 0;

                    foreach (XmlNode pose in node.ChildNodes) {
                        message = message + "\t\t\tmovej(p[" + pose.Attributes["X"].Value.ToString() + ", " + pose.Attributes["Y"].Value.ToString() + ", " + pose.Attributes["Z"].Value.ToString() + ", " + pose.Attributes["Rx"].Value.ToString() + ", " + pose.Attributes["Ry"].Value.ToString() + ", " + pose.Attributes["Rz"].Value.ToString() + "], a = " + ClassData.acceleration + ", v = " + ClassData.velocity + ", r = " + ClassData.precision + ", t =10)" + "\r\n";
                        count++;
                        if (count == 2) {
                            message = message + "\t\t\tset_tool_voltage(24)\r\n" +
                            "\t\t\tsleep(1)\r\n" +
                            "\t\t\tset_tool_digital_out(0,True)\r\n" +
                            "\t\t\tsleep(0.5)\r\n\r\n";
                        }
                        if (count == 5) {
                            message = message + "\t\t\tset_tool_digital_out(0,False)\r\n" +
                            "\t\t\tsleep(1)\r\n" +
                            "\t\t\tset_tool_voltage(0)\r\n" +
                            "\t\t\tsleep(0.5)\r\n";
                        }
                    }

                    message = message + "\t\t\tmodbus_set_output_register(\"led\",255,False)\r\n" +

                        "\t\tend\r\n" +
                        "\tend\r\n" +
                        "end\r\n" +
                        "coop_Project()";

                    var messageBytes = Encoding.UTF8.GetBytes(message);
                    ClassData.clientControl.Send(messageBytes);
                    buttonAutonomous.BackColor = Color.Green;
                    Logging.LogInformation(0, "FormMain buttonAutonomous_Click - " + message);

                } catch(Exception err) { Logging.LogInformation(3, "FormMain buttonAutonomous_Click - " + err.Message); }
            } else {
                ClassData.autonomousMode = false;
                dashboardServerClass.stopProgram();
                buttonAutonomous.BackColor = Color.Gray;
            }
        }

        #endregion FormFunctions

        // ---------------------------
        // SystemTray Functions
        // ---------------------------
        #region SystemTrayFunctions

        /// <summary>
        /// Raises a Windows notification
        /// </summary>
        /// <param name="message">Message to display on notification</param>
        public void raiseNotification(string message) {
            notifyIconMain.BalloonTipTitle = "UR-Project Notification";
            notifyIconMain.BalloonTipText = message;
            notifyIconMain.ShowBalloonTip(2000);

            Logging.LogInformation(1, "FormMain raiseNotification - Notification Raised");
            Logging.LogInformation(0, "FormMain raiseNotification - Message: " + message);
        }

        /// <summary>
        /// Raises a MessageBox Window with a Warning text
        /// </summary>
        /// <param name="title">Title of the window</param>
        /// <param name="text">Text of the message</param>
        public void raiseMessageBox(string title, string text) {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

            Logging.LogInformation(1, "FormMain raiseMessageBox - MessageBox Raised");
            Logging.LogInformation(0, "FormMain raiseMessageBox - Message: " + title + " - " + text);
        }

        private void Exit_Click(object sender, EventArgs e) {
            Logging.LogInformation(1, "FormMain Exit_Click - Closing aplication on User Instructions");
            Application.Exit();
        }

        private void Settings_Click(object sender, EventArgs e) {
            settingsForm.updateConfig();
            settingsForm.Show();
        }

        private void notifyIconMain_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.Show();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing) {
                this.Hide();
                raiseNotification("Aplication will be on standBy in the TrayBar");
                e.Cancel = true;

                Logging.LogInformation(1, "FormMain FormMain_FormClosing - Minimizing to TrayBar");
            } else {
                Logging.LogInformation(1, "FormMain FormMain_FormClosing - Closing aplication");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxPosX.Text = ClassData.currentPos[0].ToString();
            textBoxPosY.Text = ClassData.currentPos[1].ToString();
            textBoxPosZ.Text = ClassData.currentPos[2].ToString();

            textBoxRotX.Text = ClassData.currentPos[3].ToString();
            textBoxRotY.Text = ClassData.currentPos[4].ToString();
            textBoxRotZ.Text = ClassData.currentPos[5].ToString();
        }

        #endregion SystemTrayFunctions

        // ---------------------------
        // Visual Functions
        // ---------------------------
        #region VisualFunctions

        public void ChangeConnectionStatus(bool connected) {
            if (connected) {
                panelConectionLed.BackColor = Color.LightGreen;
                labelConectionStatus.Text = "Connected";
                buttonConnect.Text = "Disconnect";
            } else {
                panelConectionLed.BackColor = Color.Red;
                labelConectionStatus.Text = "Disconnected";
                buttonConnect.Text = "Connect to UR";
            }
        }

        public void hideSecondaryForms() {
            manualMoveForm.Hide();
            dashboardServerForm.Hide();
            articularMoveForm.Hide();
            formMostrarPuntos.Hide();
            richTextBoxLogger.Visible = false;
        }

        #endregion VisualFunctions

    }
}
