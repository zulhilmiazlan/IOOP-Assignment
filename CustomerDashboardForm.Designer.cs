namespace Assignment
{
    partial class CustomerDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboardForm));
            this.btRefundstatus = new System.Windows.Forms.Button();
            this.gbEwallet = new System.Windows.Forms.GroupBox();
            this.btTopUp = new System.Windows.Forms.Button();
            this.btWallet = new System.Windows.Forms.Button();
            this.lblSedapMakan = new System.Windows.Forms.Label();
            this.btUpdateProfile = new System.Windows.Forms.Button();
            this.btSendFeedback = new System.Windows.Forms.Button();
            this.btBrowseOrder = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblCustomerMainPage = new System.Windows.Forms.Label();
            this.btCancelOrder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbEwallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btRefundstatus
            // 
            this.btRefundstatus.BackColor = System.Drawing.Color.SandyBrown;
            this.btRefundstatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btRefundstatus.ForeColor = System.Drawing.Color.White;
            this.btRefundstatus.Location = new System.Drawing.Point(158, 239);
            this.btRefundstatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btRefundstatus.Name = "btRefundstatus";
            this.btRefundstatus.Size = new System.Drawing.Size(140, 51);
            this.btRefundstatus.TabIndex = 21;
            this.btRefundstatus.Text = "Refund Status";
            this.btRefundstatus.UseVisualStyleBackColor = false;
            this.btRefundstatus.Click += new System.EventHandler(this.btRefundstatus_Click);
            // 
            // gbEwallet
            // 
            this.gbEwallet.Controls.Add(this.btTopUp);
            this.gbEwallet.Controls.Add(this.btWallet);
            this.gbEwallet.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEwallet.Location = new System.Drawing.Point(206, 411);
            this.gbEwallet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEwallet.Name = "gbEwallet";
            this.gbEwallet.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEwallet.Size = new System.Drawing.Size(243, 140);
            this.gbEwallet.TabIndex = 19;
            this.gbEwallet.TabStop = false;
            this.gbEwallet.Text = "E-wallet Balance";
            // 
            // btTopUp
            // 
            this.btTopUp.BackColor = System.Drawing.Color.Silver;
            this.btTopUp.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTopUp.Location = new System.Drawing.Point(75, 107);
            this.btTopUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTopUp.Name = "btTopUp";
            this.btTopUp.Size = new System.Drawing.Size(91, 29);
            this.btTopUp.TabIndex = 1;
            this.btTopUp.Text = "Top Up";
            this.btTopUp.UseVisualStyleBackColor = false;
            // 
            // btWallet
            // 
            this.btWallet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btWallet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btWallet.ForeColor = System.Drawing.Color.White;
            this.btWallet.Location = new System.Drawing.Point(51, 45);
            this.btWallet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btWallet.Name = "btWallet";
            this.btWallet.Size = new System.Drawing.Size(140, 51);
            this.btWallet.TabIndex = 0;
            this.btWallet.Text = "RM 100.00";
            this.btWallet.UseVisualStyleBackColor = false;
            this.btWallet.Click += new System.EventHandler(this.btWallet_Click);
            // 
            // lblSedapMakan
            // 
            this.lblSedapMakan.AutoSize = true;
            this.lblSedapMakan.BackColor = System.Drawing.Color.Transparent;
            this.lblSedapMakan.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblSedapMakan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSedapMakan.Location = new System.Drawing.Point(239, 27);
            this.lblSedapMakan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSedapMakan.Name = "lblSedapMakan";
            this.lblSedapMakan.Size = new System.Drawing.Size(166, 35);
            this.lblSedapMakan.TabIndex = 18;
            this.lblSedapMakan.Text = "SedapMakan";
            // 
            // btUpdateProfile
            // 
            this.btUpdateProfile.BackColor = System.Drawing.Color.SandyBrown;
            this.btUpdateProfile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btUpdateProfile.ForeColor = System.Drawing.Color.White;
            this.btUpdateProfile.Location = new System.Drawing.Point(257, 323);
            this.btUpdateProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btUpdateProfile.Name = "btUpdateProfile";
            this.btUpdateProfile.Size = new System.Drawing.Size(140, 51);
            this.btUpdateProfile.TabIndex = 17;
            this.btUpdateProfile.Text = "Update Profile";
            this.btUpdateProfile.UseVisualStyleBackColor = false;
            this.btUpdateProfile.Click += new System.EventHandler(this.btUpdateProfile_Click);
            // 
            // btSendFeedback
            // 
            this.btSendFeedback.BackColor = System.Drawing.Color.SandyBrown;
            this.btSendFeedback.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btSendFeedback.ForeColor = System.Drawing.Color.White;
            this.btSendFeedback.Location = new System.Drawing.Point(361, 239);
            this.btSendFeedback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSendFeedback.Name = "btSendFeedback";
            this.btSendFeedback.Size = new System.Drawing.Size(140, 51);
            this.btSendFeedback.TabIndex = 16;
            this.btSendFeedback.Text = "Send Feedback";
            this.btSendFeedback.UseVisualStyleBackColor = false;
            this.btSendFeedback.Click += new System.EventHandler(this.btSendFeedback_Click);
            // 
            // btBrowseOrder
            // 
            this.btBrowseOrder.BackColor = System.Drawing.Color.SandyBrown;
            this.btBrowseOrder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btBrowseOrder.ForeColor = System.Drawing.Color.White;
            this.btBrowseOrder.Location = new System.Drawing.Point(158, 150);
            this.btBrowseOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btBrowseOrder.Name = "btBrowseOrder";
            this.btBrowseOrder.Size = new System.Drawing.Size(140, 51);
            this.btBrowseOrder.TabIndex = 15;
            this.btBrowseOrder.Text = " Browse Order";
            this.btBrowseOrder.UseVisualStyleBackColor = false;
            this.btBrowseOrder.Click += new System.EventHandler(this.btBrowseOrder_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.Red;
            this.lblWelcome.Location = new System.Drawing.Point(217, 104);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(207, 28);
            this.lblWelcome.TabIndex = 14;
            this.lblWelcome.Text = "Welcome, Customer!";
            // 
            // lblCustomerMainPage
            // 
            this.lblCustomerMainPage.AutoSize = true;
            this.lblCustomerMainPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCustomerMainPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCustomerMainPage.Location = new System.Drawing.Point(217, 68);
            this.lblCustomerMainPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerMainPage.Name = "lblCustomerMainPage";
            this.lblCustomerMainPage.Size = new System.Drawing.Size(208, 28);
            this.lblCustomerMainPage.TabIndex = 13;
            this.lblCustomerMainPage.Text = "Customer Main Page";
            // 
            // btCancelOrder
            // 
            this.btCancelOrder.BackColor = System.Drawing.Color.SandyBrown;
            this.btCancelOrder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btCancelOrder.ForeColor = System.Drawing.Color.White;
            this.btCancelOrder.Location = new System.Drawing.Point(361, 150);
            this.btCancelOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCancelOrder.Name = "btCancelOrder";
            this.btCancelOrder.Size = new System.Drawing.Size(140, 51);
            this.btCancelOrder.TabIndex = 22;
            this.btCancelOrder.Text = "Cancel Order";
            this.btCancelOrder.UseVisualStyleBackColor = false;
            this.btCancelOrder.Click += new System.EventHandler(this.btCancelOrder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(644, 551);
            this.Controls.Add(this.btCancelOrder);
            this.Controls.Add(this.btRefundstatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbEwallet);
            this.Controls.Add(this.lblSedapMakan);
            this.Controls.Add(this.btUpdateProfile);
            this.Controls.Add(this.btSendFeedback);
            this.Controls.Add(this.btBrowseOrder);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblCustomerMainPage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerDashboardForm";
            this.Text = "CustomerDashboardForm";
            this.Load += new System.EventHandler(this.CustomerDashboardForm_Load);
            this.gbEwallet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRefundstatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbEwallet;
        private System.Windows.Forms.Button btTopUp;
        private System.Windows.Forms.Button btWallet;
        private System.Windows.Forms.Label lblSedapMakan;
        private System.Windows.Forms.Button btUpdateProfile;
        private System.Windows.Forms.Button btSendFeedback;
        private System.Windows.Forms.Button btBrowseOrder;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblCustomerMainPage;
        private System.Windows.Forms.Button btCancelOrder;
    }
}