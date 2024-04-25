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
    public partial class FormSettings : Form {

        // ---------------------------
        // Local Variables
        // ---------------------------
        #region LocalVariables

        FormMain mainForm;
        ClassXml xmlClass;

        #endregion LocalVariables

        // ---------------------------
        // Init Functions
        // ---------------------------
        #region InitFunctions

        public FormSettings(FormMain mainForm, ClassXml xmlClass) {
            InitializeComponent();
            this.mainForm = mainForm;
            this.xmlClass = xmlClass;
        }


        #endregion InitFunctions

        // ---------------------------
        // Form Functions
        // ---------------------------
        #region FormFunctions

        public void updateConfig() {
            this.textBoxIp.Text = ClassData.robotIp;
            this.textBoxPort.Text = ClassData.robotPort.ToString();
            this.checkBoxDebugEnable.Checked = ClassData.debugMode;

            switch (ClassData.logLevel){
                case 0:
                    this.comboBoxLogLevel.Text = "Debug";
                    break;
                case 1:
                    this.comboBoxLogLevel.Text = "Info";
                    break;
                case 2:
                    this.comboBoxLogLevel.Text = "Warning";
                    break;
                case 3:
                    this.comboBoxLogLevel.Text = "Error";
                    break;
                default:
                    this.comboBoxLogLevel.Text = "Error";
                    break;
            }

        }

        private void buttonApply_Click(object sender, EventArgs e) {
            ClassData.robotIp = this.textBoxIp.Text;
            ClassData.robotPort = int.Parse(this.textBoxPort.Text);
            ClassData.debugMode = this.checkBoxDebugEnable.Checked;

            switch (this.comboBoxLogLevel.Text) {
                case "Debug":
                    ClassData.logLevel = 0;
                    break;
                case "Info":
                    ClassData.logLevel = 1;
                    break;
                case "Warning":
                    ClassData.logLevel = 2;
                    break;
                case "Error":
                    ClassData.logLevel = 3;
                    break;
                default:
                    ClassData.logLevel = 3;
                    break;
            }
            xmlClass.saveConfig();

            mainForm.labelIP.Text = "IP: " + ClassData.robotIp;
            mainForm.labelPort.Text = "Port: " + ClassData.robotPort.ToString();
            mainForm.buttonLogging.Visible = ClassData.debugMode;
            mainForm.hideSecondaryForms();

            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Hide();
        }

        #endregion FormFunctions

    }
}
