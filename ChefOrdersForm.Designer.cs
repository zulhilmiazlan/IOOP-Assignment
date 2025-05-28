namespace Assignment
{
    partial class ChefOrdersForm
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
            this.lblOrders = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picOrders = new System.Windows.Forms.PictureBox();
            this.tabControlOrders = new System.Windows.Forms.TabControl();
            this.tabInProgress = new System.Windows.Forms.TabPage();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.picTick = new System.Windows.Forms.PictureBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.listBoxInProgressOrders = new System.Windows.Forms.ListBox();
            this.tabCompleted = new System.Windows.Forms.TabPage();
            this.lstCompleted = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrders)).BeginInit();
            this.tabControlOrders.SuspendLayout();
            this.tabInProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTick)).BeginInit();
            this.tabCompleted.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblOrders.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblOrders.Location = new System.Drawing.Point(224, 27);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(94, 35);
            this.lblOrders.TabIndex = 0;
            this.lblOrders.Text = "Orders";
            this.lblOrders.Click += new System.EventHandler(this.lblOrders_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Assignment.Properties.Resources.logo1;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(56, 50);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // picOrders
            // 
            this.picOrders.Image = global::Assignment.Properties.Resources.orders;
            this.picOrders.Location = new System.Drawing.Point(324, 27);
            this.picOrders.Name = "picOrders";
            this.picOrders.Size = new System.Drawing.Size(50, 50);
            this.picOrders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOrders.TabIndex = 9;
            this.picOrders.TabStop = false;
            this.picOrders.Click += new System.EventHandler(this.picOrders_Click);
            // 
            // tabControlOrders
            // 
            this.tabControlOrders.Controls.Add(this.tabInProgress);
            this.tabControlOrders.Controls.Add(this.tabCompleted);
            this.tabControlOrders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tabControlOrders.Location = new System.Drawing.Point(56, 105);
            this.tabControlOrders.Name = "tabControlOrders";
            this.tabControlOrders.SelectedIndex = 0;
            this.tabControlOrders.Size = new System.Drawing.Size(431, 301);
            this.tabControlOrders.TabIndex = 10;
            // 
            // tabInProgress
            // 
            this.tabInProgress.BackColor = System.Drawing.Color.White;
            this.tabInProgress.Controls.Add(this.lblFeedback);
            this.tabInProgress.Controls.Add(this.picTick);
            this.tabInProgress.Controls.Add(this.btnComplete);
            this.tabInProgress.Controls.Add(this.listBoxInProgressOrders);
            this.tabInProgress.Location = new System.Drawing.Point(4, 29);
            this.tabInProgress.Name = "tabInProgress";
            this.tabInProgress.Padding = new System.Windows.Forms.Padding(3);
            this.tabInProgress.Size = new System.Drawing.Size(423, 268);
            this.tabInProgress.TabIndex = 0;
            this.tabInProgress.Text = "In Progress Orders";
            this.tabInProgress.Click += new System.EventHandler(this.tabInProgress_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblFeedback.ForeColor = System.Drawing.Color.Green;
            this.lblFeedback.Location = new System.Drawing.Point(126, 241);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(167, 15);
            this.lblFeedback.TabIndex = 11;
            this.lblFeedback.Text = "✔  Order marked successfully!";
            this.lblFeedback.Click += new System.EventHandler(this.lblFeedback_Click);
            // 
            // picTick
            // 
            this.picTick.Image = global::Assignment.Properties.Resources.WhatsApp_Image_2025_05_09_at_4_53_38_PM;
            this.picTick.Location = new System.Drawing.Point(292, 208);
            this.picTick.Name = "picTick";
            this.picTick.Size = new System.Drawing.Size(27, 30);
            this.picTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTick.TabIndex = 10;
            this.picTick.TabStop = false;
            this.picTick.Click += new System.EventHandler(this.picTick_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(129, 208);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(157, 30);
            this.btnComplete.TabIndex = 1;
            this.btnComplete.Text = "Mark As Completed";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // listBoxInProgressOrders
            // 
            this.listBoxInProgressOrders.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.listBoxInProgressOrders.FormattingEnabled = true;
            this.listBoxInProgressOrders.ItemHeight = 17;
            this.listBoxInProgressOrders.Location = new System.Drawing.Point(19, 19);
            this.listBoxInProgressOrders.Name = "listBoxInProgressOrders";
            this.listBoxInProgressOrders.Size = new System.Drawing.Size(383, 174);
            this.listBoxInProgressOrders.TabIndex = 0;
            this.listBoxInProgressOrders.SelectedIndexChanged += new System.EventHandler(this.lstInProgress_SelectedIndexChanged);
            // 
            // tabCompleted
            // 
            this.tabCompleted.Controls.Add(this.lstCompleted);
            this.tabCompleted.Location = new System.Drawing.Point(4, 29);
            this.tabCompleted.Name = "tabCompleted";
            this.tabCompleted.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompleted.Size = new System.Drawing.Size(423, 268);
            this.tabCompleted.TabIndex = 1;
            this.tabCompleted.Text = "Completed Orders";
            this.tabCompleted.UseVisualStyleBackColor = true;
            this.tabCompleted.Click += new System.EventHandler(this.tabCompleted_Click);
            // 
            // lstCompleted
            // 
            this.lstCompleted.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lstCompleted.FormattingEnabled = true;
            this.lstCompleted.ItemHeight = 17;
            this.lstCompleted.Location = new System.Drawing.Point(19, 19);
            this.lstCompleted.Name = "lstCompleted";
            this.lstCompleted.Size = new System.Drawing.Size(383, 225);
            this.lstCompleted.TabIndex = 1;
            // 
            // ChefOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.tabControlOrders);
            this.Controls.Add(this.picOrders);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblOrders);
            this.Name = "ChefOrdersForm";
            this.Text = "ChefOrdersForm";
            this.Load += new System.EventHandler(this.ChefOrdersForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrders)).EndInit();
            this.tabControlOrders.ResumeLayout(false);
            this.tabInProgress.ResumeLayout(false);
            this.tabInProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTick)).EndInit();
            this.tabCompleted.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picOrders;
        private System.Windows.Forms.TabControl tabControlOrders;
        private System.Windows.Forms.TabPage tabInProgress;
        private System.Windows.Forms.TabPage tabCompleted;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.ListBox listBoxInProgressOrders;
        private System.Windows.Forms.PictureBox picTick;
        private System.Windows.Forms.ListBox lstCompleted;
        private System.Windows.Forms.Label lblFeedback;
    }
}