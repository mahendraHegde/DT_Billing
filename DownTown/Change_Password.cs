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
    public partial class Change_Password : Form
    {
        public Change_Password()
        {
            InitializeComponent();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOldPass.Text = "";
            txtNewPass.Text = "";
            txtConfPass.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String oldPass;
            oldPass = txtOldPass.Text;
            if(oldPass=="Admin")
            {
                if(txtNewPass.Text!="")
                {
                    if(txtConfPass.Text!="" && txtConfPass.Text.Equals(txtNewPass.Text))
                    {
                        MessageBox.Show("Password has been changed successfully!!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Confirm Password Doesn't Match");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter New Pasword");
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Old Pasword");
            }
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {
            txtUser.Text = "Admin";
        }
    }
}
