using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sales_And_Inventory_Management.SRV;
using Sales_And_Inventory_Management_Project1.Report;

namespace Sales_And_Inventory_Management_Project1
{
    public partial class FrmSalesPrint : Form
    {
        Sales add = new Sales();
        DataTable dt = new DataTable();
        public FrmSalesPrint()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                groupBox5.Text = "Search By Date";
                dateTimePicker1.Enabled = true;
                dateTimePicker3.Enabled = false;
                cmMonth.Enabled = false;
                cmYear.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Text = "Search By Month";
            groupBox5.Enabled = true;
            dateTimePicker1.Enabled = false;
            dateTimePicker3.Enabled = false;
            cmMonth.Enabled = true;
            cmMonth.Visible = true;
            cmYear.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            groupBox5.Text = "Search By Year";
            groupBox5.Enabled = true;
            cmMonth.Enabled=false ;
            cmYear.Visible = true;
            cmYear.Enabled = true;
        }

        private void cmYear_SelectedIndexChanged(object sender, EventArgs e)
        {
           // yearcount();
        }

        public void daily()
        {


            DataSet ds = add.daily(dateTimePicker1.Text);
            try
            {
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void period()
        {


            DataSet ds = add.period(dateTimePicker1.Text,dateTimePicker3.Text);
            try
            {
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            daily();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            period();

        }

     /*  public void yearcount()
        {
           
            string a = cmYear.Text;
           
           
            DataSet ds = add.yearly(a);
            try
            {
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
            
           
        }*/

        public void monthcount()
        {

            /*string a = cmMonth.Text;


            DataSet ds = add.monthly(a);
            try
            {
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/



        }

        private void cmMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthcount();
        }

        private void FrmSalesPrint_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.ShowAlways = true;


            toolTip1.SetToolTip(this.btnPrint, "Print(Ctrl+P) ");
            toolTip1.SetToolTip(this.button2, "Exit(Ctrl+E)");
        }

        private void PrintReport()
        {

            BillDataSet ds = new BillDataSet();// ur dataset

           CrystalReportYear rpt = new CrystalReportYear ();// ur crystal report

            FrmReportShow rptViewer = new FrmReportShow();// diaplay repor form





            try
            {
                double sum = 0;
                dt = add.yearlyReport(cmYear.Text);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        BillDataSet.DataTableYearRow row = ds.DataTableYear.NewDataTableYearRow();
                        row.MONTH = dataRow["m"].ToString();

                        row.TOTAL = dataRow["total"].ToString();
                        
                        sum += Convert.ToDouble(dataRow["total"].ToString());
                        row.DataColumn4 = sum.ToString();
                        row.DataColumn1 = "Annual Sales Report";
                        string yr = cmYear.Text;
                        row.DataColumn3 ="Year - "+ yr.ToString();
                        row.DataColumn2 = "Month";

                        //  row.DataColumn16 = dataRow["serial"].ToString();
                        //  row.DataColumn17 = "Outdoor-Patients' Visting Bill Report";


                        ds.DataTableYear.AddDataTableYearRow(row);
                    }

                    rptViewer.ShowReport(rpt, ds);

                }
            }
            catch (Exception )
            {

                MessageBox.Show("Informations are not available.", "Sale And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PrintReportDaily()
        {

            BillDataSet ds = new BillDataSet();// ur dataset

            CrystalReportDaily rpt = new CrystalReportDaily();// ur crystal report

            FrmReportShow rptViewer = new FrmReportShow();// diaplay repor form





            try
            {
                double sum = 0;
                dt = add.ReportDaily(dateTimePicker1.Text);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        BillDataSet.DataTableDayRow row = ds.DataTableDay.NewDataTableDayRow();
                        row.DATE = dataRow["date"].ToString();
                        row.ITEM = dataRow["id"].ToString();
                        row.NAME = dataRow["itemname"].ToString();
                      
                        row.QTY = dataRow["qty"].ToString();
                        row.PRICE = dataRow["p"].ToString();
                        row.STOTAL = dataRow["stotal"].ToString();
                      

                        sum += Convert.ToDouble(dataRow["stotal"].ToString());

                       row.TOTAL=sum.ToString();

                        //  row.DataColumn16 = dataRow["serial"].ToString();
                        //  row.DataColumn17 = "Outdoor-Patients' Visting Bill Report";


                        ds.DataTableDay.AddDataTableDayRow(row);
                    }

                    rptViewer.ShowReport(rpt, ds);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Informations are not available.", "Sale And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PrintReportPeriod()
        {

            BillDataSet ds = new BillDataSet();// ur dataset

            CrystalReportDaily rpt = new CrystalReportDaily();// ur crystal report

            FrmReportShow rptViewer = new FrmReportShow();// diaplay repor form





            try
            {
                double sum = 0;
                dt = add.ReportPeriod(dateTimePicker1.Text,dateTimePicker3.Text);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        BillDataSet.DataTableDayRow row = ds.DataTableDay.NewDataTableDayRow();
                        row.TIME = "From  " + dateTimePicker1.Text + "  To  " + dateTimePicker3.Text;
                        row.DATE = dataRow["date"].ToString();
                        row.ITEM = dataRow["id"].ToString();
                        row.NAME = dataRow["itemname"].ToString();

                        row.QTY = dataRow["qty"].ToString();
                        row.PRICE = dataRow["p"].ToString();
                        row.STOTAL = dataRow["stotal"].ToString();


                        sum += Convert.ToDouble(dataRow["stotal"].ToString());

                        row.TOTAL = sum.ToString();

                        //  row.DataColumn16 = dataRow["serial"].ToString();
                        //  row.DataColumn17 = "Outdoor-Patients' Visting Bill Report";


                        ds.DataTableDay.AddDataTableDayRow(row);
                    }

                    rptViewer.ShowReport(rpt, ds);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Informations are not available.", "Sale And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PrintReportMonthly()
        {

            BillDataSet ds = new BillDataSet();// ur dataset

            CrystalReportYear rpt = new CrystalReportYear();// ur crystal report

            FrmReportShow rptViewer = new FrmReportShow();// diaplay repor form





            try
            {
                double sum = 0;
                dt = add.MonthlyReport(cmYear.Text,cmMonth.Text);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        BillDataSet.DataTableYearRow row = ds.DataTableYear.NewDataTableYearRow();
                        row.MONTH = dataRow["date"].ToString();

                        row.TOTAL = dataRow["total"].ToString();

                        sum += Convert.ToDouble(dataRow["total"].ToString());
                        row.DataColumn4 = sum.ToString();
                        row.DataColumn1 = "Monthly Sales Report";
                        string yr = cmYear.Text;
                        row.DataColumn3 = "Month - "+ cmMonth.Text +", "+ yr.ToString();
                        row.DataColumn2 = "Date";

                        //  row.DataColumn16 = dataRow["serial"].ToString();
                        //  row.DataColumn17 = "Outdoor-Patients' Visting Bill Report";


                        ds.DataTableYear.AddDataTableYearRow(row);
                    }

                    rptViewer.ShowReport(rpt, ds);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Informations are not available.", "Sale And Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void print()
        {
            if (radioButton1.Checked == true)
            {
                PrintReportDaily();
            }
            if (radioButton5.Checked == true)
            {
                PrintReportPeriod();
            }

            if (radioButton4.Checked == true)
            {
                PrintReport();
            }

            if (radioButton3.Checked == true)
            {
                PrintReportMonthly();
            }
            
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {

            print();
           
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox2.Text = "Search By Date";
                dateTimePicker1.Enabled = true;
                dateTimePicker3.Enabled = false;
                cmMonth.Enabled = false;
                cmYear.Enabled = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                groupBox2.Text = "From Date";
                dateTimePicker1.Enabled = true;
                dateTimePicker3.Enabled = true;
                cmMonth.Enabled = false;
                cmYear.Enabled = false;
            }
        }

        private void cmMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSalesPrint_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == (Keys.Control | Keys.P))
            {
                print();
            }
            if (e.KeyData == (Keys.Control | Keys.S))
            {
                this.Close();
            }
        }
    }
}
