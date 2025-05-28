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
    public partial class CustomerFeedbackForm : Form
    {
        public CustomerFeedbackForm()
        {
            InitializeComponent();
        }

        private void btSumbitFeedback_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your feedback!", "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
