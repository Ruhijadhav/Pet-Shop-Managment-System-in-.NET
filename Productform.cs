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
    public partial class Productform : Form
    {
        public Productform()
        {
            InitializeComponent();
            btn_empname.Text = UserSession.Username; // Display the username on the button

            DisplayProduct();
        }


        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-O2OST7QK;Initial Catalog=PetDB;Integrated Security=True;Connect Timeout=30");

        private void DisplayProduct()
        {
            Con.Open();
            string Query = "SELECT * FROM ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet(); ;
            sda.Fill(ds);
            ProductDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void Clear()
        {
           txt_ProName.Text = "";
           txt_ProdCategories.SelectedIndex =0;
           txt_ProdQuantity.Text = "";
           txt_ProdPrice.Text = "";
        } 
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_ProName.Text == "" || txt_ProdCategories.SelectedIndex == -1 || txt_ProdQuantity.Text == "" || txt_ProdPrice.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ProductTbl (PrdtName,PrdtCat,PrdtQty,PrdtPrice) values(@PN,@PC,@PQ,@PPr)", Con);
                    cmd.Parameters.AddWithValue("@PN", txt_ProName.Text);
                    cmd.Parameters.AddWithValue("@PC", txt_ProdCategories.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PQ", txt_ProdQuantity.Text);
                    cmd.Parameters.AddWithValue("@PPr", txt_ProdPrice.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Added");

                    Con.Close();
                    DisplayProduct();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int Key = 0;
        private void ProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ProName.Text = ProductDGV.SelectedRows[0].Cells[1].Value.ToString();
            txt_ProdCategories.Text = ProductDGV.SelectedRows[0].Cells[2].Value.ToString();
            txt_ProdQuantity.Text = ProductDGV.SelectedRows[0].Cells[3].Value.ToString();
            txt_ProdPrice.Text = ProductDGV.SelectedRows[0].Cells[4].Value.ToString();



            if (txt_ProName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ProductDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_ProName.Text == "" || txt_ProdCategories.Text == "" || txt_ProdQuantity.Text == "" || txt_ProdPrice.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update ProductTbl set PrdtName = @PN,PrdtCat = @PC,PrdtQty = @PQ,PrdtPrice = @PPr where PrdtId=@PKey", Con);
                    cmd.Parameters.AddWithValue("@PN", txt_ProName.Text);
                    cmd.Parameters.AddWithValue("@PC", txt_ProdCategories.Text);
                    cmd.Parameters.AddWithValue("@PQ", txt_ProdQuantity.Text);
                    cmd.Parameters.AddWithValue("@PPr", txt_ProdPrice.Text);
                    cmd.Parameters.AddWithValue("@PKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product updated!!!!   ");

                    Con.Close();
                    DisplayProduct();
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
            if (Key == 0)
            {
                MessageBox.Show("Select An Product");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ProductTbl where PrdtId = @PrdtKey", Con);
                    cmd.Parameters.AddWithValue("@PrdtKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted");

                    Con.Close();
                    DisplayProduct();
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
            HomePage homeForm = new HomePage();
            homeForm.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            BillingForm billingForm = new BillingForm();
            billingForm.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
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
