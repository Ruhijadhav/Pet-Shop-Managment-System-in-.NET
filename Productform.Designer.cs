namespace PET_Shop_1
{
    partial class Productform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productform));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_cutomer = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_ProdQuantity = new System.Windows.Forms.TextBox();
            this.txt_ProdPrice = new System.Windows.Forms.TextBox();
            this.btn_home = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ProName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_empname = new Guna.UI2.WinForms.Guna2Button();
            this.btn_product = new Guna.UI2.WinForms.Guna2Button();
            this.btn_logout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_billing = new Guna.UI2.WinForms.Guna2Button();
            this.btn_employee = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_ProdCategories = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_closelogin = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_closelogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cutomer
            // 
            this.btn_cutomer.BorderRadius = 10;
            this.btn_cutomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cutomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cutomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cutomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cutomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_cutomer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cutomer.ForeColor = System.Drawing.Color.White;
            this.btn_cutomer.Image = ((System.Drawing.Image)(resources.GetObject("btn_cutomer.Image")));
            this.btn_cutomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_cutomer.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_cutomer.Location = new System.Drawing.Point(12, 360);
            this.btn_cutomer.Name = "btn_cutomer";
            this.btn_cutomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_cutomer.Size = new System.Drawing.Size(180, 37);
            this.btn_cutomer.TabIndex = 9;
            this.btn_cutomer.Text = "    Customer";
            this.btn_cutomer.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(543, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 28);
            this.label6.TabIndex = 67;
            this.label6.Text = "Product List";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btn_edit.Location = new System.Drawing.Point(537, 228);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(130, 39);
            this.btn_edit.TabIndex = 66;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btn_delete.Location = new System.Drawing.Point(756, 228);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(134, 38);
            this.btn_delete.TabIndex = 65;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(341, 228);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(127, 43);
            this.btn_save.TabIndex = 64;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_ProdQuantity
            // 
            this.txt_ProdQuantity.Location = new System.Drawing.Point(665, 136);
            this.txt_ProdQuantity.Name = "txt_ProdQuantity";
            this.txt_ProdQuantity.Size = new System.Drawing.Size(188, 32);
            this.txt_ProdQuantity.TabIndex = 63;
            // 
            // txt_ProdPrice
            // 
            this.txt_ProdPrice.Location = new System.Drawing.Point(877, 131);
            this.txt_ProdPrice.Multiline = true;
            this.txt_ProdPrice.Name = "txt_ProdPrice";
            this.txt_ProdPrice.Size = new System.Drawing.Size(174, 39);
            this.txt_ProdPrice.TabIndex = 62;
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
            this.btn_home.Text = "    Home";
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(873, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 59;
            this.label3.Text = "Price";
            // 
            // txt_ProName
            // 
            this.txt_ProName.Location = new System.Drawing.Point(243, 137);
            this.txt_ProName.Multiline = true;
            this.txt_ProName.Name = "txt_ProName";
            this.txt_ProName.Size = new System.Drawing.Size(181, 36);
            this.txt_ProName.TabIndex = 57;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_empname);
            this.panel1.Controls.Add(this.btn_product);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_billing);
            this.panel1.Controls.Add(this.btn_cutomer);
            this.panel1.Controls.Add(this.btn_employee);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Location = new System.Drawing.Point(0, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 1007);
            this.panel1.TabIndex = 52;
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
            this.btn_product.Location = new System.Drawing.Point(12, 232);
            this.btn_product.Name = "btn_product";
            this.btn_product.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_product.Size = new System.Drawing.Size(180, 37);
            this.btn_product.TabIndex = 12;
            this.btn_product.Text = "    Product";
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
            this.btn_logout.Text = "    Logout";
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
            this.btn_billing.Text = "    Billing";
            this.btn_billing.Click += new System.EventHandler(this.guna2Button3_Click);
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
            this.btn_employee.Text = "    Employee";
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.White;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(238, 105);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(70, 23);
            this.lbl_name.TabIndex = 56;
            this.lbl_name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 55;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(661, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 58;
            this.label2.Text = "Quantity";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(344, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeftSize = new System.Drawing.Size(50, 50);
            this.guna2TextBox1.IconRightSize = new System.Drawing.Size(80, 80);
            this.guna2TextBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(1085, 324);
            this.guna2TextBox1.TabIndex = 53;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // txt_ProdCategories
            // 
            this.txt_ProdCategories.FormattingEnabled = true;
            this.txt_ProdCategories.Items.AddRange(new object[] {
            "Bird",
            "Dog",
            "Cat",
            "Food"});
            this.txt_ProdCategories.Location = new System.Drawing.Point(448, 137);
            this.txt_ProdCategories.Name = "txt_ProdCategories";
            this.txt_ProdCategories.Size = new System.Drawing.Size(190, 31);
            this.txt_ProdCategories.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 70;
            this.label4.Text = "Categories";
            // 
            // ProductDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ProductDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductDGV.ColumnHeadersHeight = 4;
            this.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDGV.Location = new System.Drawing.Point(268, 412);
            this.ProductDGV.Name = "ProductDGV";
            this.ProductDGV.RowHeadersVisible = false;
            this.ProductDGV.RowHeadersWidth = 62;
            this.ProductDGV.RowTemplate.Height = 40;
            this.ProductDGV.Size = new System.Drawing.Size(749, 315);
            this.ProductDGV.TabIndex = 71;
            this.ProductDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ProductDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.ProductDGV.ThemeStyle.ReadOnly = false;
            this.ProductDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductDGV.ThemeStyle.RowsStyle.Height = 40;
            this.ProductDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDGV_CellContentClick);
            // 
            // btn_closelogin
            // 
            this.btn_closelogin.BackColor = System.Drawing.Color.White;
            this.btn_closelogin.Image = ((System.Drawing.Image)(resources.GetObject("btn_closelogin.Image")));
            this.btn_closelogin.Location = new System.Drawing.Point(1032, 3);
            this.btn_closelogin.Name = "btn_closelogin";
            this.btn_closelogin.Size = new System.Drawing.Size(42, 37);
            this.btn_closelogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_closelogin.TabIndex = 72;
            this.btn_closelogin.TabStop = false;
            this.btn_closelogin.Click += new System.EventHandler(this.btn_closelogin_Click);
            // 
            // Productform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1085, 768);
            this.Controls.Add(this.btn_closelogin);
            this.Controls.Add(this.ProductDGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ProdCategories);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_ProdQuantity);
            this.Controls.Add(this.txt_ProdPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ProName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2TextBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Productform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productform";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_closelogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Guna.UI2.WinForms.Guna2Button btn_cutomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_ProdQuantity;
        private System.Windows.Forms.TextBox txt_ProdPrice;
        internal Guna.UI2.WinForms.Guna2Button btn_home;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ProName;
        private System.Windows.Forms.Panel panel1;
        internal Guna.UI2.WinForms.Guna2Button btn_empname;
        internal Guna.UI2.WinForms.Guna2Button btn_product;
        internal Guna.UI2.WinForms.Guna2Button btn_logout;
        internal Guna.UI2.WinForms.Guna2Button btn_billing;
        internal Guna.UI2.WinForms.Guna2Button btn_employee;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.ComboBox txt_ProdCategories;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView ProductDGV;
        private System.Windows.Forms.PictureBox btn_closelogin;
    }
}