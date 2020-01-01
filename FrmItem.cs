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
    public partial class FrmItem : Form
    {
        Item _add = new Item();
        Item add = new Item();
        Discount d = new Discount();
        Salesprice s = new Salesprice();
        public FrmItem()
        {
            InitializeComponent();
        }
        public void loadid()
        {
            DataTable dt = new DataTable();
            dt = add.Loadidinfo();
            int j = dt.Rows.Count;
            {
                if (j != 0)
                {
                    for (int i = 0; i < j; i++)
                    {

                        txtid.Text = dt.Rows[i]["itemid"].ToString();

                    }
                    string d = txtid.Text;
                    double a = Convert.ToDouble(d);
                    double b = a + 1;
                    txtitemid.Text = b.ToString();


                }
                else
                {
                    txtitemid.Text = "1";
                }
            }

        
            

        }
        private void btnnew_Click(object sender, EventArgs e)
        {
           
        }

        public void RefreshObject()
        {
            _add.Itemname = txtitemname.Text;
            _add.Itemid = txtitemid.Text;
            _add.Itemdes = txtitemdes.Text;
            _add.Itemucat = cmucat.Text;
            _add.Itemucom = cmucom.Text;
            _add.Itemunit = txtitemunit.Text;
            
        }
        public void loaditeminfo()
        {
            DataTable dt = new DataTable();
            
                dt = add.Loaditeminfo();
                int j = dt.Rows.Count;
                cmucat.Items.Clear();
                {
                    for (int i = 0; i < j; i++)
                    {

                        cmucat.Items.Add(dt.Rows[i]["cname"].ToString());


                    }
                
            }
            dt = add.LoadItemCominfo();
            int J = dt.Rows.Count;
            cmucom.Items.Clear();
            {
                for (int i = 0; i < j; i++)
                {

                    cmucom.Items.Add(dt.Rows[i]["cname"].ToString());


                }

            }

        }

        public void checkinfo()
        {
            DataTable dt = new DataTable();
            string uname = Convert.ToString(txtitemname.Text);
            _add.Itemname = txtitemname.Text;
            dt = _add.Iteminfo(uname);
            int j = dt.Rows.Count;

            if (j == 0)
            {

                _add.Insert();
                MessageBox.Show("Information saved successfully.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtitemname.Focus();
                _add.Itemid =txtitemid.Text;
                _add.Insertsitem();
                loadid();
                txtitemname.Text = "";
                txtitemunit.Text = "";
                txtitemdes.Text = "";

                cmucat.Text = "   ----Select----";
                cmucom.Text = "   ----Select----";
                
             


            }
            else
            {
                MessageBox.Show("Information not saved successfully.Data already exist.", "UnSuccessful Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtitemid.Text == "")
            {

                MessageBox.Show("Please enter  Item Id!");
                txtitemid.Focus();
                return;
            }
            if (txtitemname.Text == "")
            {

                MessageBox.Show("Please enter Item Name !");
                txtitemname.Focus();
                return;


            }
            if (cmucat.Text == "SELECT")
            {

                MessageBox.Show("Please select Category!");
                txtitemdes.Focus();
                return;


            }

            if (cmucom.Text == "SELECT")
            {

                MessageBox.Show("Please select Brand!");
                cmucom.Focus();
                return;


            }
           
            if (txtitemdes.Text == "")
            {

                MessageBox.Show("Please enter Item Description!");
                txtitemdes.Focus();
                return;


            }
            if (txtitemunit.Text == "")
            {

                MessageBox.Show("Please enter Item Unit!");
                txtitemunit.Focus();
                return;


            }
          
           

            RefreshObject();

            
          //  if (MessageBox.Show("Do you really want to Save Item Name?" + "  < " + add.Itemname + ">  " + " ? ", "Confirm Save Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
               // return;
            }

            try
            {
              
                checkinfo();

                

            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Can't Save.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnucat_Click(object sender, EventArgs e)
        {
            Frmusercompanydetails frm=new Frmusercompanydetails();
            frm.Show();
        }

        private void cmucat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void loaditemucatinfo()
        {
            DataTable dt = new DataTable();
            dt = _add.LoadItemcatinfo();
            int j = dt.Rows.Count;
            cmucat.Items.Clear();
            {
                for (int i = 0; i < j; i++)
                {

                    cmucat.Items.Add(dt.Rows[i]["cname"].ToString());


                }

            }

        }
        public void loaditemucominfo()
        {
            DataTable dt = new DataTable();
            dt = add.LoadItemcominfo();
            int j = dt.Rows.Count;
            cmucom.Items.Clear();
            {
                for (int i = 0; i < j; i++)
                {

                    cmucom.Items.Add(dt.Rows[i]["company_name"].ToString());


                }

            }

        }
        private void FrmItem_Load(object sender, EventArgs e)
        {
           // this.Owner.Enabled = false;
            loaditemucatinfo();
            loaditemucominfo();
            txtid.Hide();
            loadid();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.ShowAlways = true;

                   
            toolTip1.SetToolTip(this.btnsave, "Save(Ctrl+S) ");
            toolTip1.SetToolTip(this.btnupdate, "Update(Ctrl+U)");
            toolTip1.SetToolTip(this.btndelete, "Delete(Ctrl+D)");
            toolTip1.SetToolTip(this.btngetdata, "Get data (Ctrl+G)");
        }
        public void deleteiteminfo()
        {

            add.Itemid = txtitemid.Text;
            add.Itemname = txtitemname.Text;

            if (MessageBox.Show("Do you really want to delete Item?" + "  < " + add.Itemname + ">  " + " ? ", "Confirm Delete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {


                add.DeleteIteminfo();
               

               

                MessageBox.Show("Your Desired Information is Successfully Deleted.", "Deleted Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add.DeleteIteminfo1();
                add.DELETEPrice();
                add.DeleteItemQty();
                txtitemname.Text = "";
                cmucat.Text = "";
                cmucom.Text = "";
                txtitemdes.Text = "";
                txtitemunit.Text = "";
                btnupdate.Enabled = false;
                btndelete.Enabled = false;
                btnsave.Enabled = true;
                loadid();
                btnupdate.Enabled = false;
                btndelete.Enabled = false;
            }


            catch
            {
                MessageBox.Show("Can't Delete", "Eror Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtitemid.Text == "")
            {

                MessageBox.Show("Please enter  Item Id!");
                txtitemid.Focus();
                return;
            }
     
        
          
            deleteiteminfo();
        }

        private void btngetdata_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmusercompanydetails frm = new Frmusercompanydetails();
           // frm.Owner = this;
            frm.Show();
            frm.lbuname.Text = lbuname.Text;
            frm.cmutype.Text = "Item";
            frm.label1.Text = "Item";
            frm.cmutype.Enabled = false;
        }
        public void updatecinfo()
        {

            try
            {

                {
                    if (txtitemid.Text == "")
                    {

                        MessageBox.Show("Please enter  Item Id!");
                        txtitemid.Focus();
                        return;
                    }
                    if (txtitemname.Text == "")
                    {

                        MessageBox.Show("Please enter Item Name !");
                        txtitemname.Focus();
                        return;


                    }

                    if (cmucat.Text == "SELECT")
                    {

                        MessageBox.Show("Please select Category!");
                        txtitemdes.Focus();
                        return;


                    }

                    if (cmucom.Text == "SELECT")
                    {

                        MessageBox.Show("Please select Brand!");
                        cmucom.Focus();
                        return;


                    }
                    if (txtitemdes.Text == "")
                    {

                        MessageBox.Show("Please enter Item Description!");
                        txtitemdes.Focus();
                        return;


                    }
                    if (txtitemunit.Text == "")
                    {

                        MessageBox.Show("Please enter Item Unit!");
                        txtitemunit.Focus();
                        return;


                    }
          
                   
                   

                    _add.Itemid = txtitemid.Text;
                    _add.Itemname = txtitemname.Text;
                    _add.Itemdes = txtitemdes.Text;
                    _add.Itemucom = cmucom.Text;
                    _add.Itemucat = cmucat.Text;
                   
                    _add.Itemunit = txtitemunit.Text;
                    _add.Updateiteminfo();
                    MessageBox.Show(" Successfully Updated", "Update Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtitemname.Text = "";
                    cmucat.Text = "";
                    cmucom.Text = "";
                    txtitemdes.Text = "";
                    txtitemunit.Text = "";
                    btnupdate.Enabled = false;
                    btndelete.Enabled = false;
                    btnsave.Enabled = true;
                    loadid();
                    btnupdate.Enabled = false;
                    btndelete.Enabled = false;
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

        private void txtuprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtitemid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtitemid_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)8)
            {
                e.Handled = false;

            }
            if (e.KeyChar == (char)13)
            {

                txtitemname.Focus();

            }
        }

        private void txtitemname_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if(!char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled=true;
            }
            if (e.KeyChar == (char)8 || e.KeyChar == '.' || e.KeyChar == (char)32 || e.KeyChar=='-' )
            {
                e.Handled = false;

            } 

            if (e.KeyChar == (char)13)
            {

                txtitemdes.Focus();
            }
        }

        private void txtitemdes_KeyPress(object sender, KeyPressEventArgs e)
        {

          
            if (!char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)8 || e.KeyChar == '.' || e.KeyChar == (char)32 || e.KeyChar == '-' || e.KeyChar == ',' || e.KeyChar == ':')
            {
                e.Handled = false;

            } 

           
            if (e.KeyChar == (char)13)
            {

                txtitemunit.Focus();

            }
        }

        private void txtitemunit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)8)
            {
                e.Handled = false;

            }
        }

        private void cmucat_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void txtitemname_CursorChanged(object sender, EventArgs e)
        {

        }

        private void txtitemname_Click(object sender, EventArgs e)
        {
       
        }

        private void cmucat_Click(object sender, EventArgs e)
        {
           
        }

        private void cmucom_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.S))
            {
                if (txtitemid.Text == "")
                {

                    MessageBox.Show("Please enter  Item Id!");
                    txtitemid.Focus();
                    return;
                }
                if (txtitemname.Text == "")
                {

                    MessageBox.Show("Please enter Item Name !");
                    txtitemname.Focus();
                    return;


                }
                if (cmucat.Text == "SELECT")
                {

                    MessageBox.Show("Please select Category!");
                    txtitemdes.Focus();
                    return;


                }

                if (cmucom.Text == "SELECT")
                {

                    MessageBox.Show("Please select Brand!");
                    cmucom.Focus();
                    return;


                }

                if (txtitemdes.Text == "")
                {

                    MessageBox.Show("Please enter Item Description!");
                    txtitemdes.Focus();
                    return;


                }
                if (txtitemunit.Text == "")
                {

                    MessageBox.Show("Please enter Item Unit!");
                    txtitemunit.Focus();
                    return;


                }



                RefreshObject();


                //  if (MessageBox.Show("Do you really want to Save Item Name?" + "  < " + add.Itemname + ">  " + " ? ", "Confirm Save Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    // return;
                }

                try
                {

                    checkinfo();



                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Can't Save.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (e.KeyData == (Keys.Control | Keys.U))
            {
                updatecinfo();
            }
            if (e.KeyData == (Keys.Control | Keys.G))
            {
                this.Hide();
                Frmusercompanydetails frm = new Frmusercompanydetails();
                // frm.Owner = this;
                frm.Show();
                frm.lbuname.Text = lbuname.Text;
                frm.cmutype.Text = "Item";
                frm.label1.Text = "Item";
                frm.cmutype.Enabled = false;
            }
            if (e.KeyData == (Keys.Control | Keys.D))
            {
                if (txtitemid.Text == "")
                {

                    MessageBox.Show("Please enter  Item Id!");
                    txtitemid.Focus();
                    return;
                }



                deleteiteminfo();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmucat_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                e.Handled = true;
            
        }

        private void cmucom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FrmItem_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
