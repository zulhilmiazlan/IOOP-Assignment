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
using System.Configuration;

namespace Assignment
{
    public partial class ChefOrdersForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SedapMakanDB"].ConnectionString;
        private Timer feedbackTimer;

        public ChefOrdersForm()
        {
            InitializeComponent();
            InitializeFormState();
            SetupFeedbackTimer();
        }

        private void InitializeFormState()
        {
            if (lblFeedback != null) lblFeedback.Visible = false;
            if (picTick != null) picTick.Visible = false;
        }


        private void SetupFeedbackTimer()
        {
            feedbackTimer = new Timer();
            feedbackTimer.Interval = 3000;
            feedbackTimer.Tick += FeedbackTimer_Tick;
        }


        private void FeedbackTimer_Tick(object sender, EventArgs e)
        {
            ShowFeedback("", Color.Black, false);
            feedbackTimer.Stop();
        }


        private void ChefOrdersForm_Load(object sender, EventArgs e)
        {
            //Load the existing orders when the form starts
            LoadInProgressOrders();

            tabControlOrders.SelectedIndexChanged += TabControlOrders_SelectedIndexChanged;

            btnComplete.Visible = true;
        }


        private void TabControlOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowFeedback("", Color.Black, false);

            if (tabControlOrders.SelectedTab == tabInProgress)
            {
                btnComplete.Visible = true;
            }

            else if (tabControlOrders.SelectedTab == tabCompleted)
            {
                LoadCompletedOrders();

                btnComplete.Visible = false;
            }

        }


        private void LoadInProgressOrders()
        {
            listBoxInProgressOrders.Items.Clear();
            ShowFeedback("", Color.Black, false);

            string query = @"
                SELECT 
                    o. OrderID, 
                    o.OrderDate,
                    o.TotalAmount,
                    STRING_AGG(mi.Name + ' (x' + CONVERT(NVARCHAR(10), oi.Quantity) +')', ', ') AS ItemsSummary
                FROM
                    Orders o
                JOIN
                    OrderItems oi ON o.OrderID = oi.OrderID
                JOIN
                    MenuItem mi ON oi.MenuItemID = mi.MenuItemID
                WHERE
                    o.Status = 'Pending'
                GROUP BY
                    o.OrderID, o.OrderDate, o.TotalAmount
                ORDER BY
                    o.OrderDate ASC;";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        listBoxInProgressOrders.Items.Add("No pending orders at the moment.");
                    }

                    while (reader.Read())
                    {
                        int orderID = (int)reader["OrderID"];
                        DateTime orderDate = (DateTime)reader["OrderDate"];
                        string itemsSummary = reader["ItemsSummary"].ToString();
                        decimal totalAmount = (decimal)reader["TotalAmount"];

                        listBoxInProgressOrders.Items.Add(new OrderDisplayItem
                        {
                            OrderID = orderID,
                            DisplayText = $"Order #{orderID} - {orderDate:yyyy-MM-dd HH:mm} -Total: RM{totalAmount:F2} - Items: {itemsSummary}"
                        });
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading in-progress orders: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShowFeedback("Failed to load orders.", Color.Red, false);
                }
            }

        }


        private void LoadCompletedOrders()
        {
            listBoxInProgressOrders.Items.Clear();
            ShowFeedback("", Color.Black, false);

            string query = @"
                SELECT
                    o.OrderID,
                    o.OrderDate,
                    o.TotalAmount,
                    STRING_AGG(mi.Name + '(x' + CONVERT(NVARCHAR(10), oi.Quantity) + ')', ', ') AS ItemsSummary
                FROM
                    Orders o
                JOIN
                    OrderItems oi ON o.OrderID = oi.OrderID
                JOIN
                    MenuItem mi ON oi.MenuItemID = mi.MenuItemID
                WHERE
                    o.Status = 'Completed'
                GROUP BY
                    o.OrderID, o.OrderDate, o.TotalAmount
                ORDER BY
                    o.OrderDate DESC;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        listBoxInProgressOrders.Items.Add("No completed orders at the moment.");

                    }

                    while (reader.Read())
                    {
                        int orderID = (int)reader["OrderID"];
                        DateTime orderDate = (DateTime)reader["OrderDate"];
                        string itemsSummary = reader["ItemsSummary"].ToString();
                        decimal totalAmount = (decimal)reader["TotalAmount"];

                        listBoxInProgressOrders.Items.Add(new OrderDisplayItem
                        {
                            OrderID = orderID,
                            DisplayText = $"Order #{orderID} - {orderDate:yyyy-MM-dd HH:mm} - Total: RM{totalAmount:F2} - Items: {itemsSummary}"
                        });
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading completed orders: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShowFeedback("Failed to load order.", Color.Red, false);
                }
            }
        }


        private void btnMarkAsComplete_Click(object sender, EventArgs e)
        {
            ShowFeedback("", Color.Black, false);
            feedbackTimer.Stop();

            if (listBoxInProgressOrders.SelectedItem == null)
            {
                ShowFeedback("Please select an order to mark as completed.", Color.Red, false);
                return;
            }

            if  (!(listBoxInProgressOrders.SelectedItem is OrderDisplayItem selectedOrder))
            {
                ShowFeedback("Invalid order selection. Please select a valid order.", Color.Red, false);
                return;
            }

            int orderIDToComplete = selectedOrder.OrderID;

            string query = "UPDATE Orders SET Status = 'Completed' WHERE OrderID = @OrderID AND Status = 'Pending'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderID", orderIDToComplete);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        ShowFeedback("✔ Order marked as completed successfully!", Color.Green, true);
                        LoadInProgressOrders(); //Refresh in-progress list
                    }

                    else
                    {
                        ShowFeedback("Failed to mark order as completed. Order not found or already completed/cancelled.", Color.Red, false);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error marking order as completed: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShowFeedback("An unexpected error occured.", Color.Red, false);
                }
            }
        }


        private void ShowFeedback(string message, Color color, bool showTick)
        {
            if (lblFeedback != null)
            {
                lblFeedback.Text = message;
                lblFeedback.ForeColor = color;
                lblFeedback.Visible = !string.IsNullOrEmpty(message);
            }

            if(picTick != null)
            {
                picTick.Visible = showTick;
            }

            if (showTick)
            {
                feedbackTimer.Start();
            }
        }


        public class OrderDisplayItem
        {
            public int OrderID { get; set; }
            public string DisplayText { get; set; }

            public override string ToString()
            {
                return DisplayText;
            }
        }

        private void picLogo_Click(object sender, EventArgs e) { }
        private void lblOrders_Click(object sender, EventArgs e) { }
        private void picOrders_Click(object sender, EventArgs e) { }
        private void tabInProgress_Click(object sender, EventArgs e) { }
        private void tabCompleted_Click(object sender, EventArgs e) { }
        private void btnComplete_Click(object sender, EventArgs e) { }
        private void picTick_Click(object sender, EventArgs e) { }
        private void lblFeedback_Click(object sender, EventArgs e) { }
        private void ChefOrdersForm_Load_1(object sender, EventArgs e) { }

        private void lstInProgress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
