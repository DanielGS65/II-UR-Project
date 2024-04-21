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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.panelConectionStatus = new System.Windows.Forms.Panel();
            this.panelConectionLed = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelConectionStatus = new System.Windows.Forms.Label();
            this.labelAuthors2 = new System.Windows.Forms.Label();
            this.labelAuthors = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonManualMove = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelConectionStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 452);
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
            this.panelMainContainer.Location = new System.Drawing.Point(352, 11);
            this.panelMainContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(773, 574);
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
            this.button2.Location = new System.Drawing.Point(112, 523);
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
            this.panelMenu.Controls.Add(this.buttonManualMove);
            this.panelMenu.Controls.Add(this.buttonConnect);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.panelConectionStatus);
            this.panelMenu.Controls.Add(this.buttonMarcos);
            this.panelMenu.Controls.Add(this.labelAuthors2);
            this.panelMenu.Controls.Add(this.labelAuthors);
            this.panelMenu.Controls.Add(this.labelTitle);
            this.panelMenu.Location = new System.Drawing.Point(-15, -7);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(347, 609);
            this.panelMenu.TabIndex = 4;
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
            // labelAuthors2
            // 
            this.labelAuthors2.AutoSize = true;
            this.labelAuthors2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelAuthors2.ForeColor = System.Drawing.Color.White;
            this.labelAuthors2.Location = new System.Drawing.Point(27, 115);
            this.labelAuthors2.Name = "labelAuthors2";
            this.labelAuthors2.Size = new System.Drawing.Size(122, 21);
            this.labelAuthors2.TabIndex = 2;
            this.labelAuthors2.Text = "dgs65 - dmm84";
            // 
            // labelAuthors
            // 
            this.labelAuthors.AutoSize = true;
            this.labelAuthors.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthors.ForeColor = System.Drawing.Color.White;
            this.labelAuthors.Location = new System.Drawing.Point(134, 78);
            this.labelAuthors.Name = "labelAuthors";
            this.labelAuthors.Size = new System.Drawing.Size(87, 28);
            this.labelAuthors.TabIndex = 1;
            this.labelAuthors.Text = "Authors";
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1137, 598);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelMainContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "UR-Project";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelConectionStatus.ResumeLayout(false);
            this.panelConectionStatus.PerformLayout();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Button buttonMarcos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthors;
        private System.Windows.Forms.Label labelAuthors2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelConectionStatus;
        private System.Windows.Forms.Panel panelConectionStatus;
        private System.Windows.Forms.Panel panelConectionLed;
        private System.Windows.Forms.Button buttonConnect;
        public System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.Button buttonManualMove;
    }
}

