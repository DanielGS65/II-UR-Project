using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using URProject.Classes;

namespace URProject.Forms {
    public partial class FormManualMove : Form {
        ClassRTDE classRTDE;
        ClassControl controlClass;
        public FormManualMove(ClassRTDE rtdeClass, ClassControl controlClass) {
            InitializeComponent();
            classRTDE = rtdeClass;
            ControlArticular controlArticular = new ControlArticular(classRTDE);
            controlArticular.TopLevel = false;
            controlArticular.Show();
            controlArticular.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //tabPage2.Controls.Add(controlArticular);
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.controlClass = controlClass;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button_up_Click(object sender, EventArgs e) {
            ClassData.currentPos[2] = ClassData.currentPos[2] + 10;
            controlClass.moveRobot(ClassData.currentPos);
        }
    }
}
