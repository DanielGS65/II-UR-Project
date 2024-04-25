namespace URProject.Forms
{
    partial class FormGuardarPose
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGuardarHome = new System.Windows.Forms.Button();
            this.buttonGuardarRecoger = new System.Windows.Forms.Button();
            this.buttonGuardarEstirar = new System.Windows.Forms.Button();
            this.buttonGuardarExtra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGuardarHome
            // 
            this.buttonGuardarHome.Location = new System.Drawing.Point(72, 120);
            this.buttonGuardarHome.Name = "buttonGuardarHome";
            this.buttonGuardarHome.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarHome.TabIndex = 0;
            this.buttonGuardarHome.Text = "Guardar";
            this.buttonGuardarHome.UseVisualStyleBackColor = true;
            this.buttonGuardarHome.Click += new System.EventHandler(this.buttonGuardarHome_Click);
            // 
            // buttonGuardarRecoger
            // 
            this.buttonGuardarRecoger.Location = new System.Drawing.Point(193, 120);
            this.buttonGuardarRecoger.Name = "buttonGuardarRecoger";
            this.buttonGuardarRecoger.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarRecoger.TabIndex = 1;
            this.buttonGuardarRecoger.Text = "Guardar";
            this.buttonGuardarRecoger.UseVisualStyleBackColor = true;
            this.buttonGuardarRecoger.Click += new System.EventHandler(this.buttonGuardarRecoger_Click);
            // 
            // buttonGuardarEstirar
            // 
            this.buttonGuardarEstirar.Location = new System.Drawing.Point(314, 120);
            this.buttonGuardarEstirar.Name = "buttonGuardarEstirar";
            this.buttonGuardarEstirar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarEstirar.TabIndex = 2;
            this.buttonGuardarEstirar.Text = "Guardar";
            this.buttonGuardarEstirar.UseVisualStyleBackColor = true;
            this.buttonGuardarEstirar.Click += new System.EventHandler(this.buttonGuardarEstirar_Click);
            // 
            // buttonGuardarExtra
            // 
            this.buttonGuardarExtra.Location = new System.Drawing.Point(434, 120);
            this.buttonGuardarExtra.Name = "buttonGuardarExtra";
            this.buttonGuardarExtra.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarExtra.TabIndex = 3;
            this.buttonGuardarExtra.Text = "Guardar";
            this.buttonGuardarExtra.UseVisualStyleBackColor = true;
            this.buttonGuardarExtra.Click += new System.EventHandler(this.buttonGuardarExtra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pos Home";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pos recoger";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pos estirar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Extra";
            // 
            // FormGuardarPose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 177);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGuardarExtra);
            this.Controls.Add(this.buttonGuardarEstirar);
            this.Controls.Add(this.buttonGuardarRecoger);
            this.Controls.Add(this.buttonGuardarHome);
            this.Name = "FormGuardarPose";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardarHome;
        private System.Windows.Forms.Button buttonGuardarRecoger;
        private System.Windows.Forms.Button buttonGuardarEstirar;
        private System.Windows.Forms.Button buttonGuardarExtra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}