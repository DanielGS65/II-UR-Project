namespace URProject.Forms {
    partial class FormLogging {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogging));
            this.richTextBoxLogger = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxLogger
            // 
            this.richTextBoxLogger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxLogger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.richTextBoxLogger.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.richTextBoxLogger.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBoxLogger.Location = new System.Drawing.Point(-2, -2);
            this.richTextBoxLogger.Name = "richTextBoxLogger";
            this.richTextBoxLogger.Size = new System.Drawing.Size(1217, 621);
            this.richTextBoxLogger.TabIndex = 0;
            this.richTextBoxLogger.TabStop = false;
            this.richTextBoxLogger.Text = "";
            // 
            // FormLogging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1208, 616);
            this.ControlBox = false;
            this.Controls.Add(this.richTextBoxLogger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogging";
            this.Text = "Logger";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBoxLogger;
    }
}