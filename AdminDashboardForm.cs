using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class AdminDashboardForm : Form
    {
        private User currentUser;

        public AdminDashboardForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string role = cbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-87MTL4FI\\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True;Encrypt=False"))
                {
                    string query = "INSERT INTO Users (Email, Password, Role) VALUES (@Email, @Password, @Role)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Role", role);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("User added successfully!");
                        else
                            MessageBox.Show("User was not added. Please try again.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter an email.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-87MTL4FI\\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True;Encrypt=False"))
                {
                    string query = "DELETE FROM Users WHERE Email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("User removed successfully!");
                        else
                            MessageBox.Show("No user found with that email.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {currentUser.Email}!";
            txtMyEmail.Text = currentUser.Email;
            txtMyPassword.Text = "";

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-87MTL4FI\\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True;Encrypt=False"))
                {
                    conn.Open();

                    LoadDistinctValues(conn, "SELECT DISTINCT MONTH(OrderDate) AS OrderMonth FROM Orders", cbMonth, "OrderMonth");
                    LoadDistinctValues(conn, "SELECT DISTINCT YEAR(OrderDate) AS OrderYear FROM Orders", cbYear, "OrderYear");
                    LoadDistinctValues(conn, "SELECT DISTINCT Category FROM MenuItems", cbCategory, "Category");
                    LoadDistinctValues(conn, "SELECT Email FROM Users WHERE Role = 'Chef'", cbChef, "Email");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading form data: " + ex.Message);
            }
        }

        private void LoadDistinctValues(SqlConnection conn, string query, ComboBox comboBox, string fieldName)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader[fieldName].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load combo box values: " + ex.Message);
            }
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            string email = txtSearchEmail.Text.Trim();

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-87MTL4FI\\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True;Encrypt=False"))
                {
                    string query = "SELECT * FROM Users WHERE Email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtUpdateEmail.Text = reader["Email"].ToString();
                                cbUpdateRole.SelectedItem = reader["Role"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("User not found!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching user: " + ex.Message);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            string oldEmail = txtSearchEmail.Text.Trim();
            string newEmail = txtUpdateEmail.Text.Trim();
            string newRole = cbUpdateRole.SelectedItem?.ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-87MTL4FI\\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True;Encrypt=False"))
                {
                    string query = "UPDATE Users SET Email = @Email, Role = @Role WHERE Email = @OldEmail";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", newEmail);
                        cmd.Parameters.AddWithValue("@Role", newRole);
                        cmd.Parameters.AddWithValue("@OldEmail", oldEmail);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        MessageBox.Show(rowsAffected > 0 ? "User updated successfully!" : "Update failed. User may not exist.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
            }
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            dgvSalesReport.DataSource = null;
            dgvSalesReport.Rows.Clear();

            int month = int.Parse(cbMonth.SelectedItem?.ToString() ?? "0");
            int year = int.Parse(cbYear.SelectedItem?.ToString() ?? "0");
            string category = cbCategory.SelectedItem?.ToString();
            string chef = cbChef.SelectedItem?.ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-87MTL4FI\\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True;Encrypt=False"))
                {
                    string query = @"SELECT o.OrderId, o.OrderDate, u.Email AS ChefName, mi.Name AS ItemName, mi.Category, od.Quantity, od.Price FROM Orders o JOIN OrderDetails od ON o.OrderId = od.OrderId JOIN MenuItems mi ON od.MenuItemId = mi.MenuItemId JOIN Users u ON o.ChefId = u.Id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvSalesReport.AutoGenerateColumns = true;
                        dgvSalesReport.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No data found. Try different filters.");
                        }

                        decimal totalSales = dt.AsEnumerable()
                            .Sum(row => row.Field<decimal>("Price") * row.Field<int>("Quantity"));

                        lblTotalSales.Text = $"Total Sales: RM {totalSales:F2}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report: " + ex.Message);
            }
        }

        private void btnViewEWalletReport_Click(object sender, EventArgs e)
        {
            dgvEWalletReport.DataSource = null;
            dgvEWalletReport.Rows.Clear();

            string email = txtCustomerEmailEWallet.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter a customer email.");
                return;
            }

            if (cbEWalletMonth.SelectedItem == null || cbEWalletYear.SelectedItem == null)
            {
                MessageBox.Show("Please select both month and year.");
                return;
            }

            int month = cbEWalletMonth.SelectedIndex + 1;
            int year = int.Parse(cbEWalletYear.SelectedItem.ToString());

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-87MTL4FI\\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True;Encrypt=False"))
                {
                    conn.Open();

                    SqlCommand getIdCmd = new SqlCommand("SELECT Id FROM Users WHERE Email = @Email", conn);
                    getIdCmd.Parameters.AddWithValue("@Email", email);
                    object result = getIdCmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Customer email not found.");
                        return;
                    }

                    int customerId = Convert.ToInt32(result);

                    SqlCommand cmd = new SqlCommand(@"SELECT TransactionType, Amount, TransactionDate FROM EwalletTransactions WHERE CustomerId = @CustomerId AND MONTH(TransactionDate) = @Month AND YEAR(TransactionDate) = @Year", conn);
                    cmd.Parameters.AddWithValue("@CustomerId", customerId);
                    cmd.Parameters.AddWithValue("@Month", month);
                    cmd.Parameters.AddWithValue("@Year", year);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No transactions found for this customer in the selected month and year.");
                        lblTotalTopUps.Text = "Total Top-up: RM 0.00";
                        lblTotalSpent.Text = "Total Spent: RM 0.00";
                        return;
                    }

                    dgvEWalletReport.AutoGenerateColumns = true;
                    dgvEWalletReport.DataSource = dt;

                    decimal totalTopup = 0;
                    decimal totalSpent = 0;

                    foreach (DataRow row in dt.Rows)
                    {
                        string type = row["TransactionType"].ToString();
                        decimal amount = Convert.ToDecimal(row["Amount"]);

                        if (type == "TopUp") totalTopup += amount;
                        else if (type == "Payment") totalSpent += amount;
                    }

                    lblTotalTopUps.Text = $"Total Top-up: RM {totalTopup:F2}";
                    lblTotalSpent.Text = $"Total Spent: RM {totalSpent:F2}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading e-wallet report: " + ex.Message);
            }
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            string newEmail = txtMyEmail.Text;
            string newPassword = txtMyPassword.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-87MTL4FI\\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True;Encrypt=False"))
                {
                    string query = "UPDATE Users SET Email = @Email" +
                                   (!string.IsNullOrEmpty(newPassword) ? ", Password = @Password" : "") +
                                   " WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", newEmail);
                        cmd.Parameters.AddWithValue("@Id", currentUser.Id);

                        if (!string.IsNullOrEmpty(newPassword))
                            cmd.Parameters.AddWithValue("@Password", newPassword);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Profile updated successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
