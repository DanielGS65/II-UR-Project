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
            this.play = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.shutdown = new System.Windows.Forms.Button();
            this.running = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(75, 37);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 23);
            this.play.TabIndex = 0;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_OnClick);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(75, 91);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(75, 149);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 23);
            this.pause.TabIndex = 2;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(75, 207);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 23);
            this.quit.TabIndex = 3;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // shutdown
            // 
            this.shutdown.Location = new System.Drawing.Point(75, 269);
            this.shutdown.Name = "shutdown";
            this.shutdown.Size = new System.Drawing.Size(75, 23);
            this.shutdown.TabIndex = 4;
            this.shutdown.Text = "Shutdown";
            this.shutdown.UseVisualStyleBackColor = true;
            this.shutdown.Click += new System.EventHandler(this.shutdown_Click);
            // 
            // running
            // 
            this.running.Location = new System.Drawing.Point(75, 335);
            this.running.Name = "running";
            this.running.Size = new System.Drawing.Size(75, 23);
            this.running.TabIndex = 5;
            this.running.Text = "Running";
            this.running.UseVisualStyleBackColor = true;
            this.running.Click += new System.EventHandler(this.running_Click);
            // 
            // FormDashboardServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.running);
            this.Controls.Add(this.shutdown);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.play);
            this.Name = "FormDashboardServer";
            this.Text = "FormDashboardServer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button shutdown;
        private System.Windows.Forms.Button running;
    }
}