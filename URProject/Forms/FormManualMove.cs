using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using URProject.Classes;

namespace URProject.Forms {
    public partial class FormManualMove : Form {
        ClassControl controlClass;
        ClassRTDE rtdeClass;

        // Variables
        private int speed; // Variable para almacenar la velocidad
        private int accel; // Variable para almacenar la acceleracion
        private int precision; // Variable para almacenar la precision
        public FormManualMove(ClassRTDE rtdeClass, ClassControl controlClass) {
            InitializeComponent();
            this.controlClass = controlClass;
        }

        public void buttonMove_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            var newPos = ClassData.currentPos;

            switch (button.Name)
            {
                // Posicion TCP
                case "button_x_up":  // X-
                    newPos[0] -= 0.01;
                    break;
                case "button_x_down":  // X+
                    newPos[0] += 0.01;
                    break;
                case "button_y_left":  // Y-
                    newPos[1] -= 0.01;
                    break;
                case "button_y_right":  // Y+
                    newPos[1] += 0.01;
                    break;
                case "button_z_up":  // Z+
                    newPos[2] += 0.01;
                    break;
                case "button_z_down":  // Z-
                    newPos[2] -= 0.01;
                    break;
                // Orientacion TCP
                case "button_rx_left":  // RX+
                    newPos[3] += 0.01;
                    break;
                case "button_rx_right":  // RX-
                    newPos[3] -= 0.01;
                    break;
                case "button_ry_down":  // RY+
                    newPos[4] += 0.01;
                    break;
                case "button_ry_up":  // RY-
                    newPos[4] -= 0.01;
                    break;
                case "button_rz_left":  // RZ+
                    newPos[5] += 0.01;
                    break;
                case "button_rz_right":  // RZ-
                    newPos[5] -= 0.01;
                    break;
            }

            controlClass.moveRobot(newPos);
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

        private void numeric_precision_ValueChanged(object sender, EventArgs e) {
            // Actualiza la variable speed cada vez que el valor cambie
            precision = (int)numeric_precision.Value;
        }

        private void button_freedrive_Click(object sender, EventArgs e) {
            if (!ClassData.freeDriveMode) {
                while (!ClassData.freeDriveMode) {
                    controlClass.ToggleFreeMovement();
                    Thread.Sleep(100);
                }
                button_freedrive.BackColor = Color.Green;
            } else {
                while (ClassData.freeDriveMode) {
                    controlClass.ToggleFreeMovement();
                    Thread.Sleep(100);
                }
                button_freedrive.BackColor = Color.Red;
            }
        }

        private void button_suction_Click(object sender, EventArgs e) {

            controlClass.operateTool(!ClassData.toolStatus);
            if (ClassData.toolStatus) {
                panelSuctionLed.BackColor = Color.Green;
            } else {
                panelSuctionLed.BackColor = Color.Red;
            }
            
        }
    }
}
