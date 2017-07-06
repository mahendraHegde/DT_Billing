using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownTown
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
           
        }
        private const int WM_NCLBUTTONDBLCLK = 0x00A3; //double click on a title bar a.k.a. non-client area of the form

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                m.Result = IntPtr.Zero;
                return;
            }
            base.WndProc(ref m);
        }

        private void addUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Product_Add_Update();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
         
            f.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int res;
            this.Close();
        }
    }
}
