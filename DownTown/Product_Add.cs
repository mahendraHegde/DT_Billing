using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SQLite;

namespace DownTown
{
    public partial class Product_Add : Form
    {
        String preveText = "";
        
        DTDB db;
        String qty ="";
        public Product_Add()
        {
            InitializeComponent();
            comboSubGroup.Visible = false;
            lblSubGroup.Visible = false;
            txtML.Visible = false;
            lblML.Visible = false;
        }

        private void Product_Add_Update_Load(object sender, EventArgs e)
        {
           

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int c = 0, c1 = 0;
            if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtName.Text) || (txtML.Visible == true && string.IsNullOrWhiteSpace(txtML.Text)) || string.IsNullOrWhiteSpace(txtAc.Text) || string.IsNullOrWhiteSpace(txtFc.Text) || string.IsNullOrWhiteSpace(txtGarden.Text) || string.IsNullOrWhiteSpace(txtOc.Text) || string.IsNullOrWhiteSpace(txtParcel.Text) || string.IsNullOrWhiteSpace(txtRoom.Text))
            {
                MessageBox.Show("Please fill all the feilds");
                return;
            }
            if (comboGroup.SelectedIndex < 0 || (comboSubGroup.Visible == true && comboSubGroup.SelectedIndex < 0)) {
                MessageBox.Show("Please Select Product category or subcategory");
                return;
            }
            try
            {
                db = new DTDB();

             String sql="insert into "+DTDB.TABLE_ITEMS+ " (code,name,ml,category,tax,fc,ac,oc,room,parcel,garden) values(@code,@name,@ml,@category,@tax,@fc,@ac,@oc,@room,@parcel,@garden)";
             SQLiteCommand cmd = new SQLiteCommand(sql,db.conn);
             cmd.Parameters.Add("@code",DbType.Int32).Value=txtCode.Text;
             cmd.Parameters.Add("@name", DbType.String).Value=txtName.Text;
             if (comboSubGroup.Visible == true)
             {
                    if (comboSubGroup.Text.ToUpper().Contains("LIQUOR"))
                    {
                        cmd.Parameters.Add("@ml", DbType.Int32).Value = txtML.Text;
                    }else
                        cmd.Parameters.Add("@ml", DbType.Int32).Value =0;

                    cmd.Parameters.Add("@category", DbType.String).Value = comboSubGroup.Text;
             }else
             {
                cmd.Parameters.Add("@ml", DbType.Int32).Value =0;
                cmd.Parameters.Add("@category", DbType.String).Value = comboGroup.Text;
             }
             if (chkTax.Checked == true)
             {
                 cmd.Parameters.Add("@tax", DbType.Int32).Value =1;
             }else
             {
                cmd.Parameters.Add("@tax", DbType.Int32).Value = 0;
             }
             cmd.Parameters.Add("@fc",DbType.Double).Value=txtFc.Text;
             cmd.Parameters.Add("@ac", DbType.Double).Value =txtAc.Text;
             cmd.Parameters.Add("@oc", DbType.Double).Value = txtOc.Text;
             cmd.Parameters.Add("@room", DbType.Double).Value = txtFc.Text;
             cmd.Parameters.Add("@parcel", DbType.Double).Value = txtParcel.Text;
             cmd.Parameters.Add("@garden", DbType.Double).Value = txtGarden.Text;
             sql = "insert into "+DTDB.TABLE_STOCK+" (code,qty,ml) values(@code,@qty,@ml)";

             SQLiteCommand cmd1 = new SQLiteCommand(sql, db.conn);
             cmd1.Parameters.Add("@code", DbType.Int32).Value = txtCode.Text;
             cmd1.Parameters.Add("@qty", DbType.Int32).Value = txtQty.Text;
                if (comboSubGroup.Visible == true && comboSubGroup.Text.ToUpper().Contains("LIQUOR"))
                {
                    cmd1.Parameters.Add("@ml", DbType.Int32).Value = txtML.Text;
                }else
                {
                    cmd1.Parameters.Add("@ml", DbType.Int32).Value =0;
                }
                if ((c=cmd.ExecuteNonQuery())>0 && (c1=cmd1.ExecuteNonQuery())>0)
                {
                    MessageBox.Show("Item Added SuccessFully");
                }else if (c > 0 && c1 <= 0)
                {
                    SQLiteCommand cmd2 = new SQLiteCommand("delete from "+ DTDB.TABLE_ITEMS+" where code=@code", db.conn);
                    cmd2.Parameters.Add("@code", DbType.Int32).Value = txtCode.Text;
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Unable to Add the Product Please try again later...");
                }else if (c <= 0 && c1 > 0)
                {
                    SQLiteCommand cmd2 = new SQLiteCommand("delete from " + DTDB.TABLE_STOCK + " where code=@code", db.conn);
                    cmd2.Parameters.Add("@code", DbType.Int32).Value = txtCode.Text;
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Unable to Add the Product Please try again later...");
                }


            }
             catch(SQLiteException e1)
             {
                if (e1.ErrorCode == 19)
                {
                    MessageBox.Show("Item With such code already exists!!! ");
                }else
                {
                    MessageBox.Show(e1.Message);
                }
             }
             catch (Exception e1)
             {
                 MessageBox.Show(e1.Message);
             }
             finally
             {
                 db.conn.Close();
             }

        }

        private void comboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex == 0)
            {
                comboSubGroup.Visible = false;
                comboSubGroup.SelectedIndex = -1;
                lblSubGroup.Visible = false;
                txtML.Visible = false;
                lblML.Visible = false;
            }
            else
            {
                lblSubGroup.Visible = true;
                comboSubGroup.Visible = true;
            }
        }

        private void comboSubGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (((ComboBox)sender).Text.ToUpper().Contains("LIQUOR"))
            {
                lblML.Visible = true;
                txtML.Visible = true;
            }
            else
            {
                lblML.Visible = false;
                txtML.Visible = false;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex("^-{0,1}\\d+\\.{0,1}\\d*$");
            TextBox txt = (TextBox)sender;
            Match m = r.Match(txt.Text.Trim());
            if (m.Success||string.IsNullOrWhiteSpace(txt.Text))
            {
                preveText = txt.Text.Trim();
            }
            else
            {
                txt.Text = preveText;
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex(@"^\d+$");
            TextBox txt = (TextBox)sender;
            Match m = r.Match(txt.Text.Trim());
            if (m.Success || string.IsNullOrWhiteSpace(txt.Text))
            {
                preveText = txt.Text.Trim();
            }
            else
            {
                txt.Text = preveText;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
            txtName.Text = "";
            comboGroup.SelectedIndex = -1;
            comboSubGroup.SelectedIndex = -1;
            comboSubGroup.Visible = false;
            lblSubGroup.Visible = false;
            txtQty.Text = "";
            lblML.Visible = false;
            txtML.Text = "";
            txtML.Visible = false;
            chkTax.Checked = false;
            txtFc.Text = "";
            txtAc.Text = "";
            txtOc.Text = "";
            txtRoom.Text = "";
            txtParcel.Text = "";
            txtGarden.Text = "";
        }
    }
}
