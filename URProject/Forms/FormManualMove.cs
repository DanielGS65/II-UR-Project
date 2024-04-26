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

        // Variables
        private int speed; // Variable para almacenar la velocidad
        private int accel; // Variable para almacenar la acceleracion
        private int precision; // Variable para almacenar la precision
        public FormManualMove(ClassRTDE rtdeClass, ClassControl controlClass) {
            InitializeComponent();
            classRTDE = rtdeClass;
            ControlArticular controlArticular = new ControlArticular(classRTDE);
            controlArticular.TopLevel = true;
            controlArticular.Show();
            controlArticular.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //tabPage2.Controls.Add(controlArticular);
            controlArticular.Show();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.controlClass = controlClass;
        }

        private void label1_Click_1(object sender, EventArgs e)
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


        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        public void buttonMove_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Name)
            {
                // Posicion TCP
                case "button_x_up":  // X-
                    ClassData.currentPos[0] -= 1;
                break;
                case "button_x_down":  // X+
                    ClassData.currentPos[0] += 1;
                break;
                case "button_y_left":  // Y-
                    ClassData.currentPos[1] -= 1;
                break;
                case "button_y_right":  // Y+
                    ClassData.currentPos[1] += 1;
                break;
                case "button_z_up":  // Z+
                    ClassData.currentPos[2] += 1;
                break;
                case "button_z_down":  // Z-
                    ClassData.currentPos[2] -= 1;
                break;
                // Orientacion TCP
                case "button_rx_left":  // RX+
                    ClassData.currentPos[3] += 1;
                break;
                case "button_rx_right":  // RX-
                    ClassData.currentPos[3] -= 1;
                break;
                case "button_ry_down":  // RY+
                    ClassData.currentPos[4] += 1;
                break;
                case "button_ry_up":  // RY-
                    ClassData.currentPos[4] -= 1;
                break;
                case "button_rz_left":  // RZ+
                    ClassData.currentPos[5] += 1;
                break;
                case "button_rz_right":  // RZ-
                    ClassData.currentPos[5] -= 1;
                break;
            }

            //if (button.Name.Contains("z_up"))
            //{
                //ClassData.currentPos[2] += 1;
            //}
            controlClass.moveRobot(ClassData.currentPos);
        }

        private void numeric_speed_ValueChanged(object sender, EventArgs e)
        {
            // Actualiza la variable speed cada vez que el valor cambie
            speed = (int)numeric_speed.Value;
        }

        private void numeric_accel_ValueChanged(object sender, EventArgs e)
        {
            // Actualiza la variable speed cada vez que el valor cambie
            accel = (int)numeric_accel.Value;
        }

        private void numeric_precision_ValueChanged(object sender, EventArgs e)
        {
            // Actualiza la variable speed cada vez que el valor cambie
            precision = (int)numeric_precision.Value;
        }

        private void button_up_Click(object sender, EventArgs e) {
            ClassData.currentPos[2] = ClassData.currentPos[2] + 10;
            controlClass.moveRobot(ClassData.currentPos);
        }
    }
}
