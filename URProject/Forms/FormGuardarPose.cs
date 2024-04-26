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
        private ClassXml classXml;
        private ClassRTDE rtdeClass;

       

        public FormGuardarPose()
        {
            InitializeComponent();
            classXml = new ClassXml(this);
            rtdeClass = new ClassRTDE(this);

            
        }

        private void buttonGuardarHome_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Are you sure?", "Accept", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show("Added pose");
                    //classRTDE.getRobotPos();
                    classXml.addPose(textBox1.Text, 25, 30, 20, 10, 25, 22, "Poses");
                }
                else
                {
                    MessageBox.Show("Declined");
                }

            }
            else
            {
                MessageBox.Show("Please enter pose name");
            }
        }
    }
}
