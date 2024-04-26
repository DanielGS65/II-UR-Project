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

namespace URProject.Forms
{
    public partial class ControlArticular : Form
    {
        bool change = false;
        ClassRTDE classRTDE;
        public ControlArticular()
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
            
            Debug.WriteLine("Joint0: {0}\nJoint1: {1}\nJoint2: {2}\nJoint3: {3}\nJoint4: {4}\nJoint5: {5}\n",
                hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value, hScrollBar4.Value, hScrollBar5.Value, hScrollBar6.Value);
            try
            {
                var message = "movej(p[" + hScrollBar1.Value +
                    "," + hScrollBar1.Value +
                    "," + hScrollBar1.Value + 
                    "," + hScrollBar1.Value + 
                    "," + hScrollBar1.Value +
                    "," + hScrollBar1.Value +"], a = 1, v = 0.25, r =0, t =10)" + "\n";
                var messageBytes = Encoding.UTF8.GetBytes(message);
                ClassData.clientControl.Send(messageBytes);
            }
            catch (Exception err)
            {
                Logging.LogInformation(3, "FormMain button1_Click - " + err.Message);
            }
        }
    }
}
