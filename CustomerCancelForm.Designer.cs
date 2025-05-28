namespace Assignment
{
    partial class CustomerCancelForm
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
            this.gbMenuList = new System.Windows.Forms.GroupBox();
            this.lbMenuList = new System.Windows.Forms.ListBox();
            this.gbCancelMenu = new System.Windows.Forms.GroupBox();
            this.btOrder = new System.Windows.Forms.Button();
            this.cbCancelMenu = new System.Windows.Forms.CheckBox();
            this.gbMenuList.SuspendLayout();
            this.gbCancelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMenuList
            // 
            this.gbMenuList.Controls.Add(this.lbMenuList);
            this.gbMenuList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbMenuList.ForeColor = System.Drawing.Color.DarkOrange;
            this.gbMenuList.Location = new System.Drawing.Point(12, 12);
            this.gbMenuList.Name = "gbMenuList";
            this.gbMenuList.Size = new System.Drawing.Size(612, 763);
            this.gbMenuList.TabIndex = 6;
            this.gbMenuList.TabStop = false;
            this.gbMenuList.Text = "Menu List:";
            // 
            // lbMenuList
            // 
            this.lbMenuList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenuList.FormattingEnabled = true;
            this.lbMenuList.ItemHeight = 45;
            this.lbMenuList.Location = new System.Drawing.Point(15, 49);
            this.lbMenuList.Name = "lbMenuList";
            this.lbMenuList.Size = new System.Drawing.Size(564, 679);
            this.lbMenuList.TabIndex = 0;
            // 
            // gbCancelMenu
            // 
            this.gbCancelMenu.Controls.Add(this.btOrder);
            this.gbCancelMenu.Controls.Add(this.cbCancelMenu);
            this.gbCancelMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCancelMenu.ForeColor = System.Drawing.Color.DarkOrange;
            this.gbCancelMenu.Location = new System.Drawing.Point(656, 539);
            this.gbCancelMenu.Name = "gbCancelMenu";
            this.gbCancelMenu.Size = new System.Drawing.Size(447, 236);
            this.gbCancelMenu.TabIndex = 5;
            this.gbCancelMenu.TabStop = false;
            this.gbCancelMenu.Text = "Cancel Menu";
            // 
            // btOrder
            // 
            this.btOrder.BackColor = System.Drawing.Color.DarkGray;
            this.btOrder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btOrder.ForeColor = System.Drawing.Color.Black;
            this.btOrder.Location = new System.Drawing.Point(82, 142);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(279, 73);
            this.btOrder.TabIndex = 3;
            this.btOrder.Text = "Order";
            this.btOrder.UseVisualStyleBackColor = false;
            // 
            // cbCancelMenu
            // 
            this.cbCancelMenu.AutoSize = true;
            this.cbCancelMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCancelMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbCancelMenu.Location = new System.Drawing.Point(18, 75);
            this.cbCancelMenu.Name = "cbCancelMenu";
            this.cbCancelMenu.Size = new System.Drawing.Size(203, 41);
            this.cbCancelMenu.TabIndex = 0;
            this.cbCancelMenu.Text = "Cancel Menu";
            this.cbCancelMenu.UseVisualStyleBackColor = true;
            // 
            // CustomerCancelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1149, 807);
            this.Controls.Add(this.gbMenuList);
            this.Controls.Add(this.gbCancelMenu);
            this.Name = "CustomerCancelForm";
            this.Text = "CustomerCancelForm";
            this.gbMenuList.ResumeLayout(false);
            this.gbCancelMenu.ResumeLayout(false);
            this.gbCancelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMenuList;
        private System.Windows.Forms.ListBox lbMenuList;
        private System.Windows.Forms.GroupBox gbCancelMenu;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.CheckBox cbCancelMenu;
    }
}