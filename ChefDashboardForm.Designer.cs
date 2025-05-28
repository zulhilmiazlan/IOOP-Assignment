﻿namespace Assignment
{
    partial class ChefDashboardForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnViewMenu = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.lblChef = new System.Windows.Forms.Label();
            this.picOrders = new System.Windows.Forms.PictureBox();
            this.picViewMenu = new System.Windows.Forms.PictureBox();
            this.picUpdateProfile = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeader.Location = new System.Drawing.Point(248, 48);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(319, 54);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Chef Main Page";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.SandyBrown;
            this.btnUpdateProfile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUpdateProfile.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProfile.Location = new System.Drawing.Point(237, 211);
            this.btnUpdateProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(210, 80);
            this.btnUpdateProfile.TabIndex = 2;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnViewMenu
            // 
            this.btnViewMenu.BackColor = System.Drawing.Color.SandyBrown;
            this.btnViewMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMenu.ForeColor = System.Drawing.Color.White;
            this.btnViewMenu.Location = new System.Drawing.Point(237, 336);
            this.btnViewMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewMenu.Name = "btnViewMenu";
            this.btnViewMenu.Size = new System.Drawing.Size(210, 77);
            this.btnViewMenu.TabIndex = 3;
            this.btnViewMenu.Text = "View Menu";
            this.btnViewMenu.UseVisualStyleBackColor = false;
            this.btnViewMenu.Click += new System.EventHandler(this.btnViewMenu_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.SandyBrown;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Location = new System.Drawing.Point(237, 450);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(210, 80);
            this.btnOrders.TabIndex = 4;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // lblChef
            // 
            this.lblChef.AutoSize = true;
            this.lblChef.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChef.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblChef.Location = new System.Drawing.Point(267, 128);
            this.lblChef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChef.Name = "lblChef";
            this.lblChef.Size = new System.Drawing.Size(254, 45);
            this.lblChef.TabIndex = 9;
            this.lblChef.Text = "Welcome, Chef!";
            this.lblChef.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChef.Click += new System.EventHandler(this.lblChef_Click);
            // 
            // picOrders
            // 
            this.picOrders.Image = global::Assignment.Properties.Resources.orders;
            this.picOrders.Location = new System.Drawing.Point(476, 450);
            this.picOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picOrders.Name = "picOrders";
            this.picOrders.Size = new System.Drawing.Size(82, 80);
            this.picOrders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOrders.TabIndex = 8;
            this.picOrders.TabStop = false;
            this.picOrders.Click += new System.EventHandler(this.picOrders_Click);
            // 
            // picViewMenu
            // 
            this.picViewMenu.Image = global::Assignment.Properties.Resources.menu;
            this.picViewMenu.Location = new System.Drawing.Point(476, 336);
            this.picViewMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picViewMenu.Name = "picViewMenu";
            this.picViewMenu.Size = new System.Drawing.Size(82, 80);
            this.picViewMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picViewMenu.TabIndex = 7;
            this.picViewMenu.TabStop = false;
            this.picViewMenu.Click += new System.EventHandler(this.picViewMenu_Click);
            // 
            // picUpdateProfile
            // 
            this.picUpdateProfile.Image = global::Assignment.Properties.Resources.profile;
            this.picUpdateProfile.Location = new System.Drawing.Point(476, 211);
            this.picUpdateProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picUpdateProfile.Name = "picUpdateProfile";
            this.picUpdateProfile.Size = new System.Drawing.Size(82, 80);
            this.picUpdateProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUpdateProfile.TabIndex = 6;
            this.picUpdateProfile.TabStop = false;
            this.picUpdateProfile.Click += new System.EventHandler(this.picUpdateProfile_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Assignment.Properties.Resources.logo1;
            this.picLogo.Location = new System.Drawing.Point(18, 19);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(84, 78);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // ChefDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(804, 594);
            this.Controls.Add(this.lblChef);
            this.Controls.Add(this.picOrders);
            this.Controls.Add(this.picViewMenu);
            this.Controls.Add(this.picUpdateProfile);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnViewMenu);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.lblHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChefDashboardForm";
            this.Text = "ChefDashboardForm";
            this.Load += new System.EventHandler(this.ChefDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViewMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnViewMenu;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picUpdateProfile;
        private System.Windows.Forms.PictureBox picViewMenu;
        private System.Windows.Forms.PictureBox picOrders;
        private System.Windows.Forms.Label lblChef;
    }
}