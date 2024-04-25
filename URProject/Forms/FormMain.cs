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
        FormInfoSistema formInfoSistema;
        Form_dioni form_dioni;
        FormArticulas form_articulas;

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
            formInfoSistema = new FormInfoSistema();
            form_dioni = new Form_dioni();
            form_articulas = new FormArticulas();
            //manualMoveForm.TopLevel = false;
            //this.panelManualMove.Controls.Add(manualMoveForm);
            //manualMoveForm.Show();
            form_articulas.Show();

            


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

            var message = "movej(p[-0.175, -0.607, 0.092, 1.211, -1.215, 1.113], a = 1, v = 0.25)" + "\n";
            var messageBytes = Encoding.UTF8.GetBytes(message);
            client.Send(messageBytes);
        }

        private void buttonDebugMarcos(object sender, EventArgs e)
        {
            formInfoSistema.Show();
        }

        #endregion FormFunctions

        private void boton_dioni_Click(object sender, EventArgs e)
        {
            form_dioni.Show();
        }
    }
}
