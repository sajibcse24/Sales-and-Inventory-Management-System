namespace Sales_And_Inventory_Management_Project1
{
    partial class FrmChangepassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangepassword));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbuname = new System.Windows.Forms.Label();
            this.cmutype = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrepass = new System.Windows.Forms.TextBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtNpass = new System.Windows.Forms.TextBox();
            this.txtCpass = new System.Windows.Forms.TextBox();
            this.txtpuname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbuname);
            this.groupBox1.Controls.Add(this.cmutype);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrepass);
            this.groupBox1.Controls.Add(this.txtUname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbuname
            // 
            this.lbuname.AutoSize = true;
            this.lbuname.Location = new System.Drawing.Point(290, 18);
            this.lbuname.Name = "lbuname";
            this.lbuname.Size = new System.Drawing.Size(16, 16);
            this.lbuname.TabIndex = 70;
            this.lbuname.Text = "d";
            this.lbuname.Visible = false;
            // 
            // cmutype
            // 
            this.cmutype.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmutype.ForeColor = System.Drawing.Color.Maroon;
            this.cmutype.FormattingEnabled = true;
            this.cmutype.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmutype.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cmutype.Location = new System.Drawing.Point(144, 12);
            this.cmutype.Name = "cmutype";
            this.cmutype.Size = new System.Drawing.Size(113, 26);
            this.cmutype.TabIndex = 10;
            this.cmutype.Text = "SELECT ";
            this.cmutype.SelectedIndexChanged += new System.EventHandler(this.cmutype_SelectedIndexChanged);
            this.cmutype.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmutype_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "User Type";
            // 
            // txtPrepass
            // 
            this.txtPrepass.Location = new System.Drawing.Point(144, 72);
            this.txtPrepass.Name = "txtPrepass";
            this.txtPrepass.PasswordChar = '*';
            this.txtPrepass.Size = new System.Drawing.Size(211, 23);
            this.txtPrepass.TabIndex = 3;
            this.txtPrepass.TextChanged += new System.EventHandler(this.txtPrepass_TextChanged);
            this.txtPrepass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrepass_KeyPress);
            this.txtPrepass.Leave += new System.EventHandler(this.txtPrepass_Leave);
            // 
            // txtUname
            // 
            this.txtUname.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtUname.Location = new System.Drawing.Point(144, 43);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(211, 23);
            this.txtUname.TabIndex = 2;
            this.txtUname.TextChanged += new System.EventHandler(this.txtUname_TextChanged);
            this.txtUname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUname_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Old Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old User Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.txtNpass);
            this.groupBox2.Controls.Add(this.txtCpass);
            this.groupBox2.Controls.Add(this.txtpuname);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(361, 77);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtNpass
            // 
            this.txtNpass.Location = new System.Drawing.Point(144, 46);
            this.txtNpass.Name = "txtNpass";
            this.txtNpass.PasswordChar = '*';
            this.txtNpass.Size = new System.Drawing.Size(211, 23);
            this.txtNpass.TabIndex = 4;
            this.txtNpass.TextChanged += new System.EventHandler(this.txtNpass_TextChanged);
            this.txtNpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNpass_KeyPress);
            // 
            // txtCpass
            // 
            this.txtCpass.Location = new System.Drawing.Point(144, 72);
            this.txtCpass.Name = "txtCpass";
            this.txtCpass.PasswordChar = '*';
            this.txtCpass.Size = new System.Drawing.Size(211, 23);
            this.txtCpass.TabIndex = 4;
            this.txtCpass.TextChanged += new System.EventHandler(this.txtCpass_TextChanged);
            this.txtCpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpass_KeyPress);
            this.txtCpass.MouseLeave += new System.EventHandler(this.txtCpass_MouseLeave);
            // 
            // txtpuname
            // 
            this.txtpuname.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtpuname.Location = new System.Drawing.Point(144, 14);
            this.txtpuname.Name = "txtpuname";
            this.txtpuname.Size = new System.Drawing.Size(211, 23);
            this.txtpuname.TabIndex = 4;
            this.txtpuname.TextChanged += new System.EventHandler(this.txtpuname_TextChanged);
            this.txtpuname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpuname_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Confirm Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "New User Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(12, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 61);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(17, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Change Password";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(273, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmChangepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(419, 303);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChangepassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales and Inventory Management System";
            this.Load += new System.EventHandler(this.FrmChangepassword_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmChangepassword_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrepass;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNpass;
        private System.Windows.Forms.TextBox txtCpass;
        private System.Windows.Forms.TextBox txtpuname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.Label lbuname;
        public System.Windows.Forms.ComboBox cmutype;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}