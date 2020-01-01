using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sales_And_Inventory_Management.SRV;

namespace Sales_And_Inventory_Management_Project1
{
    public partial class FrmReg : Form
    {
        Login add = new Login();
        public FrmReg()
        {
            InitializeComponent();
        }

        public void RefreshObject()
        {
            add.Utype = cmutype.Text;
            add.Uname = txtuname.Text;
            add.Pass = txtPass.Text;
           // add.Email = txtEmail.Text;
        }

        public void save()
        {
            try
            {
                RefreshObject();
                add.Insert();
                MessageBox.Show("Information saved successfully.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtuname.Text = "";
                txtPass.Text = "";
                txtCpass.Text = "";
               // txtEmail.Text = "";
                cmutype.Text = "------- Select User Type -------";
               // txtEmail.Focus();
                checkBox1.Checked = false;
            }
            catch (Exception )
            {
                MessageBox.Show("User Name already exist.Please try with a new user name.","Sales And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtuname.Text = "";
                txtPass.Text = "";
                txtCpass.Text = "";
                // txtEmail.Text = "";
                cmutype.Text = "------- Select User Type -------";
                // txtEmail.Focus();
                checkBox1.Checked = false;
            
            }
                

        }

        public void check()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = add.LoadUser(txtuname.Text);
                int j = dt.Rows.Count;
                if (j !=0)
                {
                    MessageBox.Show("Username already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtuname.Text = "";
                    txtuname.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
           



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cmutype.Text == "------- Select User Type -------")
            {
                MessageBox.Show("Please select user type", "Sales and Inventory Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmutype.Focus();
                return;
            }
         
          

            if (txtuname.Text == "")
            {
                MessageBox.Show("Please enter user name", "Sales and Inventory Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtuname.Focus();
                return;
            }

            if (txtPass.Text == "")
            {
                MessageBox.Show("Please enter password", "Sales and Inventory Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;
            }

            if (txtCpass.Text == "")
            {
                MessageBox.Show("Please enter password again", "Sales and Inventory Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCpass.Focus();
                return;
            }

            if (txtPass.Text != txtCpass.Text)
            {
                MessageBox.Show("Password is not match.\n" + "Try Again.", "Sales and Inventory Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCpass.Focus();
                txtCpass.Text = "";
                checkBox1.Checked = false;
                return;
            }
            else
            {
                checkBox1.Checked = true;
            }
           



            save();

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuname_Leave(object sender, EventArgs e)
        {
            if(txtuname.Text !="")
            {
            check();
            }
        }

        private void txtCpass_Leave(object sender, EventArgs e)
        {
            

        }

        private void FrmReg_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Enabled = true;
        }

        private void FrmReg_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
            ToolTip toolTip1 = new ToolTip();


            toolTip1.AutoPopDelay = 5000;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.btnClose, "Close(Ctrl+C) ");
            toolTip1.SetToolTip(this.button5, "Save(Ctrl+s)");
        }

        private void cmutype_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmutype_SelectedIndexChanged(object sender, EventArgs e)
        {
           // txtEmail.Focus();
            txtuname.Focus();
        }

        private void txtuname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }



            if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            if (e.KeyChar == '.' || e.KeyChar == '_')
            {
                e.Handled = false;
            }

            if (e.KeyChar == (char)13)
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }



            if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            if (e.KeyChar == '.' || e.KeyChar == '_')
            {
                e.Handled = false;
            }

            if (e.KeyChar == (char)13)
            {
                txtCpass.Focus();
            }

          
        }

        private void txtCpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }



            if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            if (e.KeyChar == '.' || e.KeyChar == '_')
            {
                e.Handled = false;
            }
        }

        private void lbuname_Click(object sender, EventArgs e)
        {

        }

        private void FrmReg_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == (Keys.Control | Keys.S))
            {
                if (cmutype.Text == "------- Select User Type -------")
                {
                    MessageBox.Show("Please select user type", "Sales and Inventory Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmutype.Focus();
                    return;
                }



                if (txtuname.Text == "")
                {
                    MessageBox.Show("Please enter user name", "Sales and Inventory Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtuname.Focus();
                    return;
                }

                if (txtPass.Text == "")
                {
                    MessageBox.Show("Please enter password", "Sales and Inventory Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Focus();
                    return;
                }

                if (txtCpass.Text == "")
                {
                    MessageBox.Show("Please enter password again", "Sales and Inventory Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCpass.Focus();
                    return;
                }

                if (txtPass.Text != txtCpass.Text)
                {
                    MessageBox.Show("Password is not match.\n" + "Try Again.", "Sales and Inventory Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCpass.Focus();
                    txtCpass.Text = "";
                    checkBox1.Checked = false;
                    return;
                }
                else
                {
                    checkBox1.Checked = true;
                }
           

                save();
            }
            if (e.KeyData == (Keys.Control | Keys.C))
            {
                this.Close();
            }
        }
    }
}
