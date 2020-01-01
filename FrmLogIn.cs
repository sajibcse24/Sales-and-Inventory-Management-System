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
    public partial class FrmLogIn : Form
    {
        Login add = new Login();
        public FrmLogIn()
        {
            InitializeComponent();
        }

       

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;

    
            toolTip1.ShowAlways = true;

   
            toolTip1.SetToolTip(this.btnLogin, "Up (Ctrl + L)");
         
            toolTip1.SetToolTip(this.btnExit, "Exit(ESC)");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cmutype.Text == "SELECT")
            {
                MessageBox.Show("Please select user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmutype.Focus();
                return;
            }
           
            if (txtuname.Text == "")
            {
                MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtuname.Focus();
                return;
            }
            if (txtpass.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Focus();
                return;
            }

           
            DataTable dt = new DataTable();
            string utype = Convert.ToString(cmutype.Text);
            string uname = Convert.ToString(txtpass.Text);
            string pass = Convert.ToString(txtuname.Text);
            add.Utype = cmutype.Text;
            add.Uname = txtpass.Text;
            add.Pass = txtuname.Text;
           
            dt = add.LoadAccount(uname,pass,utype);
          int  j = dt.Rows.Count;

            if (j!=0)
            {
           
                this.Hide();
                 FrmMain frm = new FrmMain();
                 frm.Show();
                 frm.lbuname.Text =cmutype.Text;
                 frm.lblProfile.Text = txtuname.Text;
                 frm.lvTupe.Text= cmutype.Text;
                 if (cmutype.Text == "Admin")
                 {
                     frm.registrationToolStripMenuItem.Enabled = true;
                 }
                 else
                 {
                     frm.registrationToolStripMenuItem.Enabled = false;
                 }
                
                
             }
            else
            {
                MessageBox.Show("Login Unsuccessful !\nSorry ! Your Username or Password is incorrect.\n" + "Please enter an valid Username and Password.", "Login Status Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtuname.Focus();
                txtuname.Text = "";
                txtpass.Text = "";

            }
               
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnChngpass_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmChangepassword frm = new FrmChangepassword();
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void cmutype_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

                txtpass.Focus();
                
            }
        }

        private void cmutype_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtuname.Focus();
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FrmLogIn_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == (Keys.Control | Keys.L))
            {
                if (cmutype.Text == "SELECT")
                {
                    MessageBox.Show("Please select user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmutype.Focus();
                    return;
                }

                if (txtuname.Text == "")
                {
                    MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtuname.Focus();
                    return;
                }
                if (txtpass.Text == "")
                {
                    MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpass.Focus();
                    return;
                }


                DataTable dt = new DataTable();
                string utype = Convert.ToString(cmutype.Text);
                string uname = Convert.ToString(txtpass.Text);
                string pass = Convert.ToString(txtuname.Text);
                add.Utype = cmutype.Text;
                add.Uname = txtpass.Text;
                add.Pass = txtuname.Text;

                dt = add.LoadAccount(uname, pass, utype);
                int j = dt.Rows.Count;

                if (j != 0)
                {

                    this.Hide();
                    FrmMain frm = new FrmMain();
                    frm.Show();
                    frm.lbuname.Text = cmutype.Text;
                    frm.lblProfile.Text = txtuname.Text;
                    frm.lvTupe.Text = cmutype.Text;
                    if (cmutype.Text == "Admin")
                    {
                        frm.registrationToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        frm.registrationToolStripMenuItem.Enabled = false;
                    }


                }
                else
                {
                    MessageBox.Show("Login Unsuccessful !\nSorry ! Your Username or Password is incorrect.\n" + "Please enter an valid Username and Password.", "Login Status Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtuname.Focus();
                    txtuname.Text = "";
                    txtpass.Text = "";

                }
               
            }
        }
       
        
    }
}

