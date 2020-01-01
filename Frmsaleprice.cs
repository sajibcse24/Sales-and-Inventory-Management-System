using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using Sales_And_Inventory_Management.SRV;

namespace Sales_And_Inventory_Management_Project1
{
    public partial class Frmsaleprice : Form
    {
        public Frmsaleprice()
        {
            InitializeComponent();
        }
        Salesprice add = new Salesprice();

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmusercompanydetails add = new Frmusercompanydetails();
            add.Show();
            add.cmutype.Text = "Item";
            add.cmutype.Enabled = false;
            add.label1.Text = "Saleprice";
        }
        public void searchinfo()
        {
            string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
            SqlConnection myconnection = new SqlConnection(str);
            string Query = "select itemid as [Item ID],itemname as[Item Name] from [item] where itemid='" + id.Text + "'order by itemid ";
            SqlDataAdapter myDA = new SqlDataAdapter(Query, str);
            DataSet myDataSet = new DataSet();
            myDA.Fill(myDataSet, "item");
            }
        private void loadinfo()
        {
            string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
            SqlConnection myconnection = new SqlConnection(str);
            string Query = "select itemid as[Item ID],itemname as [Item Name],price as[Price],vat as[VAT (%)] from [price] inner join item on price.id=item.itemid order by price.id ";
            SqlDataAdapter myDA = new SqlDataAdapter(Query, str);
            DataSet myDataSet = new DataSet();
            myDA.Fill(myDataSet, "price");

            dataGridView1.DataSource = myDataSet.Tables["price"].DefaultView;
        }
        private void Frmsaleprice_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            loadinfo();
            searchinfo();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.button1, "Save (Ctrl+S) ");
            toolTip1.SetToolTip(this.btnupdate, "Update (Ctrl+U)");
            
            toolTip1.SetToolTip(this.button2, "Exit (ESC)");
           
        }
        public void RefreshObject()
        {
            add.Name =name.Text;
            add.Id = id.Text;
            add.Price = price.Text;
            add.Vat = txtvat.Text;
        }
        public void idinfo()
        {
            DataTable dt = new DataTable();
            String itemid = Convert.ToString(id.Text);
            add.Id = id.Text;
            dt = add.idinfo(itemid);
            int j = dt.Rows.Count;
            if (j != 0)
            {
                for (int i = 0; i < j; i++)
                {

                   id.Text = dt.Rows[i]["itemid"].ToString();
                   name.Text = dt.Rows[i]["itemname"].ToString();

                }

            }
            else
            {
                MessageBox.Show("Information is not exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)8)
            {
                e.Handled = false;

            }

            if (e.KeyChar == (char)13)
            {
                idinfo();
                price.Focus();
            }
        }
        public void loadid()
        {
            DataTable dt = new DataTable();
            dt = add.Loadidinfo();
            int j = dt.Rows.Count;
            {
                for (int i = 0; i < j; i++)
                {

                    id.Text = dt.Rows[i]["id"].ToString();

                }
             
            }

        }

        public void checkinfo()
        {
            DataTable dt = new DataTable();
            string itemid = Convert.ToString(id.Text);
            add.Id = id.Text;
            dt = add.Iteminfo(itemid);
            int j = dt.Rows.Count;

            if (j == 0)
            {

                add.Insert();

                MessageBox.Show("Information saved successfully.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                name.Focus();
                loadinfo();
                loadid();
                id.Focus();
                id.Text = "";
                name.Text = "";
                price.Text = "";
                txtvat.Text = "";


            }
            else
            {
                MessageBox.Show("Data already exist.", "UnSuccessful Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                id.Focus();
                id.Text = "";
                name.Text = "";
                price.Text = "";
                txtvat.Text = "";
            
            }
        }
        public void save()
        {
           

            if (id.Text == "")
            {

                MessageBox.Show("Please enter  Item Id!");
                id.Focus();
                return;
            }
            if (name.Text == "")
            {

                MessageBox.Show("Please enter Item Name !");
                name.Focus();
                return;


            }
            if (price.Text == "")
            {

                MessageBox.Show("Please enter Item Price!");
                price.Focus();
                return;


            }
            if (txtvat.Text == "")
            {

                MessageBox.Show("Please enter  Vat!");
                txtvat.Focus();
                return;
            }
            RefreshObject();
            try
            {

                checkinfo();



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Can't Save.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            save();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                id.Text = dr.Cells[0].Value.ToString();
                name.Text = dr.Cells[1].Value.ToString();
                price.Text = dr.Cells[2].Value.ToString();
                txtvat.Text = dr.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        public void updatecinfo()
        {

            try
            {


                {
                    add.Id = id.Text;
                    add.Name = name.Text;
                    add.Price =price.Text;
                    add.Vat = txtvat.Text;


                    add.UpdateDiscountinfo();
                    MessageBox.Show("Information successfully updated", "Update Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    loadinfo();
                    dataGridView1.ClearSelection();
                    id.Focus();
                    id.Text = "" ;
                    name.Text="";
                    price.Text="";
                    txtvat.Text="";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Can't updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (id.Text == "")
            {

                MessageBox.Show("Please enter  Item Id!");
                id.Focus();
                return;
            }
            if (name.Text == "")
            {

                MessageBox.Show("Please enter Item Name !");
                name.Focus();
                return;


            }
            updatecinfo();
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
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
            if(e.KeyChar==(char)13)
            {
                txtvat.Focus();
            }
        }

        private void price_TextChanged(object sender, EventArgs e)
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

        private void price_Leave(object sender, EventArgs e)
        {
            string a = price.Text;
            if (a != "")
            {
                double b = Convert.ToDouble(a);
                price.Text = String.Format("{0:0.00}", b);
            }
        }

        private void txtvat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtvat_TextChanged(object sender, EventArgs e)
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

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            label12.Visible = true;
            label12.Text = "Search Item By ID/Name";
        }

        private void searchinfo1()
        {
            string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
            SqlConnection myconnection = new SqlConnection(str);
            string Query = "select itemid as[Item ID],itemname as [Item Name],price as[Price],vat as[VAT (%)] from [price] inner join item on price.id=item.itemid  where itemid like '" + textBox4.Text + "%'   or itemname like '" + textBox4.Text + "%'order by itemid,itemname ";
            SqlDataAdapter myDA = new SqlDataAdapter(Query, str);
            DataSet myDataSet = new DataSet();
            myDA.Fill(myDataSet, "item");

            dataGridView1.DataSource = myDataSet.Tables["item"].DefaultView;
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            searchinfo1();
            dataGridView1.ClearSelection();
        }

        private void Frmsaleprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.S))
            {
                save();
            }
            if (e.KeyData == (Keys.Control | Keys.U))
            {
                if (id.Text == "")
                {

                    MessageBox.Show("Please enter  Item Id!");
                    id.Focus();
                    return;
                }
                if (name.Text == "")
                {

                    MessageBox.Show("Please enter Item Name !");
                    name.Focus();
                    return;


                }
                updatecinfo();
            }
         
            
        }
    }
}
