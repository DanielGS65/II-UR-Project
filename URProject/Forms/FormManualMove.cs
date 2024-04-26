using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            controlArticular.TopLevel = false;
            controlArticular.Show();
            controlArticular.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tabPage2.Controls.Add(controlArticular);
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }
    }
}
