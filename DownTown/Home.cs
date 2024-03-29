﻿using System;
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
        Form product_add_form = null;
        Form product_update_form = null;
        Form tax = null;
        Form change_password = null;
        Form stock_update = null;
        DTDB Db;
        public Home()
        {
            InitializeComponent();
            Db=new DTDB();
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
            product_add_form = new Product_Add();
            product_add_form.MdiParent = this;
            product_add_form.Dock = DockStyle.Fill;

            product_add_form.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Are You Sure to Quit?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, "", buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            }
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Home")
                    Application.OpenForms[i].Close();
            }
            this.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            product_update_form = new Product_Update();
            product_update_form.MdiParent = this;
            product_update_form.Dock = DockStyle.Fill;
            product_update_form.Show();
        }

        private void taxRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tax = new Tax();
            tax.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_password = new Change_Password();
            change_password.ShowDialog();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            stock_update = new Stock_Update();
            stock_update.ShowDialog();
        }
    }
}
