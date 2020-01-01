using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sales_And_Inventory_Management_Project1.Report;
using Sales_And_Inventory_Management.SRV;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace Sales_And_Inventory_Management_Project1
{
    public partial class FrmSales : Form
    {


        Purchase add1 = new Purchase();
        Sales add = new Sales();
        DataTable dt = new DataTable();
        public FrmSales()
        {
            InitializeComponent();
        }
        private void refreshobject()
        {
          
            add.Date = billingdate.Text;
            add.Time = time.Text;
         

           // add.Due = txtdue.Text;
            add.Payment =txtdue.Text;
           // add.Totalamount = txtamount.Text;
            add.Mno = lblday.Text;
            add.Month = m.Text;
            add.Year = y.Text;
        }
        private void mycount()
        {
            string a = billingdate.Text;
            DateTime dt = Convert.ToDateTime(a);
            int day = dt.Day;
            int month = dt.Month;
            DateTime d = new DateTime(1, month, 1);
            m.Text = d.ToString("MMMM");
            lblday.Text = month.ToString();
            int year = dt.Year;
          
            y.Text = year.ToString();
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
        private void FrmSales_Load(object sender, EventArgs e)
        {
           // this.Owner.Enabled = false;
            dataGridView2.ClearSelection();
            loadinfo();
            billingdate.Text = System.DateTime.Now.ToString();
            mycount();
            invoiceinfo();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.ShowAlways = true;


            toolTip1.SetToolTip(this.btnsave, "Save(Ctrl+S) ");
            toolTip1.SetToolTip(this.btnadd, "Add(Ctrl+A)");
            toolTip1.SetToolTip(this.btnprint, "Print(Ctrl+P)");
            toolTip1.SetToolTip(this.btnremove, "Close (Ctrl+C)");
           // searchinfo();
            //txtInvoiceNo.Enabled = true;
        }

        private void txtInvoiceNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        public void resettxt()
        {
            txtname.Text = "";
            txtid.Text = "";
            txtprice.Text = "";
            txtquantity.Text = "";
            txtstotal.Text = "";
            txtvat.Text = "";
            txtdiscount.Text = "";
            
            txtid.Focus();
        }
        private void check()
        {
           /* try
            {
                DataTable dt = new DataTable();

                string k = Convert.ToString(txtinvoice.Text);
                string id = Convert.ToString(txtid.Text);

                add.Invoice = k;
                add.Itemid = id;

                dt = add.Checkinfo(k, id);
                int j = dt.Rows.Count;


                if (j == 0)
                {
                    add.Insert();
                    searchinfo();
                    resettxt();
                    double sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                        txtamount.Text = sum.ToString();
                    }




                }





                else
                {
                    MessageBox.Show("Item already exist.", "UnSuccessful Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    searchinfo();
                    double sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                        txtstotal.Text = sum.ToString();
                    }

                }
            }
            catch (Exception )
            {
                MessageBox.Show("Can't add into the card.", "UnSuccessful Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
       

        private void addtocart()
        {
            
           

           
            refreshobject();

            check();
        }

        private void searchinfo()
        {
           /* try
            {
                
                DataSet ds = add.searchinfo(txtinvoice.Text);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    DataView dw = new DataView(ds.Tables[0]);
                    dataGridView1.DataSource = dw;

                }
                else
                {
                    // MessageBox.Show("No book found ", "Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            catch (Exception)
            {
                throw;
                // MessageBox.Show("No book found ", "Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/

        }

        public double subtot()
        {

            int i = 0;
            int j = 0;
            double k = 0;
           

            try
            {
                j = listView1.Items.Count;
                if (j != 0)
                {
                    for (i = 0; i <= j - 1; i++)
                    {
                        k = k + Convert.ToDouble(listView1.Items[i].SubItems[3].Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return k;

        }

        private void btnAddcart()
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Please enter Item No !");
                txtid.Focus();
                return;
            }

            if (txtquantity.Text == "")
            {
                MessageBox.Show("Please enter Item Quntity!");
                txtquantity.Focus();
                return;
            }



            try
            {
                if (listView1.Items.Count == 0)
                {

                    ListViewItem lst = new ListViewItem(txtid.Text);

                    lst.SubItems.Add(txtname.Text);
                    lst.SubItems.Add(txtquantity.Text);
                    lst.SubItems.Add(txtstotal.Text);

                    listView1.Items.Add(lst);
                    txtamount.Text = subtot().ToString();
                    resettxt();
                    // textBox3.Text = "";
                    return;
                }

                for (int j = 0; j < listView1.Items.Count; j++)
                {
                    if (listView1.Items[j].SubItems[0].Text == txtid.Text)
                    {
                        listView1.Items[j].SubItems[0].Text = txtid.Text;
                        listView1.Items[j].SubItems[1].Text = txtname.Text;
                        listView1.Items[j].SubItems[2].Text = txtquantity.Text;
                        listView1.Items[j].SubItems[3].Text = txtstotal.Text;

                        txtamount.Text = subtot().ToString();
                        resettxt();
                        //  textBox3.Text = "";
                        return;

                    }
                }

                ListViewItem lst1 = new ListViewItem(txtid.Text);



                lst1.SubItems.Add(txtname.Text);
                lst1.SubItems.Add(txtquantity.Text);
                lst1.SubItems.Add(txtstotal.Text);

                listView1.Items.Add(lst1);
                txtamount.Text = subtot().ToString();
                resettxt();
                //  textBox3.Text = "";
                return;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }


        private void Button7_Click(object sender, EventArgs e)
        {
            btnAddcart();
        }
        public void idinfo()
        {
            DataTable dt = new DataTable();
    
            try
            {
                dt = add.idinfo(txtid.Text);
                int j = dt.Rows.Count;
                if (j != 0)
                {
                    for (int i = 0; i < j; i++)
                    {

                        txtname.Text = dt.Rows[i]["itemname"].ToString();
                        txtunit.Text = dt.Rows[i]["itemunit"].ToString();
                        txtnet.Text = dt.Rows[i]["vat"].ToString();
                        txtprice.Text = dt.Rows[i]["price"].ToString();
                        txttype.Text = dt.Rows[i]["type"].ToString();
                        txtd.Text = dt.Rows[i]["amount"].ToString();
                        textBox3.Text = dt.Rows[i]["qty"].ToString();

                    }
                    dataGridView2.ClearSelection();
                    txtquantity.Focus();
                    label33.Visible = false;
                }
                else
                {
                   // MessageBox.Show("Information is not exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label33.Visible = true;
                    label33.Text = "Information does not exist.";
                    txtid.Text = "";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Information is not exist", "Sales And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtid.Text = "";
            }
        }

        public void id()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = add.id(txtid.Text);
                int j = dt.Rows.Count;
                if (j != 0)
                {
                    for (int i = 0; i < j; i++)
                    {

                        txttype.Text = dt.Rows[i]["type"].ToString();
                        txtd.Text = dt.Rows[i]["amount"].ToString();


                    }

                }
                else
                {
                    MessageBox.Show("Information is not exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                vat();
                percentage();
               


                }
               /* if (txttype.Text != "Percentage")
                {
                    string a = txtprice.Text;
                    string b = txtd.Text;
                    if (a != "" && b != "")
                    {
                        double c = Convert.ToDouble(a);
                        double d = Convert.ToDouble(b);

                        // double samount = Convert.ToDouble(txtdiscount.Text);
                        double amount = c - d;
                        txtdiscount.Text = amount.ToString();
                        //txtdue.Text = amount.ToString();
                    }
                }
                else 
                {
                    string a = txtprice.Text;
                    string b = txtd.Text;
                    double c = Convert.ToDouble(a);
                    double d = Convert.ToDouble(b);
                    double sub = c * d;
                    double total = sub / 100;
                    double t = c - total;
                    txtdiscount.Text = t.ToString();
                    // id();
                    txtprice.Focus();
                }
                if (txtnet.Text != "")
                {

                    string a = txtprice.Text;
                    string b = txtnet.Text;
                    double c = Convert.ToDouble(a);
                    double d = Convert.ToDouble(b);
                    double sub = c * d;
                    double total = sub / 100;
                    txtvat.Text = total.ToString();
                    // id();
                    txtprice.Focus();
                }*/

               
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmusercompanydetails add = new Frmusercompanydetails();
            add.Show();
            add.cmutype.Text = "Item";
            add.cmutype.Enabled = false;
            add.label1.Text = "Sales";
            add.label3.Text = txtinvoice.Text;
        }

        private void saveafterrefresh()
        {
            listView1.Items.Clear();
            txtamount.Text = "";
            txtpayment.Text = "";
            textBox2.Text = "";
            txtdue.Text = "";
        }
        
      private void save()
        {
           
            try
            {
                
               

                for (int i = 0; i < listView1.Items.Count; i++)
                {

                    add.Invoice = txtinvoice.Text;
                    add.Itemid = listView1.Items[i].SubItems[0].Text;
                    add.Quantity = listView1.Items[i].SubItems[2].Text;
                   
                    add.Stotal = listView1.Items[i].SubItems[3].Text;
                    add.Insert();
                    double sub = Convert.ToDouble(textBox3.Text) - Convert.ToDouble(listView1.Items[i].SubItems[2].Text);
                   // add.Itemid = txtid.Text;
                    add1.Itemid = listView1.Items[i].SubItems[0].Text;
                    add1.Itemunit = sub.ToString();
                    add1.Updateiteminfoqty();
                  /*  if (txtquantity.Text != "" && label8.Text != "")
                    {
                        double a = Convert.ToInt32(label8.Text);
                        double b = Convert.ToInt32(txtquantity.Text);
                        double sub = a - b;
                        add.Invoice = txtinvoice.Text;
                        add.Itemunit = sub.ToString();
                        add.UpdateS();
                    }*/
                    // add.Updateiteminfo();
                    
                }

                add.Date = billingdate.Text;
                add.Time = time.Text;



                add.Payment = txtdue.Text;
           
                add.Mno = lblday.Text;
                add.Month = m.Text;
                add.Year = y.Text;
                add.Insert1();
                MessageBox.Show(" Successfully Saved", "Sale And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                btnprint.Enabled = true;

                saveafterrefresh();
                textBox3.Text = "";



            }
            catch (Exception)
            {
                
                MessageBox.Show(" Can't save.", "Sale And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void invoiceinfo()
        {
            try
            {
                dt = add.invoice1();
                int j = dt.Rows.Count;
                if (j != 0)
                {
                    for (int i = 0; i < j; i++)
                    {

                        string a = dt.Rows[i]["invoice"].ToString();
                        double b = Convert.ToDouble(a);
                        double sum= b+1;
                        txtinvoice.Text = sum.ToString();

                      

                    }
                  

                }
                else
                {
                  
                 txtinvoice.Text = "1";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Information is not exist", "Sales And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("sorry no product added", "Sales And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtpayment.Text =="")
            {
                MessageBox.Show("Please enter total payment.", "Sales And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpayment.Focus();
                return;
            }
            save();

        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            string a, b;
            a = txtdiscount.Text;
            b = txtquantity.Text;
            if (a != "" && b != "")
            {
                double c = Convert.ToDouble(a);
                double d = Convert.ToDouble(b);
                double mul = c * d;
                txtstotal.Text = mul.ToString();
            }
            if (a == "" || b == "")
            {
                textamount.Text = "";

            }

           /* string m = txtdiscount.Text;
            string n = txtvat.Text;
            if (txtquantity.Text != "")
            {
                if (m != "" && n != "")
                {
                    double p = Convert.ToDouble(m);
                    double q = Convert.ToDouble(n);
                    double sub = p + q;

                    //string s = txtquantity.Text;
                    //double q;

                    string k = txtquantity.Text;
                    double kk = Convert.ToDouble(k);
                    txtstotal.Text = Convert.ToString(kk * sub);
                }
            }
            else
            {
                txtstotal.Text = "";
            }*/

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            string a, b;
            a = txtprice.Text;
            b = txtquantity.Text;
            if (a != "" && b != "")
            {
                double c = Convert.ToDouble(a);
                double d = Convert.ToDouble(b);
                double mul = c * d;
                textamount.Text = mul.ToString();
            }
            if (a == "" || b == "")
            {
                textamount.Text = "";

            }
        }

        private void txtvat_TextChanged(object sender, EventArgs e)
        {
            /*Exception X = new Exception();

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
            if (txtvat.Text != "")
            {

                string a = txtstotal.Text;
                string b = txtvat.Text;
                double c = Convert.ToDouble(a);
                double d = Convert.ToDouble(b);
                double sub = c * d;
                double total = sub / 100;
                txtnet.Text = total.ToString();
                double samount = Convert.ToDouble(txtnet.Text);
                double amount = c + samount;
                txtgtotal.Text = amount.ToString();
                if (txtdiscount.Text == "")
                {
                    txtamount.Text = txtgtotal.Text;
                    txtdue.Text = txtgtotal.Text;
                }

            }
            if (txtvat.Text == "")
            {
                txtnet.Text = "";
                txtgtotal.Text = txtstotal.Text;
                txtamount.Text = txtstotal.Text;
                txtdue.Text = txtstotal.Text;
            }
            if (txtnet.Text != "" && txtdiscount.Text != "")
            {
                string a = txtnet.Text;
                string b = txtdiscount.Text;
                double c = Convert.ToDouble(a);
                double d = Convert.ToDouble(b);
                double sub = Math.Abs(c - d);
                txtamount.Text = sub.ToString();
                txtdue.Text = txtamount.Text;


            }

            if (txtamount.Text != "" && txtpayment.Text != "")
            {
                string a = txtamount.Text;
                string b = txtpayment.Text;
                double c = Convert.ToDouble(a);
                double d = Convert.ToDouble(b);
                double sub = Math.Abs(c - d);
                txtdue.Text = sub.ToString();


            }*/
        }

        private void txtdis_TextChanged(object sender, EventArgs e)
        {
            /*Exception X = new Exception();

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
            if (txtdis.Text != "")
            {

                string a = txtgtotal.Text;
                string b = txtdis.Text;
                double c = Convert.ToDouble(a);
                double d = Convert.ToDouble(b);
                double sub = c * d;
                double total = sub / 100;
                txtdiscount.Text = total.ToString();
                double samount = Convert.ToDouble(txtdiscount.Text);
                double amount = c - samount;
                txtamount.Text = amount.ToString();
                txtdue.Text = amount.ToString();
            }*/
        }

        private void txtTotalPayment_TextChanged(object sender, EventArgs e)
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
            if (txtamount.Text != "" && txtpayment.Text != "")
            {
                string a = txtamount.Text;
                string b = txtpayment.Text;
                double c = Convert.ToDouble(a);
                double d = Convert.ToDouble(b);
                double sub = (c - d);
               // sub = sub ;
                textBox2.Text = sub.ToString();
                txtdue.Text = txtamount.Text;

            }

            if (txtpayment.Text == "")
            {
                textBox2.Text = txtamount.Text;
                txtdue.Text = "";
            }
            if (textBox2.Text != "" && txtpayment.Text != "")
            {
                string a = txtpayment.Text;
                string b = textBox2.Text;
                double c = Convert.ToDouble(a);
                double d =Math.Abs( Convert.ToDouble(b));
                double sub =(c - d);
                txtdue.Text = sub.ToString();
            }


            

        }

        private void txtstotal_TextChanged(object sender, EventArgs e)
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

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (txtd.Text == "Fixed discount")
            {
                txtdis.Enabled = false;
                txtdiscount.Enabled = true;
            }
            else
            {
                txtdis.Enabled = true;
                txtdiscount.Enabled = false;

            }*/
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            /*string a = txtgtotal.Text;
            string b = txtdiscount.Text;
            if (a != "" && b != "")
            {
                double c = Convert.ToDouble(a);
                double d = Convert.ToDouble(b);

                // double samount = Convert.ToDouble(txtdiscount.Text);
                double amount = c - d;
                txtamount.Text = amount.ToString();
                txtdue.Text = amount.ToString();
            }*/
        }

        private void PrintReport()
        {

            BillDataSet ds = new BillDataSet();

            CrystalReportBill rpt = new CrystalReportBill();

            FrmReportShow rptViewer = new FrmReportShow();

            DataTable dt = new DataTable();

            Sales addInfo = new Sales();
            string id = Convert.ToString(txtinvoice.Text);

            addInfo.Invoice = id;

            dt = addInfo.LoadInfoDbill(id);
             double total = 0;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dt.Rows)
                {
                    BillDataSet.BillDataTableRow row = ds.BillDataTable.NewBillDataTableRow();
                    row.INVOICE = dataRow["invoice"].ToString();
                    row.ID = dataRow["id"].ToString();
                    row.NAME = dataRow["itemname"].ToString();
                    row.QNTY = dataRow["quantity"].ToString();
                    row.DataColumn14 = dataRow["itemunit"].ToString();
                    row.UPRICE = dataRow["price"].ToString();
                    row.VAT = dataRow["vat"].ToString();
                    row.DUE = dataRow["type"].ToString();
                    
                    row.DISCOUNTAMOUNT = dataRow["amount"].ToString();

                   // row.DUE = lbdis.Text; ;
                    
                    row.STOTAL = dataRow["subtotal"].ToString();
                    total += Convert.ToDouble(dataRow["subtotal"].ToString());
                    row.TOTAL = total.ToString();
                    row.PAYMENT = dataRow["payment"].ToString();
                    ds.BillDataTable.AddBillDataTableRow(row);
                }

                rptViewer.ShowReport(rpt, ds);
                btnprint.Enabled = false;
              

            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           
            PrintReport();
            invoiceinfo();
           
          
           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtdue_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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


            if (txtamount.Text != "" && txtpayment.Text != "")
            {
                string a = txtamount.Text;
                string b = txtpayment.Text;
                double c = Convert.ToDouble(a);
                double d = Convert.ToDouble(b);
                double sub = (c - d);


                textBox2.Text = sub.ToString();


            }

            if (txtpayment.Text == "")

                //textBox2.Text = txtamount.Text;

                textBox2.Text = "";
           


          
        }

        private void txtamount_TextChanged(object sender, EventArgs e)
        {
           // txtdue.Text = txtamount.Text;
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void FrmSales_Leave(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged_1(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                idinfo();
            }
            vat();
            percentage();



            if (txtid.Text == "")
            {
                txtname.Text = "";
                txtprice.Text = "";
                txtquantity.Text = "";
                txtnet.Text = "";
                txtunit.Text = "";
                txtd.Text = "";
                txttype.Text = "";
                txtdiscount.Text = "";
                txtvat.Text = "";
                txtstotal.Text = "";
                txtid.Focus();
            }


          
          

        }

        private void btnprint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.S))
            {
                save();
            }
           /* if (e.KeyData == (Keys.Control | Keys.A))
            {
                //addtocart();
            }*/
            if (e.KeyData == (Keys.Control | Keys.P))
            {
                PrintReport();
            }
            if (e.KeyData == (Keys.Control | Keys.R))
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)8)
            {
                e.Handled = true;

            }
        }

        private void billingdate_ValueChanged(object sender, EventArgs e)
        {
            mycount();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void FrmSales_FormClosing(object sender, FormClosingEventArgs e)
        {
           // this.Owner.Enabled = true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void vat()
        {

            string a = txtprice.Text;
            string b = txtnet.Text;
            if (b != "" && a!="" )
            {

           
                double c = Convert.ToDouble(a);
                double d = Convert.ToDouble(b);
                double sub = c * d;
                double total = sub / 100;
                double sum = c + total;
                txtvat.Text = sum.ToString();
                // id();
                txtprice.Focus();
            } 
        }

        private void txtnet_TextChanged(object sender, EventArgs e)
        {
            vat();
                 //double samount = Convert.ToDouble(txtnet.Text);
                 //double amount = c + d;
                // txtgtotal.Text = amount.ToString();
               /*  if (txtdiscount.Text == "")
                 {
                     txtamount.Text = txtgtotal.Text;
                     txtdue.Text = txtgtotal.Text;
                 }

             }
             if (txtvat.Text == "")
             {
                 txtnet.Text = "";
                 txtgtotal.Text = txtstotal.Text;
                 txtamount.Text = txtstotal.Text;
                 txtdue.Text = txtstotal.Text;
             }
             if (txtnet.Text != "" && txtdiscount.Text != "")
             {
                 string a = txtnet.Text;
                 string b = txtdiscount.Text;
                 double c = Convert.ToDouble(a);
                 double d = Convert.ToDouble(b);
                 double sub = Math.Abs(c - d);
                 txtamount.Text = sub.ToString();
                 txtdue.Text = txtamount.Text;


             }

             if (txtamount.Text != "" && txtpayment.Text != "")
             {
                 string a = txtamount.Text;
                 string b = txtpayment.Text;
                 double c = Convert.ToDouble(a);
                 double d = Convert.ToDouble(b);
                 double sub = Math.Abs(c - d);
                 txtdue.Text = sub.ToString();


             }
         }*/
     
        }

        private void txtgtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txttype_TextChanged(object sender, EventArgs e)
        {
            if (txttype.Text == "Percentage")
            {
                label31.Text = "%";
                lbdis.Text = "%";
            }
            else
            {
                label31.Text = "TK.";
            }

          
          
        }

        private void txtd_TextChanged(object sender, EventArgs e)
        {
            percentage();
           

        }

        private void percentage()
        {
            if (txttype.Text != "Percentage")
            {
                string a = txtvat.Text;
                string b = txtd.Text;
                if (a != "" && b != "")
                {
                    double c = Convert.ToDouble(a);
                    double d = Convert.ToDouble(b);

                    // double samount = Convert.ToDouble(txtdiscount.Text);
                    double amount = c - d;
                    txtdiscount.Text = amount.ToString();
                    //txtdue.Text = amount.ToString();
                }
            }
            else
            {


                string a = txtvat.Text;
                string b = txtd.Text;
                if (a != "" && b != "")
                {
                    double c = Convert.ToDouble(a);
                    double d = Convert.ToDouble(b);
                    double sub = c * d;
                    double total = sub / 100;
                    double t = c - total;
                    txtdiscount.Text = t.ToString();
                    // id();
                    txtprice.Focus();
                }

            }
        }

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
          if(!char.IsDigit(e.KeyChar))
          {
              e.Handled = true;
          }
          if (e.KeyChar==(char)8)
          {
              e.Handled = false;
          }

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            billingdate.Text = System.DateTime.Now.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtquantity_Leave(object sender, EventArgs e)
        {
            if(txtquantity.Text !="")
            {
                double b = Convert.ToInt32(txtquantity.Text);
                if(b==0)
                {
                     MessageBox.Show("Sale quantity must be greater than 0.","Sales Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     txtquantity.Text = "";
                     txtquantity.Focus();
                     return;
                }
            }
            if (txtquantity.Text != "" && textBox3.Text != "")
            {
                double a = Convert.ToInt32(textBox3.Text);
                double b = Convert.ToInt32(txtquantity.Text);
                if (b > a)
                {
                    MessageBox.Show("Sale quantity must be equal or less than available quantity.","Sales Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtquantity.Text = "";
                    txtquantity.Focus();
                    return;
                }
            }
        }

        private void txtstotal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtstotal_Leave(object sender, EventArgs e)
        {
            string a = txtstotal.Text;
            if (a != "")
            {
                double b = Convert.ToDouble(a);
                txtstotal.Text = String.Format("{0:0.00}", b);
            }
        }

        private void txtpayment_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtpayment_Leave(object sender, EventArgs e)
        {
            string a = txtpayment.Text;
            if (a != "")
            {
                double b = Convert.ToDouble(a);
                txtpayment.Text = String.Format("{0:0.00}", b);
            }
        }

        private void txtname_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            label21.Visible = true;
            label21.Text = "Search Item By ID/Name";
           // textBox4.Text = "Search Item By ID/Name";
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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
          
                DataGridViewRow dr = dataGridView2.SelectedRows[0];
                txtid.Text = dr.Cells[0].Value.ToString();
                dataGridView2.ClearSelection();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmSales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.C))
            {
                this.Close();
            }
            if (e.KeyData == (Keys.Control | Keys.A))
            {
                btnAddcart();
            }
            if (e.KeyData == (Keys.Control | Keys.S))
            {
                if (listView1.Items.Count == 0)
                {
                    MessageBox.Show("sorry no product added", "Sales And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtpayment.Text == "")
                {
                    MessageBox.Show("Please enter total payment.", "Sales And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtpayment.Focus();
                    return;
                }
                save();
            }

            if (e.KeyData == (Keys.Control | Keys.P))
            {
                PrintReport();

                invoiceinfo();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}