namespace URProject.Forms {
    partial class FormSettings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.labelIp = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.panelRobotConnection = new System.Windows.Forms.Panel();
            this.labelRobotConnection = new System.Windows.Forms.Label();
            this.panelRobotConnection2 = new System.Windows.Forms.Panel();
            this.panelModbus = new System.Windows.Forms.Panel();
            this.labelModbus = new System.Windows.Forms.Label();
            this.panelModbus2 = new System.Windows.Forms.Panel();
            this.panelDebug = new System.Windows.Forms.Panel();
            this.labelDebug = new System.Windows.Forms.Label();
            this.panelDebug2 = new System.Windows.Forms.Panel();
            this.checkBoxDebugEnable = new System.Windows.Forms.CheckBox();
            this.labelDebugEnable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxLogLevel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRobotConnection.SuspendLayout();
            this.panelRobotConnection2.SuspendLayout();
            this.panelModbus.SuspendLayout();
            this.panelDebug.SuspendLayout();
            this.panelDebug2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIp
            // 
            this.labelIp.AutoSize = true;
            this.labelIp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelIp.ForeColor = System.Drawing.Color.White;
            this.labelIp.Location = new System.Drawing.Point(26, 33);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(33, 32);
            this.labelIp.TabIndex = 1;
            this.labelIp.Text = "IP";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPort.ForeColor = System.Drawing.Color.White;
            this.labelPort.Location = new System.Drawing.Point(299, 34);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(71, 32);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "PORT";
            // 
            // textBoxIp
            // 
            this.textBoxIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.textBoxIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxIp.ForeColor = System.Drawing.Color.White;
            this.textBoxIp.Location = new System.Drawing.Point(66, 33);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(191, 39);
            this.textBoxIp.TabIndex = 3;
            this.textBoxIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPort
            // 
            this.textBoxPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.textBoxPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPort.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxPort.ForeColor = System.Drawing.Color.White;
            this.textBoxPort.Location = new System.Drawing.Point(382, 31);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(191, 39);
            this.textBoxPort.TabIndex = 4;
            this.textBoxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelRobotConnection
            // 
            this.panelRobotConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panelRobotConnection.Controls.Add(this.labelRobotConnection);
            this.panelRobotConnection.Location = new System.Drawing.Point(0, 0);
            this.panelRobotConnection.Name = "panelRobotConnection";
            this.panelRobotConnection.Size = new System.Drawing.Size(810, 69);
            this.panelRobotConnection.TabIndex = 5;
            // 
            // labelRobotConnection
            // 
            this.labelRobotConnection.AutoSize = true;
            this.labelRobotConnection.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labelRobotConnection.ForeColor = System.Drawing.Color.White;
            this.labelRobotConnection.Location = new System.Drawing.Point(77, 6);
            this.labelRobotConnection.Name = "labelRobotConnection";
            this.labelRobotConnection.Size = new System.Drawing.Size(260, 41);
            this.labelRobotConnection.TabIndex = 0;
            this.labelRobotConnection.Text = "Robot Connection";
            // 
            // panelRobotConnection2
            // 
            this.panelRobotConnection2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.panelRobotConnection2.Controls.Add(this.labelIp);
            this.panelRobotConnection2.Controls.Add(this.textBoxIp);
            this.panelRobotConnection2.Controls.Add(this.textBoxPort);
            this.panelRobotConnection2.Controls.Add(this.labelPort);
            this.panelRobotConnection2.Location = new System.Drawing.Point(0, 53);
            this.panelRobotConnection2.Name = "panelRobotConnection2";
            this.panelRobotConnection2.Size = new System.Drawing.Size(802, 98);
            this.panelRobotConnection2.TabIndex = 6;
            // 
            // panelModbus
            // 
            this.panelModbus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panelModbus.Controls.Add(this.labelModbus);
            this.panelModbus.Location = new System.Drawing.Point(0, 147);
            this.panelModbus.Name = "panelModbus";
            this.panelModbus.Size = new System.Drawing.Size(802, 70);
            this.panelModbus.TabIndex = 7;
            // 
            // labelModbus
            // 
            this.labelModbus.AutoSize = true;
            this.labelModbus.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labelModbus.ForeColor = System.Drawing.Color.White;
            this.labelModbus.Location = new System.Drawing.Point(77, 4);
            this.labelModbus.Name = "labelModbus";
            this.labelModbus.Size = new System.Drawing.Size(290, 41);
            this.labelModbus.TabIndex = 1;
            this.labelModbus.Text = "Modbus Connection";
            // 
            // panelModbus2
            // 
            this.panelModbus2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.panelModbus2.Location = new System.Drawing.Point(-6, 197);
            this.panelModbus2.Name = "panelModbus2";
            this.panelModbus2.Size = new System.Drawing.Size(809, 97);
            this.panelModbus2.TabIndex = 8;
            // 
            // panelDebug
            // 
            this.panelDebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panelDebug.Controls.Add(this.labelDebug);
            this.panelDebug.Location = new System.Drawing.Point(-1, 293);
            this.panelDebug.Name = "panelDebug";
            this.panelDebug.Size = new System.Drawing.Size(808, 56);
            this.panelDebug.TabIndex = 9;
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labelDebug.ForeColor = System.Drawing.Color.White;
            this.labelDebug.Location = new System.Drawing.Point(81, 5);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(108, 41);
            this.labelDebug.TabIndex = 2;
            this.labelDebug.Text = "Debug";
            // 
            // panelDebug2
            // 
            this.panelDebug2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.panelDebug2.Controls.Add(this.label1);
            this.panelDebug2.Controls.Add(this.comboBoxLogLevel);
            this.panelDebug2.Controls.Add(this.checkBoxDebugEnable);
            this.panelDebug2.Controls.Add(this.labelDebugEnable);
            this.panelDebug2.Location = new System.Drawing.Point(0, 342);
            this.panelDebug2.Name = "panelDebug2";
            this.panelDebug2.Size = new System.Drawing.Size(807, 85);
            this.panelDebug2.TabIndex = 10;
            // 
            // checkBoxDebugEnable
            // 
            this.checkBoxDebugEnable.AutoSize = true;
            this.checkBoxDebugEnable.Location = new System.Drawing.Point(32, 21);
            this.checkBoxDebugEnable.Name = "checkBoxDebugEnable";
            this.checkBoxDebugEnable.Size = new System.Drawing.Size(22, 21);
            this.checkBoxDebugEnable.TabIndex = 6;
            this.checkBoxDebugEnable.UseVisualStyleBackColor = true;
            // 
            // labelDebugEnable
            // 
            this.labelDebugEnable.AutoSize = true;
            this.labelDebugEnable.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelDebugEnable.ForeColor = System.Drawing.Color.White;
            this.labelDebugEnable.Location = new System.Drawing.Point(59, 13);
            this.labelDebugEnable.Name = "labelDebugEnable";
            this.labelDebugEnable.Size = new System.Drawing.Size(85, 32);
            this.labelDebugEnable.TabIndex = 5;
            this.labelDebugEnable.Text = "Enable";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonApply);
            this.panel1.Location = new System.Drawing.Point(-6, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 126);
            this.panel1.TabIndex = 11;
            // 
            // buttonApply
            // 
            this.buttonApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.buttonApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.buttonApply.FlatAppearance.BorderSize = 4;
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApply.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonApply.ForeColor = System.Drawing.Color.White;
            this.buttonApply.Location = new System.Drawing.Point(485, 11);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(138, 65);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.buttonCancel.FlatAppearance.BorderSize = 4;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(639, 11);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(138, 65);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxLogLevel
            // 
            this.comboBoxLogLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboBoxLogLevel.DisplayMember = "0";
            this.comboBoxLogLevel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxLogLevel.ForeColor = System.Drawing.Color.White;
            this.comboBoxLogLevel.FormattingEnabled = true;
            this.comboBoxLogLevel.Items.AddRange(new object[] {
            "Debug",
            "Info",
            "Warning",
            "Error"});
            this.comboBoxLogLevel.Location = new System.Drawing.Point(360, 8);
            this.comboBoxLogLevel.Name = "comboBoxLogLevel";
            this.comboBoxLogLevel.Size = new System.Drawing.Size(169, 40);
            this.comboBoxLogLevel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(239, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Log Level";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDebug2);
            this.Controls.Add(this.panelDebug);
            this.Controls.Add(this.panelModbus2);
            this.Controls.Add(this.panelModbus);
            this.Controls.Add(this.panelRobotConnection2);
            this.Controls.Add(this.panelRobotConnection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettings";
            this.Text = "UR-Project Settings";
            this.TopMost = true;
            this.panelRobotConnection.ResumeLayout(false);
            this.panelRobotConnection.PerformLayout();
            this.panelRobotConnection2.ResumeLayout(false);
            this.panelRobotConnection2.PerformLayout();
            this.panelModbus.ResumeLayout(false);
            this.panelModbus.PerformLayout();
            this.panelDebug.ResumeLayout(false);
            this.panelDebug.PerformLayout();
            this.panelDebug2.ResumeLayout(false);
            this.panelDebug2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Panel panelRobotConnection;
        private System.Windows.Forms.Label labelRobotConnection;
        private System.Windows.Forms.Panel panelRobotConnection2;
        private System.Windows.Forms.Panel panelModbus;
        private System.Windows.Forms.Label labelModbus;
        private System.Windows.Forms.Panel panelModbus2;
        private System.Windows.Forms.Panel panelDebug;
        private System.Windows.Forms.Label labelDebug;
        private System.Windows.Forms.Panel panelDebug2;
        private System.Windows.Forms.CheckBox checkBoxDebugEnable;
        private System.Windows.Forms.Label labelDebugEnable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLogLevel;
    }
}