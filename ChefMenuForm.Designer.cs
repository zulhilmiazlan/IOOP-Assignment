namespace Assignment
{
    partial class ChefMenuForm
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
            this.components = new System.ComponentModel.Container();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpBoxUpdateMenu = new System.Windows.Forms.GroupBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.pictureBoxTick = new System.Windows.Forms.PictureBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtBoxDishName = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.checkBoxAvailable = new System.Windows.Forms.CheckBox();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDishName = new System.Windows.Forms.Label();
            this.radioBtnRemove = new System.Windows.Forms.RadioButton();
            this.radioBtnAdd = new System.Windows.Forms.RadioButton();
            this.grpBoxMenuList = new System.Windows.Forms.GroupBox();
            this.listBoxMenuList = new System.Windows.Forms.ListBox();
            this.feedbackTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxViewMenu = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.grpBoxUpdateMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTick)).BeginInit();
            this.grpBoxMenuList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeader.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeader.Location = new System.Drawing.Point(174, 27);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(149, 35);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Main Menu";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // grpBoxUpdateMenu
            // 
            this.grpBoxUpdateMenu.Controls.Add(this.txtCategory);
            this.grpBoxUpdateMenu.Controls.Add(this.lblCategory);
            this.grpBoxUpdateMenu.Controls.Add(this.lblFeedback);
            this.grpBoxUpdateMenu.Controls.Add(this.pictureBoxTick);
            this.grpBoxUpdateMenu.Controls.Add(this.btnConfirm);
            this.grpBoxUpdateMenu.Controls.Add(this.txtBoxDishName);
            this.grpBoxUpdateMenu.Controls.Add(this.txtBoxPrice);
            this.grpBoxUpdateMenu.Controls.Add(this.checkBoxAvailable);
            this.grpBoxUpdateMenu.Controls.Add(this.lblAvailability);
            this.grpBoxUpdateMenu.Controls.Add(this.lblPrice);
            this.grpBoxUpdateMenu.Controls.Add(this.lblDishName);
            this.grpBoxUpdateMenu.Controls.Add(this.radioBtnRemove);
            this.grpBoxUpdateMenu.Controls.Add(this.radioBtnAdd);
            this.grpBoxUpdateMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpBoxUpdateMenu.ForeColor = System.Drawing.Color.DarkOrange;
            this.grpBoxUpdateMenu.Location = new System.Drawing.Point(298, 119);
            this.grpBoxUpdateMenu.Name = "grpBoxUpdateMenu";
            this.grpBoxUpdateMenu.Size = new System.Drawing.Size(203, 284);
            this.grpBoxUpdateMenu.TabIndex = 9;
            this.grpBoxUpdateMenu.TabStop = false;
            this.grpBoxUpdateMenu.Text = "Update Menu:";
            this.grpBoxUpdateMenu.Enter += new System.EventHandler(this.grpBoxUpdateMenu_Enter);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblFeedback.ForeColor = System.Drawing.Color.Green;
            this.lblFeedback.Location = new System.Drawing.Point(25, 256);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(150, 15);
            this.lblFeedback.TabIndex = 10;
            this.lblFeedback.Text = "✔ Dish added successfully!";
            this.lblFeedback.Visible = false;
            this.lblFeedback.Click += new System.EventHandler(this.lblFeedback_Click);
            // 
            // pictureBoxTick
            // 
            this.pictureBoxTick.Image = global::Assignment.Properties.Resources.WhatsApp_Image_2025_05_09_at_4_53_38_PM;
            this.pictureBoxTick.Location = new System.Drawing.Point(128, 218);
            this.pictureBoxTick.Name = "pictureBoxTick";
            this.pictureBoxTick.Size = new System.Drawing.Size(41, 35);
            this.pictureBoxTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTick.TabIndex = 9;
            this.pictureBoxTick.TabStop = false;
            this.pictureBoxTick.Click += new System.EventHandler(this.pictureBoxTick_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirm.Location = new System.Drawing.Point(28, 218);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 35);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtBoxDishName
            // 
            this.txtBoxDishName.Location = new System.Drawing.Point(90, 71);
            this.txtBoxDishName.Name = "txtBoxDishName";
            this.txtBoxDishName.Size = new System.Drawing.Size(100, 30);
            this.txtBoxDishName.TabIndex = 7;
            this.txtBoxDishName.TextChanged += new System.EventHandler(this.txtBoxDishName_TextChanged);
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(90, 143);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(100, 30);
            this.txtBoxPrice.TabIndex = 6;
            this.txtBoxPrice.TextChanged += new System.EventHandler(this.txtBoxPrice_TextChanged);
            // 
            // checkBoxAvailable
            // 
            this.checkBoxAvailable.AutoSize = true;
            this.checkBoxAvailable.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.checkBoxAvailable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxAvailable.Location = new System.Drawing.Point(103, 189);
            this.checkBoxAvailable.Name = "checkBoxAvailable";
            this.checkBoxAvailable.Size = new System.Drawing.Size(85, 23);
            this.checkBoxAvailable.TabIndex = 5;
            this.checkBoxAvailable.Text = "Available";
            this.checkBoxAvailable.UseVisualStyleBackColor = true;
            this.checkBoxAvailable.CheckedChanged += new System.EventHandler(this.checkBoxAvailable_CheckedChanged);
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAvailability.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAvailability.Location = new System.Drawing.Point(11, 189);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(86, 20);
            this.lblAvailability.TabIndex = 4;
            this.lblAvailability.Text = "Availability:";
            this.lblAvailability.Click += new System.EventHandler(this.lblAvailability_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrice.Location = new System.Drawing.Point(7, 148);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(80, 20);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price (RM):";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblDishName
            // 
            this.lblDishName.AutoSize = true;
            this.lblDishName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDishName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDishName.Location = new System.Drawing.Point(5, 76);
            this.lblDishName.Name = "lblDishName";
            this.lblDishName.Size = new System.Drawing.Size(85, 20);
            this.lblDishName.TabIndex = 2;
            this.lblDishName.Text = "Dish Name:";
            this.lblDishName.Click += new System.EventHandler(this.lblDishName_Click);
            // 
            // radioBtnRemove
            // 
            this.radioBtnRemove.AutoSize = true;
            this.radioBtnRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.radioBtnRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioBtnRemove.Location = new System.Drawing.Point(103, 32);
            this.radioBtnRemove.Name = "radioBtnRemove";
            this.radioBtnRemove.Size = new System.Drawing.Size(87, 24);
            this.radioBtnRemove.TabIndex = 1;
            this.radioBtnRemove.TabStop = true;
            this.radioBtnRemove.Text = "Remove";
            this.radioBtnRemove.UseVisualStyleBackColor = true;
            this.radioBtnRemove.CheckedChanged += new System.EventHandler(this.radioBtnRemove_CheckedChanged);
            // 
            // radioBtnAdd
            // 
            this.radioBtnAdd.AutoSize = true;
            this.radioBtnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.radioBtnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioBtnAdd.Location = new System.Drawing.Point(34, 32);
            this.radioBtnAdd.Name = "radioBtnAdd";
            this.radioBtnAdd.Size = new System.Drawing.Size(59, 24);
            this.radioBtnAdd.TabIndex = 0;
            this.radioBtnAdd.TabStop = true;
            this.radioBtnAdd.Text = "Add";
            this.radioBtnAdd.UseVisualStyleBackColor = true;
            this.radioBtnAdd.CheckedChanged += new System.EventHandler(this.radioBtnAdd_CheckedChanged);
            // 
            // grpBoxMenuList
            // 
            this.grpBoxMenuList.Controls.Add(this.listBoxMenuList);
            this.grpBoxMenuList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpBoxMenuList.ForeColor = System.Drawing.Color.DarkOrange;
            this.grpBoxMenuList.Location = new System.Drawing.Point(24, 119);
            this.grpBoxMenuList.Name = "grpBoxMenuList";
            this.grpBoxMenuList.Size = new System.Drawing.Size(250, 284);
            this.grpBoxMenuList.TabIndex = 11;
            this.grpBoxMenuList.TabStop = false;
            this.grpBoxMenuList.Text = "Menu List:";
            this.grpBoxMenuList.Enter += new System.EventHandler(this.grpBoxMenuList_Enter);
            // 
            // listBoxMenuList
            // 
            this.listBoxMenuList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.listBoxMenuList.FormattingEnabled = true;
            this.listBoxMenuList.ItemHeight = 20;
            this.listBoxMenuList.Location = new System.Drawing.Point(16, 32);
            this.listBoxMenuList.Name = "listBoxMenuList";
            this.listBoxMenuList.Size = new System.Drawing.Size(216, 244);
            this.listBoxMenuList.TabIndex = 0;
            this.listBoxMenuList.SelectedIndexChanged += new System.EventHandler(this.listBoxMenuList_SelectedIndexChanged);
            // 
            // feedbackTimer
            // 
            this.feedbackTimer.Interval = 3000;
            this.feedbackTimer.Tick += new System.EventHandler(this.feedbackTimer_Tick);
            // 
            // pictureBoxViewMenu
            // 
            this.pictureBoxViewMenu.Image = global::Assignment.Properties.Resources.menu;
            this.pictureBoxViewMenu.Location = new System.Drawing.Point(332, 27);
            this.pictureBoxViewMenu.Name = "pictureBoxViewMenu";
            this.pictureBoxViewMenu.Size = new System.Drawing.Size(53, 47);
            this.pictureBoxViewMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxViewMenu.TabIndex = 10;
            this.pictureBoxViewMenu.TabStop = false;
            this.pictureBoxViewMenu.Click += new System.EventHandler(this.pictureBoxViewMenu_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Assignment.Properties.Resources.logo1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(56, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 6;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(90, 107);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(100, 30);
            this.txtCategory.TabIndex = 12;
            this.txtCategory.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCategory.Location = new System.Drawing.Point(7, 112);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(72, 20);
            this.lblCategory.TabIndex = 11;
            this.lblCategory.Text = "Category:";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // ChefMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(553, 458);
            this.Controls.Add(this.grpBoxMenuList);
            this.Controls.Add(this.pictureBoxViewMenu);
            this.Controls.Add(this.grpBoxUpdateMenu);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.lblHeader);
            this.Name = "ChefMenuForm";
            this.Text = "ChefMenuForm";
            this.Load += new System.EventHandler(this.ChefMenuForm_Load);
            this.grpBoxUpdateMenu.ResumeLayout(false);
            this.grpBoxUpdateMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTick)).EndInit();
            this.grpBoxMenuList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.GroupBox grpBoxUpdateMenu;
        private System.Windows.Forms.RadioButton radioBtnRemove;
        private System.Windows.Forms.RadioButton radioBtnAdd;
        private System.Windows.Forms.TextBox txtBoxDishName;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.CheckBox checkBoxAvailable;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDishName;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.PictureBox pictureBoxViewMenu;
        private System.Windows.Forms.GroupBox grpBoxMenuList;
        private System.Windows.Forms.ListBox listBoxMenuList;
        private System.Windows.Forms.PictureBox pictureBoxTick;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Timer feedbackTimer;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
    }
}