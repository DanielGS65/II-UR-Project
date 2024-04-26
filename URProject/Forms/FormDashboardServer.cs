using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using URProject.Classes;

namespace URProject.Forms
{
    public partial class FormDashboardServer : Form
    {
        ClassDashboardServer dS;

        public FormDashboardServer()
        {
            InitializeComponent();
            this.dS = new ClassDashboardServer();
        }

        public void setDashboardServer(ClassDashboardServer dS)
        {
            this.dS = dS; 
        }

        private void play_OnClick(object sender, EventArgs e)
        {
            this.dS.playProgram();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            this.dS.stopProgram();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            this.dS.pauseProgram();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.dS.quitProgram();
        }

        private void shutdown_Click(object sender, EventArgs e)
        {
            this.dS.shutdownProgram();
        }

        private void running_Click(object sender, EventArgs e)
        {
            this.dS.runningProgram();
        }
    }
}
