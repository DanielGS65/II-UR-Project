﻿using URProject.Forms;

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
            this.buttonPoseTrayectory = new System.Windows.Forms.Button();
            this.buttonDashboardServer = new System.Windows.Forms.Button();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelConectionStatus.SuspendLayout();
            this.panelRobotPosition.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 682);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 50);
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
            this.panelMainContainer.Location = new System.Drawing.Point(313, 86);
            this.panelMainContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(748, 618);
            this.panelMainContainer.TabIndex = 1;
            // 
            // buttonMarcos
            // 
            this.buttonMarcos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.buttonMarcos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.buttonMarcos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMarcos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonMarcos.ForeColor = System.Drawing.Color.White;
            this.buttonMarcos.Location = new System.Drawing.Point(13, 230);
            this.buttonMarcos.Name = "buttonMarcos";
            this.buttonMarcos.Size = new System.Drawing.Size(292, 51);
            this.buttonMarcos.TabIndex = 2;
            this.buttonMarcos.TabStop = false;
            this.buttonMarcos.Text = "Robot Data";
            this.buttonMarcos.UseVisualStyleBackColor = false;
            this.buttonMarcos.Click += new System.EventHandler(this.buttonDebugMarcos);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(15, 679);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 52);
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
            this.panelMenu.Controls.Add(this.buttonPoseTrayectory);
            this.panelMenu.Controls.Add(this.buttonDashboardServer);
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
            this.panelMenu.Location = new System.Drawing.Point(-13, -6);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(308, 748);
            this.panelMenu.TabIndex = 4;
            // 
            // buttonPoseTrayectory
            // 
            this.buttonPoseTrayectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.buttonPoseTrayectory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.buttonPoseTrayectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPoseTrayectory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonPoseTrayectory.ForeColor = System.Drawing.Color.White;
            this.buttonPoseTrayectory.Location = new System.Drawing.Point(16, 403);
            this.buttonPoseTrayectory.Name = "buttonPoseTrayectory";
            this.buttonPoseTrayectory.Size = new System.Drawing.Size(292, 51);
            this.buttonPoseTrayectory.TabIndex = 12;
            this.buttonPoseTrayectory.TabStop = false;
            this.buttonPoseTrayectory.Text = "Pose and Trayectory";
            this.buttonPoseTrayectory.UseVisualStyleBackColor = false;
            this.buttonPoseTrayectory.Click += new System.EventHandler(this.buttonPoseTrayectory_Click);
            // 
            // buttonDashboardServer
            // 
            this.buttonDashboardServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.buttonDashboardServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.buttonDashboardServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboardServer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonDashboardServer.ForeColor = System.Drawing.Color.White;
            this.buttonDashboardServer.Location = new System.Drawing.Point(14, 346);
            this.buttonDashboardServer.Name = "buttonDashboardServer";
            this.buttonDashboardServer.Size = new System.Drawing.Size(292, 51);
            this.buttonDashboardServer.TabIndex = 11;
            this.buttonDashboardServer.TabStop = false;
            this.buttonDashboardServer.Text = "Dashboard Server";
            this.buttonDashboardServer.UseVisualStyleBackColor = false;
            this.buttonDashboardServer.Click += new System.EventHandler(this.buttonDashboardServer_Click);
            // 
            // buttonLogging
            // 
            this.buttonLogging.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.buttonLogging.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.buttonLogging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogging.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonLogging.ForeColor = System.Drawing.Color.White;
            this.buttonLogging.Location = new System.Drawing.Point(15, 607);
            this.buttonLogging.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogging.Name = "buttonLogging";
            this.buttonLogging.Size = new System.Drawing.Size(292, 51);
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
            this.labelPort.Location = new System.Drawing.Point(177, 92);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(55, 23);
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
            this.buttonManualMove.Location = new System.Drawing.Point(14, 288);
            this.buttonManualMove.Name = "buttonManualMove";
            this.buttonManualMove.Size = new System.Drawing.Size(292, 51);
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
            this.buttonConnect.Location = new System.Drawing.Point(72, 178);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(170, 38);
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
            this.panelConectionStatus.Location = new System.Drawing.Point(3, 125);
            this.panelConectionStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelConectionStatus.Name = "panelConectionStatus";
            this.panelConectionStatus.Size = new System.Drawing.Size(306, 40);
            this.panelConectionStatus.TabIndex = 5;
            // 
            // panelConectionLed
            // 
            this.panelConectionLed.BackColor = System.Drawing.Color.Red;
            this.panelConectionLed.Location = new System.Drawing.Point(108, 14);
            this.panelConectionLed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelConectionLed.Name = "panelConectionLed";
            this.panelConectionLed.Size = new System.Drawing.Size(17, 14);
            this.panelConectionLed.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status";
            // 
            // labelConectionStatus
            // 
            this.labelConectionStatus.AutoSize = true;
            this.labelConectionStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConectionStatus.ForeColor = System.Drawing.Color.White;
            this.labelConectionStatus.Location = new System.Drawing.Point(131, 8);
            this.labelConectionStatus.Name = "labelConectionStatus";
            this.labelConectionStatus.Size = new System.Drawing.Size(113, 23);
            this.labelConectionStatus.TabIndex = 4;
            this.labelConectionStatus.Text = "Disconnected";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelIP.ForeColor = System.Drawing.Color.White;
            this.labelIP.Location = new System.Drawing.Point(24, 92);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(29, 23);
            this.labelIP.TabIndex = 2;
            this.labelIP.Text = "IP:";
            // 
            // labelRobot
            // 
            this.labelRobot.AutoSize = true;
            this.labelRobot.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRobot.ForeColor = System.Drawing.Color.White;
            this.labelRobot.Location = new System.Drawing.Point(112, 66);
            this.labelRobot.Name = "labelRobot";
            this.labelRobot.Size = new System.Drawing.Size(96, 23);
            this.labelRobot.TabIndex = 1;
            this.labelRobot.Text = "Robot Info";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(76, 26);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(158, 37);
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
            this.panelRobotPosition.Location = new System.Drawing.Point(294, -6);
            this.panelRobotPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRobotPosition.Name = "panelRobotPosition";
            this.panelRobotPosition.Size = new System.Drawing.Size(778, 74);
            this.panelRobotPosition.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(421, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 28);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tool Rotation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(527, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(432, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(340, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 28);
            this.label8.TabIndex = 10;
            this.label8.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(193, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(98, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tool Position";
            // 
            // textBoxRotZ
            // 
            this.textBoxRotZ.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxRotZ.Location = new System.Drawing.Point(556, 34);
            this.textBoxRotZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRotZ.Name = "textBoxRotZ";
            this.textBoxRotZ.ReadOnly = true;
            this.textBoxRotZ.Size = new System.Drawing.Size(56, 30);
            this.textBoxRotZ.TabIndex = 5;
            this.textBoxRotZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRotY
            // 
            this.textBoxRotY.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxRotY.Location = new System.Drawing.Point(461, 35);
            this.textBoxRotY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRotY.Name = "textBoxRotY";
            this.textBoxRotY.ReadOnly = true;
            this.textBoxRotY.Size = new System.Drawing.Size(56, 30);
            this.textBoxRotY.TabIndex = 4;
            this.textBoxRotY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRotX
            // 
            this.textBoxRotX.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxRotX.Location = new System.Drawing.Point(370, 35);
            this.textBoxRotX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRotX.Name = "textBoxRotX";
            this.textBoxRotX.ReadOnly = true;
            this.textBoxRotX.Size = new System.Drawing.Size(56, 30);
            this.textBoxRotX.TabIndex = 3;
            this.textBoxRotX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPosZ
            // 
            this.textBoxPosZ.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxPosZ.Location = new System.Drawing.Point(223, 35);
            this.textBoxPosZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPosZ.Name = "textBoxPosZ";
            this.textBoxPosZ.ReadOnly = true;
            this.textBoxPosZ.Size = new System.Drawing.Size(56, 30);
            this.textBoxPosZ.TabIndex = 2;
            this.textBoxPosZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPosY
            // 
            this.textBoxPosY.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxPosY.Location = new System.Drawing.Point(128, 34);
            this.textBoxPosY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPosY.Name = "textBoxPosY";
            this.textBoxPosY.ReadOnly = true;
            this.textBoxPosY.Size = new System.Drawing.Size(56, 30);
            this.textBoxPosY.TabIndex = 1;
            this.textBoxPosY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPosX
            // 
            this.textBoxPosX.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxPosX.Location = new System.Drawing.Point(36, 34);
            this.textBoxPosX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPosX.Name = "textBoxPosX";
            this.textBoxPosX.ReadOnly = true;
            this.textBoxPosX.Size = new System.Drawing.Size(56, 30);
            this.textBoxPosX.TabIndex = 0;
            this.textBoxPosX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1071, 737);
            this.Controls.Add(this.panelRobotPosition);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelMainContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "FormMain";
            this.Text = "UR-Project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Button buttonPoseTrayectory;
        private System.Windows.Forms.Button buttonDashboardServer;
        private System.Windows.Forms.Timer timer1;
    }
}

