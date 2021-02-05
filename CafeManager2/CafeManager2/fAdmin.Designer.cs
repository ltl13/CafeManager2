namespace CafeManager2
{
    partial class fAdmin
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
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.tpFoodCagetory = new System.Windows.Forms.TabPage();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.tcAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpBill);
            this.tcAdmin.Controls.Add(this.tpFood);
            this.tcAdmin.Controls.Add(this.tpFoodCagetory);
            this.tcAdmin.Controls.Add(this.tpTable);
            this.tcAdmin.Controls.Add(this.tpAccount);
            this.tcAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcAdmin.Location = new System.Drawing.Point(0, 0);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(731, 539);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpBill
            // 
            this.tpBill.Location = new System.Drawing.Point(4, 31);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(723, 504);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // tpFood
            // 
            this.tpFood.Location = new System.Drawing.Point(4, 31);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpFood.Size = new System.Drawing.Size(723, 504);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Món ăn";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // tpFoodCagetory
            // 
            this.tpFoodCagetory.Location = new System.Drawing.Point(4, 31);
            this.tpFoodCagetory.Name = "tpFoodCagetory";
            this.tpFoodCagetory.Padding = new System.Windows.Forms.Padding(3);
            this.tpFoodCagetory.Size = new System.Drawing.Size(723, 504);
            this.tpFoodCagetory.TabIndex = 2;
            this.tpFoodCagetory.Text = "Danh mục";
            this.tpFoodCagetory.UseVisualStyleBackColor = true;
            // 
            // tpTable
            // 
            this.tpTable.Location = new System.Drawing.Point(4, 31);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(723, 504);
            this.tpTable.TabIndex = 3;
            this.tpTable.Text = "Bàn ăn";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // tpAccount
            // 
            this.tpAccount.Location = new System.Drawing.Point(4, 31);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(723, 504);
            this.tpAccount.TabIndex = 4;
            this.tpAccount.Text = "Tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 539);
            this.Controls.Add(this.tcAdmin);
            this.Name = "fAdmin";
            this.Text = "fAdmin";
            this.tcAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.TabPage tpFoodCagetory;
        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.TabPage tpAccount;
    }
}