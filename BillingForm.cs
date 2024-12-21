using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PET_Shop_1
{
    public partial class BillingForm : Form
    {
        public BillingForm()
        {
            InitializeComponent();
            btn_empname.Text = UserSession.Username; // Display the username on the button

            GetCustomers();
            txt_customerid.SelectedIndexChanged += txt_customerid_SelectedIndexChanged;

            DisplayProduct();
            DisplayTransations();
            

        }
        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-O2OST7QK;Initial Catalog=PetDB;Integrated Security=True;Connect Timeout=30");
         int Key = 0;        // Initialize Key to 0 as default
         int Stock = 0;      // Initialize Stock to 0 as default
         int GrdTotal = 0;
        public void GetCustomers()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select CustId from CustomerTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId",typeof(int));
            dt.Load(Rdr);
            txt_customerid.ValueMember = "CustId";
            txt_customerid.DataSource = dt;
            Con.Close();
        }
        private void DisplayProduct()
        {
            Con.Open();
            string query = "SELECT PrdtId, PrdtName, PrdtCat, PrdtQty, PrdtPrice FROM ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            /*DataTable dt = new DataTable();
            sda.Fill(dt);
            ProductDGV.DataSource = dt;
            Con.Close();*/
            var ds = new DataSet();
            sda.Fill(ds);
            ProductDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void txt_customerid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCustId = Convert.ToInt32(txt_customerid.SelectedValue);
            GetCustomerName(selectedCustId);
        }

        private void DisplayTransations()
        {
            Con.Open();
            string query = "SELECT * FROM BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            /*DataTable dt = new DataTable();
            sda.Fill(dt);
            ProductDGV.DataSource = dt;
            Con.Close();*/
            var ds = new DataSet();
            sda.Fill(ds);
            TransationDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        public void GetCustomerName(int custId)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select CustName from CustomerTbl where CustId = @CustId", Con);
            cmd.Parameters.AddWithValue("@CustId", custId);
            SqlDataReader Rdr = cmd.ExecuteReader();
            if (Rdr.Read())
            {
                txt_CustomerName.Text = Rdr["CustName"].ToString(); // Assuming txt_customername is a TextBox or Label
            }
            Con.Close();
        }


        private void updateStock(int productId, int quantitySold)
        {
            try
            {
                int NewQty = Convert.ToInt32(Stock -  quantitySold);
                Con.Open();
                SqlCommand cmd = new SqlCommand("update ProductTbl set PrdtQty = @PQ where PrdtId = @PKey", Con);
                cmd.Parameters.AddWithValue("@PQ", NewQty);
                cmd.Parameters.AddWithValue("@PKey", Key);
                cmd.ExecuteNonQuery();
                Con.Close();
                DisplayProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int n = 0;
       
        
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void txt_CustomerAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_customerPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             /*if (ProductDGV.SelectedRows.Count > 0)
            {
                // Get the selected row
                var selectedRow = ProductDGV.SelectedRows[0];

                // Display product name
                txt_productName.Text = selectedRow.Cells[1].Value.ToString();

                // Attempt to parse the stock value
                string stockValue = selectedRow.Cells[2].Value.ToString();
                if (int.TryParse(stockValue, out Stock))
                {
                    // Stock parsed successfully
                }
                else
                {
                    MessageBox.Show("Invalid stock value: " + stockValue);
                }

                // Attempt to parse the product price
                string priceValue = selectedRow.Cells[3].Value.ToString();
                if (decimal.TryParse(priceValue, out decimal price))
                {
                    txt_productPrice.Text = price.ToString("F2"); // Format to two decimal places
                }
                else
                {
                    MessageBox.Show("Invalid price value: " + priceValue);
                }

                // Get the key value
                Key = Convert.ToInt32(selectedRow.Cells[0].Value);
            }*/

            txt_productName.Text = ProductDGV.SelectedRows[0].Cells[1].Value.ToString();
            string stockValue = ProductDGV.SelectedRows[0].Cells[3].Value?.ToString();
        if (int.TryParse(stockValue, out int stock))
        {
            Stock = stock;
        }
        else
        {
            MessageBox.Show("Invalid stock value: " + stockValue);
            Stock = 0; // Set a default value if parsing fails
        }
            txt_productPrice.Text = ProductDGV.SelectedRows[0].Cells[4].Value.ToString();
            if(txt_productName.Text == "")
            {
                Key = 0;

            }
            else
            {
                Key = Convert.ToInt32(ProductDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }


        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_customerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();

            // Close the current Login form
            this.Close();
        }


        private void btn_Addtobill_Click(object sender, EventArgs e)
        {
            // Validate product quantity and stock availability
            if (string.IsNullOrEmpty(txt_productqty.Text) || !int.TryParse(txt_productqty.Text, out int productQty) || productQty > Stock)
            {
                MessageBox.Show("Not enough stock available.");
                return; // Exit the method to prevent further execution
            }

            // Check if required information is missing (e.g., product name or key)
            if (Key == 0 || string.IsNullOrEmpty(txt_productName.Text))
            {
                MessageBox.Show("Missing information.");
                return; // Exit the method if information is missing
            }

            // Calculate the total price for the selected product
            int total = Convert.ToInt32(txt_productqty.Text) * Convert.ToInt32(txt_productPrice.Text);


            if (BillDGV.Columns.Count == 0)
            {
                BillDGV.Columns.Add("ProductID", "Prdt ID");
                BillDGV.Columns.Add("ProductName", "Prdt Name");
                BillDGV.Columns.Add("Quantity", "Quantity");
                BillDGV.Columns.Add("Price", "Price");
                BillDGV.Columns.Add("Total", "Total");
            }
            // Create a new row for the DataGridView
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(BillDGV);

            // Populate the cells with values
            newRow.Cells[0].Value = Key;  // Product ID
            newRow.Cells[1].Value = txt_productName.Text; // Product name from the textbox
            newRow.Cells[2].Value = txt_productqty.Text;  // Product quantity
            newRow.Cells[3].Value = txt_productPrice.Text; // Product price
            newRow.Cells[4].Value = total;  // Total price for the product

            // Update the grand total
            GrdTotal += total;
            Totallbl.Text = "Rs " + GrdTotal;  // Update the total label

            // Add the new row to the DataGridView
            BillDGV.Rows.Add(newRow);

            // Update stock in ProductDGV
            updateStockInProductDGV(Key, productQty);

            // Reset the form fields for the next entry (you need to define ReSet() to reset the fields)
            ReSet();
        }

        // Method to update the stock in ProductDGV
        private void updateStockInProductDGV(int productId, int quantitySold)
        {
            foreach (DataGridViewRow row in ProductDGV.Rows)
            {
                if (Convert.ToInt32(row.Cells["PrdtId"].Value) == productId)
                {
                    int currentStock = Convert.ToInt32(row.Cells["PrdtQty"].Value);
                    row.Cells["PrdtQty"].Value = currentStock - quantitySold; // Update stock
                    break;
                }
            }
        }


        private void ReSet()
        {
           txt_productName.Text = "";
           txt_productqty.Text = "";
            txt_productPrice.Text = "";  // Reset price field

            Stock = 0;
           Key = 0;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
           
            ReSet();

        }
        private void InsertBill()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into BillTbl (BDate,CustId,CustName,EmpName,Amt) values(@BD,@CI,@CN,@EN,@Am)", Con);
                cmd.Parameters.AddWithValue("@BD", DateTime.Today.Date);
                cmd.Parameters.AddWithValue("@CI", txt_customerid.Text);
                cmd.Parameters.AddWithValue("@CN", txt_CustomerName.Text);
                cmd.Parameters.AddWithValue("@EN", btn_empname.Text);
                cmd.Parameters.AddWithValue("@Am", GrdTotal);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bill Generated Successfully");

                Con.Close();
                DisplayTransations();                //Clear();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        string prodname;

        private void btn_print_Click(object sender, EventArgs e)
        {
            InsertBill();
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = ProductDGV.Rows[e.RowIndex];
            txt_productName.Text = selectedRow.Cells["PrdtName"].Value.ToString();
            Stock = Convert.ToInt32(selectedRow.Cells["PrdtQty"].Value);
            txt_productPrice.Text = selectedRow.Cells["PrdtPrice"].Value.ToString();
            Key = Convert.ToInt32(selectedRow.Cells["PrdtId"].Value);
        }

        private void TransationDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            HomePage homeForm = new HomePage();
            homeForm.Show();
            this.Hide();
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

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();

        }
        int PrdtId, PrdtQty, PrdtPrice, tottal, pos = 60;

        private void btn_empname_Click(object sender, EventArgs e)
        {
            btn_empname.Text = UserSession.Username; // Display the username on the button

        }

        String PrdtName;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Pet Caring Hub", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID, PRODUCT, PRICE, QUANTITY TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach(DataGridViewRow row in BillDGV.Rows)
            {
                PrdtId = Convert.ToInt32(row.Cells["ProductID"].Value);
                PrdtName = "" + row.Cells["ProductName"].Value;
                PrdtPrice = Convert.ToInt32(row.Cells["Price"].Value);
                PrdtQty = Convert.ToInt32(row.Cells["Quantity"].Value);
                tottal = Convert.ToInt32(row.Cells["Total"].Value);

                e.Graphics.DrawString("" + PrdtId, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(26,pos));
                e.Graphics.DrawString("" + PrdtName, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(45, pos));
                e.Graphics.DrawString("" + PrdtPrice, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(120, pos));
                e.Graphics.DrawString("" + PrdtQty, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(170, pos));
                e.Graphics.DrawString("" + tottal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(235, pos));
                pos = pos + 20;
            }
            e.Graphics.DrawString("Grant Total: Rs" + GrdTotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(50, pos + 50));
            e.Graphics.DrawString("**************** PETSHOP ****************", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(10, pos + 85));
            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            pos = 100;
            GrdTotal = 0;
            n=0;
        }
    }
}
