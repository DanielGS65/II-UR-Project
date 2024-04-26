using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
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

        private FormManualMove manualMoveForm;
        private FormSettings settingsForm;
        private Form_dioni dioniForm;

        public static RichTextBox richTextBoxLogger;
        //FormLogging loggingForm;

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

            //Forms Init
            dioniForm = new Form_dioni();
            manualMoveForm = new FormManualMove(rtdeClass);
            manualMoveForm.TopLevel = false;
            this.panelMainContainer.Controls.Add(manualMoveForm);

            settingsForm = new FormSettings(this,xmlClass);

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

            //Check UR Connections
            /*Ping pinger = new Ping();
            PingReply reply = pinger.Send(ClassData.ip);
            if (reply.Status != IPStatus.Success) {
                Logging.LogInformation(2, "FormMain - UR is disconected");
            } else {

                //Connect to UR
                this.ipAddress = IPAddress.Parse(ClassData.ip);
                this.ipEndPoint = new IPEndPoint(ipAddress, ClassData.port);

                this.client = new Socket(ipEndPoint.AddressFamily, SocketType.Stream,
                ProtocolType.Tcp);
                client.Connect(ipEndPoint);
                Logging.LogInformation(1, "FormMain - UR is connected");
            }*/
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
        #region FormFunctions

        private void buttonConnect_Click(object sender, EventArgs e) {
            if (ClassData.client == null) {
                if (rtdeClass.checkRobotConnection()) {
                    Logging.LogInformation(1, "FormMain buttonConnect_Click - Robot Detected, starting Connection");
                    rtdeClass.connectSocket();
                    ChangeConnectionStatus(true);
                } else {
                    Logging.LogInformation(1, "FormMain buttonConnect_Click - Robot Not Detected");
                    raiseMessageBox("WARNNING: Robot not connected", "Cannot connect to robot. Check if the Robot is online");
                    ChangeConnectionStatus(false);
                }
            } else {
                Logging.LogInformation(1, "FormMain buttonConnect_Click - Disconnecting");
                ClassData.client = null;
                ChangeConnectionStatus(false);
            }
        }

        private void button1_Click(object sender, EventArgs e) {

            try {
                var message = "movej(p[0.2, -0.2, 0.5, 0, 2, -2], a = 1, v = 0.25, r =0, t =10)" + "\n";
                var messageBytes = Encoding.UTF8.GetBytes(message);
                client.Send(messageBytes);
            }catch(Exception err) {
                Logging.LogInformation(3, "FormMain button1_Click - " + err.Message);
            }
            
        }

        private void buttonDebugMarcos(object sender, EventArgs e) {

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
#endregion