namespace Assignment
{
    partial class AdminDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabAddorRemoveUsers = new System.Windows.Forms.TabPage();
            this.lblAddorRemoveUsers = new System.Windows.Forms.Label();
            this.tabUpdateUserProfile = new System.Windows.Forms.TabPage();
            this.lblUpdateRole = new System.Windows.Forms.Label();
            this.cbUpdateRole = new System.Windows.Forms.ComboBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.lblNewEmail = new System.Windows.Forms.Label();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.lblCurrentEmail = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSearchEmail = new System.Windows.Forms.TextBox();
            this.tabSalesReport = new System.Windows.Forms.TabPage();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.dgvSalesReport = new System.Windows.Forms.DataGridView();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.cbChef = new System.Windows.Forms.ComboBox();
            this.lblSelectChef = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblSelectCategory = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.lblSalesReport = new System.Windows.Forms.Label();
            this.tabEWallet = new System.Windows.Forms.TabPage();
            this.txtCustomerEmailEWallet = new System.Windows.Forms.TextBox();
            this.lblTotalSpent = new System.Windows.Forms.Label();
            this.lblTotalTopUps = new System.Windows.Forms.Label();
            this.dgvEWalletReport = new System.Windows.Forms.DataGridView();
            this.btnViewEWalletReport = new System.Windows.Forms.Button();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.cbYearEWallet = new System.Windows.Forms.Label();
            this.cbMonthEWallet = new System.Windows.Forms.Label();
            this.cbEWalletYear = new System.Windows.Forms.ComboBox();
            this.cbEWalletMonth = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEWallet = new System.Windows.Forms.Label();
            this.tabMyProfile = new System.Windows.Forms.TabPage();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.lblMyPassword = new System.Windows.Forms.Label();
            this.txtMyPassword = new System.Windows.Forms.TextBox();
            this.lblMyEmail = new System.Windows.Forms.Label();
            this.lblTitleProfile = new System.Windows.Forms.Label();
            this.txtMyEmail = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabAddorRemoveUsers.SuspendLayout();
            this.tabUpdateUserProfile.SuspendLayout();
            this.tabSalesReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            this.tabEWallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEWalletReport)).BeginInit();
            this.tabMyProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(235, 197);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(134, 24);
            this.btnAddUser.TabIndex = 18;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(372, 197);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(134, 24);
            this.btnRemoveUser.TabIndex = 21;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(64, 124);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(165, 27);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(101, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(128, 27);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(235, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(271, 22);
            this.txtEmail.TabIndex = 19;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(235, 128);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(271, 22);
            this.txtPassword.TabIndex = 7;
            // 
            // lblRole
            // 
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(113, 151);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(116, 27);
            this.lblRole.TabIndex = 10;
            this.lblRole.Text = "Role:";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "SystemAdmin",
            "Manager",
            "Chef",
            "Customer"});
            this.cbRole.Location = new System.Drawing.Point(235, 156);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(271, 24);
            this.cbRole.TabIndex = 9;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHome);
            this.tabControl.Controls.Add(this.tabAddorRemoveUsers);
            this.tabControl.Controls.Add(this.tabUpdateUserProfile);
            this.tabControl.Controls.Add(this.tabSalesReport);
            this.tabControl.Controls.Add(this.tabEWallet);
            this.tabControl.Controls.Add(this.tabMyProfile);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(591, 554);
            this.tabControl.TabIndex = 22;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.Moccasin;
            this.tabHome.Controls.Add(this.btnExit);
            this.tabHome.Controls.Add(this.lblWelcome);
            this.tabHome.Controls.Add(this.pictureBox1);
            this.tabHome.Location = new System.Drawing.Point(4, 25);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(583, 525);
            this.tabHome.TabIndex = 4;
            this.tabHome.Text = "Home";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(499, 482);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 40);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(386, 28);
            this.lblWelcome.TabIndex = 22;
            this.lblWelcome.Text = "Admin Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 422);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // tabAddorRemoveUsers
            // 
            this.tabAddorRemoveUsers.BackColor = System.Drawing.Color.Moccasin;
            this.tabAddorRemoveUsers.Controls.Add(this.lblAddorRemoveUsers);
            this.tabAddorRemoveUsers.Controls.Add(this.btnRemoveUser);
            this.tabAddorRemoveUsers.Controls.Add(this.btnAddUser);
            this.tabAddorRemoveUsers.Controls.Add(this.txtEmail);
            this.tabAddorRemoveUsers.Controls.Add(this.txtPassword);
            this.tabAddorRemoveUsers.Controls.Add(this.cbRole);
            this.tabAddorRemoveUsers.Controls.Add(this.lblEmail);
            this.tabAddorRemoveUsers.Controls.Add(this.lblPassword);
            this.tabAddorRemoveUsers.Controls.Add(this.lblRole);
            this.tabAddorRemoveUsers.Location = new System.Drawing.Point(4, 25);
            this.tabAddorRemoveUsers.Name = "tabAddorRemoveUsers";
            this.tabAddorRemoveUsers.Size = new System.Drawing.Size(583, 525);
            this.tabAddorRemoveUsers.TabIndex = 0;
            this.tabAddorRemoveUsers.Text = "Add or Remove Users";
            // 
            // lblAddorRemoveUsers
            // 
            this.lblAddorRemoveUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddorRemoveUsers.Location = new System.Drawing.Point(14, 14);
            this.lblAddorRemoveUsers.Name = "lblAddorRemoveUsers";
            this.lblAddorRemoveUsers.Size = new System.Drawing.Size(492, 28);
            this.lblAddorRemoveUsers.TabIndex = 23;
            this.lblAddorRemoveUsers.Text = "Add or Remove Users";
            // 
            // tabUpdateUserProfile
            // 
            this.tabUpdateUserProfile.BackColor = System.Drawing.Color.Moccasin;
            this.tabUpdateUserProfile.Controls.Add(this.lblUpdateRole);
            this.tabUpdateUserProfile.Controls.Add(this.cbUpdateRole);
            this.tabUpdateUserProfile.Controls.Add(this.btnUpdateUser);
            this.tabUpdateUserProfile.Controls.Add(this.lblNewEmail);
            this.tabUpdateUserProfile.Controls.Add(this.txtUpdateEmail);
            this.tabUpdateUserProfile.Controls.Add(this.btnSearchUser);
            this.tabUpdateUserProfile.Controls.Add(this.lblCurrentEmail);
            this.tabUpdateUserProfile.Controls.Add(this.lblTitle);
            this.tabUpdateUserProfile.Controls.Add(this.txtSearchEmail);
            this.tabUpdateUserProfile.Location = new System.Drawing.Point(4, 25);
            this.tabUpdateUserProfile.Name = "tabUpdateUserProfile";
            this.tabUpdateUserProfile.Size = new System.Drawing.Size(583, 525);
            this.tabUpdateUserProfile.TabIndex = 0;
            this.tabUpdateUserProfile.Text = "Update User Profile";
            // 
            // lblUpdateRole
            // 
            this.lblUpdateRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateRole.Location = new System.Drawing.Point(45, 140);
            this.lblUpdateRole.Name = "lblUpdateRole";
            this.lblUpdateRole.Size = new System.Drawing.Size(203, 23);
            this.lblUpdateRole.TabIndex = 9;
            this.lblUpdateRole.Text = "Change Role:";
            // 
            // cbUpdateRole
            // 
            this.cbUpdateRole.FormattingEnabled = true;
            this.cbUpdateRole.Items.AddRange(new object[] {
            "System Admin",
            "Manager",
            "Chef",
            "Customer"});
            this.cbUpdateRole.Location = new System.Drawing.Point(254, 140);
            this.cbUpdateRole.Name = "cbUpdateRole";
            this.cbUpdateRole.Size = new System.Drawing.Size(208, 24);
            this.cbUpdateRole.TabIndex = 8;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(468, 140);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateUser.TabIndex = 7;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // lblNewEmail
            // 
            this.lblNewEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewEmail.Location = new System.Drawing.Point(64, 111);
            this.lblNewEmail.Name = "lblNewEmail";
            this.lblNewEmail.Size = new System.Drawing.Size(184, 23);
            this.lblNewEmail.TabIndex = 6;
            this.lblNewEmail.Text = "New Email:";
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Location = new System.Drawing.Point(254, 112);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(208, 22);
            this.txtUpdateEmail.TabIndex = 5;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(468, 69);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(75, 23);
            this.btnSearchUser.TabIndex = 4;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // lblCurrentEmail
            // 
            this.lblCurrentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentEmail.Location = new System.Drawing.Point(41, 68);
            this.lblCurrentEmail.Name = "lblCurrentEmail";
            this.lblCurrentEmail.Size = new System.Drawing.Size(207, 23);
            this.lblCurrentEmail.TabIndex = 3;
            this.lblCurrentEmail.Text = "Current Email:";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(472, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Update User Profile";
            // 
            // txtSearchEmail
            // 
            this.txtSearchEmail.Location = new System.Drawing.Point(254, 69);
            this.txtSearchEmail.Name = "txtSearchEmail";
            this.txtSearchEmail.Size = new System.Drawing.Size(208, 22);
            this.txtSearchEmail.TabIndex = 0;
            // 
            // tabSalesReport
            // 
            this.tabSalesReport.BackColor = System.Drawing.Color.Moccasin;
            this.tabSalesReport.Controls.Add(this.lblTotalSales);
            this.tabSalesReport.Controls.Add(this.dgvSalesReport);
            this.tabSalesReport.Controls.Add(this.btnViewReport);
            this.tabSalesReport.Controls.Add(this.cbChef);
            this.tabSalesReport.Controls.Add(this.lblSelectChef);
            this.tabSalesReport.Controls.Add(this.cbCategory);
            this.tabSalesReport.Controls.Add(this.lblSelectCategory);
            this.tabSalesReport.Controls.Add(this.lblYear);
            this.tabSalesReport.Controls.Add(this.lblMonth);
            this.tabSalesReport.Controls.Add(this.cbYear);
            this.tabSalesReport.Controls.Add(this.cbMonth);
            this.tabSalesReport.Controls.Add(this.lblSelectDate);
            this.tabSalesReport.Controls.Add(this.lblSalesReport);
            this.tabSalesReport.Location = new System.Drawing.Point(4, 25);
            this.tabSalesReport.Name = "tabSalesReport";
            this.tabSalesReport.Size = new System.Drawing.Size(583, 525);
            this.tabSalesReport.TabIndex = 1;
            this.tabSalesReport.Text = "Sales Report";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.Location = new System.Drawing.Point(16, 488);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(438, 23);
            this.lblTotalSales.TabIndex = 15;
            this.lblTotalSales.Text = "Total Sales:";
            // 
            // dgvSalesReport
            // 
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReport.Location = new System.Drawing.Point(32, 230);
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.RowHeadersWidth = 51;
            this.dgvSalesReport.RowTemplate.Height = 24;
            this.dgvSalesReport.Size = new System.Drawing.Size(525, 238);
            this.dgvSalesReport.TabIndex = 14;
            // 
            // btnViewReport
            // 
            this.btnViewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.Location = new System.Drawing.Point(416, 69);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(153, 154);
            this.btnViewReport.TabIndex = 13;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // cbChef
            // 
            this.cbChef.FormattingEnabled = true;
            this.cbChef.Location = new System.Drawing.Point(190, 200);
            this.cbChef.Name = "cbChef";
            this.cbChef.Size = new System.Drawing.Size(208, 24);
            this.cbChef.TabIndex = 12;
            // 
            // lblSelectChef
            // 
            this.lblSelectChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectChef.Location = new System.Drawing.Point(16, 201);
            this.lblSelectChef.Name = "lblSelectChef";
            this.lblSelectChef.Size = new System.Drawing.Size(168, 23);
            this.lblSelectChef.TabIndex = 11;
            this.lblSelectChef.Text = "Select chef:";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(190, 138);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(208, 24);
            this.cbCategory.TabIndex = 10;
            // 
            // lblSelectCategory
            // 
            this.lblSelectCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCategory.Location = new System.Drawing.Point(15, 139);
            this.lblSelectCategory.Name = "lblSelectCategory";
            this.lblSelectCategory.Size = new System.Drawing.Size(169, 23);
            this.lblSelectCategory.TabIndex = 9;
            this.lblSelectCategory.Text = "Select category:";
            // 
            // lblYear
            // 
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(317, 97);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(81, 24);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonth
            // 
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(190, 98);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(118, 23);
            this.lblMonth.TabIndex = 7;
            this.lblMonth.Text = "Month";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(317, 70);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(81, 24);
            this.cbYear.TabIndex = 5;
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(190, 71);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(121, 24);
            this.cbMonth.TabIndex = 4;
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(19, 72);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(165, 23);
            this.lblSelectDate.TabIndex = 3;
            this.lblSelectDate.Text = "Select date:";
            // 
            // lblSalesReport
            // 
            this.lblSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesReport.Location = new System.Drawing.Point(14, 13);
            this.lblSalesReport.Name = "lblSalesReport";
            this.lblSalesReport.Size = new System.Drawing.Size(566, 23);
            this.lblSalesReport.TabIndex = 2;
            this.lblSalesReport.Text = "Sales Report";
            // 
            // tabEWallet
            // 
            this.tabEWallet.BackColor = System.Drawing.Color.Moccasin;
            this.tabEWallet.Controls.Add(this.txtCustomerEmailEWallet);
            this.tabEWallet.Controls.Add(this.lblTotalSpent);
            this.tabEWallet.Controls.Add(this.lblTotalTopUps);
            this.tabEWallet.Controls.Add(this.dgvEWalletReport);
            this.tabEWallet.Controls.Add(this.btnViewEWalletReport);
            this.tabEWallet.Controls.Add(this.lblCustomerEmail);
            this.tabEWallet.Controls.Add(this.cbYearEWallet);
            this.tabEWallet.Controls.Add(this.cbMonthEWallet);
            this.tabEWallet.Controls.Add(this.cbEWalletYear);
            this.tabEWallet.Controls.Add(this.cbEWalletMonth);
            this.tabEWallet.Controls.Add(this.lblDate);
            this.tabEWallet.Controls.Add(this.lblEWallet);
            this.tabEWallet.Location = new System.Drawing.Point(4, 25);
            this.tabEWallet.Name = "tabEWallet";
            this.tabEWallet.Size = new System.Drawing.Size(583, 525);
            this.tabEWallet.TabIndex = 2;
            this.tabEWallet.Text = "E-Wallet";
            // 
            // txtCustomerEmailEWallet
            // 
            this.txtCustomerEmailEWallet.Location = new System.Drawing.Point(191, 71);
            this.txtCustomerEmailEWallet.Name = "txtCustomerEmailEWallet";
            this.txtCustomerEmailEWallet.Size = new System.Drawing.Size(208, 22);
            this.txtCustomerEmailEWallet.TabIndex = 28;
            // 
            // lblTotalSpent
            // 
            this.lblTotalSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSpent.Location = new System.Drawing.Point(289, 459);
            this.lblTotalSpent.Name = "lblTotalSpent";
            this.lblTotalSpent.Size = new System.Drawing.Size(291, 23);
            this.lblTotalSpent.TabIndex = 27;
            this.lblTotalSpent.Text = "Total Spent:";
            // 
            // lblTotalTopUps
            // 
            this.lblTotalTopUps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTopUps.Location = new System.Drawing.Point(20, 459);
            this.lblTotalTopUps.Name = "lblTotalTopUps";
            this.lblTotalTopUps.Size = new System.Drawing.Size(292, 23);
            this.lblTotalTopUps.TabIndex = 26;
            this.lblTotalTopUps.Text = "Total top-ups:";
            // 
            // dgvEWalletReport
            // 
            this.dgvEWalletReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEWalletReport.Location = new System.Drawing.Point(20, 184);
            this.dgvEWalletReport.Name = "dgvEWalletReport";
            this.dgvEWalletReport.RowHeadersWidth = 51;
            this.dgvEWalletReport.RowTemplate.Height = 24;
            this.dgvEWalletReport.Size = new System.Drawing.Size(538, 249);
            this.dgvEWalletReport.TabIndex = 25;
            // 
            // btnViewEWalletReport
            // 
            this.btnViewEWalletReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEWalletReport.Location = new System.Drawing.Point(405, 71);
            this.btnViewEWalletReport.Name = "btnViewEWalletReport";
            this.btnViewEWalletReport.Size = new System.Drawing.Size(153, 74);
            this.btnViewEWalletReport.TabIndex = 24;
            this.btnViewEWalletReport.Text = "View e-Wallet Report";
            this.btnViewEWalletReport.UseVisualStyleBackColor = true;
            this.btnViewEWalletReport.Click += new System.EventHandler(this.btnViewEWalletReport_Click);
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerEmail.Location = new System.Drawing.Point(16, 71);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(182, 23);
            this.lblCustomerEmail.TabIndex = 22;
            this.lblCustomerEmail.Text = "Customer Email:";
            // 
            // cbYearEWallet
            // 
            this.cbYearEWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYearEWallet.Location = new System.Drawing.Point(318, 147);
            this.cbYearEWallet.Name = "cbYearEWallet";
            this.cbYearEWallet.Size = new System.Drawing.Size(81, 24);
            this.cbYearEWallet.TabIndex = 19;
            this.cbYearEWallet.Text = "Year";
            this.cbYearEWallet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMonthEWallet
            // 
            this.cbMonthEWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonthEWallet.Location = new System.Drawing.Point(191, 148);
            this.cbMonthEWallet.Name = "cbMonthEWallet";
            this.cbMonthEWallet.Size = new System.Drawing.Size(118, 23);
            this.cbMonthEWallet.TabIndex = 18;
            this.cbMonthEWallet.Text = "Month";
            this.cbMonthEWallet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbEWalletYear
            // 
            this.cbEWalletYear.FormattingEnabled = true;
            this.cbEWalletYear.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025"});
            this.cbEWalletYear.Location = new System.Drawing.Point(318, 120);
            this.cbEWalletYear.Name = "cbEWalletYear";
            this.cbEWalletYear.Size = new System.Drawing.Size(81, 24);
            this.cbEWalletYear.TabIndex = 17;
            // 
            // cbEWalletMonth
            // 
            this.cbEWalletMonth.FormattingEnabled = true;
            this.cbEWalletMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbEWalletMonth.Location = new System.Drawing.Point(191, 121);
            this.cbEWalletMonth.Name = "cbEWalletMonth";
            this.cbEWalletMonth.Size = new System.Drawing.Size(121, 24);
            this.cbEWalletMonth.TabIndex = 16;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(16, 122);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(169, 23);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Select date:";
            // 
            // lblEWallet
            // 
            this.lblEWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEWallet.Location = new System.Drawing.Point(15, 13);
            this.lblEWallet.Name = "lblEWallet";
            this.lblEWallet.Size = new System.Drawing.Size(126, 23);
            this.lblEWallet.TabIndex = 14;
            this.lblEWallet.Text = "e-Wallet";
            // 
            // tabMyProfile
            // 
            this.tabMyProfile.BackColor = System.Drawing.Color.Moccasin;
            this.tabMyProfile.Controls.Add(this.btnSaveChange);
            this.tabMyProfile.Controls.Add(this.lblMyPassword);
            this.tabMyProfile.Controls.Add(this.txtMyPassword);
            this.tabMyProfile.Controls.Add(this.lblMyEmail);
            this.tabMyProfile.Controls.Add(this.lblTitleProfile);
            this.tabMyProfile.Controls.Add(this.txtMyEmail);
            this.tabMyProfile.Location = new System.Drawing.Point(4, 25);
            this.tabMyProfile.Name = "tabMyProfile";
            this.tabMyProfile.Size = new System.Drawing.Size(583, 525);
            this.tabMyProfile.TabIndex = 3;
            this.tabMyProfile.Text = "My Profile";
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.Location = new System.Drawing.Point(417, 447);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(153, 62);
            this.btnSaveChange.TabIndex = 16;
            this.btnSaveChange.Text = "Save";
            this.btnSaveChange.UseVisualStyleBackColor = true;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // lblMyPassword
            // 
            this.lblMyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyPassword.Location = new System.Drawing.Point(30, 106);
            this.lblMyPassword.Name = "lblMyPassword";
            this.lblMyPassword.Size = new System.Drawing.Size(230, 23);
            this.lblMyPassword.TabIndex = 15;
            this.lblMyPassword.Text = "New Password:";
            // 
            // txtMyPassword
            // 
            this.txtMyPassword.Location = new System.Drawing.Point(266, 106);
            this.txtMyPassword.Name = "txtMyPassword";
            this.txtMyPassword.Size = new System.Drawing.Size(208, 22);
            this.txtMyPassword.TabIndex = 14;
            // 
            // lblMyEmail
            // 
            this.lblMyEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyEmail.Location = new System.Drawing.Point(39, 63);
            this.lblMyEmail.Name = "lblMyEmail";
            this.lblMyEmail.Size = new System.Drawing.Size(221, 23);
            this.lblMyEmail.TabIndex = 12;
            this.lblMyEmail.Text = "Current Email:";
            // 
            // lblTitleProfile
            // 
            this.lblTitleProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleProfile.Location = new System.Drawing.Point(14, 15);
            this.lblTitleProfile.Name = "lblTitleProfile";
            this.lblTitleProfile.Size = new System.Drawing.Size(188, 23);
            this.lblTitleProfile.TabIndex = 11;
            this.lblTitleProfile.Text = "Update Your Profile";
            // 
            // txtMyEmail
            // 
            this.txtMyEmail.Location = new System.Drawing.Point(266, 63);
            this.txtMyEmail.Name = "txtMyEmail";
            this.txtMyEmail.Size = new System.Drawing.Size(208, 22);
            this.txtMyEmail.TabIndex = 10;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(615, 578);
            this.Controls.Add(this.tabControl);
            this.Name = "AdminDashboardForm";
            this.Text = "AdminDashboardForm";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabAddorRemoveUsers.ResumeLayout(false);
            this.tabAddorRemoveUsers.PerformLayout();
            this.tabUpdateUserProfile.ResumeLayout(false);
            this.tabUpdateUserProfile.PerformLayout();
            this.tabSalesReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).EndInit();
            this.tabEWallet.ResumeLayout(false);
            this.tabEWallet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEWalletReport)).EndInit();
            this.tabMyProfile.ResumeLayout(false);
            this.tabMyProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAddorRemoveUsers;
        private System.Windows.Forms.TabPage tabUpdateUserProfile;
        private System.Windows.Forms.TextBox txtSearchEmail;
        private System.Windows.Forms.Label lblCurrentEmail;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Label lblNewEmail;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.Label lblUpdateRole;
        private System.Windows.Forms.ComboBox cbUpdateRole;
        private System.Windows.Forms.TabPage tabSalesReport;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.Label lblSalesReport;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.DataGridView dgvSalesReport;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.ComboBox cbChef;
        private System.Windows.Forms.Label lblSelectChef;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblSelectCategory;
        private System.Windows.Forms.TabPage tabEWallet;
        private System.Windows.Forms.Button btnViewEWalletReport;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEWallet;
        private System.Windows.Forms.Label cbYearEWallet;
        private System.Windows.Forms.Label cbMonthEWallet;
        private System.Windows.Forms.ComboBox cbEWalletYear;
        private System.Windows.Forms.ComboBox cbEWalletMonth;
        private System.Windows.Forms.Label lblTotalSpent;
        private System.Windows.Forms.Label lblTotalTopUps;
        private System.Windows.Forms.DataGridView dgvEWalletReport;
        private System.Windows.Forms.TabPage tabMyProfile;
        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.Label lblMyPassword;
        private System.Windows.Forms.TextBox txtMyPassword;
        private System.Windows.Forms.Label lblMyEmail;
        private System.Windows.Forms.Label lblTitleProfile;
        private System.Windows.Forms.TextBox txtMyEmail;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAddorRemoveUsers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCustomerEmailEWallet;
    }
}