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
    public partial class Login : Form
    {
        public static string Employee { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // Connection string to the database
            string connectionString = "Data Source=LAPTOP-O2OST7QK;Initial Catalog=PetDB;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                // SQL query to check if the user exists
                string query = "SELECT COUNT(1) FROM EmployeeTbl WHERE EmpName=@EU AND EmpPass=@EP";
                SqlCommand cmd = new SqlCommand(query, Con);

                // Parameters to prevent SQL Injection
                cmd.Parameters.AddWithValue("@EU", txt_username.Text.Trim());
                cmd.Parameters.AddWithValue("@EP", txt_pass.Text.Trim());

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                // If the user exists, open the BillingForm
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    UserSession.Username = txt_username.Text.Trim();


                    HomePage HomePage = new HomePage();
                    HomePage.Show();
                    this.Hide(); // Hide the login form
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password. Please try again.");
                }

                Con.Close();
            }

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            // In Login form, after successful login verification

        }

        private void btn_forgetPass_Click(object sender, EventArgs e)
        {

            txt_username.Text = "";
            txt_pass.Text = "";

        }

        private void btn_closelogin_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
