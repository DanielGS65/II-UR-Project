using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using URProject.Classes;
using URProject.Forms;

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
        private FormInfoSistema formInfoSistema;
        private Form_dioni dioniForm;
        private FormGuardarPose formGuardarPose;
        private FormDashboardServer dashboardServerForm;

        private FormMostrarPuntos formMostrarPuntos;
        public static RichTextBox richTextBoxLogger;

        IPAddress ipAddress;
        IPEndPoint ipEndPoint;
        Socket client;

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
            dashboardServerForm = new FormDashboardServer();
            manualMoveForm = new FormManualMove(controlClass);
            formGuardarPose = new FormGuardarPose();
            formInfoSistema = new FormInfoSistema(rtdeClass);
            manualMoveForm.TopLevel = false;
            this.panelMainContainer.Controls.Add(manualMoveForm);

            settingsForm = new FormSettings(this,xmlClass);

            formMostrarPuntos = new FormMostrarPuntos(xmlClass, rtdeClass);
            formMostrarPuntos.Show();
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
            if (ClassData.client == null || ClassData.clientControl == null) {
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
                ClassData.client = null;
                ClassData.clientControl = null;
                ChangeConnectionStatus(false);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            //controlClass.moveRobot();
            controlClass.operateTool(true);
            //controlClass.operateTool(false);
            //controlClass.ToggleFreeMovement();
            
        }

        private void buttonDebugMarcos(object sender, EventArgs e) {
            formInfoSistema.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            dioniForm.Show();
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
            formGuardarPose.Show();

        }

        private void buttonDashboardServer_Click(object sender, EventArgs e)
        {
            dashboardServerForm.Show();
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
            richTextBoxLogger.Visible = false;
        }



        #endregion VisualFunctions

    }
}
