using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using URProject.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace URProject.Forms
{
    public partial class ControlArticular : Form
    {
        bool change = false;
        ClassRTDE classRTDE;
        public ControlArticular(ClassRTDE rtdeClass)
        {
            InitializeComponent();
            classRTDE = rtdeClass;
        }

        private void button12_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            float j1 = (float) hScrollBar1.Value / 100f;
            float j2 = (float) hScrollBar2.Value / 100f;
            float j3 = (float) hScrollBar3.Value / 100f;
            float j4 = (float) hScrollBar4.Value / 100f;
            float j5 = (float) hScrollBar5.Value / 100f;
            float j6 = (float) hScrollBar6.Value / 100f;
            //var cliente = ClassData.client;
            Debug.WriteLine("Joint0: {0}\nJoint1: {1}\nJoint2: {2}\nJoint3: {3}\nJoint4: {4}\nJoint5: {5}\n",
                j1, j2, j3, j4, j5, j6);
            try
            {
                var message = "movej(p[" + j1+","+j2+","+j2+","+j3+","+j4+","+j5+
                    "], a = 1, v = 0.25, r =0, t =10)" + "\n";
                var messageBytes = Encoding.UTF8.GetBytes(message);
                //cliente.Send(messageBytes);
            }
            catch (Exception err)
            {
                Logging.LogInformation(3, "FormMain button1_Click - " + err.Message);
            }
        }
    }
}
