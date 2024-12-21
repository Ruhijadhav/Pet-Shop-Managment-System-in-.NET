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
    public partial class CustomerForm : Form
    {


        public CustomerForm()
        {
            InitializeComponent();
            btn_empname.Text = UserSession.Username; // Display the username on the button

            DisplayCustomer();
            btn_empname.Text = UserSession.Username;

        }

        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-O2OST7QK;Initial Catalog=PetDB;Integrated Security=True;Connect Timeout=30");

        private void DisplayCustomer()
        {
            Con.Open();
            string Query = "SELECT * FROM CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet(); ;
            sda.Fill(ds);
            CustomerDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void Clear()
        {
            txt_customerName.Text = "";
            txt_CustomerAddress.Text = "";
            txt_customerPhone.Text = "";
         
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (txt_customerName.Text == "" || txt_CustomerAddress.Text == "" || txt_customerPhone.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CustomerTbl (CustName,CustAdd,CustPhone) values(@CN,@CA,@CP)", Con);
                    cmd.Parameters.AddWithValue("@CN", txt_customerName.Text);
                    cmd.Parameters.AddWithValue("@CA", txt_CustomerAddress.Text);                   
                    cmd.Parameters.AddWithValue("@CP", txt_customerPhone.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("customer Added");

                    Con.Close();
                    DisplayCustomer();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_customerName.Text = CustomerDGV.SelectedRows[0].Cells[1].Value.ToString();
            txt_CustomerAddress.Text = CustomerDGV.SelectedRows[0].Cells[2].Value.ToString();
            txt_customerPhone.Text = CustomerDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (txt_customerName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CustomerDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select An Customer");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from CustomerTbl where CustId = @CKey", Con);
                    cmd.Parameters.AddWithValue("@CKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted");

                    Con.Close();
                    DisplayCustomer();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_customerName.Text == "" || txt_CustomerAddress.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update CustomerTbl set CustName = @CN,CustAdd = @CA,CustPhone = @CP where CustId=@CKey", Con);
                    cmd.Parameters.AddWithValue("@CN", txt_customerName.Text);
                    cmd.Parameters.AddWithValue("@CA", txt_CustomerAddress.Text);
                    cmd.Parameters.AddWithValue("@CP", txt_customerPhone.Text);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer updated!!!!   ");

                    Con.Close();
                    DisplayCustomer();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        

        }

        private void btn_home_Click(object sender, EventArgs e)
        {

        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
            this.Hide();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
            this.Hide();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            Productform productForm = new Productform();
            productForm.Show();
            this.Hide();
        }

        private void btn_billing_Click(object sender, EventArgs e)
        {
            BillingForm billingForm = new BillingForm();
            billingForm.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void txt_CustomerAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_empname_Click(object sender, EventArgs e)
        {
            btn_empname.Text = UserSession.Username; // Display the username on the button

        }

        private void btn_closelogin_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();

            // Close the current Login form
            this.Close();
        }
    }
}
