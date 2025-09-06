using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDriven.Project.UI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClient child = new FormClient(); 
            child.MdiParent = this;
            child.WindowState = FormWindowState.Maximized;
            child.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
