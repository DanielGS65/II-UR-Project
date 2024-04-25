using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URProject.Forms
{
    public partial class FormGuardarPose : Form
    {
        public FormGuardarPose()
        {
            InitializeComponent();
        }

        private bool flag;

        private void buttonGuardarExtra_Click(object sender, EventArgs e)
        {
            flag = formConfirmacionLlamada(sender, e);

            if (flag) {
                // Guardar los datos de la pos del robot
            }
        }

        private void buttonGuardarEstirar_Click(object sender, EventArgs e)
        {
            flag = formConfirmacionLlamada(sender, e);

            if (flag)
            {
                // Guardar los datos de la pos del robot
            }
        }

        private void buttonGuardarRecoger_Click(object sender, EventArgs e)
        {
            flag = formConfirmacionLlamada(sender, e);

            if (flag)
            {
                // Guardar los datos de la pos del robot
            }
        }

        private void buttonGuardarHome_Click(object sender, EventArgs e)
        {
            flag = formConfirmacionLlamada(sender, e);

            if (flag)
            {
                // Guardar los datos de la pos del robot
            }
        }

        private bool formConfirmacionLlamada(object sender, EventArgs e)
        {
            FormConfirmacion fc = new FormConfirmacion();
            fc.ShowDialog();

            return fc.boolPlaceHolder;
            
        }
    }
}
