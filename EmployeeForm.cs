using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PET_Shop_1
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            this.Load += new System.EventHandler(this.EmployeeForm_Load);

            InitializeComponent();
            btn_empname.Text = UserSession.Username; // Display the username on the button

            DisplayEmployees();
            MessageBox.Show("EmployeeForm Loaded"); // For debugging

        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            btn_empname.Text = UserSession.Username; // Display the username on the button
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        
        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-O2OST7QK;Initial Catalog=PetDB;Integrated Security=True;Connect Timeout=30");

        private void DisplayEmployees()
        {
            Con.Open();
            string Query = "SELECT * FROM EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query,Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet(); ;
            sda.Fill(ds);
            EmployeeDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void Clear()
        {
            txt_empName.Text = "";
            txt_empAddress.Text = "";
            txt_empPhone.Text = "";
            txt_empPass.Text = "";
        }

        int Key = 0;

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_empName.Text == "" || txt_empAddress.Text == "" || txt_empPhone.Text == "" || txt_empPass.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmployeeTbl (EmpName,EmpAdd,EmpDOB,EmpPhone,EmpPass) values(@EN,@EA,@ED,@EP,@EPa)", Con);
                    cmd.Parameters.AddWithValue("@EN", txt_empName.Text);
                    cmd.Parameters.AddWithValue("@EA",txt_empAddress.Text);
                    cmd.Parameters.AddWithValue("@ED", txt_empDOB.MaxDate);
                    cmd.Parameters.AddWithValue("@EP", txt_empPhone.Text);
                    cmd.Parameters.AddWithValue("@EPa", txt_empPass.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added");

                    Con.Close();
                    DisplayEmployees();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void EmployeeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_empName.Text = EmployeeDGV.SelectedRows[0].Cells[1].Value.ToString();
            txt_empAddress.Text = EmployeeDGV.SelectedRows[0].Cells[2].Value.ToString();
            txt_empDOB.Text = EmployeeDGV.SelectedRows[0].Cells[3].Value.ToString();
            txt_empPhone.Text = EmployeeDGV.SelectedRows[0].Cells[4].Value.ToString();
            txt_empPass.Text = EmployeeDGV.SelectedRows[0].Cells[5].Value.ToString();

            if(txt_empName.Text == "")
            {
                Key =0;
            }
            else
            {
                Key = Convert.ToInt32(EmployeeDGV.SelectedRows[0].Cells[0].Value.ToString());
            }


        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_empName.Text == "" || txt_empAddress.Text == "" || txt_empPhone.Text == "" || txt_empPass.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update EmployeeTbl set EmpName = @EN,EmpAdd = @EA,EmpDOB = @ED,EmpPhone = @EP,EmpPass = @EPa where EmpID=@EKey", Con);
                    cmd.Parameters.AddWithValue("@EN", txt_empName.Text);
                    cmd.Parameters.AddWithValue("@EA", txt_empAddress.Text);
                    cmd.Parameters.AddWithValue("@ED", txt_empDOB.MaxDate);
                    cmd.Parameters.AddWithValue("@EP", txt_empPhone.Text);
                    cmd.Parameters.AddWithValue("@EPa", txt_empPass.Text);
                    cmd.Parameters.AddWithValue("@EKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee updated!!!!   ");

                    Con.Close();
                    DisplayEmployees();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (Key==0)
            {
                MessageBox.Show("Select An Employee");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from EmployeeTbl where EmpID = @EmpKey", Con);
                    cmd.Parameters.AddWithValue("@EmpKey",Key);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted");

                    Con.Close();
                    DisplayEmployees();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CustomerForm Obj = new CustomerForm();
            Obj.Show();
            this.Hide();

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            HomePage homeForm = new HomePage();
            homeForm.Show();
            this.Hide();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            Productform Obj = new Productform();
            Obj.Show();
            this.Hide();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
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

        private void btn_empname_Click(object sender, EventArgs e)
        {
            btn_empname.Text = UserSession.Username; // Display the username on the button

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();

            // Close the current Login form
            this.Close();
        }
    }
}
