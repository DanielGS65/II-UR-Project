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
        public FormManualMove(ClassRTDE rtdeClass) {
            InitializeComponent();
            classRTDE = rtdeClass;
            ControlArticular controlArticular = new ControlArticular(classRTDE);
            controlArticular.TopLevel = true;
            controlArticular.Show();
            controlArticular.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //tabPage2.Controls.Add(controlArticular);
            controlArticular.Show();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
    }
}
