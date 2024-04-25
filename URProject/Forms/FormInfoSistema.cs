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

namespace URProject.Forms
{
    public partial class FormInfoSistema : Form
    {
        ClassRTDE rtde;
        public FormInfoSistema()
        {
            InitializeComponent();
        }

        public void setRTDE(ClassRTDE rt)
        {
            this.rtde = rt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.rtde.getRobotPos();
        }
    }
}
