using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Topup : Form
    {
        private User _loggedInUser;


        public Topup()
        {
            InitializeComponent();
        }

        public Topup (User user)
        {
            InitializeComponent();
            _loggedInUser = user;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn10_Click(object sender, EventArgs e)
        {
            amountText.Text = "10";
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            amountText.Text = "20";
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            amountText.Text = "30";
        }

        private void btn40_Click(object sender, EventArgs e)
        {
            amountText.Text = "40";
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            amountText.Text = "50";
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            amountText.Text = "100";
        }

        private void numberButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            amountText.Text = clickedButton.Text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagerDashboardForm managerDashboard = new ManagerDashboardForm(_loggedInUser);

            managerDashboard.Show();

            this.Hide();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string amount = amountText.Text;

            decimal topUpAmount;

            if (decimal.TryParse(amount, out topUpAmount))
            {
                if (topUpAmount < 10)
                {
                    MessageBox.Show("Please insert a minimum top-up amount of RM 10.", "Invalid Top-up Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    amountText.Clear();
                    amountText.Focus();

                }
                else
                {
                    MessageBox.Show($"Top-up amount of RM {topUpAmount:F2} is valid. Proceeding...", "Valid Top-up", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {

                MessageBox.Show("Please enter a valid numeric amount for top-up.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                amountText.Clear();
                amountText.Focus();
            }
        }

        private void Topup_Load(object sender, EventArgs e)
        {

        }
    }
}
