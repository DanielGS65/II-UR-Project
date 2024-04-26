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
            this.load = new System.Windows.Forms.Button();
            this.directory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(75, 130);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 23);
            this.play.TabIndex = 0;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_OnClick);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(75, 178);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(75, 230);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 23);
            this.pause.TabIndex = 2;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(75, 278);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 23);
            this.quit.TabIndex = 3;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // shutdown
            // 
            this.shutdown.Location = new System.Drawing.Point(75, 323);
            this.shutdown.Name = "shutdown";
            this.shutdown.Size = new System.Drawing.Size(75, 23);
            this.shutdown.TabIndex = 4;
            this.shutdown.Text = "Shutdown";
            this.shutdown.UseVisualStyleBackColor = true;
            this.shutdown.Click += new System.EventHandler(this.shutdown_Click);
            // 
            // running
            // 
            this.running.Location = new System.Drawing.Point(75, 372);
            this.running.Name = "running";
            this.running.Size = new System.Drawing.Size(75, 23);
            this.running.TabIndex = 5;
            this.running.Text = "Running";
            this.running.UseVisualStyleBackColor = true;
            this.running.Click += new System.EventHandler(this.running_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(75, 82);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 6;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // directory
            // 
            this.directory.Location = new System.Drawing.Point(206, 82);
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(312, 20);
            this.directory.TabIndex = 7;
            // 
            // FormDashboardServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.directory);
            this.Controls.Add(this.load);
            this.Controls.Add(this.running);
            this.Controls.Add(this.shutdown);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.play);
            this.Name = "FormDashboardServer";
            this.Text = "FormDashboardServer";
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