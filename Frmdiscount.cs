using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sales_And_Inventory_Management.SRV;
namespace Sales_And_Inventory_Management_Project1
{
    public partial class Frmdiscount : Form
    {
        Discount add = new Discount();
    
        public Frmdiscount()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmdiscount_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            loadinfo();
             //this.Owner.Enabled = false;

            ToolTip toolTip1 = new ToolTip();


            toolTip1.AutoPopDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.btnsave, "Save (Ctrl+S) ");
            toolTip1.SetToolTip(this.btnupdate, "Update (Ctrl+U)");
            toolTip1.SetToolTip(this.btndelete, "Delete (Ctrl+D)");
            toolTip1.SetToolTip(this.button1, "Browse (Ctrl+B)");
            toolTip1.SetToolTip(this.btnexit, "Exit (ESC)");

        }


        public void RefreshObject()
        {
            add.Itemid = txtid.Text;
            add.Itemtype = txttype.Text;
            add.Itemamount = txtamount.Text;

        }
       public void set()
        {
            if (txtid.Text == "")
            {

                MessageBox.Show("Please enter item id!");
                txtid.Focus();
                return;
            }
            if (txtname.Text == "")
            {

                MessageBox.Show("Please enter item name!");
                txtname.Focus();
                return;
            }

            if (txttype.Text == "------SELECT------")
            {

                MessageBox.Show("Please enter Discount Type");
               txttype.Focus();
                return;
            }
            if (txtamount.Text == "")
            {

                MessageBox.Show("Please enter Discount Amount");
                txtamount.Focus();
                return;
            }

        }
       public void save()
        {
           
            RefreshObject();

            //set();

                checkinfo();

            
        }
        public void checkinfo()
        {
            DataTable dt = new DataTable();
            string itemid = Convert.ToString(txtid.Text);
            add.Itemid = txtid.Text;
            dt = add.Iteminfo(itemid);
            int j = dt.Rows.Count;

            if (j == 0)
            {

                add.Insert();

                MessageBox.Show("Information saved successfully.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadinfo();
                txtid.Focus();
                txtid.Text = "";
                txtname.Text = "";
                txttype.Text = "";
                txtamount.Text = "";


            }
            else
            {
                MessageBox.Show("Data already exist.", "UnSuccessful Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadinfo()
        {
            string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
            SqlConnection myconnection = new SqlConnection(str);
            string Query = "select id as [Item ID],type as [Discount Type], amount as [Amount] from [discount] order by id ";
            SqlDataAdapter myDA = new SqlDataAdapter(Query, str);
            DataSet myDataSet = new DataSet();
            myDA.Fill(myDataSet, "discount");

            dataGridView1.DataSource = myDataSet.Tables["discount"].DefaultView;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {

                MessageBox.Show("Please enter item id!");
                txtid.Focus();
                return;
            }
            if (txtname.Text == "")
            {

                MessageBox.Show("Please enter item name!");
                txtname.Focus();
                return;
            }

            if (txttype.Text == "------SELECT------")
            {

                MessageBox.Show("Please enter Discount Type");
                txttype.Focus();
                return;
            }
            if (txtamount.Text == "")
            {

                MessageBox.Show("Please enter Discount Amount");
                txtamount.Focus();
                return;
            }
            save();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmusercompanydetails add = new Frmusercompanydetails();
            add.Show();
            add.lbuname.Text = lbuname.Text;
            add.cmutype.Text = "Item";
            add.cmutype.Enabled = false;
            add.label1.Text = "Discount";
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }
        public void deleteiteminfo()
        {

         
            add.Itemid = txtid.Text;

            if (MessageBox.Show("Do you really want to delete Item!!!!" + "  < " + add.Itemid + ">  " + " ? ", "Confirm Delete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
              //  add.DeleteIteminfo();

                MessageBox.Show("Your Desired Information is Successfully Deleted.", "Deleted Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtname.Text = "";
                txtid.Text = "";
                txttype.Text = "";
                txtamount.Text = "";
             


                btnupdate.Enabled = false;
                btndelete.Enabled = false;
                btnsave.Enabled = false;
            }


            catch
            {
                MessageBox.Show("Can't Delete", "Eror Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void updatecinfo()
        {

            try
            {


                {
                    add.Itemid = txtid.Text;
                    add.Itemtype = txttype.Text;
                    add.Itemamount = txtamount.Text;

                    add.UpdateDiscountinfo();
                    MessageBox.Show("Information successfully updated", "Update Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                    loadinfo();
                    dataGridView1.ClearSelection();
                    txtid.Text = "";
                    txtname.Text = "";
                    txttype.Text = "";
                    txtamount.Text = "";


                    btnupdate.Enabled = false;
                    btndelete.Enabled = false;
                    btnsave.Enabled = false;


                   
              
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Can't updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Frmdiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.S))
            {
                save();
                loadinfo();
            }
            if (e.KeyData == (Keys.Control | Keys.U))
            {
                updatecinfo();
                loadinfo();
            }
            if (e.KeyData == (Keys.Control | Keys.E))
            {
                //updatecinfo();
                this.Close();
               // loadinfo();
            }
            if (e.KeyData == (Keys.Control | Keys.B))
            {
                this.Hide();
                Frmusercompanydetails add = new Frmusercompanydetails();
                add.Show();
                add.cmutype.Text = "Item";
                add.cmutype.Enabled = false;
                add.label1.Text = "Discount";
            }


            if (e.KeyData == (Keys.Control | Keys.D))
            {
                deleteiteminfo();
                loadinfo();
            }
        }
        public void idinfo()
        {
            DataTable dt = new DataTable();
            String itemid = Convert.ToString(txtid.Text);
            add.Itemid = txtid.Text;
            dt = add.idinfo(itemid);
            int j = dt.Rows.Count;
            if (j != 0)
            {
                for (int i = 0; i < j; i++)
                {

                    txtid.Text = dt.Rows[i]["itemid"].ToString();
                    txtname.Text = dt.Rows[i]["itemname"].ToString();


                }

            }
            else
            {
                MessageBox.Show("Information is not exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)8)
            {
                e.Handled = false;

            }

            if (e.KeyChar == (char)13)
            {
                idinfo();
                txtname.Focus();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {

                MessageBox.Show("Please enter item id!");
                txtid.Focus();
                return;
            }
            if (txtname.Text == "")
            {

                MessageBox.Show("Please enter item name!");
                txtname.Focus();
                return;
            }

            if (txttype.Text == "------SELECT------")
            {

                MessageBox.Show("Please enter Discount Type");
                txttype.Focus();
                return;
            }
            if (txtamount.Text == "")
            {

                MessageBox.Show("Please enter Discount Amount");
                txtamount.Focus();
                return;
            }
            deleteiteminfo();

          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lbuname.Text == "Admin")
            {
                try
                {
                    DataGridViewRow dr = dataGridView1.SelectedRows[0];
                    txtid.Text = dr.Cells[0].Value.ToString();

                    txttype.Text = dr.Cells[1].Value.ToString();
                    txtamount.Text = dr.Cells[2].Value.ToString();
                    idinfo();
                    btnsave.Enabled = false;
                    txttype.Enabled = true;
                    txtamount.Enabled = true;

                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    DataGridViewRow dr = dataGridView1.SelectedRows[0];
                    txtid.Text = dr.Cells[0].Value.ToString();

                    txttype.Text = dr.Cells[1].Value.ToString();
                    txtamount.Text = dr.Cells[2].Value.ToString();
                    idinfo();
                    btnsave.Enabled = false;
                    btndelete.Enabled = false;
                    txttype.Enabled = true;
                    txtamount.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
           
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {

                MessageBox.Show("Please enter item id!");
                txtid.Focus();
                return;
            }
            if (txtname.Text == "")
            {

                MessageBox.Show("Please enter item name!");
                txtname.Focus();
                return;
            }

            if (txttype.Text == "------SELECT------")
            {

                MessageBox.Show("Please enter Discount Type");
                txttype.Focus();
                return;
            }
            if (txtamount.Text == "")
            {

                MessageBox.Show("Please enter Discount Amount");
                txtamount.Focus();
                return;
            }
            updatecinfo();
           
        }

        private void txttype_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txttype_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            btnsave.Enabled = true;
            txtamount.Enabled = true;
            txtamount.Focus();
            if (txttype.Text == "Percentage")
            {
                label5.Text = "%";
            }
            else
            {
                label5.Text = "TK.";
            }
        }

        private void txtamount_TextChanged(object sender, EventArgs e)
        {
            Exception X = new Exception();

            TextBox T = (TextBox)sender;

            try
            {
                if (T.Text != "-")
                {
                    double x = double.Parse(T.Text);

                    if (T.Text.Contains(','))
                        throw X;
                }
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }

            }
            if (txtid.Text != "" && txttype.Text != "SELECT" && txtamount.Text != "")
            {
                btnsave.Enabled = true;
                btndelete.Enabled = true;
                btnupdate.Enabled = true;
            }

        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                txtamount.Focus();
               }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            string senderText = (sender as TextBox).Text;
            string senderName = (sender as TextBox).Name;
            string[] splitByDecimal = senderText.Split('.');
            int cursorPosition = (sender as TextBox).SelectionStart;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if (e.KeyChar == '.'
                && senderText.IndexOf('.') > -1)
            {
                e.Handled = true;
            }


            if (!char.IsControl(e.KeyChar)
                && senderText.IndexOf('.') < cursorPosition
                && splitByDecimal.Length > 1
                && splitByDecimal[1].Length == 3)
            {
                e.Handled = true;



            }
           
        }

        private void txtamount_Leave(object sender, EventArgs e)
        {
            string a = txtamount.Text;
            if (a != "")
            {
                double b = Convert.ToDouble(a);
                txtamount.Text = String.Format("{0:0.00}", b);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void searchinfo1()
        {
            string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
            SqlConnection myconnection = new SqlConnection(str);
            string Query = "select id as [Item ID],type as [Discount Type], amount as [Amount] from discount inner join item on discount.id=item.itemid where itemid like '" + textBox4.Text + "%'   or itemname like '" + textBox4.Text + "%'order by itemid,itemname ";
            SqlDataAdapter myDA = new SqlDataAdapter(Query, str);
            DataSet myDataSet = new DataSet();
            myDA.Fill(myDataSet, "item");

            dataGridView1.DataSource = myDataSet.Tables["item"].DefaultView;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            label12.Visible = true;
            label12.Text = "Search Item By ID/Name";
        }

        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            searchinfo1();
            dataGridView1.ClearSelection();
        }
    }
}
