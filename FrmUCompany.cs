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
    public partial class FrmUCompany : Form
    {
        UserCompany _add = new UserCompany();
        UserCompany add = new UserCompany();
        public FrmUCompany()
        {
            InitializeComponent();
        }



        public void RefreshObject()
        {
            _add.Companyname = txtUcomname.Text;
            _add.Companyid = txtUcomid.Text;

        }

        public void  checkinfo()
        {
            try
            {
                DataTable dt = new DataTable();

                dt = add.Companyinfo(txtUcomid.Text, txtUcomname.Text);
                int j = dt.Rows.Count;

                if (j == 0)
                {

                    _add.Insert();
                    MessageBox.Show("Information saved successfully.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUcomname.Focus();
                    loadid();
                    btnnew();
                }
                else
                {
                    MessageBox.Show("Information already exist.", "Unsuccessful Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Information already exist.", "Unsuccessful Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void save() 
        {

            if (txtUcomid.Text == "")
            {

                MessageBox.Show("Please enter Brand ID !");
                txtUcomid.Focus();
                return;


            }


            if (txtUcomname.Text == "")
            {

                MessageBox.Show("Please enter  Brand Name!");
                txtUcomname.Focus();
                return;
            }
          
            RefreshObject();


            //if (MessageBox.Show("Do you really want to Save Company Name?" + "  < " + _add.Companyname + ">  " + " ? ", "Confirm Save Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
              //  return;
            }

            
                // _add.Insert();
                checkinfo();

                //MessageBox.Show("Information saved successfully.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  txtUcomname.Focus();

          
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            save();
            
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    

       

        public void updatecinfo()
        {

            try
            {

                {
                    add.Companyid =txtUcomid.Text;
                    add.Companyname =txtUcomname.Text;
                   
                    add.UpdateCompanyinfo();
                    MessageBox.Show("Information successfully updated", "Update Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Can't updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtUcomid.Text == "")
            {

                MessageBox.Show("Please enter Brand ID !");
                txtUcomid.Focus();
                return;


            }


            if (txtUcomname.Text == "")
            {

                MessageBox.Show("Please enter  Brand Name!");
                txtUcomname.Focus();
                return;
            }
          
            txtUcomname.Text = "";
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
            btnsave.Enabled = true; 
            

            loadid();
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
        }


        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        void btnnew()
    {
        txtUcomname.Focus();
        txtUcomname.Text = "";
        
    }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //btnnew();
        }

        public void deletecinfo()
        {
            if (txtUcomid.Text == "")
            {

                MessageBox.Show("Please enter Brand ID !");
                txtUcomid.Focus();
                return;


            }

          

            add.Companyname = txtUcomname.Text;

            if (MessageBox.Show("Do you really want to delete Brand Name" + "  < " + add.Companyname + ">  " + " ? ", "Confirm Delete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {


                add.DeleteCompanyinfo();
               
                MessageBox.Show("Your Desired Information is Successfully Deleted.", "Deleted Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUcomname.Text = "";
                txtUcomid.Text = "";
           
            }


            catch
            {
                MessageBox.Show("Can't Delete", "Eror Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            deletecinfo();
            loadid();
            
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
            btnsave.Enabled = true;
        }

        void get()
        {
            this.Hide();
            Frmusercompanydetails frm = new Frmusercompanydetails();
        
            frm.Show();
            frm.cmutype.Text = "Brand";
            frm.lbuname.Text = lbuname.Text;
            frm.cmutype.Enabled = false;
           // btndelete.Enabled = true;
           // btnupdate.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            get();
            
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
              if (txtUcomname.Text == "")
            {

                MessageBox.Show("Please enter  Company Name!");
                txtUcomname.Focus();
                return;
            }
            if (txtUcomid.Text == "")
            {

                MessageBox.Show("Please enter Company ID !");
                txtUcomid.Focus();
                return;


            }


            RefreshObject();

            if (MessageBox.Show("Do you really want to Save Company Name?" + "  < " + _add.Companyname + ">  " + " ? ", "Confirm Save Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {


                _add.Insert();


                MessageBox.Show("Information saved successfully.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUcomname.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Can't Save.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        

            }
        }

        private void Frmusercompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (txtUcomname.Text == "")
                {

                    MessageBox.Show("Please enter  Company Name!");
                    txtUcomname.Focus();
                    return;
                }
                if (txtUcomid.Text == "")
                {

                    MessageBox.Show("Please enter Company ID !");
                    txtUcomid.Focus();
                    return;


                }






                RefreshObject();
                if (MessageBox.Show("Do you really want to Save Company Name?" + "  < " + _add.Companyname + ">  " + " ? ", "Confirm Save Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                try
                {


                    _add.Insert();


                    MessageBox.Show("Information saved successfully.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUcomname.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Can't Save.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btnsave_MouseHover(object sender, EventArgs e)
        {
            
           
        }
        public void loadid()
        
        {
            DataTable dt = new DataTable();
            dt = add.Loadid();
            int j = dt.Rows.Count;
            // comboBox1.Items.Clear();
            {
                if (j != 0)
                {
                    for (int i = 0; i < j; i++)
                    {

                        txtUcomid.Text = dt.Rows[i]["company_Id"].ToString();

                    }
                    string d = txtUcomid.Text;
                    double a = Convert.ToDouble(d);
                    double b = a + 1;
                    txtUcomid.Text = b.ToString();


                }
                else
                {
                    txtUcomid.Text = "1";
                }
            

        }
        
        
        
        
        }
        private void Frmusercompany_Load(object sender, EventArgs e)
        {
            //btnupdate.Enabled = false;
            //btndelete.Enabled = false;
            //this.Owner.Enabled = false;
            loadid();
           // this.Owner.Enabled = false;
            

            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;

            //  toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.button1, "New (Ctrl + N)");
            toolTip1.SetToolTip(this.btnsave, "Save(Ctrl+S) ");
            toolTip1.SetToolTip(this.btnupdate, "Update(Ctrl+U)");
            toolTip1.SetToolTip(this.btndelete, "Delete(Ctrl+D)");
            toolTip1.SetToolTip(this.button2, "Get data (Ctrl+G)");
        }
        

        private void btndelete_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmUCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.N))
            {
                btnnew();


            }
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

        private void FrmUCompany_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FrmUCompany_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Owner.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtUcomname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)8 || e.KeyChar == 32 || e.KeyChar == '-' || e.KeyChar=='.')
            {
                e.Handled = false;
            }
          
        }
    }
}
