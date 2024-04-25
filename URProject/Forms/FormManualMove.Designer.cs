namespace URProject.Forms {
    partial class FormManualMove {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManualMove));
            this.button_up = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.button_down = new System.Windows.Forms.Button();
            this.button_freeHand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_up
            // 
            this.button_up.FlatAppearance.BorderSize = 0;
            this.button_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_up.Image = ((System.Drawing.Image)(resources.GetObject("button_up.Image")));
            this.button_up.Location = new System.Drawing.Point(149, 109);
            this.button_up.Margin = new System.Windows.Forms.Padding(0);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(64, 64);
            this.button_up.TabIndex = 0;
            this.button_up.UseVisualStyleBackColor = false;
            // 
            // button_right
            // 
            this.button_right.FlatAppearance.BorderSize = 0;
            this.button_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_right.Image = ((System.Drawing.Image)(resources.GetObject("button_right.Image")));
            this.button_right.Location = new System.Drawing.Point(213, 173);
            this.button_right.Margin = new System.Windows.Forms.Padding(0);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(64, 64);
            this.button_right.TabIndex = 1;
            this.button_right.UseVisualStyleBackColor = false;
            // 
            // button_left
            // 
            this.button_left.FlatAppearance.BorderSize = 0;
            this.button_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_left.Image = ((System.Drawing.Image)(resources.GetObject("button_left.Image")));
            this.button_left.Location = new System.Drawing.Point(84, 173);
            this.button_left.Margin = new System.Windows.Forms.Padding(0);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(64, 64);
            this.button_left.TabIndex = 2;
            this.button_left.UseVisualStyleBackColor = false;
            // 
            // button_down
            // 
            this.button_down.FlatAppearance.BorderSize = 0;
            this.button_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_down.Image = ((System.Drawing.Image)(resources.GetObject("button_down.Image")));
            this.button_down.Location = new System.Drawing.Point(150, 234);
            this.button_down.Margin = new System.Windows.Forms.Padding(0);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(64, 64);
            this.button_down.TabIndex = 3;
            this.button_down.UseVisualStyleBackColor = false;
            // 
            // button_freeHand
            // 
            this.button_freeHand.FlatAppearance.BorderSize = 0;
            this.button_freeHand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_freeHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_freeHand.Image = ((System.Drawing.Image)(resources.GetObject("button_freeHand.Image")));
            this.button_freeHand.Location = new System.Drawing.Point(85, 323);
            this.button_freeHand.Margin = new System.Windows.Forms.Padding(0);
            this.button_freeHand.Name = "button_freeHand";
            this.button_freeHand.Size = new System.Drawing.Size(166, 64);
            this.button_freeHand.TabIndex = 1;
            this.button_freeHand.Text = "Freedrive";
            this.button_freeHand.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Move Tool";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_freeHand);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 438);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(402, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 438);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // FormManualMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(857, 478);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_down);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_up);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormManualMove";
            this.Text = "FormManualMove";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_up;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_down;
        private System.Windows.Forms.Button button_freeHand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}