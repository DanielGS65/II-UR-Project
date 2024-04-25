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
            this.grid.Location = new System.Drawing.Point(22, 67);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersWidth = 20;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(367, 227);
            this.grid.TabIndex = 0;
            // 
            // buttonAddToTrajectory
            // 
            this.buttonAddToTrajectory.Location = new System.Drawing.Point(142, 342);
            this.buttonAddToTrajectory.Name = "buttonAddToTrajectory";
            this.buttonAddToTrajectory.Size = new System.Drawing.Size(128, 23);
            this.buttonAddToTrajectory.TabIndex = 1;
            this.buttonAddToTrajectory.Text = "Add to trajectory";
            this.buttonAddToTrajectory.UseVisualStyleBackColor = true;
            this.buttonAddToTrajectory.Click += new System.EventHandler(this.buttonAddToTrajectory_Click);
            // 
            // gridTrajectory
            // 
            this.gridTrajectory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTrajectory.Location = new System.Drawing.Point(439, 67);
            this.gridTrajectory.Name = "gridTrajectory";
            this.gridTrajectory.RowHeadersWidth = 51;
            this.gridTrajectory.RowTemplate.Height = 24;
            this.gridTrajectory.Size = new System.Drawing.Size(349, 227);
            this.gridTrajectory.TabIndex = 2;
            // 
            // buttonExecTrajectory
            // 
            this.buttonExecTrajectory.Location = new System.Drawing.Point(555, 342);
            this.buttonExecTrajectory.Name = "buttonExecTrajectory";
            this.buttonExecTrajectory.Size = new System.Drawing.Size(128, 23);
            this.buttonExecTrajectory.TabIndex = 3;
            this.buttonExecTrajectory.Text = "Execute trajectory";
            this.buttonExecTrajectory.UseVisualStyleBackColor = true;
            // 
            // FormMostrarPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExecTrajectory);
            this.Controls.Add(this.gridTrajectory);
            this.Controls.Add(this.buttonAddToTrajectory);
            this.Controls.Add(this.grid);
            this.Name = "FormMostrarPuntos";
            this.Text = "FormMostrarPuntos";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrajectory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button buttonAddToTrajectory;
        private System.Windows.Forms.DataGridView gridTrajectory;
        private System.Windows.Forms.Button buttonExecTrajectory;
    }
}