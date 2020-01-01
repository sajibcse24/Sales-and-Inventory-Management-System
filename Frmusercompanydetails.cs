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
    public partial class Frmusercompanydetails : Form
    {
        DataSet ds = new DataSet();
        Item add = new Item();
        public Frmusercompanydetails()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void searchinpinfobyname()
        {
            string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
            SqlConnection myconnection = new SqlConnection(str);
            string Query = "select company_Id as [Brand Id],company_name as[Brand Name] from [User Company] where company_name like '" + txtSearchbyname.Text + "%' ";// union (select date,pid,billtype,billid,net,payment,due from [pbillsearch] where date between '" + date2 + "' and '" + date3 + "' )union (select date,pid,billtype,billid,net,payment,due from [dbillsearch] where  date between '" + date2 + "' and '" + date3 + "') order by date   ";

            // cmd = new SqlCommand("SELECT (invoiceNo) as [Invoice No],(InvoiceDate) as [Invoice Date],(Sales.CustomerID) as [Customer ID],(CustomerName) as [Customer Name],(GrandTotal) as [Grand Total],(TotalPayment) as [Total Payment],(PaymentDue) as [Payment Due] from Sales,Customer where Sales.CustomerID=Customer.CustomerID and InvoiceDate between #" + dtpInvoiceDateFrom.Text + "# And #" + dtpInvoiceDateTo.Text + "# order by InvoiceDate desc", con);
            SqlDataAdapter myDA = new SqlDataAdapter(Query, str);
            DataSet myDataSet = new DataSet();
            myDA.Fill(myDataSet, "User Company");

            dataGridView1.DataSource = myDataSet.Tables["User Company"].DefaultView;

        }

        public void searchinpinfobycategoryname()
        {
            string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
            SqlConnection myconnection = new SqlConnection(str);
            string Query = "select cid as [Category Id],cname as[Category Name],cdes as[Category Description] from [Category] where cname like '" + txtSearchbyname.Text + "%' ";// union (select date,pid,billtype,billid,net,payment,due from [pbillsearch] where date between '" + date2 + "' and '" + date3 + "' )union (select date,pid,billtype,billid,net,payment,due from [dbillsearch] where  date between '" + date2 + "' and '" + date3 + "') order by date   ";

            // cmd = new SqlCommand("SELECT (invoiceNo) as [Invoice No],(InvoiceDate) as [Invoice Date],(Sales.CustomerID) as [Customer ID],(CustomerName) as [Customer Name],(GrandTotal) as [Grand Total],(TotalPayment) as [Total Payment],(PaymentDue) as [Payment Due] from Sales,Customer where Sales.CustomerID=Customer.CustomerID and InvoiceDate between #" + dtpInvoiceDateFrom.Text + "# And #" + dtpInvoiceDateTo.Text + "# order by InvoiceDate desc", con);
            SqlDataAdapter myDA = new SqlDataAdapter(Query, str);
            DataSet myDataSet = new DataSet();
            myDA.Fill(myDataSet, "Category");

            dataGridView1.DataSource = myDataSet.Tables["Category"].DefaultView;

        }
        public void searchinpinfobyitemname()
        {
            string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
            SqlConnection myconnection = new SqlConnection(str);
            string Query = "select itemid as [Item Id],itemname as[Item Name],itemucat as[Item Under Category ],itemucom as[Item Under Brand],itemdes as[Item Description],itemunit as[Item Unit] from [item] where itemname like '" + txtSearchbyname.Text + "%' ";// union (select date,pid,billtype,billid,net,payment,due from [pbillsearch] where date between '" + date2 + "' and '" + date3 + "' )union (select date,pid,billtype,billid,net,payment,due from [dbillsearch] where  date between '" + date2 + "' and '" + date3 + "') order by date   ";

            // cmd = new SqlCommand("SELECT (invoiceNo) as [Invoice No],(InvoiceDate) as [Invoice Date],(Sales.CustomerID) as [Customer ID],(CustomerName) as [Customer Name],(GrandTotal) as [Grand Total],(TotalPayment) as [Total Payment],(PaymentDue) as [Payment Due] from Sales,Customer where Sales.CustomerID=Customer.CustomerID and InvoiceDate between #" + dtpInvoiceDateFrom.Text + "# And #" + dtpInvoiceDateTo.Text + "# order by InvoiceDate desc", con);
            SqlDataAdapter myDA = new SqlDataAdapter(Query, str);
            DataSet myDataSet = new DataSet();
            myDA.Fill(myDataSet, "item");

            dataGridView1.DataSource = myDataSet.Tables["item"].DefaultView;

        }

        public void searchinpinfoallcategory()
        {
            string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
            SqlConnection myconnection = new SqlConnection(str);
            string Query = "select cid as [Category Id],cname as[Category Name],cdes as[Category ] from [Category] where cname like '" + txtSearchbyname.Text + "%' and cid like '" + txtSearchbycid.Text + "%' ";// union (select date,pid,billtype,billid,net,payment,due from [pbillsearch] where date between '" + date2 + "' and '" + date3 + "' )union (select date,pid,billtype,billid,net,payment,due from [dbillsearch] where  date between '" + date2 + "' and '" + date3 + "') order by date   ";

            // cmd = new SqlCommand("SELECT (invoiceNo) as [Invoice No],(InvoiceDate) as [Invoice Date],(Sales.CustomerID) as [Customer ID],(CustomerName) as [Customer Name],(GrandTotal) as [Grand Total],(TotalPayment) as [Total Payment],(PaymentDue) as [Payment Due] from Sales,Customer where Sales.CustomerID=Customer.CustomerID and InvoiceDate between #" + dtpInvoiceDateFrom.Text + "# And #" + dtpInvoiceDateTo.Text + "# order by InvoiceDate desc", con);
            SqlDataAdapter myDA = new SqlDataAdapter(Query, str);
            DataSet myDataSet = new DataSet();
            myDA.Fill(myDataSet, "Category");

            dataGridView1.DataSource = myDataSet.Tables["Category"].DefaultView;

        }
     
        public void searchinpinfoallitem()
        {
            string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
            SqlConnection myconnection = new SqlConnection(str);
            string Query = "select itemid as [Item Id],itemname as[Item Name],itemucat as[Item Under Category ],itemucom as[Item Under Brand],itemdes as[Item Description],itemunit as[Item Unit] from [item] where itemname like '" + txtSearchbyname.Text + "%' and itemid like '" + txtSearchbycid.Text + "%' ";// union (select date,pid,billtype,billid,net,payment,due from [pbillsearch] where date between '" + date2 + "' and '" + date3 + "' )union (select date,pid,billtype,billid,net,payment,due from [dbillsearch] where  date between '" + date2 + "' and '" + date3 + "') order by date   ";

            // cmd = new SqlCommand("SELECT (invoiceNo) as [Invoice No],(InvoiceDate) as [Invoice Date],(Sales.CustomerID) as [Customer ID],(CustomerName) as [Customer Name],(GrandTotal) as [Grand Total],(TotalPayment) as [Total Payment],(PaymentDue) as [Payment Due] from Sales,Customer where Sales.CustomerID=Customer.CustomerID and InvoiceDate between #" + dtpInvoiceDateFrom.Text + "# And #" + dtpInvoiceDateTo.Text + "# order by InvoiceDate desc", con);
            SqlDataAdapter myDA = new SqlDataAdapter(Query, str);
            DataSet myDataSet = new DataSet();
            myDA.Fill(myDataSet, "item");

            dataGridView1.DataSource = myDataSet.Tables["item"].DefaultView;

        }



        public void searchinpinfoall()
        {
            string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
            SqlConnection myconnection = new SqlConnection(str);
            string Query = "select company_Id as [Brand Id],company_name as[Brand Name] from [User Company] where company_name like '" + txtSearchbyname.Text + "%' and company_Id like '" + txtSearchbycid.Text + "%' ";// union (select date,pid,billtype,billid,net,payment,due from [pbillsearch] where date between '" + date2 + "' and '" + date3 + "' )union (select date,pid,billtype,billid,net,payment,due from [dbillsearch] where  date between '" + date2 + "' and '" + date3 + "') order by date   ";

            // cmd = new SqlCommand("SELECT (invoiceNo) as [Invoice No],(InvoiceDate) as [Invoice Date],(Sales.CustomerID) as [Customer ID],(CustomerName) as [Customer Name],(GrandTotal) as [Grand Total],(TotalPayment) as [Total Payment],(PaymentDue) as [Payment Due] from Sales,Customer where Sales.CustomerID=Customer.CustomerID and InvoiceDate between #" + dtpInvoiceDateFrom.Text + "# And #" + dtpInvoiceDateTo.Text + "# order by InvoiceDate desc", con);
            SqlDataAdapter myDA = new SqlDataAdapter(Query, str);
            DataSet myDataSet = new DataSet();
            myDA.Fill(myDataSet, "User Company");

            dataGridView1.DataSource = myDataSet.Tables["User Company"].DefaultView;

        }
        private void txtSearchbyname_TextChanged(object sender, EventArgs e)
        {
            if (cmutype.Text == "Brand")
            {
                {
                    searchinpinfobyname();
                }

                if (txtSearchbycid.Text != "" && txtSearchbyname.Text != "")
                {
                    searchinpinfoall();
                }

            }


            if (cmutype.Text == "Category")
            {
                {
                    searchinpinfobycategoryname();
                }

                if (txtSearchbycid.Text != "" && txtSearchbyname.Text != "")
                {
                    searchinpinfoallcategory();
                }

            }

            if (cmutype.Text == "Item")
            {
                {
                   // searchinpinfobyitemname();
                    searchDiscountName();
                }

                if (txtSearchbycid.Text != "" && txtSearchbyname.Text != "")
                {
                    //searchinpinfoallitem();
                    searchDiscountNID();
                }

                if (cmutype.Text == "Item" && label1.Text == "Saleprice")
                {
                    searchN();
                    if (txtSearchbycid.Text != "" && txtSearchbyname.Text != "")
                    {
                        searchSnameid();
                    }
                }

                if (cmutype.Text == "Item" && label1.Text == "Discount")
                {
                    searchDN();
                    if (txtSearchbycid.Text != "" && txtSearchbyname.Text != "")
                    {
                        searchSnameid();
                    }
                }

            }  
        }
        private void loadinfo()
        {
            string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
            SqlConnection myconnection = new SqlConnection(str);
            string Query = "select company_Id as[Brand Id],company_name as [Brand name] from [User Company]  order by company_Id ";// union (select date,pid,billtype,billid,net,payment,due from [pbillsearch] where date between '" + date2 + "' and '" + date3 + "' )union (select date,pid,billtype,billid,net,payment,due from [dbillsearch] where  date between '" + date2 + "' and '" + date3 + "') order by date   ";

            // cmd = new SqlCommand("SELECT (invoiceNo) as [Invoice No],(InvoiceDate) as [Invoice Date],(Sales.CustomerID) as [Customer ID],(CustomerName) as [Customer Name],(GrandTotal) as [Grand Total],(TotalPayment) as [Total Payment],(PaymentDue) as [Payment Due] from Sales,Customer where Sales.CustomerID=Customer.CustomerID and InvoiceDate between #" + dtpInvoiceDateFrom.Text + "# And #" + dtpInvoiceDateTo.Text + "# order by InvoiceDate desc", con);
            SqlDataAdapter myDA = new SqlDataAdapter(Query, str);
            DataSet myDataSet = new DataSet();
            myDA.Fill(myDataSet, "User Company");

            dataGridView1.DataSource = myDataSet.Tables["User Company"].DefaultView;
        }

        private void loadinfoc()
        {
            string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
            SqlConnection myconnection = new SqlConnection(str);
            string Query = "select cid as [Category Id],cname as [Category name],cdes as [Category description] from [Category]  order by cid ";// union (select date,pid,billtype,billid,net,payment,due from [pbillsearch] where date between '" + date2 + "' and '" + date3 + "' )union (select date,pid,billtype,billid,net,payment,due from [dbillsearch] where  date between '" + date2 + "' and '" + date3 + "') order by date   ";

            // cmd = new SqlCommand("SELECT (invoiceNo) as [Invoice No],(InvoiceDate) as [Invoice Date],(Sales.CustomerID) as [Customer ID],(CustomerName) as [Customer Name],(GrandTotal) as [Grand Total],(TotalPayment) as [Total Payment],(PaymentDue) as [Payment Due] from Sales,Customer where Sales.CustomerID=Customer.CustomerID and InvoiceDate between #" + dtpInvoiceDateFrom.Text + "# And #" + dtpInvoiceDateTo.Text + "# order by InvoiceDate desc", con);
            SqlDataAdapter myDA = new SqlDataAdapter(Query, str);
            DataSet myDataSet = new DataSet();
            myDA.Fill(myDataSet, "Category");

            dataGridView1.DataSource = myDataSet.Tables["Category"].DefaultView;
        }

        private void Frmusercompanydetails_Load(object sender, EventArgs e)
        {
          //loadinfo();
          //  this.Owner.Enabled = false;

        }
        public void searchinpinfobyid()
        {
            string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
            SqlConnection myconnection = new SqlConnection(str);
            string Query = "select company_Id as[Brand Id], company_name as [Brand Name] from [User Company] where company_Id like '" + txtSearchbycid.Text + "%' ";
            SqlDataAdapter myDA = new SqlDataAdapter(Query, str);
            DataSet myDataSet = new DataSet();
            myDA.Fill(myDataSet, "User Company");

            dataGridView1.DataSource = myDataSet.Tables["User Company"].DefaultView;

        }

        public void searchinpinfobycatid()
        {
            string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
            SqlConnection myconnection = new SqlConnection(str);
            string Query = "select cid as[Category Id],cname as [Category Name],cdes as[Category Description] from [Category] where cid like '" + txtSearchbycid.Text + "%' ";
            SqlDataAdapter myDA = new SqlDataAdapter(Query, str);
            DataSet myDataSet = new DataSet();
            myDA.Fill(myDataSet, "Category");

            dataGridView1.DataSource = myDataSet.Tables["Category"].DefaultView;

        }
       /* public void searchinpinfobyitemid()
        {
            string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
            SqlConnection myconnection = new SqlConnection(str);
            string Query = "select itemid as [Item Id],itemname as[Item Name],itemucat as[Category ],itemucom as[Company],itemdes as[Item Description],itemunit as[Item Unit],price as [Unit Price],vat as[VAT],type as[Discount Type], amount as[Discount]  from [item],[price],[discount] where item.itemid like '" + txtSearchbycid.Text + "%' and price.id like '" + txtSearchbycid.Text + "%' and discount.id like '" + txtSearchbycid.Text + "%'";
            SqlDataAdapter myDA = new SqlDataAdapter(Query, str);
            DataSet myDataSet = new DataSet();
            myDA.Fill(myDataSet, "item,price,discount");
                
            dataGridView1.DataSource = myDataSet.Tables["item,price,discount"].DefaultView;

        }*/

        private void txtSearchbycid_TextChanged(object sender, EventArgs e)
        {
            if (cmutype.Text == "Brand")
            {
                {
                    searchinpinfobyid();
                }

                if (txtSearchbycid.Text != "" && txtSearchbyname.Text != "")
                {
                    searchinpinfoall();
                    
                }
            }
           

            if (cmutype.Text == "Category")
            {
                {
                    searchinpinfobycatid();
                }

                if (txtSearchbycid.Text != "" && txtSearchbyname.Text != "")
                {
                    searchinpinfoallcategory();
                }
            }
            if (cmutype.Text == "Item")
            {
                {
                   // searchinpinfobyitemid();
                   // searchinpinfoallitem();
                    searchDiscount();
                    
                }

                if (cmutype.Text == "Item" && label1.Text == "Saleprice")
                {
                    searchS();
                    if (txtSearchbycid.Text != "" && txtSearchbyname.Text != "")
                    {
                        searchSnameid();
                    }
                }

                if (cmutype.Text == "Item" && label1.Text == "Discount")
                {
                    searchD();
                    if (txtSearchbycid.Text != "" && txtSearchbyname.Text != "")
                    {
                        searchSnameid();
                    }
                }

                if (txtSearchbycid.Text != "" && txtSearchbyname.Text != "")
                {
                    //searchinpinfoallitem();
                    searchDiscountNID();
                }
            }
        }

       



        public void searchDiscount()
        {


            DataSet ds = add.searchDiscount(txtSearchbycid.Text);
            try
            {

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {

                    DataView dw = new DataView(ds.Tables[0]);
                    dataGridView1.DataSource = dw;

                }
                else
                {
                    dataGridView1.DataSource = null;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("No Item is found ", "Sales And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public void searchDiscountNID()
        {


            DataSet ds = add.searchDiscountNID(txtSearchbycid.Text,txtSearchbyname.Text);
            try
            {

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {

                    DataView dw = new DataView(ds.Tables[0]);
                    dataGridView1.DataSource = dw;

                }
                else
                {
                    dataGridView1.DataSource = null;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("No Item is found ", "Sales And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public void searchAll()
        {


            DataSet ds = add.searchAllItem();
            try
            {

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {

                    DataView dw = new DataView(ds.Tables[0]);
                    dataGridView1.DataSource = dw;

                }
                else
                {
                    dataGridView1.DataSource = null;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("No Item is found ", "Sales And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public void searchDiscountName()
        {


            DataSet ds = add.searchDiscountName(txtSearchbyname.Text);
            try
            {

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {

                    DataView dw = new DataView(ds.Tables[0]);
                    dataGridView1.DataSource = dw;

                }
                else
                {
                    dataGridView1.DataSource = null;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("No Item is found ", "Sales And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public void searchS()
        {


            DataSet ds = add.searchinpinfobyitemid(txtSearchbycid.Text);
            try
            {

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {

                    DataView dw = new DataView(ds.Tables[0]);
                    dataGridView1.DataSource = dw;

                }
                else
                {
                    dataGridView1.DataSource = null;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("No Item is found ", "Sales And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public void searchSnameid()
        {


            DataSet ds = add.searchinpinfobyitemidname(txtSearchbycid.Text,txtSearchbyname.Text);
            try
            {

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {

                    DataView dw = new DataView(ds.Tables[0]);
                    dataGridView1.DataSource = dw;

                }
                else
                {
                    dataGridView1.DataSource = null;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("No Item is found ", "Sales And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public void searchN()
        {


            DataSet ds = add.searchn(txtSearchbyname.Text);
            try
            {

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {

                    DataView dw = new DataView(ds.Tables[0]);
                    dataGridView1.DataSource = dw;

                }
                else
                {
                    dataGridView1.DataSource = null;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("No Item is found ", "Sales And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public void searchD()
        {


            DataSet ds = add.searchinpinfobyitemid(txtSearchbycid.Text);
            try
            {

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {

                    DataView dw = new DataView(ds.Tables[0]);
                    dataGridView1.DataSource = dw;

                }
                else
                {
                    dataGridView1.DataSource = null;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("No Item is found ", "Sales And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public void searchDN()
        {


            DataSet ds = add.searchDN(txtSearchbyname.Text);
            try
            {

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {

                    DataView dw = new DataView(ds.Tables[0]);
                    dataGridView1.DataSource = dw;

                }
                else
                {
                    dataGridView1.DataSource = null;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("No Item is found ", "Sales And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }




        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

          /*  if (cmutype.Text == "Item" && label1.Text == "Discount")
            {
                this.Hide();
                Frmdiscount com = new Frmdiscount();


                com.Show();
                com.lbuname.Text = lbuname.Text;
                com.txttype.Enabled = true;
                // com.txtamount.Enabled = true;

                // com.btndelete.Enabled = true;
                //com.btnupdate.Enabled = true;
                //com.btnsave.Enabled = true;
                try
                {
                    DataGridViewRow dr = dataGridView1.SelectedRows[0];
                    com.txtid.Text = dr.Cells[0].Value.ToString();
                    com.txtname.Text = dr.Cells[1].Value.ToString();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            if (lbuname.Text == "Admin")
            {
                if (cmutype.Text == "Item" && label1.Text == "Item")
                {
                    this.Hide();
                    FrmItem c = new FrmItem();
                    // c.Owner = this;
                    c.Show();
                    c.textBox1.Text = "item";
                    c.btndelete.Enabled = true;
                    c.btnupdate.Enabled = true;
                    c.btnsave.Enabled = false;
                    try
                    {
                        DataGridViewRow dr = dataGridView1.SelectedRows[0];

                        c.txtitemid.Text = dr.Cells[0].Value.ToString();
                        c.txtitemname.Text = dr.Cells[1].Value.ToString();
                        c.cmucat.Text = dr.Cells[2].Value.ToString();
                        c.cmucom.Text = dr.Cells[3].Value.ToString();
                        c.txtitemdes.Text = dr.Cells[4].Value.ToString();
                        c.txtitemunit.Text = dr.Cells[5].Value.ToString();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

                else
                {
                    if (cmutype.Text == "Item" && label1.Text == "Item")
                    {
                        this.Hide();
                        FrmItem c = new FrmItem();
                        // c.Owner = this;
                        c.Show();
                        c.textBox1.Text = "item";
                        //  c.btndelete.Enabled = true;
                        c.btnupdate.Enabled = true;
                        c.btnsave.Enabled = false;
                        try
                        {
                            DataGridViewRow dr = dataGridView1.SelectedRows[0];

                            c.txtitemid.Text = dr.Cells[0].Value.ToString();
                            c.txtitemname.Text = dr.Cells[1].Value.ToString();
                            c.cmucat.Text = dr.Cells[2].Value.ToString();
                            c.cmucom.Text = dr.Cells[3].Value.ToString();
                            c.txtitemdes.Text = dr.Cells[4].Value.ToString();
                            c.txtitemunit.Text = dr.Cells[5].Value.ToString();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (cmutype.Text == "Item" && label1.Text == "Sales")
                {
                    this.Hide();
                    FrmSales c = new FrmSales();


                    c.Show();
                    try
                    {
                        DataGridViewRow dr = dataGridView1.SelectedRows[0];

                        c.txtid.Text = dr.Cells[0].Value.ToString();
                        c.txtname.Text = dr.Cells[1].Value.ToString();
                        c.txtunit.Text = dr.Cells[5].Value.ToString();
                        c.txtprice.Text = dr.Cells[6].Value.ToString();
                        c.txtnet.Text = dr.Cells[7].Value.ToString();
                        c.txttype.Text = dr.Cells[8].Value.ToString();
                        c.txtd.Text = dr.Cells[9].Value.ToString();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (cmutype.Text == "Item" && label1.Text == "Saleprice")
                {
                    this.Hide();
                    Frmsaleprice c = new Frmsaleprice();
                    c.Show();

                    try
                    {
                        DataGridViewRow dr = dataGridView1.SelectedRows[0];

                        c.id.Text = dr.Cells[0].Value.ToString();
                        c.name.Text = dr.Cells[1].Value.ToString();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (lbuname.Text == "Admin")
                {

                    try
                    {
                        if (cmutype.Text == "Brand")
                        {

                            this.Hide();
                            FrmUCompany c = new FrmUCompany();
                            c.Show();
                            c.btnupdate.Enabled = true;
                            c.btndelete.Enabled = true;
                            c.btnsave.Enabled = false;
                            if (dataGridView1.Rows.Count > 0)
                            {
                                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                                c.txtUcomid.Text = dr.Cells[0].Value.ToString();
                                c.txtUcomname.Text = dr.Cells[1].Value.ToString();
                            }
                        }
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
                        if (cmutype.Text == "Brand")
                        {

                            this.Hide();
                            FrmUCompany c = new FrmUCompany();
                            c.Show();
                            c.btnupdate.Enabled = true;
                           // c.btndelete.Enabled = true;
                            c.btnsave.Enabled = false;
                            if (dataGridView1.Rows.Count > 0)
                            {
                                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                                c.txtUcomid.Text = dr.Cells[0].Value.ToString();
                                c.txtUcomname.Text = dr.Cells[1].Value.ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (lbuname.Text == "Admin")
                {
                    if (cmutype.Text == "Category")
                    {
                        this.Hide();
                        Frmcategory c = new Frmcategory();
                        c.Show();

                        c.btndelete.Enabled = true;
                        c.btnupdate.Enabled = true;
                        c.button1.Enabled = false;
                        try
                        {
                            DataGridViewRow dr = dataGridView1.SelectedRows[0];

                            c.txtcatid.Text = dr.Cells[0].Value.ToString();
                            c.txtcatdes.Text = dr.Cells[1].Value.ToString();
                            c.txtcatname.Text = dr.Cells[2].Value.ToString();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                else
                {
                    if (cmutype.Text == "Category")
                    {
                        this.Hide();
                        Frmcategory c = new Frmcategory();
                        c.Show();

                       // c.btndelete.Enabled = true;
                        c.btnupdate.Enabled = true;
                        c.button1.Enabled = false;
                        try
                        {
                            DataGridViewRow dr = dataGridView1.SelectedRows[0];

                            c.txtcatid.Text = dr.Cells[0].Value.ToString();
                            c.txtcatdes.Text = dr.Cells[1].Value.ToString();
                            c.txtcatname.Text = dr.Cells[2].Value.ToString();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                if (cmutype.Text == "Item" && label1.Text == "Stock")
                {

                    this.Hide();
                    FrmPurchase c = new FrmPurchase();
                    c.Show();
                    c.txtInvoice.Text = label3.Text;
                    if (dataGridView1.Rows.Count > 0)
                    {
                        DataGridViewRow dr = dataGridView1.SelectedRows[0];
                        c.txtID.Text = dr.Cells[0].Value.ToString();
                        c.txtItem.Text = dr.Cells[1].Value.ToString();
                        c.txtCategory.Text = dr.Cells[2].Value.ToString();
                    }
                }*/
            
        }
        private void cmutype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmutype.Text=="Brand")
            {
                groupBox3.Text = "Search Brand By Name";
                groupBox4.Text = "Search Brand By ID";
            
                txtSearchbycid.Text = "";
                txtSearchbyname.Text = "";
               this.dataGridView1.DataSource = null;
                this.dataGridView1.Rows.Clear();
                loadinfo();
               
               // dataGridView1.Refresh();
            }
            if (cmutype.Text == "Item")
            {
                groupBox3.Text= "Search Item By Name";
                groupBox4.Text = "Search Item By ID";

                txtSearchbycid.Text = "";
                txtSearchbyname.Text = "";
                this.dataGridView1.DataSource = null;
                this.dataGridView1.Rows.Clear();
                searchAll();
                //dataGridView1.Refresh();
            }
            if (cmutype.Text == "Category")
            {
                groupBox3.Text = "Search Category By Name";
                groupBox4.Text = "Search Category By ID";
                txtSearchbycid.Text = "";
                txtSearchbyname.Text = "";
                this.dataGridView1.DataSource = null;
                this.dataGridView1.Rows.Clear();
                loadinfoc();
            }
            txtSearchbycid.Enabled = true;
            txtSearchbyname.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmutype_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Frmusercompanydetails_Leave(object sender, EventArgs e)
        {
            //this.Owner.Enabled = true;
        }

        private void Frmusercompanydetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cmutype.Text == "Item" && label1.Text == "Saleprice")
            {
                Frmsaleprice f = new Frmsaleprice();
                f.Show();
            }

            if (cmutype.Text == "Item" && label1.Text == "Discount")
            {
                Frmdiscount f = new Frmdiscount();
                f.Show();
            }

            if (cmutype.Text == "Item" && label1.Text == "Item")
            {
                FrmItem f = new FrmItem();
                f.Show();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cmutype.Text == "Item" && label1.Text == "Discount")
            {
                this.Hide();
                Frmdiscount com = new Frmdiscount();


                com.Show();
                com.lbuname.Text = lbuname.Text;
                com.txttype.Enabled = true;
                // com.txtamount.Enabled = true;

                // com.btndelete.Enabled = true;
                //com.btnupdate.Enabled = true;
                //com.btnsave.Enabled = true;
                try
                {
                    DataGridViewRow dr = dataGridView1.SelectedRows[0];
                    com.txtid.Text = dr.Cells[0].Value.ToString();
                    com.txtname.Text = dr.Cells[1].Value.ToString();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            if (lbuname.Text == "Admin")
            {
                if (cmutype.Text == "Item" && label1.Text == "Item")
                {
                    this.Hide();
                    FrmItem c = new FrmItem();
                    // c.Owner = this;
                    c.Show();
                    c.textBox1.Text = "item";
                    c.btndelete.Enabled = true;
                    c.btnupdate.Enabled = true;
                    c.btnsave.Enabled = false;
                    try
                    {
                        DataGridViewRow dr = dataGridView1.SelectedRows[0];

                        c.txtitemid.Text = dr.Cells[0].Value.ToString();
                        c.txtitemname.Text = dr.Cells[1].Value.ToString();
                        c.cmucat.Text = dr.Cells[2].Value.ToString();
                        c.cmucom.Text = dr.Cells[3].Value.ToString();
                        c.txtitemdes.Text = dr.Cells[4].Value.ToString();
                        c.txtitemunit.Text = dr.Cells[5].Value.ToString();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else
            {
                if (cmutype.Text == "Item" && label1.Text == "Item")
                {
                    this.Hide();
                    FrmItem c = new FrmItem();
                    // c.Owner = this;
                    c.Show();
                    c.textBox1.Text = "item";
                    //  c.btndelete.Enabled = true;
                    c.btnupdate.Enabled = true;
                    c.btnsave.Enabled = false;
                    try
                    {
                        DataGridViewRow dr = dataGridView1.SelectedRows[0];

                        c.txtitemid.Text = dr.Cells[0].Value.ToString();
                        c.txtitemname.Text = dr.Cells[1].Value.ToString();
                        c.cmucat.Text = dr.Cells[2].Value.ToString();
                        c.cmucom.Text = dr.Cells[3].Value.ToString();
                        c.txtitemdes.Text = dr.Cells[4].Value.ToString();
                        c.txtitemunit.Text = dr.Cells[5].Value.ToString();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (cmutype.Text == "Item" && label1.Text == "Sales")
            {
                this.Hide();
                FrmSales c = new FrmSales();


                c.Show();
                try
                {
                    DataGridViewRow dr = dataGridView1.SelectedRows[0];

                    c.txtid.Text = dr.Cells[0].Value.ToString();
                    c.txtname.Text = dr.Cells[1].Value.ToString();
                    c.txtunit.Text = dr.Cells[5].Value.ToString();
                    c.txtprice.Text = dr.Cells[6].Value.ToString();
                    c.txtnet.Text = dr.Cells[7].Value.ToString();
                    c.txttype.Text = dr.Cells[8].Value.ToString();
                    c.txtd.Text = dr.Cells[9].Value.ToString();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (cmutype.Text == "Item" && label1.Text == "Saleprice")
            {
                this.Hide();
                Frmsaleprice c = new Frmsaleprice();
                c.Show();

                try
                {
                    DataGridViewRow dr = dataGridView1.SelectedRows[0];

                    c.id.Text = dr.Cells[0].Value.ToString();
                    c.name.Text = dr.Cells[1].Value.ToString();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (lbuname.Text == "Admin")
            {

                try
                {
                    if (cmutype.Text == "Brand")
                    {

                        this.Hide();
                        FrmUCompany c = new FrmUCompany();
                        c.Show();
                        c.btnupdate.Enabled = true;
                        c.btndelete.Enabled = true;
                        c.btnsave.Enabled = false;
                        if (dataGridView1.Rows.Count > 0)
                        {
                            DataGridViewRow dr = dataGridView1.SelectedRows[0];
                            c.txtUcomid.Text = dr.Cells[0].Value.ToString();
                            c.txtUcomname.Text = dr.Cells[1].Value.ToString();
                        }
                    }
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
                    if (cmutype.Text == "Brand")
                    {

                        this.Hide();
                        FrmUCompany c = new FrmUCompany();
                        c.Show();
                        c.btnupdate.Enabled = true;
                        // c.btndelete.Enabled = true;
                        c.btnsave.Enabled = false;
                        if (dataGridView1.Rows.Count > 0)
                        {
                            DataGridViewRow dr = dataGridView1.SelectedRows[0];
                            c.txtUcomid.Text = dr.Cells[0].Value.ToString();
                            c.txtUcomname.Text = dr.Cells[1].Value.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (lbuname.Text == "Admin")
            {
                if (cmutype.Text == "Category")
                {
                    this.Hide();
                    Frmcategory c = new Frmcategory();
                    c.Show();

                    c.btndelete.Enabled = true;
                    c.btnupdate.Enabled = true;
                    c.button1.Enabled = false;
                    try
                    {
                        DataGridViewRow dr = dataGridView1.SelectedRows[0];

                        c.txtcatid.Text = dr.Cells[0].Value.ToString();
                        c.txtcatdes.Text = dr.Cells[1].Value.ToString();
                        c.txtcatname.Text = dr.Cells[2].Value.ToString();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else
            {
                if (cmutype.Text == "Category")
                {
                    this.Hide();
                    Frmcategory c = new Frmcategory();
                    c.Show();

                    // c.btndelete.Enabled = true;
                    c.btnupdate.Enabled = true;
                    c.button1.Enabled = false;
                    try
                    {
                        DataGridViewRow dr = dataGridView1.SelectedRows[0];

                        c.txtcatid.Text = dr.Cells[0].Value.ToString();
                        c.txtcatdes.Text = dr.Cells[1].Value.ToString();
                        c.txtcatname.Text = dr.Cells[2].Value.ToString();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (cmutype.Text == "Item" && label1.Text == "Stock")
            {

                this.Hide();
                FrmPurchase c = new FrmPurchase();
                c.Show();
                c.txtInvoice.Text = label3.Text;
                if (dataGridView1.Rows.Count > 0)
                {
                    DataGridViewRow dr = dataGridView1.SelectedRows[0];
                    c.txtID.Text = dr.Cells[0].Value.ToString();
                    c.txtItem.Text = dr.Cells[1].Value.ToString();
                    c.txtCategory.Text = dr.Cells[2].Value.ToString();
                }
            }
        }
    }
}
