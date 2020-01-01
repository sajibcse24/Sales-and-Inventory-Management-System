namespace Sales_And_Inventory_Management_Project1
{
    partial class FrmItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItem));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbuname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtitemunit = new System.Windows.Forms.TextBox();
            this.txtitemdes = new System.Windows.Forms.TextBox();
            this.cmucom = new System.Windows.Forms.ComboBox();
            this.cmucat = new System.Windows.Forms.ComboBox();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.txtitemid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btngetdata = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbuname);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.txtitemunit);
            this.groupBox1.Controls.Add(this.txtitemdes);
            this.groupBox1.Controls.Add(this.cmucom);
            this.groupBox1.Controls.Add(this.cmucat);
            this.groupBox1.Controls.Add(this.txtitemname);
            this.groupBox1.Controls.Add(this.txtitemid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(23, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(503, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbuname
            // 
            this.lbuname.AutoSize = true;
            this.lbuname.Location = new System.Drawing.Point(400, 84);
            this.lbuname.Name = "lbuname";
            this.lbuname.Size = new System.Drawing.Size(16, 16);
            this.lbuname.TabIndex = 72;
            this.lbuname.Text = "d";
            this.lbuname.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(434, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(23, 23);
            this.textBox1.TabIndex = 18;
            this.textBox1.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(434, 14);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(23, 23);
            this.txtid.TabIndex = 17;
            this.txtid.Visible = false;
            // 
            // txtitemunit
            // 
            this.txtitemunit.Location = new System.Drawing.Point(135, 197);
            this.txtitemunit.Margin = new System.Windows.Forms.Padding(4);
            this.txtitemunit.Name = "txtitemunit";
            this.txtitemunit.Size = new System.Drawing.Size(122, 23);
            this.txtitemunit.TabIndex = 15;
            this.txtitemunit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtitemunit_KeyPress);
            // 
            // txtitemdes
            // 
            this.txtitemdes.Location = new System.Drawing.Point(135, 145);
            this.txtitemdes.Margin = new System.Windows.Forms.Padding(4);
            this.txtitemdes.Multiline = true;
            this.txtitemdes.Name = "txtitemdes";
            this.txtitemdes.Size = new System.Drawing.Size(268, 44);
            this.txtitemdes.TabIndex = 14;
            this.txtitemdes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtitemdes_KeyPress);
            // 
            // cmucom
            // 
            this.cmucom.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmucom.ForeColor = System.Drawing.Color.Black;
            this.cmucom.FormattingEnabled = true;
            this.cmucom.Location = new System.Drawing.Point(135, 111);
            this.cmucom.Margin = new System.Windows.Forms.Padding(4);
            this.cmucom.Name = "cmucom";
            this.cmucom.Size = new System.Drawing.Size(160, 26);
            this.cmucom.TabIndex = 13;
            this.cmucom.Text = "SELECT";
            this.cmucom.Click += new System.EventHandler(this.cmucom_Click);
            this.cmucom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmucom_KeyPress);
            // 
            // cmucat
            // 
            this.cmucat.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmucat.ForeColor = System.Drawing.Color.Black;
            this.cmucat.FormattingEnabled = true;
            this.cmucat.Location = new System.Drawing.Point(135, 74);
            this.cmucat.Margin = new System.Windows.Forms.Padding(4);
            this.cmucat.Name = "cmucat";
            this.cmucat.Size = new System.Drawing.Size(160, 26);
            this.cmucat.TabIndex = 12;
            this.cmucat.Text = "SELECT";
            this.cmucat.SelectedIndexChanged += new System.EventHandler(this.cmucat_SelectedIndexChanged_1);
            this.cmucat.Click += new System.EventHandler(this.cmucat_Click);
            this.cmucat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmucat_KeyPress);
            // 
            // txtitemname
            // 
            this.txtitemname.Location = new System.Drawing.Point(135, 46);
            this.txtitemname.Margin = new System.Windows.Forms.Padding(4);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(268, 23);
            this.txtitemname.TabIndex = 11;
            this.txtitemname.Click += new System.EventHandler(this.txtitemname_Click);
            this.txtitemname.CursorChanged += new System.EventHandler(this.txtitemname_CursorChanged);
            this.txtitemname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtitemname_KeyPress);
            // 
            // txtitemid
            // 
            this.txtitemid.Enabled = false;
            this.txtitemid.Location = new System.Drawing.Point(135, 14);
            this.txtitemid.Margin = new System.Windows.Forms.Padding(4);
            this.txtitemid.Name = "txtitemid";
            this.txtitemid.Size = new System.Drawing.Size(160, 23);
            this.txtitemid.TabIndex = 10;
            this.txtitemid.TextChanged += new System.EventHandler(this.txtitemid_TextChanged);
            this.txtitemid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtitemid_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Item Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btngetdata);
            this.groupBox2.Controls.Add(this.btndelete);
            this.groupBox2.Controls.Add(this.btnupdate);
            this.groupBox2.Controls.Add(this.btnsave);
            this.groupBox2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(23, 254);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(503, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(403, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btngetdata
            // 
            this.btngetdata.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btngetdata.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngetdata.Location = new System.Drawing.Point(303, 22);
            this.btngetdata.Margin = new System.Windows.Forms.Padding(4);
            this.btngetdata.Name = "btngetdata";
            this.btngetdata.Size = new System.Drawing.Size(93, 34);
            this.btngetdata.TabIndex = 0;
            this.btngetdata.Text = "&Get Data";
            this.btngetdata.UseVisualStyleBackColor = false;
            this.btngetdata.Click += new System.EventHandler(this.btngetdata_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btndelete.Enabled = false;
            this.btndelete.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(212, 22);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(83, 34);
            this.btndelete.TabIndex = 0;
            this.btndelete.Text = "&Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnupdate.Enabled = false;
            this.btnupdate.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(110, 22);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(92, 34);
            this.btnupdate.TabIndex = 0;
            this.btnupdate.Text = "&Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsave.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(11, 22);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(91, 34);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "&Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // FrmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(541, 336);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales and Inventory Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmItem_FormClosing);
            this.Load += new System.EventHandler(this.FrmItem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmItem_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btngetdata;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtitemunit;
        public System.Windows.Forms.TextBox txtitemdes;
        public System.Windows.Forms.ComboBox cmucom;
        public System.Windows.Forms.ComboBox cmucat;
        public System.Windows.Forms.TextBox txtitemname;
        public System.Windows.Forms.TextBox txtitemid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btndelete;
        public System.Windows.Forms.Button btnupdate;
        public System.Windows.Forms.Button btnsave;
        public System.Windows.Forms.Label lbuname;
    }
}