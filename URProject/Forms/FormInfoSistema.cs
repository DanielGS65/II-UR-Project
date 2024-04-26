using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using URProject.Classes;

namespace URProject.Forms
{
    public partial class FormInfoSistema : Form
    {
        ClassRTDE rtde;
        static UniversalRobot_Outputs UrOutputs = new UniversalRobot_Outputs();
        public FormInfoSistema(ClassRTDE rt)
        {
            InitializeComponent();
            rtde = rt;

            rtde.OnSockClosed += new EventHandler(Ur3_OnSockClosed);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(rtde.Setup_Ur_Outputs(UrOutputs, 10));
            rtde.OnDataReceive += new EventHandler(Ur3_OnDataReceive);
            rtde.Ur_ControlStart();
        }

        static void Ur3_OnSockClosed(object sender, EventArgs e)
        {
            Debug.WriteLine("Closed");
        }
        static void Ur3_OnDataReceive(object sender, EventArgs e)
        {
            Debug.WriteLine(UrOutputs.actual_q[0]);
        }
    }
}
