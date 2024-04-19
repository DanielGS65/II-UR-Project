using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URProject.Forms
{
    public partial class Form_dioni : Form
    {
        public Form_dioni()
        {
            InitializeComponent();
        }

        private void clickButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string name = button.Name;
        }
    }
}
