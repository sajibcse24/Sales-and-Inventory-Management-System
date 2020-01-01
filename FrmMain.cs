using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales_And_Inventory_Management_Project1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void wordpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Wordpad.exe");
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("TaskMgr.exe");
        }

        private void mSWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Winword.exe");
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = System.DateTime.Now.ToString();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //progressBar1.Hide();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void userCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUCompany frm = new FrmUCompany();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void seaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPurchase add = new FrmPurchase();
            add.Show();
            add.dataGridView2.ClearSelection();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReg a = new FrmReg();
            a.Owner = this;
            a.Show();
          //  a.txtEmail.Focus();
           // a.lbuname.Text = lbuname.Text;

           
           
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogIn a = new FrmLogIn();
            a.Show();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSales frm = new FrmSales();
            frm.Owner = this;
            frm.Show();
            frm.txtid.Focus();
            frm.dataGridView2.ClearSelection();
        }

        private void companyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUCompany frm = new FrmUCompany();
           // frm.Owner = this;
            frm.Show();
            frm.lbuname.Text = lbuname.Text;
        }

        private void categoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmcategory frm = new Frmcategory();
            frm.Show();
            frm.txtcatname.Focus();
            frm.lbuname.Text = lbuname.Text;
          //  frm.Owner = this;

        }

        private void productToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmItem frm = new FrmItem();
            frm.Show();
        }

        private void productPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmsaleprice a = new Frmsaleprice();
            a.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmusercompanydetails frm = new Frmusercompanydetails();
            frm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogIn a = new FrmLogIn();
            a.Show();
            a.txtuname.Focus();

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stockToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSalesPrint s = new FrmSalesPrint();
            s.Show();
            s.radioButton3.Checked = false;
            s.groupBox5.Enabled = false;
        }

        private void productEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItem a = new FrmItem();
           // a.Owner = this;
            a.Show();
            a.lbuname.Text = lbuname.Text;
        }

        private void productPriceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frmsaleprice a = new Frmsaleprice();
            a.Show();
            a.dataGridView1.ClearSelection();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void productDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmdiscount m = new Frmdiscount();
            m.Show();
            m.lbuname.Text =lbuname.Text;
            m.dataGridView1.ClearSelection();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void changeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangepassword f = new FrmChangepassword();
            f.Show();
            if (lbuname.Text == "User")
            {
                f.cmutype.Enabled = false;
                f.cmutype.Text = "User";
               
            }
        }

        private void notepadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void calculatorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Wordpad.exe");
        }

        private void taskManagerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("TaskMgr.exe");
        }

        private void mSWordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Winword.exe");
        }
    }
}
