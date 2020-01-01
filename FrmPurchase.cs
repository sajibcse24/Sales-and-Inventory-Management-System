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
    public partial class FrmPurchase : Form
    {
        string inv;
        int flag;
        Purchase add = new Purchase();
        public FrmPurchase()
        {
            InitializeComponent();
        }
        private void savebutton()
        {
            if (txtInvoice.Text == "")
            {

                MessageBox.Show("Please enter invoice no !");
                txtInvoice.Focus();
                return;
            }
            if (txtID.Text == "")
            {
                MessageBox.Show("Please enter Item No !");
                txtID.Focus();
                return;
            }
          
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Please enter Item Quntity!");
                txtQuantity.Focus();
                return;
            }
           
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Please enter Unit Price!");
                txtPrice.Focus();
                return;
            }
            RefreshObject();
           
                check();
            

          

        }
        private void RefreshObject()
        {
            add.Time = dateTimePicker2.Text;
            add.Itemname = txtItem.Text;
            add.Itemid = txtID.Text;
            add.Date =dateTimePicker1.Text;
            add.Invoice = txtInvoice.Text;
            add.Itemucat = txtCategory.Text;
            add.Itemunit = txtQuantity.Text;
            add.Unitprice = txtPrice.Text ;
        }
        private void Refreshobject()
        {
            add.Time = dateTimePicker2.Text;
            add.Itemname = "";
            add.Itemid = "";
            add.Date = dateTimePicker1.Text;
            add.Invoice = txtInvoice.Text;
            add.Itemucat = "";
            add.Itemunit = "";
            add.Unitprice = "";
        }

        private void loadinfo()
        {
            string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
            SqlConnection myconnection = new SqlConnection(str);
            string Query = "select itemid as [Item ID],itemname as [Item Name] from item order by itemid ";
            SqlDataAdapter myDA = new SqlDataAdapter(Query, str);
            DataSet myDataSet = new DataSet();
            myDA.Fill(myDataSet, "item");

            dataGridView2.DataSource = myDataSet.Tables["item"].DefaultView;
        }


        private void FrmPurchase_Load(object sender, EventArgs e)
        {
            dataGridView2.ClearSelection();
            loadinfo();
            dateTimePicker1.Value = DateTime.Now;
            textBox1.Hide();
            loadinvoice();
          //  txtInvoice.Enabled = true;
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;

            //  toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.button1, "Up (Ctrl + N)");
            toolTip1.SetToolTip(this.button2, "Down ");
            toolTip1.SetToolTip(this.button3, "Top");
            toolTip1.SetToolTip(this.button4, "Bottom");
            toolTip1.SetToolTip(this.btnCart, "Add to cart (Ctrl+C)");
            toolTip1.SetToolTip(this.button5, "Submit (Ctrl + P)");
            toolTip1.SetToolTip(this.button6, "Exit(Ctrl+E)");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)

        {
            if (dataGridView1.CurrentRow == null) return;
            int i = dataGridView1.Rows.Count;
            if (i != 0)
            {

                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows[i - 2].Index].Cells[0];
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = true;
                textBox9.Text = (i - 1).ToString();
            }
           
        }
        public void searchbyitemid()
        {
            string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
            SqlConnection myconnection = new SqlConnection(str);
            string Query = "select itemid as [Item ID],itemname as[Item name],itemucat as [Category],itemunit as [Quntity], uprice as [Purchase price] from [stock] where itemid like '" + textBox9.Text + "%' and invoice='"+txtInvoice.Text+"' ";
            SqlDataAdapter myDA = new SqlDataAdapter(Query, str);
            DataSet myDataSet = new DataSet();
            myDA.Fill(myDataSet, "stock");

            dataGridView1.DataSource = myDataSet.Tables["stock"].DefaultView;

        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            //searchbyitemid();
        }
        private void check()
        {
            DataTable dt = new DataTable();
            string uname = Convert.ToString(txtInvoice.Text);
            string id = Convert.ToString(txtID.Text);
            string date = Convert.ToString(dateTimePicker1.Text);
            string time = Convert.ToString(dateTimePicker2.Text);
            add.Invoice = uname;
            add.Itemid = id;
            add.Date = date;
            add.Time = time;
           dt = add.Checkinfo(uname, id, date, time);
            int j = dt.Rows.Count;

            if (j == 0)
            {
                try{
                    add.Insert();
                    add.Updateiteminfoqty();
                    searchinfo();
                    if (dataGridView1.Rows.Count > 0)
                    {

                        int i = dataGridView1.Rows.Count;

                        i--;
                        txtNumber.Text = i.ToString();
                        dataGridView1.Rows[0].Selected = true;
                        int rowindex = dataGridView1.CurrentRow.Index;
                        int a = rowindex + 1;
                        textBox9.Text = a.ToString();

                        newrow();
                    }


                         
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Can't Stock.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
           
            }
            else
            {
                MessageBox.Show("Item already exist.", "UnSuccessful Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            }
        }
        public void newrow()
        {
            txtID.Text = "";
            txtItem.Text = "";
            txtCategory.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtID.Focus();
        }

        private void btnAddcart()
        {
            dataGridView2.ClearSelection();
            if (txtInvoice.Text == "")
            {

                MessageBox.Show("Please enter invoice no !");
                txtInvoice.Focus();
                return;
            }
            if (txtID.Text == "")
            {
                MessageBox.Show("Please enter Item No !");
                txtID.Focus();
                return;
            }

            if (txtItem.Text == "")
            {
                MessageBox.Show("Please enter Item Name !");
                txtItem.Focus();
                return;
            }

            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Please enter Item Quntity!");
                txtQuantity.Focus();
                return;
            }

            if (txtPrice.Text == "")
            {
                MessageBox.Show("Please enter Unit Price!");
                txtPrice.Focus();
                return;
            }

            try
            {
                if (listView1.Items.Count == 0)
                {

                    ListViewItem lst = new ListViewItem(txtID.Text);

                    lst.SubItems.Add(txtItem.Text);
                    lst.SubItems.Add(txtCategory.Text);
                    lst.SubItems.Add(txtQuantity.Text);
                    lst.SubItems.Add(txtPrice.Text);

                    listView1.Items.Add(lst);

                    newrow();

                    return;
                }

                for (int j = 0; j < listView1.Items.Count; j++)
                {
                    if (listView1.Items[j].SubItems[0].Text == txtID.Text)
                    {
                        listView1.Items[j].SubItems[0].Text = txtID.Text;
                        listView1.Items[j].SubItems[1].Text = txtItem.Text;
                        listView1.Items[j].SubItems[2].Text = txtCategory.Text;
                        listView1.Items[j].SubItems[3].Text = txtQuantity.Text;
                        listView1.Items[j].SubItems[4].Text = txtPrice.Text;
                        newrow();

                        return;

                    }
                }





                ListViewItem lst1 = new ListViewItem(txtID.Text);

                lst1.SubItems.Add(txtItem.Text);
                lst1.SubItems.Add(txtCategory.Text);
                lst1.SubItems.Add(txtQuantity.Text);
                lst1.SubItems.Add(txtPrice.Text);

                listView1.Items.Add(lst1);

                newrow();

                return;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        private void button6_Click(object sender, EventArgs e)
        {
           // if (flag == 1)
            {
               // updatecinfo();
            }
           // else
            {
               // savebutton();
            }

            btnAddcart();
            
            
        }
        public void searchinfo()
        {
            string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
            SqlConnection myconnection = new SqlConnection(str);
            string Query = "select itemid as [Item ID],itemname as[Item Name],itemucat as[Category],itemunit as[Quantity],uprice as[Purchase Price (TK.)] from [stock] where invoice='" + txtInvoice.Text + "'order by itemid ";
            SqlDataAdapter myDA = new SqlDataAdapter(Query, str);
            DataSet myDataSet = new DataSet();
            myDA.Fill(myDataSet, "stock");
            dataGridView1.DataSource = myDataSet.Tables["stock"].DefaultView;
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Frmusercompanydetails add = new Frmusercompanydetails();
            add.Show();
            add.cmutype.Text = "Item";
            add.cmutype.Enabled = false;
            add.label1.Text = "Stock";
            add.label3.Text =txtInvoice.Text;*/
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int i = dataGridView1.Rows.Count - 2;
            if (dataGridView1.CurrentRow.Index + 1 <= i)
            {

                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentRow.Index + 1].Cells[0];
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            if (dataGridView1.CurrentRow.Index - 1 >= 0)
            {

                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Cells[0];
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = true;
               
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                dataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int i = dataGridView1.Rows.Count;
            if (i != 0)
            {

                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows[0].Index].Cells[0];
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = true;
                int j = dataGridView1.Rows.Count;
                dataGridView1.Rows[0].Selected = true;
                j--;
                int rowindex = dataGridView1.CurrentRow.Index;
                int a = rowindex + 1;
                textBox9.Text = a.ToString();
            }
           
        }
      
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*int rowindex = dataGridView1.CurrentRow.Index;
            int a = rowindex + 1;
            textBox9.Text = a.ToString();
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                txtID.Text = dr.Cells[0].Value.ToString();
                txtItem.Text = dr.Cells[1].Value.ToString();
                txtCategory.Text = dr.Cells[2].Value.ToString();
                txtQuantity.Text = dr.Cells[3].Value.ToString();
                txtPrice.Text = dr.Cells[4].Value.ToString();
                txtQuantity.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        public void updatecinfo()
        {
            try
            {

                {
                    if (txtID.Text == "")
                    {

                        MessageBox.Show("Please enter  Item Id!");
                        txtID.Focus();
                        return;
                    }
                    if (txtItem.Text == "")
                    {
                        MessageBox.Show("Please enter Item Name !");
                        txtItem.Focus();
                        return;
                    }
                    if (txtCategory.Text == "")
                    {
                        MessageBox.Show("Please enter Item Category!");
                        txtCategory.Focus();
                        return;
                    }
                    if (txtPrice.Text == "")
                    {
                        MessageBox.Show("Please enter Item Price!");
                        txtPrice.Focus();
                        return;
                    }
                    if (txtQuantity.Text == "")
                    {
                        MessageBox.Show("Please enter Item Under Category!");
                        txtQuantity.Focus();
                        return;
                    }
                    if (txtInvoice.Text == "")
                    {

                        MessageBox.Show("Please enter Invoice no!");
                        txtInvoice.Focus();
                        return;
                    }
                    RefreshObject();
                    add.Unitprice = txtPrice.Text;
                    add.Updateiteminfo();
                    flag = 0;
                    MessageBox.Show(" Successfully Updated", "Update Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchinfo();
                    int i = dataGridView1.Rows.Count;
                    if (this.dataGridView1.SelectedRows.Count > 0)
                    {
                        i--;
                        txtNumber.Text = i.ToString();
                        dataGridView1.Rows[0].Selected = true;
                        int rowindex = dataGridView1.CurrentRow.Index;
                        int a = rowindex + 1;
                        textBox9.Text = a.ToString();

                         newrow();
                       
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Can't updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void btnUpdate_Click(object sender, EventArgs e)
        {
           //updatecinfo();
          // searchinfo();
        }
        private void loadinvoice()
        {
            DataTable dt = new DataTable();
            dt = add.Loadinvoiceinfo();
            int j = dt.Rows.Count;
            {
                if (j != 0)
                {
                    for (int i = 0; i < j; i++)
                    {

                        inv = dt.Rows[i]["invoice"].ToString();


                    }

                    double a = Convert.ToDouble(inv);
                    double b = a + 1;
                    txtInvoice.Text = b.ToString();
                }
                else {
                    txtInvoice.Text = "1";
                }
            }
        }
        public void submit()
        {
            loadinvoice();
            txtID.Text = "";
            txtItem.Text = "";
            txtCategory.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            textBox9.Text = "";
            txtNumber.Text = "";
            txtInvoice.Focus();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }

        private void save()
        {

            try
            {
                if(textBox3.Text=="")
                {
                    textBox3.Text = "0";
                }

                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    
                    add.Invoice =txtInvoice.Text;
                    add.Date = dateTimePicker1.Text;
                    add.Time = dateTimePicker2.Text;
                    add.Itemid = listView1.Items[i].SubItems[0].Text;
                    add.Itemname = listView1.Items[i].SubItems[1].Text;
                    add.Itemucat = listView1.Items[i].SubItems[2].Text;
                    double a=Convert.ToDouble(listView1.Items[i].SubItems[3].Text) + Convert.ToDouble(textBox3.Text);
                    add.Itemunit = a.ToString();
                    add.Unitprice = listView1.Items[i].SubItems[4].Text;
                    add.Insert();
                  
                    add.Updateiteminfoqty();
                }
                MessageBox.Show("Successfully purchased", "Sale And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listView1.Items.Clear();
                loadinvoice();





            }
            catch (Exception)
            {

                MessageBox.Show(" Can't save.", "Sale And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("sorry no product added", "Sales And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            save();
           // submit();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) { e.Handled = true; }
            if (e.KeyChar == (char)8)
            {
                e.Handled = false;

            }
            if (e.KeyChar == (char)13)
            {
               
                txtPrice.Focus();

            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                idinfo();
            }
        }
        public void idinfo()
        {
            DataTable dt = new DataTable();
            
            string id = Convert.ToString(txtID.Text);
            add.Itemid = txtID.Text;
          //  dt = add.idinfoqty(txtID.Text);
          //  int k = dt.Rows.Count;
           // if (k == 0)
            {
                dt = add.idinfo(id);
                int j = dt.Rows.Count;
                if (j != 0)
                {
                    for (int i = 0; i < j; i++)
                    {

                        txtID.Text = dt.Rows[i]["itemid"].ToString();
                        txtItem.Text = dt.Rows[i]["itemname"].ToString();
                        txtCategory.Text = dt.Rows[i]["itemucat"].ToString();
                        textBox3.Text = dt.Rows[i]["qty"].ToString();


                    }
                    label12.Visible = false;

                }
                else
                {
                    label12.Visible = true;
                    label12.Text = "Information does not exist.";
                    txtID.Text = "";
                    // MessageBox.Show("Information is not exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
           
            }
        }
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled=true;
            }
            if (e.KeyChar == (char)8)
            {
                e.Handled = false;

            }
            
            if (e.KeyChar == (char)13)
            {
                idinfo();
                txtQuantity.Focus();
            }
        }

        private void txtInvoice_TextChanged(object sender, EventArgs e)
        {
            searchinfo();
        }

        private void btnID_MouseHover(object sender, EventArgs e)
        {
           // toolTip1.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView1.CurrentRow.Index;
            int a = rowindex + 1;
            textBox9.Text = a.ToString();
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                flag =1;
                txtID.Text = dr.Cells[0].Value.ToString();
                textBox1.Text = dr.Cells[0].Value.ToString();
                txtItem.Text = dr.Cells[1].Value.ToString();
                txtCategory.Text = dr.Cells[2].Value.ToString();
                txtQuantity.Text = dr.Cells[3].Value.ToString();
                txtPrice.Text = dr.Cells[4].Value.ToString();
                txtQuantity.Focus();
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.RemoveAt(item.Index);
                        

                            int i = dataGridView1.Rows.Count;

                            i--;
                            txtNumber.Text = i.ToString();
                            dataGridView1.Rows[0].Selected = true;
                           // int rowindex = dataGridView1.CurrentRow.Index;
                           // int a = rowindex + 1;
                            textBox9.Text = a.ToString();

                           // newrow();
                        
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
           
        }

        private void FrmPurchase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.N))
            {
                if (dataGridView1.CurrentRow == null) return;
                if (dataGridView1.CurrentRow.Index - 1 >= 0)
                {

                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Cells[0];
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = true;
                }




            }
            if (e.KeyData == (Keys.Down))
            {
                if (dataGridView1.CurrentRow == null) return;
                int i = dataGridView1.Rows.Count - 2;
                if (dataGridView1.CurrentRow.Index + 1 <= i)
                {

                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentRow.Index + 1].Cells[0];
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = true;
                }
            }

            if (e.KeyData == (Keys.Control | Keys.C))
            {
                btnAddcart();
            }
            if (e.KeyData == (Keys.Control | Keys.P))
            {
                if (listView1.Items.Count == 0)
                {
                    MessageBox.Show("sorry no product added", "Sales And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                save();
            }
            if (e.KeyData == (Keys.Control | Keys.E))
            {
                this.Close();
            }

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
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
          
        
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            string a = txtPrice.Text;
           if(a!="")
            {
            double b = Convert.ToDouble(a);
            txtPrice.Text = String.Format("{0:0.00}", b);
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCart_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtInvoice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)8)
            {
                e.Handled = false;

            }
            if (e.KeyChar == (char)13)
            {

                txtID.Focus();

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtQuantity.Text = "";
                txtPrice.Text = "";
                DataGridViewRow dr = dataGridView2.SelectedRows[0];
                txtID.Text = dr.Cells[0].Value.ToString();
                dataGridView2.ClearSelection();
                txtQuantity.Focus();
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchinfo1()
        {
            string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
            SqlConnection myconnection = new SqlConnection(str);
            string Query = "select itemid as [Item ID],itemname as [Item Name] from item where itemid like '" + textBox4.Text + "%'   or itemname like '" + textBox4.Text + "%'order by itemid,itemname ";
            SqlDataAdapter myDA = new SqlDataAdapter(Query, str);
            DataSet myDataSet = new DataSet();
            myDA.Fill(myDataSet, "item");

            dataGridView2.DataSource = myDataSet.Tables["item"].DefaultView;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            searchinfo1();
            dataGridView2.ClearSelection();
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            //textBox4.Text = "                    Search";
            label13.Visible = true;
            label13.Text = "Search Item By ID/Name";

        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
          //  idinfo();
        }

        private void txtidd_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
