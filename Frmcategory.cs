using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sales_And_Inventory_Management.SRV;
using System.Data.SqlClient;

 
namespace Sales_And_Inventory_Management_Project1
{
    public partial class Frmcategory : Form
    {
        category _add = new category();
        category add = new category();
        public Frmcategory()
        {
            InitializeComponent();
        }
        public void RefreshObject()
        {
            _add.Categoryname = txtcatname.Text;
            _add.Categoryid = txtcatid.Text;
            _add.Categorydes = txtcatdes.Text;

        }

        public void checkinfo()
        {
            try
            {
                DataTable dt = new DataTable();

                dt = add.Companyinfo(txtcatname.Text,txtcatid.Text);
                int j = dt.Rows.Count;

                if (j == 0)
                {

                    _add.Insert();
                    MessageBox.Show("Information saved successfully.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcatname.Focus();
                    loadcatinfo();

                    txtcatdes.Text = "";
                    txtcatname.Text = "";

                }
                else
                {
                    MessageBox.Show("Category already exist.", "UnSuccessful Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcatdes.Text = "";
                    txtcatname.Text = "";
                    txtcatname.Focus();
                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Category already exist.", "UnSuccessful Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcatdes.Text = "";
                    txtcatname.Text = "";
                    txtcatname.Focus();
            }
        }

        public void categoryinfo()
        {
            DataTable dt = new DataTable();
            string uname = Convert.ToString(txtcatid.Text);
            add.Categoryid = txtcatid.Text;
            dt = add.Categoryinfo(uname);
            int j = dt.Rows.Count;
            if(j!=0){
            for(int i=0;i<j;i++)
        
            {

              txtcatdes.Text=dt.Rows[i]["cname"].ToString();
              txtcatname.Text=dt.Rows[i]["cdes"].ToString();

            }

            }
            else
            {
                MessageBox.Show("Information is not exist","Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadcatinfo()
        {
            DataTable dt = new DataTable();
            dt = add.LoadCategoryinfo();
            int j = dt.Rows.Count;
            // comboBox1.Items.Clear();
            {
                if (j != 0)
                {
                    for (int i = 0; i < j; i++)
                    {

                        textBox1.Text = dt.Rows[i]["cid"].ToString();

                    }
                    string d = textBox1.Text;
                    double a = Convert.ToDouble(d);
                    double b = a + 1;
                    txtcatid.Text = b.ToString();


                }
                else
                {
                    txtcatid.Text = "1";
                }
            } 

        }
        void save()
        {
            if (txtcatid.Text == "")
            {

                MessageBox.Show("Please enter Category ID.");
                txtcatid.Focus();
                return;


            }
            if (txtcatname.Text == "")
            {

                MessageBox.Show("Please enter Category name.");
                txtcatname.Focus();
                return;


            }

            if (txtcatdes.Text == "")
            {

                MessageBox.Show("Please enter  Category description.");
                txtcatdes.Focus();
                return;
            }

            RefreshObject();


         

          
                checkinfo();

            
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            save();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
        }
        public void updatecinfo()
        {

            try
            {

                {
                   
                    if (txtcatid.Text == "")
                    {

                        MessageBox.Show("Please enter Category ID.");
                        txtcatid.Focus();
                        return;


                    }
                    if (txtcatname.Text == "")
                    {

                        MessageBox.Show("Please enter Category name.");
                        txtcatname.Focus();
                        return;


                    }

                    if (txtcatdes.Text == "")
                    {

                        MessageBox.Show("Please enter  Category description.");
                        txtcatdes.Focus();
                        return;
                    }
                        
                    add.Categoryid = txtcatid.Text;
                    add.Categoryname = txtcatdes.Text;
                    add.Categorydes = txtcatname.Text;

                    add.UpdateCategoryinfo();
                    MessageBox.Show(" Successfully Updated", "Update Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //txtcatid.Text = "";
                    txtcatname.Text = "";
                    txtcatdes.Text = "";
                    loadcatinfo();
                    btnupdate.Enabled = false;
                    btndelete.Enabled = false;
                    button1.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Can't updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            updatecinfo();

        }
        public void deletecinfo()
        {

            if (txtcatid.Text == "")
            {

                MessageBox.Show("Please enter Category ID !");
                txtcatid.Focus();
                return;


            }
           // add.Categoryname = txtcatdes.Text;

            if (MessageBox.Show("Do you really want to delete Category? ", "Sales And Inventory Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {


                add.DeleteCompanyinfo();

                MessageBox.Show("Your Desired Information is Successfully Deleted.", "Deleted Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcatname.Text = "";
                txtcatdes.Text = "";
                loadcatinfo();
                btnupdate.Enabled = false;
                btndelete.Enabled = false;
                button1.Enabled = true;
            }


            catch
            {
                MessageBox.Show("Can't Delete", "Eror Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            deletecinfo();
        }
        void get()
        
        {
            this.Hide();
            Frmusercompanydetails frm = new Frmusercompanydetails();
            frm.Show();
            frm.lbuname.Text = lbuname.Text;
            frm.cmutype.Text = "Category";
            frm.cmutype.Enabled = false;
        }

        private void btngetdata_Click(object sender, EventArgs e)
        {
            get();
        }

        private void txtcatname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frmcategory_Load(object sender, EventArgs e)
        {
            comboBox1.Hide();
            textBox1.Hide();
            loadcatinfo();
            ToolTip toolTip1 = new ToolTip();


            toolTip1.AutoPopDelay = 5000;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.button1, "Save(Ctrl+S) ");
            toolTip1.SetToolTip(this.btnupdate, "Update(Ctrl+U)");
            toolTip1.SetToolTip(this.btndelete, "Delete(Ctrl+D)");
            toolTip1.SetToolTip(this.btngetdata, "Get data (Ctrl+G)");
            toolTip1.SetToolTip(this.button2, "Exit (ESC)");
        }
      

        private void txtcatid_TextChanged(object sender, EventArgs e)
        {
           
            if (txtcatid.Text == "")
            {
                txtcatname.Text = "";
                txtcatdes.Text = "";
            }
        }

        private void txtcatid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)8)
            {
                e.Handled = false;

            }
          
            if (e.KeyChar == (char)13)
            {
                categoryinfo();
                txtcatname.Focus();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcatname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)8 || e.KeyChar==32)
            {
                e.Handled = false;

            }
            if(!char.IsLetter(e.KeyChar))
            {
                e.Handled = true ;
            }

             
            if (e.KeyChar == (char)13)
            {
              
                txtcatname.Focus();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Frmcategory_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyData == (Keys.Control | Keys.S))
            {
                save();
            }
            if (e.KeyData == (Keys.Control | Keys.U))
            {
                updatecinfo();
            }
            if (e.KeyData == (Keys.Control | Keys.G))
            {
                get();
            }
            if (e.KeyData == (Keys.Control | Keys.D))
            {
                deletecinfo();
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmcategory_FormClosing(object sender, FormClosingEventArgs e)
        {
           // this.Owner.Enabled = true;
        }

        private void txtcatname_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)8 || e.KeyChar == 32 || e.KeyChar == '-' )
            {
                e.Handled = false;
            }
          


           
            if (e.KeyChar == (char)13)
            {

                txtcatdes.Focus();
               
            }
        }

        private void txtcatid_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtcatdes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)8 || e.KeyChar == 32 || e.KeyChar == '.' || e.KeyChar == '-' || e.KeyChar == ',' || e.KeyChar == ':')
            {
                e.Handled = false;
            }
          


           
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
