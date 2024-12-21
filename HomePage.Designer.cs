namespace PET_Shop_1
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_empname = new Guna.UI2.WinForms.Guna2Button();
            this.btn_product = new Guna.UI2.WinForms.Guna2Button();
            this.btn_logout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_billing = new Guna.UI2.WinForms.Guna2Button();
            this.btn_customer = new Guna.UI2.WinForms.Guna2Button();
            this.btn_employee = new Guna.UI2.WinForms.Guna2Button();
            this.btn_home = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_closelogin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnl_dog = new System.Windows.Forms.Panel();
            this.lbl_dog = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_cat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_bird = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lbl_Financial = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_dogs = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_birds = new System.Windows.Forms.Label();
            this.lbl_cats = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_closelogin)).BeginInit();
            this.pnl_dog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.guna2CircleProgressBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_empname);
            this.panel1.Controls.Add(this.btn_product);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_billing);
            this.panel1.Controls.Add(this.btn_customer);
            this.panel1.Controls.Add(this.btn_employee);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 642);
            this.panel1.TabIndex = 0;
            // 
            // btn_empname
            // 
            this.btn_empname.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_empname.BorderRadius = 10;
            this.btn_empname.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_empname.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_empname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_empname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_empname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.btn_empname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empname.ForeColor = System.Drawing.Color.Black;
            this.btn_empname.Image = ((System.Drawing.Image)(resources.GetObject("btn_empname.Image")));
            this.btn_empname.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_empname.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_empname.Location = new System.Drawing.Point(12, 27);
            this.btn_empname.Name = "btn_empname";
            this.btn_empname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_empname.Size = new System.Drawing.Size(180, 37);
            this.btn_empname.TabIndex = 13;
            this.btn_empname.Text = "EmpName";
            this.btn_empname.Click += new System.EventHandler(this.btn_empname_Click);
            // 
            // btn_product
            // 
            this.btn_product.BorderRadius = 10;
            this.btn_product.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_product.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_product.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_product.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_product.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_product.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btn_product.ForeColor = System.Drawing.Color.White;
            this.btn_product.Image = ((System.Drawing.Image)(resources.GetObject("btn_product.Image")));
            this.btn_product.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_product.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_product.Location = new System.Drawing.Point(12, 230);
            this.btn_product.Name = "btn_product";
            this.btn_product.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_product.Size = new System.Drawing.Size(180, 37);
            this.btn_product.TabIndex = 12;
            this.btn_product.Text = "Product";
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BorderRadius = 10;
            this.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_logout.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_logout.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_logout.Location = new System.Drawing.Point(12, 478);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_logout.Size = new System.Drawing.Size(180, 37);
            this.btn_logout.TabIndex = 11;
            this.btn_logout.Text = "Logout";
            this.btn_logout.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btn_billing
            // 
            this.btn_billing.BorderRadius = 10;
            this.btn_billing.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_billing.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_billing.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_billing.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_billing.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_billing.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_billing.ForeColor = System.Drawing.Color.White;
            this.btn_billing.Image = ((System.Drawing.Image)(resources.GetObject("btn_billing.Image")));
            this.btn_billing.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_billing.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_billing.Location = new System.Drawing.Point(12, 420);
            this.btn_billing.Name = "btn_billing";
            this.btn_billing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_billing.Size = new System.Drawing.Size(180, 37);
            this.btn_billing.TabIndex = 10;
            this.btn_billing.Text = "Billing";
            this.btn_billing.Click += new System.EventHandler(this.btn_billing_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.BorderRadius = 10;
            this.btn_customer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_customer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_customer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_customer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_customer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_customer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer.ForeColor = System.Drawing.Color.White;
            this.btn_customer.Image = ((System.Drawing.Image)(resources.GetObject("btn_customer.Image")));
            this.btn_customer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_customer.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_customer.Location = new System.Drawing.Point(12, 361);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_customer.Size = new System.Drawing.Size(180, 37);
            this.btn_customer.TabIndex = 9;
            this.btn_customer.Text = "Customer";
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_employee
            // 
            this.btn_employee.BorderRadius = 10;
            this.btn_employee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_employee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_employee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_employee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_employee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_employee.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btn_employee.ForeColor = System.Drawing.Color.White;
            this.btn_employee.Image = ((System.Drawing.Image)(resources.GetObject("btn_employee.Image")));
            this.btn_employee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_employee.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_employee.Location = new System.Drawing.Point(12, 298);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_employee.Size = new System.Drawing.Size(180, 37);
            this.btn_employee.TabIndex = 8;
            this.btn_employee.Text = "Employee";
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            // 
            // btn_home
            // 
            this.btn_home.BorderRadius = 10;
            this.btn_home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_home.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btn_home.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_home.Location = new System.Drawing.Point(12, 160);
            this.btn_home.Name = "btn_home";
            this.btn_home.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_home.Size = new System.Drawing.Size(180, 37);
            this.btn_home.TabIndex = 7;
            this.btn_home.Text = "Home";
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeftSize = new System.Drawing.Size(50, 50);
            this.guna2TextBox1.IconRightSize = new System.Drawing.Size(80, 80);
            this.guna2TextBox1.Location = new System.Drawing.Point(244, 14);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(650, 195);
            this.guna2TextBox1.TabIndex = 1;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // btn_closelogin
            // 
            this.btn_closelogin.Image = ((System.Drawing.Image)(resources.GetObject("btn_closelogin.Image")));
            this.btn_closelogin.Location = new System.Drawing.Point(728, 83);
            this.btn_closelogin.Name = "btn_closelogin";
            this.btn_closelogin.Size = new System.Drawing.Size(139, 126);
            this.btn_closelogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_closelogin.TabIndex = 2;
            this.btn_closelogin.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to pet shop";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(364, 131);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 57);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "We serve you with high quality service and nice care to your pet";
            // 
            // pnl_dog
            // 
            this.pnl_dog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pnl_dog.Controls.Add(this.lbl_dogs);
            this.pnl_dog.Controls.Add(this.label7);
            this.pnl_dog.Controls.Add(this.lbl_dog);
            this.pnl_dog.Controls.Add(this.label3);
            this.pnl_dog.Controls.Add(this.label2);
            this.pnl_dog.Controls.Add(this.guna2PictureBox1);
            this.pnl_dog.Location = new System.Drawing.Point(260, 331);
            this.pnl_dog.Name = "pnl_dog";
            this.pnl_dog.Size = new System.Drawing.Size(242, 100);
            this.pnl_dog.TabIndex = 6;
            // 
            // lbl_dog
            // 
            this.lbl_dog.AutoSize = true;
            this.lbl_dog.ForeColor = System.Drawing.Color.White;
            this.lbl_dog.Location = new System.Drawing.Point(34, 12);
            this.lbl_dog.Name = "lbl_dog";
            this.lbl_dog.Size = new System.Drawing.Size(47, 19);
            this.lbl_dog.TabIndex = 3;
            this.lbl_dog.Text = "Dogs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 47);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(87, 50);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.lbl_cats);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lbl_cat);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.guna2PictureBox2);
            this.panel2.Location = new System.Drawing.Point(585, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 100);
            this.panel2.TabIndex = 7;
            // 
            // lbl_cat
            // 
            this.lbl_cat.AutoSize = true;
            this.lbl_cat.ForeColor = System.Drawing.Color.White;
            this.lbl_cat.Location = new System.Drawing.Point(34, 12);
            this.lbl_cat.Name = "lbl_cat";
            this.lbl_cat.Size = new System.Drawing.Size(42, 19);
            this.lbl_cat.TabIndex = 3;
            this.lbl_cat.Text = "Cats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(0, 50);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(87, 50);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.lbl_birds);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.lbl_bird);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.guna2PictureBox3);
            this.panel3.Location = new System.Drawing.Point(260, 507);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 100);
            this.panel3.TabIndex = 7;
            // 
            // lbl_bird
            // 
            this.lbl_bird.AutoSize = true;
            this.lbl_bird.ForeColor = System.Drawing.Color.White;
            this.lbl_bird.Location = new System.Drawing.Point(34, 12);
            this.lbl_bird.Name = "lbl_bird";
            this.lbl_bird.Size = new System.Drawing.Size(44, 19);
            this.lbl_bird.TabIndex = 3;
            this.lbl_bird.Text = "Birds";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "label9";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(5, 47);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(87, 50);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 0;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.Controls.Add(this.lbl_Financial);
            this.guna2CircleProgressBar1.FillColor = System.Drawing.Color.DarkKhaki;
            this.guna2CircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(636, 461);
            this.guna2CircleProgressBar1.Minimum = 0;
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.DarkKhaki;
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.FloralWhite;
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(162, 162);
            this.guna2CircleProgressBar1.TabIndex = 8;
            this.guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.Value = 100;
            // 
            // lbl_Financial
            // 
            this.lbl_Financial.AutoSize = true;
            this.lbl_Financial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Financial.ForeColor = System.Drawing.Color.White;
            this.lbl_Financial.Location = new System.Drawing.Point(48, 67);
            this.lbl_Financial.Name = "lbl_Financial";
            this.lbl_Financial.Size = new System.Drawing.Size(37, 28);
            this.lbl_Financial.TabIndex = 4;
            this.lbl_Financial.Text = "Rs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "label7";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "label10";
            // 
            // lbl_dogs
            // 
            this.lbl_dogs.AutoSize = true;
            this.lbl_dogs.ForeColor = System.Drawing.Color.Silver;
            this.lbl_dogs.Location = new System.Drawing.Point(136, 41);
            this.lbl_dogs.Name = "lbl_dogs";
            this.lbl_dogs.Size = new System.Drawing.Size(47, 19);
            this.lbl_dogs.TabIndex = 5;
            this.lbl_dogs.Text = "Dogs";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(118, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 19);
            this.label12.TabIndex = 6;
            this.label12.Text = "label12";
            // 
            // lbl_birds
            // 
            this.lbl_birds.AutoSize = true;
            this.lbl_birds.ForeColor = System.Drawing.Color.Silver;
            this.lbl_birds.Location = new System.Drawing.Point(136, 43);
            this.lbl_birds.Name = "lbl_birds";
            this.lbl_birds.Size = new System.Drawing.Size(44, 19);
            this.lbl_birds.TabIndex = 7;
            this.lbl_birds.Text = "Birds";
            // 
            // lbl_cats
            // 
            this.lbl_cats.AutoSize = true;
            this.lbl_cats.ForeColor = System.Drawing.Color.Silver;
            this.lbl_cats.Location = new System.Drawing.Point(110, 60);
            this.lbl_cats.Name = "lbl_cats";
            this.lbl_cats.Size = new System.Drawing.Size(36, 19);
            this.lbl_cats.TabIndex = 6;
            this.lbl_cats.Text = "Cat";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(854, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(905, 642);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.guna2CircleProgressBar1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_dog);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_closelogin);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_closelogin)).EndInit();
            this.pnl_dog.ResumeLayout(false);
            this.pnl_dog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.guna2CircleProgressBar1.ResumeLayout(false);
            this.guna2CircleProgressBar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal Guna.UI2.WinForms.Guna2Button btn_home;
        internal Guna.UI2.WinForms.Guna2Button btn_product;
        internal Guna.UI2.WinForms.Guna2Button btn_logout;
        internal Guna.UI2.WinForms.Guna2Button btn_billing;
        internal Guna.UI2.WinForms.Guna2Button btn_customer;
        internal Guna.UI2.WinForms.Guna2Button btn_employee;
        internal Guna.UI2.WinForms.Guna2Button btn_empname;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.PictureBox btn_closelogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnl_dog;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lbl_dog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_cat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_bird;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private System.Windows.Forms.Label lbl_Financial;
        private System.Windows.Forms.Label lbl_dogs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_cats;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_birds;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}