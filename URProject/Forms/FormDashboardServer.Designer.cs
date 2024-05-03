namespace URProject.Forms
{
    partial class FormDashboardServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboardServer));
            this.play = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.shutdown = new System.Windows.Forms.Button();
            this.running = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.directory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.play.ForeColor = System.Drawing.Color.White;
            this.play.Location = new System.Drawing.Point(112, 152);
            this.play.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(146, 49);
            this.play.TabIndex = 0;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_OnClick);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stop.ForeColor = System.Drawing.Color.White;
            this.stop.Location = new System.Drawing.Point(582, 152);
            this.stop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(146, 49);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pause.ForeColor = System.Drawing.Color.White;
            this.pause.Location = new System.Drawing.Point(346, 152);
            this.pause.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(146, 49);
            this.pause.TabIndex = 2;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.quit.ForeColor = System.Drawing.Color.White;
            this.quit.Location = new System.Drawing.Point(824, 152);
            this.quit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(146, 49);
            this.quit.TabIndex = 3;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // shutdown
            // 
            this.shutdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.shutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shutdown.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.shutdown.ForeColor = System.Drawing.Color.White;
            this.shutdown.Location = new System.Drawing.Point(346, 336);
            this.shutdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shutdown.Name = "shutdown";
            this.shutdown.Size = new System.Drawing.Size(146, 49);
            this.shutdown.TabIndex = 4;
            this.shutdown.Text = "Shutdown";
            this.shutdown.UseVisualStyleBackColor = false;
            this.shutdown.Click += new System.EventHandler(this.shutdown_Click);
            // 
            // running
            // 
            this.running.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.running.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.running.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.running.ForeColor = System.Drawing.Color.White;
            this.running.Location = new System.Drawing.Point(112, 336);
            this.running.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.running.Name = "running";
            this.running.Size = new System.Drawing.Size(146, 49);
            this.running.TabIndex = 5;
            this.running.Text = "Running";
            this.running.UseVisualStyleBackColor = false;
            this.running.Click += new System.EventHandler(this.running_Click);
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.load.ForeColor = System.Drawing.Color.White;
            this.load.Location = new System.Drawing.Point(732, 66);
            this.load.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(238, 49);
            this.load.TabIndex = 6;
            this.load.Text = "Load Program";
            this.load.UseVisualStyleBackColor = false;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // directory
            // 
            this.directory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.directory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.directory.ForeColor = System.Drawing.Color.White;
            this.directory.Location = new System.Drawing.Point(112, 71);
            this.directory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(598, 39);
            this.directory.TabIndex = 7;
            // 
            // FormDashboardServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.directory);
            this.Controls.Add(this.load);
            this.Controls.Add(this.running);
            this.Controls.Add(this.shutdown);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDashboardServer";
            this.Text = "FormDashboardServer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button shutdown;
        private System.Windows.Forms.Button running;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.TextBox directory;
    }
}