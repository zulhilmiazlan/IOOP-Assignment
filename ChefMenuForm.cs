using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Assignment
{
    public partial class ChefMenuForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SedapMakanDB"].ConnectionString;


        public ChefMenuForm()
        {
            InitializeComponent();
            InitializeFormState();
        }


        private void InitializeFormState()
        {
            radioBtnAdd.Checked = true;

            //just to initially hide the feedback message
            lblFeedback.Visible = false;
            pictureBoxTick.Visible = false;
        }


        private void ChefMenuForm_Load(object sender, EventArgs e)
        {
            //this iss to call the method to load existing menu items from db
            LoadMenuItems();

            radioBtnAdd_CheckedChanged(this, EventArgs.Empty);
        }


        private void LoadMenuItems()
        {
            listBoxMenuList.Items.Clear();

            string query = "SELECT Name, Category, Price, IsAvailable FROM MenuItem ORDER BY Name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string dishName = reader["Name"].ToString();
                        string category = reader["Category"].ToString();
                        decimal price = (decimal)reader["Price"];
                        bool isAvailable = (bool)reader["IsAvailable"];

                        string availabilityStatus = isAvailable ? "Available" : "Not Available";
                        //Format: "Dish Name - RM Price (Availability)"
                        listBoxMenuList.Items.Add($"{dishName} ({category}) - RM {price:F2} ({availabilityStatus}");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    //makes a message appear indicating an error if there's an error loading  data
                    MessageBox.Show("Error loading menu items: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void pictureBoxLogo_Click(object sender, EventArgs e) { }
        private void lblHeader_Click(object sender, EventArgs e) { }
        private void pictureBoxViewMenu_Click(object sender, EventArgs e) { }
        private void grpBoxMenuList_Enter(object sender, EventArgs e) { }
        private void listBoxMenuList_SelectedIndexChanged(object sender, EventArgs e) { }
        private void grpBoxUpdateMenu_Enter(object sender, EventArgs e) { }


        private void radioBtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnAdd.Checked)
            {
                //Enable inputs for adding a new dish
                txtBoxDishName.Enabled = true;
                txtCategory.Enabled = true;
                txtBoxPrice.Enabled = true;
                checkBoxAvailable.Enabled = true;

                //Clears the input section to set default for users to add info
                txtBoxDishName.Text = "";
                txtCategory.Text = "";
                txtBoxPrice.Text = "";
                checkBoxAvailable.Checked = true;

                //Hide feedback messages
                lblFeedback.Visible = false;
                pictureBoxTick.Visible = false;
            }
        }


        private void radioBtnRemove_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnRemove.Checked)
            {
                //For removing a menu item only Dish name is needed
                txtBoxDishName.Enabled = true;
                txtCategory.Enabled = false;
                txtBoxPrice.Enabled = false;
                checkBoxAvailable.Enabled = false;

                //Clearing input section
                txtBoxDishName.Text = "";
                txtCategory.Text = "";
                txtBoxPrice.Text = "";
                checkBoxAvailable.Checked = false;

                //Hiding feeback messages
                lblFeedback.Visible = false;
                pictureBoxTick.Visible = false;
            }
        }

        private void lblDishName_Click(object sender, EventArgs e) { }
        private void txtBoxDishName_TextChanged(object sender, EventArgs e) { }
        private void lblPrice_Click(object sender, EventArgs e) { }
        private void txtBoxPrice_TextChanged(object sender, EventArgs e) { }
        private void lblAvailability_Click(object sender, EventArgs e) { }
        private void checkBoxAvailable_CheckedChanged(object sender, EventArgs e) { }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lblFeedback.Visible = false;
            pictureBoxTick.Visible = false;
            feedbackTimer.Stop();

            if (radioBtnAdd.Checked)
            {
                AddDish();
            }

            else if (radioBtnRemove.Checked)
            {
                RemoveDish();
            }
        }


        //Method to add dish
        private void AddDish()
        {
            string dishName = txtBoxDishName.Text.Trim(); //Trim is to remove whitespaces
            string category = txtCategory.Text.Trim();
            string priceText = txtBoxPrice.Text.Trim();
            bool isAvailable = checkBoxAvailable.Checked;

            if (string.IsNullOrEmpty(dishName))
            {
                ShowFeedback("Dish Name cannot be empty.", Color.Red, false);
                return;
            }

            if (string.IsNullOrEmpty(category))
            {
                ShowFeedback("Category cannot be empty.", Color.Red, false);
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                ShowFeedback("Invalid Price. Please enter a valid price number.", Color.Red, false);
                return;
            }

            if (price <= 0)
            {
                ShowFeedback("Price should not be zero, it must be greater than zero.", Color.Red, false);
                return;
            }


            //SQL insert statement
            string query = "INSERT INTO MenuItem (Name, Category, Price, IsAvailable) VALUES (@Name, @Category, @Price, @IsAvailable)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", dishName);
                command.Parameters.AddWithValue("@Category", category);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@IsAvailable", isAvailable);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        ShowFeedback("✔ Dish added successfully!", Color.Green, true);

                        LoadMenuItems();

                        //Clear input section after succesfully added
                        txtBoxDishName.Text = "";
                        txtBoxPrice.Text = "";
                        checkBoxAvailable.Checked = true;
                    }

                    else
                    {
                        ShowFeedback("Failed to add dish. No rows affected.", Color.Red, false);
                    }
                }

                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601) // Unique constraint violation error numbers
                    {
                        ShowFeedback("Dish with this name already exists.", Color.Red, false);
                    }

                    else
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ShowFeedback("An unexpected error occurred.", Color.Red, false);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error adding dish: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShowFeedback("An unexpected error occurred.", Color.Red, false);
                }
            }
        }


        //Method for RemoveDish
        private void RemoveDish()
        {
            string dishNameToRemove = txtBoxDishName.Text.Trim();

            if (string.IsNullOrEmpty(dishNameToRemove))
            {
                ShowFeedback("Please enter a name of a dish to be removed.", Color.Red, false);
                return;
            }

            //Sql delete statement
            string query = "DELETE FROM MenuItem WHERE Name = @Name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", dishNameToRemove);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        ShowFeedback($"✔ Dish '{dishNameToRemove}' removed successfully!", Color.Green, true);
                        LoadMenuItems(); // Refresh the listbox
                        txtBoxDishName.Text = ""; // Clear input field after successful removal
                    }

                    else
                    {
                        ShowFeedback($"Dish '{dishNameToRemove}' not found.", Color.Red, false);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing dish: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShowFeedback("An unexpected error occurred while removing the dish.", Color.Red, false);
                }
            }
        }
        

        //Method for ShowFeedback
        private void ShowFeedback(string message, Color color, bool showTick)
        {
            lblFeedback.Text = message;
            lblFeedback.ForeColor = color;
            lblFeedback.Visible = true;
            pictureBoxTick.Visible = showTick;
            feedbackTimer.Start();
        }

        private void pictureBoxTick_Click(object sender, EventArgs e) { }
        private void lblFeedback_Click(object sender, EventArgs e) { }


        private void feedbackTimer_Tick(object sender, EventArgs e)
        {
            lblFeedback.Visible = false;
            pictureBoxTick.Visible = false;
            feedbackTimer.Stop();
        }


        private void lblCategory_Click(object sender, EventArgs e) { }
        private void txtCategory_TextChanged(object sender, EventArgs e) { }
    }
}
