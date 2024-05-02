using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using URProject.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace URProject.Forms
{
    public partial class FormArticularMove : Form
    {
        bool change = false;
        ClassRTDE classRTDE;
        public FormArticularMove()
        {
            InitializeComponent();
        }

        private void button12_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            joint1.Text = (hScrollBar1.Value / 100f).ToString();
            joint2.Text = (hScrollBar2.Value / 100f).ToString();
            joint3.Text = (hScrollBar3.Value / 100f).ToString();
            joint4.Text = (hScrollBar4.Value / 100f).ToString();
            joint5.Text = (hScrollBar5.Value / 100f).ToString();
            joint6.Text = (hScrollBar6.Value / 100f).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String j1 = ((float)hScrollBar1.Value / 100f).ToString(CultureInfo.InvariantCulture);
            String j2 = ((float)hScrollBar2.Value / 100f).ToString(CultureInfo.InvariantCulture);
            String j3 = ((float)hScrollBar3.Value / 100f).ToString(CultureInfo.InvariantCulture);
            String j4 = ((float)hScrollBar4.Value / 100f).ToString(CultureInfo.InvariantCulture);
            String j5 = ((float)hScrollBar5.Value / 100f).ToString(CultureInfo.InvariantCulture);
            String j6 = ((float)hScrollBar6.Value / 100f).ToString(CultureInfo.InvariantCulture);
            //var cliente = ClassData.client;
            Debug.WriteLine("Joint0: {0}\nJoint1: {1}\nJoint2: {2}\nJoint3: {3}\nJoint4: {4}\nJoint5: {5}\n",
                j1, j2, j3, j4, j5, j6);
            try
            {
                var message = "movej([" + j1 + "," + j2 + "," + j3 + "," + j4 + "," + j5 + "," + j6 +
                    "], a = 1, v = 0.25, r =0, t =10)" + "\n";
                message = "movej(["+j1+","+j2+","+j3+","+j4+","+j5+","+j6+"], a = 1, v = 0.25, r =0, t =10)" + "\n";
                var messageBytes = Encoding.UTF8.GetBytes(message);
                ClassData.clientControl.Send(messageBytes);
            }
            catch (Exception err)
            {
                Logging.LogInformation(3, "Form ControlaArticular button1_Click - " + err.Message);
            }
        }
    }
}
