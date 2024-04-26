namespace URProject.Forms
{
    partial class FormMostrarPuntos
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.buttonAddToTrajectory = new System.Windows.Forms.Button();
            this.gridTrajectory = new System.Windows.Forms.DataGridView();
            this.buttonExecTrajectory = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSavePose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrajectory)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(16, 54);
            this.grid.Margin = new System.Windows.Forms.Padding(2);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersWidth = 20;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(275, 184);
            this.grid.TabIndex = 0;
            // 
            // buttonAddToTrajectory
            // 
            this.buttonAddToTrajectory.Location = new System.Drawing.Point(106, 278);
            this.buttonAddToTrajectory.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddToTrajectory.Name = "buttonAddToTrajectory";
            this.buttonAddToTrajectory.Size = new System.Drawing.Size(96, 19);
            this.buttonAddToTrajectory.TabIndex = 1;
            this.buttonAddToTrajectory.Text = "Add to trajectory";
            this.buttonAddToTrajectory.UseVisualStyleBackColor = true;
            this.buttonAddToTrajectory.Click += new System.EventHandler(this.buttonAddToTrajectory_Click);
            // 
            // gridTrajectory
            // 
            this.gridTrajectory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTrajectory.Location = new System.Drawing.Point(329, 54);
            this.gridTrajectory.Margin = new System.Windows.Forms.Padding(2);
            this.gridTrajectory.Name = "gridTrajectory";
            this.gridTrajectory.RowHeadersWidth = 51;
            this.gridTrajectory.RowTemplate.Height = 24;
            this.gridTrajectory.Size = new System.Drawing.Size(262, 184);
            this.gridTrajectory.TabIndex = 2;
            // 
            // buttonExecTrajectory
            // 
            this.buttonExecTrajectory.Location = new System.Drawing.Point(416, 278);
            this.buttonExecTrajectory.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExecTrajectory.Name = "buttonExecTrajectory";
            this.buttonExecTrajectory.Size = new System.Drawing.Size(96, 19);
            this.buttonExecTrajectory.TabIndex = 3;
            this.buttonExecTrajectory.Text = "Execute trajectory";
            this.buttonExecTrajectory.UseVisualStyleBackColor = true;
            this.buttonExecTrajectory.Click += new System.EventHandler(this.buttonExecTrajectory_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 313);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 5;
            // 
            // buttonSavePose
            // 
            this.buttonSavePose.Location = new System.Drawing.Point(357, 313);
            this.buttonSavePose.Name = "buttonSavePose";
            this.buttonSavePose.Size = new System.Drawing.Size(75, 23);
            this.buttonSavePose.TabIndex = 4;
            this.buttonSavePose.Text = "Save pose";
            this.buttonSavePose.UseVisualStyleBackColor = true;
            this.buttonSavePose.Click += new System.EventHandler(this.buttonSavePose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 19);
            this.button1.TabIndex = 6;
            this.button1.Text = "Delete point";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMostrarPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSavePose);
            this.Controls.Add(this.buttonExecTrajectory);
            this.Controls.Add(this.gridTrajectory);
            this.Controls.Add(this.buttonAddToTrajectory);
            this.Controls.Add(this.grid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMostrarPuntos";
            this.Text = "FormMostrarPuntos";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrajectory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button buttonAddToTrajectory;
        private System.Windows.Forms.DataGridView gridTrajectory;
        private System.Windows.Forms.Button buttonExecTrajectory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSavePose;
        private System.Windows.Forms.Button button1;
    }
}