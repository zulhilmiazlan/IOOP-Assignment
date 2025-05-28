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
    public partial class CustomerDashboardForm : Form
    {
        private User currentUser;

        public CustomerDashboardForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }
        private void btWallet_Click(object sender, EventArgs e)
        {

        }

        private void btBrowseOrder_Click(object sender, EventArgs e)
        {
            CustomerOrderForm orderForm = new CustomerOrderForm();
            orderForm.Show();
        }

        private void btCancelOrder_Click(object sender, EventArgs e)
        {
            CustomerCancelForm cancelForm = new CustomerCancelForm();
            cancelForm.Show();
        }

        private void btRefundstatus_Click(object sender, EventArgs e)
        {
            CustomerRefundForm refundForm = new CustomerRefundForm();
            refundForm.Show();
        }

        private void btSendFeedback_Click(object sender, EventArgs e)
        {
            CustomerFeedbackForm feedbackForm = new CustomerFeedbackForm();
            feedbackForm.Show();
        }

        private void btUpdateProfile_Click(object sender, EventArgs e)
        {
            UpdateProfileForm profileForm = new UpdateProfileForm();
            profileForm.Show();
        }

        private void CustomerDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
