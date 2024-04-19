namespace URProject.Forms
{
    partial class FormInfoSistema
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
            this.textTimeStamp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textTimeStamp
            // 
            this.textTimeStamp.Enabled = false;
            this.textTimeStamp.Location = new System.Drawing.Point(131, 84);
            this.textTimeStamp.Name = "textTimeStamp";
            this.textTimeStamp.Size = new System.Drawing.Size(168, 44);
            this.textTimeStamp.TabIndex = 0;
            this.textTimeStamp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormInfoSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textTimeStamp);
            this.Name = "FormInfoSistema";
            this.Text = "FormInfoSistema";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textTimeStamp;
    }
}