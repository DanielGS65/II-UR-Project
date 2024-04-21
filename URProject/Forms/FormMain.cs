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

        ClassRTDE rtdeClass;

        FormManualMove manualMoveForm;

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
            Logging.CreateLogFile();
            Logging.LogInformation(1,"Logging Started");

            //TrayBar Functions
            notifyIconMain.ContextMenuStrip = new ContextMenuStrip();
            notifyIconMain.ContextMenuStrip.Items.Add("Settings", null, Settings_Click);
            notifyIconMain.ContextMenuStrip.Items.Add("Exit", null, Exit_Click);

            //Forms Init
            manualMoveForm = new FormManualMove();
            manualMoveForm.TopLevel = false;
            this.panelMainContainer.Controls.Add(manualMoveForm);


            //Start ClassRTDE
            rtdeClass = new ClassRTDE(this);

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

        #endregion InitFunctions

        // ---------------------------
        // Form Functions
        // ---------------------------
        #region FormFunctions

        private void button1_Click(object sender, EventArgs e) {

            var message = "movej(p[0.2, -0.2, 0.5, 0, 2, -2], a = 1, v = 0.25, r =0, t =10)" + "\n";
            var messageBytes = Encoding.UTF8.GetBytes(message);
            client.Send(messageBytes);
        }

        private void buttonDebugMarcos(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {

        }

        private void buttonManualMove_Click(object sender, EventArgs e) {
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

        public void hideSecondaryForms() {
            manualMoveForm.Hide();
        }

        #endregion VisualFunctions

    }
}
