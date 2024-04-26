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
    public partial class FormArticulas : Form
    {
        Form form_conf = new Confirmacion();
        public FormArticulas()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas continuar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la opción seleccionada por el usuario
            if (resultado == DialogResult.Yes)
            {
                // El usuario ha confirmado, hacer algo
                MessageBox.Show("Acción confirmada.");
            }
            else
            {
                // El usuario ha cancelado, hacer algo (opcional)
                MessageBox.Show("Acción cancelada.");
            }
        }
    }
}
