namespace Assignment
{
    partial class CustomerRefundForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRefundForm));
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.tpInProgress = new System.Windows.Forms.TabPage();
            this.btMarkAsCompleted = new System.Windows.Forms.Button();
            this.tpCompleted = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabcontrol1.SuspendLayout();
            this.tpInProgress.SuspendLayout();
            this.tpCompleted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.tpInProgress);
            this.tabcontrol1.Controls.Add(this.tpCompleted);
            this.tabcontrol1.Location = new System.Drawing.Point(12, 149);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(1212, 817);
            this.tabcontrol1.TabIndex = 16;
            // 
            // tpInProgress
            // 
            this.tpInProgress.Controls.Add(this.listBox2);
            this.tpInProgress.Controls.Add(this.btMarkAsCompleted);
            this.tpInProgress.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpInProgress.Location = new System.Drawing.Point(8, 39);
            this.tpInProgress.Name = "tpInProgress";
            this.tpInProgress.Padding = new System.Windows.Forms.Padding(3);
            this.tpInProgress.Size = new System.Drawing.Size(1196, 770);
            this.tpInProgress.TabIndex = 0;
            this.tpInProgress.Text = "In Progress";
            this.tpInProgress.UseVisualStyleBackColor = true;
            // 
            // btMarkAsCompleted
            // 
            this.btMarkAsCompleted.BackColor = System.Drawing.Color.DarkGray;
            this.btMarkAsCompleted.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMarkAsCompleted.Location = new System.Drawing.Point(9, 603);
            this.btMarkAsCompleted.Name = "btMarkAsCompleted";
            this.btMarkAsCompleted.Size = new System.Drawing.Size(1166, 85);
            this.btMarkAsCompleted.TabIndex = 2;
            this.btMarkAsCompleted.Text = "Mark as completed";
            this.btMarkAsCompleted.UseVisualStyleBackColor = false;
            // 
            // tpCompleted
            // 
            this.tpCompleted.Controls.Add(this.listBox1);
            this.tpCompleted.Controls.Add(this.groupBox2);
            this.tpCompleted.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpCompleted.Location = new System.Drawing.Point(8, 39);
            this.tpCompleted.Name = "tpCompleted";
            this.tpCompleted.Padding = new System.Windows.Forms.Padding(3);
            this.tpCompleted.Size = new System.Drawing.Size(1196, 770);
            this.tpCompleted.TabIndex = 1;
            this.tpCompleted.Text = "Completed";
            this.tpCompleted.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 33;
            this.listBox1.Location = new System.Drawing.Point(4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1191, 697);
            this.listBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(20, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1156, 669);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(404, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 78);
            this.label1.TabIndex = 14;
            this.label1.Text = "Refund Status";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 33;
            this.listBox2.Location = new System.Drawing.Point(12, 15);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(1162, 565);
            this.listBox2.TabIndex = 3;
            // 
            // CustomerRefundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1252, 978);
            this.Controls.Add(this.tabcontrol1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "CustomerRefundForm";
            this.Text = "CustomerRefundForm";
            this.tabcontrol1.ResumeLayout(false);
            this.tpInProgress.ResumeLayout(false);
            this.tpCompleted.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.TabPage tpInProgress;
        private System.Windows.Forms.Button btMarkAsCompleted;
        private System.Windows.Forms.TabPage tpCompleted;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
    }
}