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
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FrmLogIn frm = new FrmLogIn();
            progressBar1.Visible = true;



            this.progressBar1.Value = this.progressBar1.Value + 2;
            if (this.progressBar1.Value == 10)
            {
                label2.Text = "Reading modules..";
            }
            else if (this.progressBar1.Value == 20)
            {
                label2.Text = "Turning on modules.";
            }
            else if (this.progressBar1.Value == 40)
            {
                label2.Text = "Starting modules..";
            }
            else if (this.progressBar1.Value == 60)
            {
                label2.Text = "Loading modules..";
            }
            else if (this.progressBar1.Value == 80)
            {
                label2.Text = "Done Loading modules..";
            }
            else if (this.progressBar1.Value == 100)
            {
                frm.Show();
                timer1.Enabled = false;
                this.Hide();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
