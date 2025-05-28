namespace Assignment
{
    partial class CustomerOrderForm
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
            this.gbUpdateMenu = new System.Windows.Forms.GroupBox();
            this.btOrder = new System.Windows.Forms.Button();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cbAddMenu = new System.Windows.Forms.CheckBox();
            this.gbMenuList = new System.Windows.Forms.GroupBox();
            this.lbMenuList = new System.Windows.Forms.ListBox();
            this.gbUpdateMenu.SuspendLayout();
            this.gbMenuList.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUpdateMenu
            // 
            this.gbUpdateMenu.Controls.Add(this.btOrder);
            this.gbUpdateMenu.Controls.Add(this.tbQuantity);
            this.gbUpdateMenu.Controls.Add(this.lblQuantity);
            this.gbUpdateMenu.Controls.Add(this.cbAddMenu);
            this.gbUpdateMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUpdateMenu.ForeColor = System.Drawing.Color.DarkOrange;
            this.gbUpdateMenu.Location = new System.Drawing.Point(690, 12);
            this.gbUpdateMenu.Name = "gbUpdateMenu";
            this.gbUpdateMenu.Size = new System.Drawing.Size(447, 374);
            this.gbUpdateMenu.TabIndex = 3;
            this.gbUpdateMenu.TabStop = false;
            this.gbUpdateMenu.Text = "Update Menu";
            // 
            // btOrder
            // 
            this.btOrder.BackColor = System.Drawing.Color.DarkGray;
            this.btOrder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btOrder.ForeColor = System.Drawing.Color.Black;
            this.btOrder.Location = new System.Drawing.Point(83, 258);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(279, 73);
            this.btOrder.TabIndex = 3;
            this.btOrder.Text = "Order";
            this.btOrder.UseVisualStyleBackColor = false;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(141, 173);
            this.tbQuantity.Multiline = true;
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(257, 37);
            this.tbQuantity.TabIndex = 2;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblQuantity.Location = new System.Drawing.Point(10, 173);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(125, 37);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity:";
            // 
            // cbAddMenu
            // 
            this.cbAddMenu.AutoSize = true;
            this.cbAddMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbAddMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbAddMenu.Location = new System.Drawing.Point(17, 98);
            this.cbAddMenu.Name = "cbAddMenu";
            this.cbAddMenu.Size = new System.Drawing.Size(173, 41);
            this.cbAddMenu.TabIndex = 0;
            this.cbAddMenu.Text = "Add Menu";
            this.cbAddMenu.UseVisualStyleBackColor = true;
            // 
            // gbMenuList
            // 
            this.gbMenuList.Controls.Add(this.lbMenuList);
            this.gbMenuList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbMenuList.ForeColor = System.Drawing.Color.DarkOrange;
            this.gbMenuList.Location = new System.Drawing.Point(12, 12);
            this.gbMenuList.Name = "gbMenuList";
            this.gbMenuList.Size = new System.Drawing.Size(612, 763);
            this.gbMenuList.TabIndex = 4;
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
            // CustomerOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1176, 798);
            this.Controls.Add(this.gbMenuList);
            this.Controls.Add(this.gbUpdateMenu);
            this.Name = "CustomerOrderForm";
            this.Text = "CustomerOrderForm";
            this.gbUpdateMenu.ResumeLayout(false);
            this.gbUpdateMenu.PerformLayout();
            this.gbMenuList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUpdateMenu;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.CheckBox cbAddMenu;
        private System.Windows.Forms.GroupBox gbMenuList;
        private System.Windows.Forms.ListBox lbMenuList;
    }
}