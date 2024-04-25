using URProject.Forms;

namespace URProject {
    partial class FormMain {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.button1 = new System.Windows.Forms.Button();
            this.panelMainContainer = new System.Windows.Forms.Panel();
            this.buttonMarcos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonLogging = new System.Windows.Forms.Button();
            this.labelPort = new System.Windows.Forms.Label();
            this.buttonManualMove = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.panelConectionStatus = new System.Windows.Forms.Panel();
            this.panelConectionLed = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelConectionStatus = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelRobot = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelRobotPosition = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRotZ = new System.Windows.Forms.TextBox();
            this.textBoxRotY = new System.Windows.Forms.TextBox();
            this.textBoxRotX = new System.Windows.Forms.TextBox();
            this.textBoxPosZ = new System.Windows.Forms.TextBox();
            this.textBoxPosY = new System.Windows.Forms.TextBox();
            this.textBoxPosX = new System.Windows.Forms.TextBox();
            this.panelMenu.SuspendLayout();
            this.panelConectionStatus.SuspendLayout();
            this.panelRobotPosition.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 525);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainContainer.BackColor = System.Drawing.Color.Gainsboro;
            this.panelMainContainer.Location = new System.Drawing.Point(352, 102);
            this.panelMainContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(773, 483);
            this.panelMainContainer.TabIndex = 1;
            // 
            // buttonMarcos
            // 
            this.buttonMarcos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.buttonMarcos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.buttonMarcos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMarcos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonMarcos.ForeColor = System.Drawing.Color.White;
            this.buttonMarcos.Location = new System.Drawing.Point(15, 288);
            this.buttonMarcos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMarcos.Name = "buttonMarcos";
            this.buttonMarcos.Size = new System.Drawing.Size(329, 64);
            this.buttonMarcos.TabIndex = 2;
            this.buttonMarcos.TabStop = false;
            this.buttonMarcos.Text = "Botón debug Marcos";
            this.buttonMarcos.UseVisualStyleBackColor = false;
            this.buttonMarcos.Click += new System.EventHandler(this.buttonDebugMarcos);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(15, 525);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 65);
            this.button2.TabIndex = 3;
            this.button2.Text = "Botón de Dioni";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panelMenu.Controls.Add(this.buttonLogging);
            this.panelMenu.Controls.Add(this.labelPort);
            this.panelMenu.Controls.Add(this.buttonManualMove);
            this.panelMenu.Controls.Add(this.buttonConnect);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.panelConectionStatus);
            this.panelMenu.Controls.Add(this.buttonMarcos);
            this.panelMenu.Controls.Add(this.labelIP);
            this.panelMenu.Controls.Add(this.labelRobot);
            this.panelMenu.Controls.Add(this.labelTitle);
            this.panelMenu.Location = new System.Drawing.Point(-15, -7);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(347, 609);
            this.panelMenu.TabIndex = 4;
            // 
            // buttonLogging
            // 
            this.buttonLogging.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.buttonLogging.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.buttonLogging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogging.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonLogging.ForeColor = System.Drawing.Color.White;
            this.buttonLogging.Location = new System.Drawing.Point(15, 434);
            this.buttonLogging.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogging.Name = "buttonLogging";
            this.buttonLogging.Size = new System.Drawing.Size(329, 64);
            this.buttonLogging.TabIndex = 9;
            this.buttonLogging.TabStop = false;
            this.buttonLogging.Text = "Logging";
            this.buttonLogging.UseVisualStyleBackColor = false;
            this.buttonLogging.Visible = false;
            this.buttonLogging.Click += new System.EventHandler(this.buttonLogging_Click);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelPort.ForeColor = System.Drawing.Color.White;
            this.labelPort.Location = new System.Drawing.Point(199, 115);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(63, 28);
            this.labelPort.TabIndex = 8;
            this.labelPort.Text = "PORT:";
            // 
            // buttonManualMove
            // 
            this.buttonManualMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.buttonManualMove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.buttonManualMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManualMove.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonManualMove.ForeColor = System.Drawing.Color.White;
            this.buttonManualMove.Location = new System.Drawing.Point(16, 360);
            this.buttonManualMove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonManualMove.Name = "buttonManualMove";
            this.buttonManualMove.Size = new System.Drawing.Size(329, 64);
            this.buttonManualMove.TabIndex = 7;
            this.buttonManualMove.TabStop = false;
            this.buttonManualMove.Text = "Manual Move";
            this.buttonManualMove.UseVisualStyleBackColor = false;
            this.buttonManualMove.Click += new System.EventHandler(this.buttonManualMove_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.buttonConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.Color.White;
            this.buttonConnect.Location = new System.Drawing.Point(81, 222);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(191, 48);
            this.buttonConnect.TabIndex = 6;
            this.buttonConnect.TabStop = false;
            this.buttonConnect.Text = "Connect to UR";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // panelConectionStatus
            // 
            this.panelConectionStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.panelConectionStatus.Controls.Add(this.panelConectionLed);
            this.panelConectionStatus.Controls.Add(this.label1);
            this.panelConectionStatus.Controls.Add(this.labelConectionStatus);
            this.panelConectionStatus.Location = new System.Drawing.Point(3, 156);
            this.panelConectionStatus.Name = "panelConectionStatus";
            this.panelConectionStatus.Size = new System.Drawing.Size(344, 50);
            this.panelConectionStatus.TabIndex = 5;
            // 
            // panelConectionLed
            // 
            this.panelConectionLed.BackColor = System.Drawing.Color.Red;
            this.panelConectionLed.Location = new System.Drawing.Point(121, 17);
            this.panelConectionLed.Name = "panelConectionLed";
            this.panelConectionLed.Size = new System.Drawing.Size(19, 18);
            this.panelConectionLed.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status";
            // 
            // labelConectionStatus
            // 
            this.labelConectionStatus.AutoSize = true;
            this.labelConectionStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConectionStatus.ForeColor = System.Drawing.Color.White;
            this.labelConectionStatus.Location = new System.Drawing.Point(147, 10);
            this.labelConectionStatus.Name = "labelConectionStatus";
            this.labelConectionStatus.Size = new System.Drawing.Size(119, 28);
            this.labelConectionStatus.TabIndex = 4;
            this.labelConectionStatus.Text = "Disconected";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelIP.ForeColor = System.Drawing.Color.White;
            this.labelIP.Location = new System.Drawing.Point(27, 115);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(32, 28);
            this.labelIP.TabIndex = 2;
            this.labelIP.Text = "IP:";
            // 
            // labelRobot
            // 
            this.labelRobot.AutoSize = true;
            this.labelRobot.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRobot.ForeColor = System.Drawing.Color.White;
            this.labelRobot.Location = new System.Drawing.Point(126, 83);
            this.labelRobot.Name = "labelRobot";
            this.labelRobot.Size = new System.Drawing.Size(113, 28);
            this.labelRobot.TabIndex = 1;
            this.labelRobot.Text = "Robot Info";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(86, 33);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(183, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "UR-Project";
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
            this.notifyIconMain.Text = "UR-Project";
            this.notifyIconMain.Visible = true;
            this.notifyIconMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconMain_MouseDoubleClick);
            // 
            // panelRobotPosition
            // 
            this.panelRobotPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRobotPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.panelRobotPosition.Controls.Add(this.label9);
            this.panelRobotPosition.Controls.Add(this.label6);
            this.panelRobotPosition.Controls.Add(this.label7);
            this.panelRobotPosition.Controls.Add(this.label8);
            this.panelRobotPosition.Controls.Add(this.label5);
            this.panelRobotPosition.Controls.Add(this.label4);
            this.panelRobotPosition.Controls.Add(this.label3);
            this.panelRobotPosition.Controls.Add(this.label2);
            this.panelRobotPosition.Controls.Add(this.textBoxRotZ);
            this.panelRobotPosition.Controls.Add(this.textBoxRotY);
            this.panelRobotPosition.Controls.Add(this.textBoxRotX);
            this.panelRobotPosition.Controls.Add(this.textBoxPosZ);
            this.panelRobotPosition.Controls.Add(this.textBoxPosY);
            this.panelRobotPosition.Controls.Add(this.textBoxPosX);
            this.panelRobotPosition.Location = new System.Drawing.Point(331, -7);
            this.panelRobotPosition.Name = "panelRobotPosition";
            this.panelRobotPosition.Size = new System.Drawing.Size(815, 93);
            this.panelRobotPosition.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(474, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 32);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tool Rotation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(593, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(486, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(382, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 32);
            this.label8.TabIndex = 10;
            this.label8.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(217, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(110, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(102, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tool Position";
            // 
            // textBoxRotZ
            // 
            this.textBoxRotZ.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxRotZ.Location = new System.Drawing.Point(625, 43);
            this.textBoxRotZ.Name = "textBoxRotZ";
            this.textBoxRotZ.ReadOnly = true;
            this.textBoxRotZ.Size = new System.Drawing.Size(62, 34);
            this.textBoxRotZ.TabIndex = 5;
            this.textBoxRotZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRotY
            // 
            this.textBoxRotY.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxRotY.Location = new System.Drawing.Point(519, 44);
            this.textBoxRotY.Name = "textBoxRotY";
            this.textBoxRotY.ReadOnly = true;
            this.textBoxRotY.Size = new System.Drawing.Size(62, 34);
            this.textBoxRotY.TabIndex = 4;
            this.textBoxRotY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRotX
            // 
            this.textBoxRotX.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxRotX.Location = new System.Drawing.Point(416, 44);
            this.textBoxRotX.Name = "textBoxRotX";
            this.textBoxRotX.ReadOnly = true;
            this.textBoxRotX.Size = new System.Drawing.Size(62, 34);
            this.textBoxRotX.TabIndex = 3;
            this.textBoxRotX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPosZ
            // 
            this.textBoxPosZ.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxPosZ.Location = new System.Drawing.Point(251, 44);
            this.textBoxPosZ.Name = "textBoxPosZ";
            this.textBoxPosZ.ReadOnly = true;
            this.textBoxPosZ.Size = new System.Drawing.Size(62, 34);
            this.textBoxPosZ.TabIndex = 2;
            this.textBoxPosZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPosY
            // 
            this.textBoxPosY.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxPosY.Location = new System.Drawing.Point(144, 43);
            this.textBoxPosY.Name = "textBoxPosY";
            this.textBoxPosY.ReadOnly = true;
            this.textBoxPosY.Size = new System.Drawing.Size(62, 34);
            this.textBoxPosY.TabIndex = 1;
            this.textBoxPosY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPosX
            // 
            this.textBoxPosX.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxPosX.Location = new System.Drawing.Point(40, 43);
            this.textBoxPosX.Name = "textBoxPosX";
            this.textBoxPosX.ReadOnly = true;
            this.textBoxPosX.Size = new System.Drawing.Size(62, 34);
            this.textBoxPosX.TabIndex = 0;
            this.textBoxPosX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1137, 598);
            this.Controls.Add(this.panelRobotPosition);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelMainContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "UR-Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelConectionStatus.ResumeLayout(false);
            this.panelConectionStatus.PerformLayout();
            this.panelRobotPosition.ResumeLayout(false);
            this.panelRobotPosition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Button buttonMarcos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelRobot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelConectionStatus;
        private System.Windows.Forms.Button buttonConnect;
        public System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.Button buttonManualMove;
        private System.Windows.Forms.Panel panelRobotPosition;
        public System.Windows.Forms.Label labelPort;
        public System.Windows.Forms.Label labelIP;
        public System.Windows.Forms.Label labelConectionStatus;
        public System.Windows.Forms.Panel panelConectionLed;
        public System.Windows.Forms.Button buttonLogging;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox textBoxRotZ;
        public System.Windows.Forms.TextBox textBoxRotY;
        public System.Windows.Forms.TextBox textBoxRotX;
        public System.Windows.Forms.TextBox textBoxPosZ;
        public System.Windows.Forms.TextBox textBoxPosY;
        public System.Windows.Forms.TextBox textBoxPosX;
    }
}

