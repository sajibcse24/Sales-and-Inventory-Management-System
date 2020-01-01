using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Sales_And_Inventory_Management_Project1
{
    public partial class FrmReportShow : Form
    {
        public FrmReportShow()
        {
            InitializeComponent();
        }

        public void ShowReport(ReportClass rpt, DataSet ds)
        {
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            this.Show();
        }


        private void FrmReportShow_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
