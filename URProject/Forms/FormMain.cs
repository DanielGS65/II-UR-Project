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

            manualMoveForm = new FormManualMove();
            //manualMoveForm.TopLevel = false;
            //this.panelManualMove.Controls.Add(manualMoveForm);
            manualMoveForm.Show();

            //Start ClassRTDE
            rtdeClass = new ClassRTDE(this);

            //Check UR Connections
            Ping pinger = new Ping();
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
            }
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

        #endregion FormFunctions

    }
}
