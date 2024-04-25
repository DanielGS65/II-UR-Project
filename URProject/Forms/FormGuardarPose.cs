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
    public partial class FormGuardarPose : Form
    {
        ClassRTDE classRTDE;
        public FormGuardarPose()
        {
            InitializeComponent();
        }

        private bool flag;

        private void buttonGuardarExtra_Click(object sender, EventArgs e)
        {
            flag = formConfirmacionLlamada(sender, e);

            if (flag) {
                classRTDE.getRobotPos();
            }
        }

        private void buttonGuardarEstirar_Click(object sender, EventArgs e)
        {
            flag = formConfirmacionLlamada(sender, e);

            if (flag)
            {
                classRTDE.getRobotPos();
            }
        }

        private void buttonGuardarRecoger_Click(object sender, EventArgs e)
        {
            flag = formConfirmacionLlamada(sender, e);

            if (flag)
            {
                classRTDE.getRobotPos();
            }
        }

        private void buttonGuardarHome_Click(object sender, EventArgs e)
        {
            flag = formConfirmacionLlamada(sender, e);

            if (flag)
            {
                classRTDE.getRobotPos();
            }
        }

        private bool formConfirmacionLlamada(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas continuar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            bool res;
                        
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Acción confirmada.");
                res = true;
            }
            else
            {
                MessageBox.Show("Acción cancelada.");
                res = false;
            }

            return res;

        }
    }
}
