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
    public partial class login : Form
    {
        Form Home;
        //public event EventHandler Leave;
        public login()
        {
            InitializeComponent();
        }

        private void txtusername_Leave(Object sender, EventArgs e)
        {
            txtusername.Text = "";
            MessageBox.Show("You are in the Control.GotFocus event.");

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "admin")
            {
                if (txtpassword.Text == "admin")
                {
                    Home = new Home();
                    Home.ShowDialog();
                    this.Close();

                }
                else
                    MessageBox.Show("Password is Incorrect");
            }
            else
                MessageBox.Show("User Name is Incorrect");
        }
    }
}
