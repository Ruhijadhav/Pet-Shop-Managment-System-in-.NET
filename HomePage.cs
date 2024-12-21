using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PET_Shop_1
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            Countdogs();
            Countbirds();
            Councats();
            Finance();
            btn_empname.Text = UserSession.Username; // Display the username on the button

        }


        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-O2OST7QK;Initial Catalog=PetDB;Integrated Security=True;Connect Timeout=30");
        private void Countdogs()
        {
            string Cat = "Dog";
            Con.Open();
            SqlDataAdapter dsa = new SqlDataAdapter("Select Count(*) from ProductTbl where PrdtCat='"+Cat+"'",Con);
            DataTable dt = new DataTable();
            dsa.Fill(dt);
            lbl_dogs.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void Finance()
        {
            
            Con.Open();
            SqlDataAdapter dsa = new SqlDataAdapter("Select Sum(Amt) from BillTbl" ,Con);
            DataTable dt = new DataTable();
            dsa.Fill(dt);
            lbl_Financial.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void Councats()
        {
            string Cat = "Cat";
            Con.Open();
            SqlDataAdapter dsa = new SqlDataAdapter("Select Count(*) from ProductTbl where PrdtCat='" + Cat + "'", Con);
            DataTable dt = new DataTable();
            dsa.Fill(dt);
            lbl_cats.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void Countbirds()
        {
            string Cat = "Bird";
            Con.Open();
            SqlDataAdapter dsa = new SqlDataAdapter("Select Count(*) from ProductTbl where PrdtCat='" + Cat + "'", Con);
            DataTable dt = new DataTable();
            dsa.Fill(dt);
            lbl_birds.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close(); // Closes the HomePage
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {

        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            Productform productForm = new Productform();
            productForm.Show();
            this.Hide();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
            this.Hide();


        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
            this.Hide();

        }

        private void btn_billing_Click(object sender, EventArgs e)
        {
            BillingForm billingForm = new BillingForm();
            billingForm.Show();
            this.Hide();
        }

        private void btn_empname_Click(object sender, EventArgs e)
        {
            btn_empname.Text = UserSession.Username; // Display the username on the button

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login loginpage = new Login();
            loginpage.Show();

            // Close the current Login form
            this.Close();
        }
    }
}
