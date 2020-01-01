namespace Sales_And_Inventory_Management_Project1
{
    partial class FrmSales
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSales));
            this.btnprint = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Label11 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txttype = new System.Windows.Forms.TextBox();
            this.txtunit = new System.Windows.Forms.TextBox();
            this.txtd = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstotal = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtvat = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtnet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textamount = new System.Windows.Forms.TextBox();
            this.billingdate = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbdis = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtdue = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtpayment = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdis = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.m = new System.Windows.Forms.Label();
            this.lblday = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.txtinvoice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnprint.Enabled = false;
            this.btnprint.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(153, 19);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(106, 29);
            this.btnprint.TabIndex = 135;
            this.btnprint.Text = "&Print Invoice";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnprint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnprint_KeyDown);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnremove.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnremove.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(308, 17);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(86, 29);
            this.btnremove.TabIndex = 134;
            this.btnremove.Text = "Close";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(16, 258);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(70, 16);
            this.Label11.TabIndex = 89;
            this.Label11.Text = "Sale Qty.";
            this.Label11.Click += new System.EventHandler(this.Label11_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.label33);
            this.GroupBox1.Controls.Add(this.textBox3);
            this.GroupBox1.Controls.Add(this.label32);
            this.GroupBox1.Controls.Add(this.label8);
            this.GroupBox1.Controls.Add(this.label31);
            this.GroupBox1.Controls.Add(this.label30);
            this.GroupBox1.Controls.Add(this.label29);
            this.GroupBox1.Controls.Add(this.label16);
            this.GroupBox1.Controls.Add(this.label15);
            this.GroupBox1.Controls.Add(this.label14);
            this.GroupBox1.Controls.Add(this.label10);
            this.GroupBox1.Controls.Add(this.txttype);
            this.GroupBox1.Controls.Add(this.txtunit);
            this.GroupBox1.Controls.Add(this.txtd);
            this.GroupBox1.Controls.Add(this.label26);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.txtdiscount);
            this.GroupBox1.Controls.Add(this.btnadd);
            this.GroupBox1.Controls.Add(this.txtid);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.txtstotal);
            this.GroupBox1.Controls.Add(this.txtprice);
            this.GroupBox1.Controls.Add(this.txtname);
            this.GroupBox1.Controls.Add(this.txtvat);
            this.GroupBox1.Controls.Add(this.label17);
            this.GroupBox1.Controls.Add(this.label25);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.txtquantity);
            this.GroupBox1.Controls.Add(this.Label12);
            this.GroupBox1.Controls.Add(this.txtnet);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.GroupBox1.Location = new System.Drawing.Point(28, 72);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(476, 387);
            this.GroupBox1.TabIndex = 131;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Item Details";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Enabled = false;
            this.label33.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Maroon;
            this.label33.Location = new System.Drawing.Point(278, 17);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(38, 16);
            this.label33.TabIndex = 152;
            this.label33.Text = "year";
            this.label33.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(159, 291);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(59, 23);
            this.textBox3.TabIndex = 115;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(227, 227);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(31, 16);
            this.label32.TabIndex = 114;
            this.label32.Text = "TK.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 16);
            this.label8.TabIndex = 151;
            this.label8.Text = "Available Quantity";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(206, 200);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(0, 16);
            this.label31.TabIndex = 113;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(17, 229);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(62, 16);
            this.label30.TabIndex = 112;
            this.label30.Text = "Balance";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(206, 132);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(31, 16);
            this.label29.TabIndex = 111;
            this.label29.Text = "TK.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(263, 324);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 16);
            this.label16.TabIndex = 106;
            this.label16.Text = "TK.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(260, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 16);
            this.label15.TabIndex = 105;
            this.label15.Text = "TK.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 16);
            this.label14.TabIndex = 104;
            this.label14.Text = "Balance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(169, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 16);
            this.label10.TabIndex = 103;
            this.label10.Text = "%";
            // 
            // txttype
            // 
            this.txttype.Enabled = false;
            this.txttype.Location = new System.Drawing.Point(124, 162);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(132, 23);
            this.txttype.TabIndex = 102;
            this.txttype.TextChanged += new System.EventHandler(this.txttype_TextChanged);
            // 
            // txtunit
            // 
            this.txtunit.Enabled = false;
            this.txtunit.Location = new System.Drawing.Point(198, 255);
            this.txtunit.Name = "txtunit";
            this.txtunit.Size = new System.Drawing.Size(44, 23);
            this.txtunit.TabIndex = 101;
            // 
            // txtd
            // 
            this.txtd.Enabled = false;
            this.txtd.Location = new System.Drawing.Point(125, 197);
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(64, 23);
            this.txtd.TabIndex = 100;
            this.txtd.TextChanged += new System.EventHandler(this.txtd_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(16, 324);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(62, 16);
            this.label26.TabIndex = 77;
            this.label26.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 96;
            this.label2.Text = "Discount";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtdiscount
            // 
            this.txtdiscount.Enabled = false;
            this.txtdiscount.Location = new System.Drawing.Point(125, 224);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(94, 23);
            this.txtdiscount.TabIndex = 103;
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnadd.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Black;
            this.btnadd.Location = new System.Drawing.Point(124, 354);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(105, 27);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "&Add To Cart";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.Button7_Click);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(125, 16);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(132, 23);
            this.txtid.TabIndex = 95;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged_1);
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 94;
            this.label1.Text = "Item Id";
            // 
            // txtstotal
            // 
            this.txtstotal.Enabled = false;
            this.txtstotal.Location = new System.Drawing.Point(124, 321);
            this.txtstotal.Name = "txtstotal";
            this.txtstotal.Size = new System.Drawing.Size(133, 23);
            this.txtstotal.TabIndex = 97;
            this.txtstotal.TextChanged += new System.EventHandler(this.txtstotal_TextChanged);
            this.txtstotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstotal_KeyPress);
            this.txtstotal.Leave += new System.EventHandler(this.txtstotal_Leave);
            // 
            // txtprice
            // 
            this.txtprice.Enabled = false;
            this.txtprice.Location = new System.Drawing.Point(124, 73);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(119, 23);
            this.txtprice.TabIndex = 91;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Location = new System.Drawing.Point(125, 46);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(169, 23);
            this.txtname.TabIndex = 90;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged_1);
            // 
            // txtvat
            // 
            this.txtvat.Enabled = false;
            this.txtvat.Location = new System.Drawing.Point(124, 128);
            this.txtvat.Name = "txtvat";
            this.txtvat.Size = new System.Drawing.Size(76, 23);
            this.txtvat.TabIndex = 0;
            this.txtvat.TextChanged += new System.EventHandler(this.txtvat_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 165);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 16);
            this.label17.TabIndex = 100;
            this.label17.Text = "Discount type";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(16, 102);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 16);
            this.label25.TabIndex = 90;
            this.label25.Text = "VAT";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(16, 49);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(83, 16);
            this.Label5.TabIndex = 74;
            this.Label5.Text = "Item Name";
            this.Label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(128, 255);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(61, 23);
            this.txtquantity.TabIndex = 92;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            this.txtquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantity_KeyPress);
            this.txtquantity.Leave += new System.EventHandler(this.txtquantity_Leave);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(16, 76);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(77, 16);
            this.Label12.TabIndex = 87;
            this.Label12.Text = "Unit Price";
            this.Label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // txtnet
            // 
            this.txtnet.Enabled = false;
            this.txtnet.Location = new System.Drawing.Point(125, 99);
            this.txtnet.MaxLength = 3;
            this.txtnet.Name = "txtnet";
            this.txtnet.Size = new System.Drawing.Size(38, 23);
            this.txtnet.TabIndex = 99;
            this.txtnet.TextChanged += new System.EventHandler(this.txtnet_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(288, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(14, 23);
            this.button1.TabIndex = 98;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textamount
            // 
            this.textamount.Enabled = false;
            this.textamount.Location = new System.Drawing.Point(702, 14);
            this.textamount.Name = "textamount";
            this.textamount.Size = new System.Drawing.Size(26, 20);
            this.textamount.TabIndex = 92;
            this.textamount.Visible = false;
            this.textamount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // billingdate
            // 
            this.billingdate.CustomFormat = "dd/MMM/yyyy";
            this.billingdate.Enabled = false;
            this.billingdate.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.billingdate.Location = new System.Drawing.Point(167, 7);
            this.billingdate.Name = "billingdate";
            this.billingdate.Size = new System.Drawing.Size(109, 22);
            this.billingdate.TabIndex = 126;
            this.billingdate.ValueChanged += new System.EventHandler(this.billingdate_ValueChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(121, 11);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(40, 16);
            this.Label3.TabIndex = 124;
            this.Label3.Text = "Date";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.Color.LightGray;
            this.Label13.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.Color.Maroon;
            this.Label13.Location = new System.Drawing.Point(30, 9);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(63, 19);
            this.Label13.TabIndex = 120;
            this.Label13.Text = "Billing";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 465);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 199);
            this.groupBox2.TabIndex = 138;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 15);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(464, 176);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item ID";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Name";
            this.columnHeader2.Width = 197;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 84;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total (TK.)";
            this.columnHeader5.Width = 100;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsave.Location = new System.Drawing.Point(7, 19);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 29);
            this.btnsave.TabIndex = 141;
            this.btnsave.Text = "&Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbdis);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.txtdue);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtpayment);
            this.groupBox3.Controls.Add(this.txtamount);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(510, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 147);
            this.groupBox3.TabIndex = 142;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lbdis
            // 
            this.lbdis.AutoSize = true;
            this.lbdis.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdis.ForeColor = System.Drawing.Color.Black;
            this.lbdis.Location = new System.Drawing.Point(292, 46);
            this.lbdis.Name = "lbdis";
            this.lbdis.Size = new System.Drawing.Size(41, 16);
            this.lbdis.TabIndex = 151;
            this.lbdis.Text = "lvdis";
            this.lbdis.Visible = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(201, 79);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(31, 16);
            this.label28.TabIndex = 110;
            this.label28.Text = "TK.";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(201, 46);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(31, 16);
            this.label27.TabIndex = 109;
            this.label27.Text = "TK.";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(228, 108);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(31, 16);
            this.label24.TabIndex = 108;
            this.label24.Text = "TK.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(228, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 16);
            this.label19.TabIndex = 107;
            this.label19.Text = "TK.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 106;
            this.label4.Text = "Exchange";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(114, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 23);
            this.textBox2.TabIndex = 105;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtdue
            // 
            this.txtdue.Enabled = false;
            this.txtdue.Location = new System.Drawing.Point(112, 105);
            this.txtdue.Name = "txtdue";
            this.txtdue.Size = new System.Drawing.Size(109, 23);
            this.txtdue.TabIndex = 104;
            this.txtdue.TextChanged += new System.EventHandler(this.txtdue_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(4, 109);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 16);
            this.label18.TabIndex = 96;
            this.label18.Text = "Total Payment";
            // 
            // txtpayment
            // 
            this.txtpayment.Location = new System.Drawing.Point(114, 46);
            this.txtpayment.Name = "txtpayment";
            this.txtpayment.Size = new System.Drawing.Size(81, 23);
            this.txtpayment.TabIndex = 1;
            this.txtpayment.TextChanged += new System.EventHandler(this.txtTotalPayment_TextChanged);
            this.txtpayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpayment_KeyPress);
            this.txtpayment.Leave += new System.EventHandler(this.txtpayment_Leave);
            // 
            // txtamount
            // 
            this.txtamount.Enabled = false;
            this.txtamount.Location = new System.Drawing.Point(112, 17);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(109, 23);
            this.txtamount.TabIndex = 93;
            this.txtamount.TextChanged += new System.EventHandler(this.txtamount_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 49);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 16);
            this.label20.TabIndex = 95;
            this.label20.Text = "Total Paid";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(4, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(102, 16);
            this.label23.TabIndex = 76;
            this.label23.Text = "Total Amount";
            this.label23.Click += new System.EventHandler(this.Label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(863, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 102;
            this.label9.Text = "%";
            this.label9.Visible = false;
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // txtdis
            // 
            this.txtdis.Location = new System.Drawing.Point(733, 13);
            this.txtdis.Name = "txtdis";
            this.txtdis.Size = new System.Drawing.Size(29, 20);
            this.txtdis.TabIndex = 101;
            this.txtdis.Visible = false;
            this.txtdis.TextChanged += new System.EventHandler(this.txtdis_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Maroon;
            this.label22.Location = new System.Drawing.Point(827, 3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(20, 16);
            this.label22.TabIndex = 92;
            this.label22.Text = "%";
            this.label22.Visible = false;
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnsave);
            this.groupBox4.Controls.Add(this.btnremove);
            this.groupBox4.Controls.Add(this.btnprint);
            this.groupBox4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(510, 474);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 56);
            this.groupBox4.TabIndex = 143;
            this.groupBox4.TabStop = false;
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Enabled = false;
            this.m.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m.ForeColor = System.Drawing.Color.Maroon;
            this.m.Location = new System.Drawing.Point(768, 15);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(53, 16);
            this.m.TabIndex = 144;
            this.m.Text = "month";
            this.m.Visible = false;
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Enabled = false;
            this.lblday.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblday.ForeColor = System.Drawing.Color.Maroon;
            this.lblday.Location = new System.Drawing.Point(650, 9);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(32, 16);
            this.lblday.TabIndex = 145;
            this.lblday.Text = "day";
            this.lblday.Visible = false;
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Enabled = false;
            this.y.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y.ForeColor = System.Drawing.Color.Maroon;
            this.y.Location = new System.Drawing.Point(558, 18);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(38, 16);
            this.y.TabIndex = 146;
            this.y.Text = "year";
            this.y.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(291, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 147;
            this.label6.Text = "Time";
            // 
            // time
            // 
            this.time.Enabled = false;
            this.time.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time.Location = new System.Drawing.Point(340, 9);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(109, 23);
            this.time.TabIndex = 148;
            // 
            // txtinvoice
            // 
            this.txtinvoice.Enabled = false;
            this.txtinvoice.Location = new System.Drawing.Point(149, 46);
            this.txtinvoice.Name = "txtinvoice";
            this.txtinvoice.Size = new System.Drawing.Size(71, 20);
            this.txtinvoice.TabIndex = 149;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(31, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 150;
            this.label7.Text = "Invoice No";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataGridView2);
            this.groupBox7.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox7.Location = new System.Drawing.Point(510, 142);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(283, 173);
            this.groupBox7.TabIndex = 151;
            this.groupBox7.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(251, 148);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(545, 91);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 153;
            this.label21.Text = "Search";
            this.label21.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.Color.DimGray;
            this.textBox4.Location = new System.Drawing.Point(548, 117);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(162, 20);
            this.textBox4.TabIndex = 152;
            this.textBox4.Text = "Search Item By ID/Name";
            this.textBox4.Click += new System.EventHandler(this.textBox4_Click);
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.CancelButton = this.btnremove;
            this.ClientSize = new System.Drawing.Size(970, 667);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtinvoice);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.y);
            this.Controls.Add(this.lblday);
            this.Controls.Add(this.m);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textamount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.billingdate);
            this.Controls.Add(this.txtdis);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label13);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales and Inventory Management  System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSales_FormClosing);
            this.Load += new System.EventHandler(this.FrmSales_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSales_KeyDown);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnprint;
        internal System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnadd;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.DateTimePicker billingdate;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label13;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtname;
        public System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox textamount;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtstotal;
        internal System.Windows.Forms.Label label25;
        internal System.Windows.Forms.TextBox txtvat;
        internal System.Windows.Forms.TextBox txtdue;
        private System.Windows.Forms.TextBox txtdiscount;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdis;
        internal System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtamount;
        internal System.Windows.Forms.TextBox txtpayment;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.Label label22;
        internal System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label m;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker time;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label29;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label28;
        internal System.Windows.Forms.Label label27;
        internal System.Windows.Forms.Label label24;
        internal System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        internal System.Windows.Forms.Label label31;
        internal System.Windows.Forms.Label label30;
        internal System.Windows.Forms.Label label32;
        public System.Windows.Forms.TextBox txtprice;
        public System.Windows.Forms.TextBox txtnet;
        public System.Windows.Forms.TextBox txtd;
        public System.Windows.Forms.TextBox txtunit;
        public System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.TextBox txtinvoice;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label lbdis;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label33;
    }
}