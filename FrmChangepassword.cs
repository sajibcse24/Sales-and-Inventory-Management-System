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
    public partial class FrmChangepassword : Form
    {
        ChangeAccount add = new ChangeAccount();
        Login log = new Login();
        public FrmChangepassword()
        {
            InitializeComponent();
        }
        public void save()
        {
            if (txtNpass.Text != txtCpass.Text)
            {
                MessageBox.Show("Password is not confirmed\n" + "Try Again.");
                txtCpass.Focus();
                txtCpass.Text = "";
                checkBox1.Checked = false;
                return;
            }
            else
            {
                checkBox1.Checked = true;
            }

            try
            {

                {
                    add.Utype = cmutype.Text;
                    add.Uname = txtUname.Text;
                    add.Nuname = txtpuname.Text;
                    add.Pass = txtCpass.Text;
                    add.updateaccount();
                    MessageBox.Show("Your Account Is Successfully Changed", "Account Change Status Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox1.Checked = false;
                    txtCpass.Text = "";
                    txtNpass.Text = "";
                    txtPrepass.Text = "";
                    txtpuname.Text = "";
                    txtUname.Text = "";
                    txtpuname.Enabled = false;
                    // txtUname.Enabled = false;
                    txtNpass.Enabled = false;
                    txtCpass.Enabled = false;
                    txtPrepass.Enabled = false;
                    // cmutype.Text = "SELECT";
                    txtUname.Focus();







                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Can't Changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         

        }


        private void button2_Click(object sender, EventArgs e)
        {
            save();
           
        }

        private void FrmChangepassword_Load(object sender, EventArgs e)
        {
            txtUname.Enabled = true;
            txtpuname.Enabled = false;
            txtPrepass.Enabled = false;
            txtNpass.Enabled = false;
            txtCpass.Enabled = false;
            button2.Enabled = false;
            ToolTip toolTip1 = new ToolTip();


            toolTip1.AutoPopDelay = 5000;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.button1, "Cancel(Ctrl+C) ");
            toolTip1.SetToolTip(this.button2, "Save(Ctrl+S)");
           // toolTip1.SetToolTip(this.btndelete, "Delete(Ctrl+D)");
        }

        private void cmutype_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCpass.Text = "";
            txtNpass.Text = "";
            txtPrepass.Text = "";
            txtpuname.Text = "";
            txtUname.Text = "";
            txtUname.Enabled = true;
            txtPrepass.Enabled = false;
            txtUname.Focus();
        }

        public void getunameadmin()
        {
                  
           
            DataTable dt = new DataTable();
            string utype = Convert.ToString(cmutype.Text);
            string uname = Convert.ToString(txtUname.Text);


            add.Uname = txtUname.Text;
            add.Utype = cmutype.Text;


            dt = add.LoadPass(uname,utype);
            int j = dt.Rows.Count;

            if (j == 1)
            {

                txtPrepass.Enabled = true;
                txtPrepass.Focus();

            }
            else
            {
                txtpuname.Enabled = false;
                txtPrepass.Enabled = false;
                txtNpass.Enabled = false;
                txtCpass.Enabled = false;

            }

        }

        public void getaccountadmin()
        {

          
           

            DataTable dt = new DataTable();
            string utype = Convert.ToString(cmutype.Text);
            string uname = Convert.ToString(txtUname.Text);
            string pass = Convert.ToString(txtPrepass.Text);

            add.Utype = cmutype.Text;
            add.Uname = txtUname.Text;
            add.Pass = txtPrepass.Text;

            dt = add.LoadAccount(uname, pass,utype);
            int j = dt.Rows.Count;

            if (j == 1)
            {

                txtpuname.Enabled = true;
                txtpuname.Focus();
                txtNpass.Enabled = true;
                txtCpass.Enabled = true;


            }
            else
            {
              //  MessageBox.Show("Sorry,your are not an authentication user.\n" + "You can't change system account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void getunameuser()
        {


          

            DataTable dt = new DataTable();
            string utype = Convert.ToString(cmutype.Text);
            string uname = Convert.ToString(txtUname.Text);

            add.Utype = cmutype.Text;
            add.Uname = txtUname.Text;


            dt = add.LoadPass(uname,utype);
            int j = dt.Rows.Count;

            if (j == 1)
            {

                txtPrepass.Enabled = true;
                txtPrepass.Focus();

            }
            else
            {
                txtpuname.Enabled = false;
                txtPrepass.Enabled = false;
                txtNpass.Enabled = false;
                txtCpass.Enabled = false;

            }

        }

        public void getaccountuser()
        {




            DataTable dt = new DataTable();
            string utype = Convert.ToString(cmutype.Text);
            string uname = Convert.ToString(txtUname.Text);
            string pass = Convert.ToString(txtPrepass.Text);

            add.Utype = cmutype.Text;
            add.Uname = txtUname.Text;
            add.Pass = txtPrepass.Text;

            dt = add.LoadAccount(uname, pass,utype);
            int j = dt.Rows.Count;

            if (j == 1)
            {

                txtpuname.Enabled = true;
                txtpuname.Focus();
                txtNpass.Enabled = true;
                txtCpass.Enabled = true;


            }
            else
            {
                //  MessageBox.Show("Sorry,your are not an authentication user.\n" + "You can't change system account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }


        }

        private void txtUname_TextChanged(object sender, EventArgs e)
        {
            if (cmutype.Text == "Admin")
            {
                getunameadmin();

            }
            if (cmutype.Text == "User")
            {
                getunameuser();

            }
            if (txtUname.Text == "" || txtPrepass.Text == "")
            {
                txtCpass.Text = "";
                txtNpass.Text = "";
                txtPrepass.Text = "";
                txtpuname.Text = "";
                txtpuname.Enabled = false;

                txtNpass.Enabled = false;
                txtCpass.Enabled = false;

            } 

              
        }

        private void txtPrepass_TextChanged(object sender, EventArgs e)
        {
            if (cmutype.Text == "Admin")
            {

                getaccountadmin();
            }
            if (cmutype.Text == "User")
            {

                getaccountuser();
            }
            if (txtUname.Text == "" || txtPrepass.Text == "")
            {
                txtCpass.Text = "";
                txtNpass.Text = "";
                txtPrepass.Text = "";
                txtpuname.Text = "";
                txtpuname.Enabled = false;

                txtNpass.Enabled = false;
                txtCpass.Enabled = false;

            }
           
           
        }

        private void txtPrepass_Leave(object sender, EventArgs e)
        {
           
        }

        private void cmutype_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            
                e.Handled = true;

            
        }

        private void txtCpass_TextChanged(object sender, EventArgs e)
        {
            if(txtCpass.Text !="" && txtNpass.Text !="" && txtPrepass.Text !="" && txtpuname.Text !="" && txtUname.Text !="" && cmutype.Text !="----- SELECT -----")
            {
               button2.Enabled=true; 
            }
            else
            {
                 button2.Enabled=false; 
            }
        }

        private void txtNpass_TextChanged(object sender, EventArgs e)
        {
            if (txtCpass.Text != "" && txtNpass.Text != "" && txtPrepass.Text != "" && txtpuname.Text != "" && txtUname.Text != "" && cmutype.Text != "----- SELECT -----")
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void txtpuname_TextChanged(object sender, EventArgs e)
        {
            if (txtCpass.Text != "" && txtNpass.Text != "" && txtPrepass.Text != "" && txtpuname.Text != "" && txtUname.Text != "" && cmutype.Text != "----- SELECT -----")
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void txtCpass_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void txtUname_KeyPress(object sender, KeyPressEventArgs e)
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

           /* if (e.KeyChar == (char)13)
            {
                if (cmutype.Text == "Admin")
                {
                    getunameadmin();

                }
                if (cmutype.Text == "User")
                {
                    getunameuser();

                }
               

            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtpuname_KeyPress(object sender, KeyPressEventArgs e)
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

            if(e.KeyChar==(char)13)
            {
                txtNpass.Focus();
            }
        }

        private void txtNpass_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrepass_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FrmChangepassword_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == (Keys.Control | Keys.S))
            {
                save();
            }
            if (e.KeyData == (Keys.Control | Keys.C))
            {
                this.Close();
            }
        }
    }
}
