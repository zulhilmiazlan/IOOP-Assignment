namespace Assignment
{
    partial class CustomerFeedbackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerFeedbackForm));
            this.btSumbitFeedback = new System.Windows.Forms.Button();
            this.tbSuggestions = new System.Windows.Forms.TextBox();
            this.LbWriteYourSuggestions = new System.Windows.Forms.Label();
            this.gbDoYouSatisfyWithOurFood = new System.Windows.Forms.GroupBox();
            this.cbNo = new System.Windows.Forms.CheckBox();
            this.cbYes = new System.Windows.Forms.CheckBox();
            this.lbDoYouSatisfyWithOurFood = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbFeedback = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbDoYouSatisfyWithOurFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btSumbitFeedback
            // 
            this.btSumbitFeedback.BackColor = System.Drawing.Color.DarkGray;
            this.btSumbitFeedback.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSumbitFeedback.ForeColor = System.Drawing.Color.Black;
            this.btSumbitFeedback.Location = new System.Drawing.Point(75, 894);
            this.btSumbitFeedback.Name = "btSumbitFeedback";
            this.btSumbitFeedback.Size = new System.Drawing.Size(807, 70);
            this.btSumbitFeedback.TabIndex = 20;
            this.btSumbitFeedback.Text = "Sumbit Feedback";
            this.btSumbitFeedback.UseVisualStyleBackColor = false;
            this.btSumbitFeedback.Click += new System.EventHandler(this.btSumbitFeedback_Click);
            // 
            // tbSuggestions
            // 
            this.tbSuggestions.Location = new System.Drawing.Point(75, 598);
            this.tbSuggestions.Multiline = true;
            this.tbSuggestions.Name = "tbSuggestions";
            this.tbSuggestions.Size = new System.Drawing.Size(807, 282);
            this.tbSuggestions.TabIndex = 19;
            // 
            // LbWriteYourSuggestions
            // 
            this.LbWriteYourSuggestions.AutoSize = true;
            this.LbWriteYourSuggestions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbWriteYourSuggestions.Location = new System.Drawing.Point(68, 546);
            this.LbWriteYourSuggestions.Name = "LbWriteYourSuggestions";
            this.LbWriteYourSuggestions.Size = new System.Drawing.Size(320, 39);
            this.LbWriteYourSuggestions.TabIndex = 18;
            this.LbWriteYourSuggestions.Text = "Write your suggestions";
            // 
            // gbDoYouSatisfyWithOurFood
            // 
            this.gbDoYouSatisfyWithOurFood.BackColor = System.Drawing.Color.Transparent;
            this.gbDoYouSatisfyWithOurFood.Controls.Add(this.cbNo);
            this.gbDoYouSatisfyWithOurFood.Controls.Add(this.cbYes);
            this.gbDoYouSatisfyWithOurFood.Location = new System.Drawing.Point(75, 437);
            this.gbDoYouSatisfyWithOurFood.Name = "gbDoYouSatisfyWithOurFood";
            this.gbDoYouSatisfyWithOurFood.Size = new System.Drawing.Size(539, 95);
            this.gbDoYouSatisfyWithOurFood.TabIndex = 17;
            this.gbDoYouSatisfyWithOurFood.TabStop = false;
            // 
            // cbNo
            // 
            this.cbNo.AutoSize = true;
            this.cbNo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNo.Location = new System.Drawing.Point(299, 41);
            this.cbNo.Name = "cbNo";
            this.cbNo.Size = new System.Drawing.Size(119, 33);
            this.cbNo.TabIndex = 1;
            this.cbNo.Text = "         No";
            this.cbNo.UseVisualStyleBackColor = true;
            // 
            // cbYes
            // 
            this.cbYes.AutoSize = true;
            this.cbYes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYes.Location = new System.Drawing.Point(69, 41);
            this.cbYes.Name = "cbYes";
            this.cbYes.Size = new System.Drawing.Size(117, 33);
            this.cbYes.TabIndex = 0;
            this.cbYes.Text = "        Yes";
            this.cbYes.UseVisualStyleBackColor = true;
            // 
            // lbDoYouSatisfyWithOurFood
            // 
            this.lbDoYouSatisfyWithOurFood.AutoSize = true;
            this.lbDoYouSatisfyWithOurFood.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoYouSatisfyWithOurFood.Location = new System.Drawing.Point(68, 377);
            this.lbDoYouSatisfyWithOurFood.Name = "lbDoYouSatisfyWithOurFood";
            this.lbDoYouSatisfyWithOurFood.Size = new System.Drawing.Size(405, 39);
            this.lbDoYouSatisfyWithOurFood.TabIndex = 16;
            this.lbDoYouSatisfyWithOurFood.Text = "Do you satisfy with our food?";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(75, 314);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(539, 39);
            this.tbEmail.TabIndex = 15;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(75, 189);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(539, 39);
            this.tbName.TabIndex = 14;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(67, 247);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(114, 45);
            this.lbEmail.TabIndex = 13;
            this.lbEmail.Text = "Email:";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(67, 127);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(188, 45);
            this.lbUsername.TabIndex = 12;
            this.lbUsername.Text = "Username:";
            // 
            // lbFeedback
            // 
            this.lbFeedback.AutoSize = true;
            this.lbFeedback.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFeedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbFeedback.Location = new System.Drawing.Point(316, -2);
            this.lbFeedback.Name = "lbFeedback";
            this.lbFeedback.Size = new System.Drawing.Size(440, 117);
            this.lbFeedback.TabIndex = 11;
            this.lbFeedback.Text = "Feedback";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerFeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(987, 976);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btSumbitFeedback);
            this.Controls.Add(this.tbSuggestions);
            this.Controls.Add(this.LbWriteYourSuggestions);
            this.Controls.Add(this.gbDoYouSatisfyWithOurFood);
            this.Controls.Add(this.lbDoYouSatisfyWithOurFood);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbFeedback);
            this.Name = "CustomerFeedbackForm";
            this.Text = "CustomerFeedbackForm";
            this.gbDoYouSatisfyWithOurFood.ResumeLayout(false);
            this.gbDoYouSatisfyWithOurFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btSumbitFeedback;
        private System.Windows.Forms.TextBox tbSuggestions;
        private System.Windows.Forms.Label LbWriteYourSuggestions;
        private System.Windows.Forms.GroupBox gbDoYouSatisfyWithOurFood;
        private System.Windows.Forms.CheckBox cbNo;
        private System.Windows.Forms.CheckBox cbYes;
        private System.Windows.Forms.Label lbDoYouSatisfyWithOurFood;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbFeedback;
    }
}