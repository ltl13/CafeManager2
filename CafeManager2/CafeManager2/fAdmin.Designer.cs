﻿namespace CafeManager2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.dtpkFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpkTo = new System.Windows.Forms.DateTimePicker();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnViewFood = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbxSearchFood = new System.Windows.Forms.TextBox();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxFoodID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxFoodName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxFoodCagetory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxFoodPrice = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbxCagetoryName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxCagetoryID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dtgvCagetory = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnViewCagetory = new System.Windows.Forms.Button();
            this.btnEditCagetory = new System.Windows.Forms.Button();
            this.btnDeleteCagetory = new System.Windows.Forms.Button();
            this.btnAddCagetory = new System.Windows.Forms.Button();
            this.tcAdmin.SuspendLayout();
            this.tpBill.SuspendLayout();
            this.tpFood.SuspendLayout();
            this.tpFoodCagetory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCagetory)).BeginInit();
            this.panel10.SuspendLayout();
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
            this.tpBill.Controls.Add(this.panel2);
            this.tpBill.Controls.Add(this.panel1);
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
            this.tpFood.Controls.Add(this.panel6);
            this.tpFood.Controls.Add(this.panel5);
            this.tpFood.Controls.Add(this.panel4);
            this.tpFood.Controls.Add(this.panel3);
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
            this.tpFoodCagetory.Controls.Add(this.panel7);
            this.tpFoodCagetory.Controls.Add(this.panel9);
            this.tpFoodCagetory.Controls.Add(this.panel10);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.dtpkTo);
            this.panel1.Controls.Add(this.dtpkFrom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 50);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvBill);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 442);
            this.panel2.TabIndex = 1;
            // 
            // dtgvBill
            // 
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvBill.Location = new System.Drawing.Point(0, 0);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 51;
            this.dtgvBill.RowTemplate.Height = 24;
            this.dtgvBill.Size = new System.Drawing.Size(717, 442);
            this.dtgvBill.TabIndex = 0;
            // 
            // dtpkFrom
            // 
            this.dtpkFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFrom.Location = new System.Drawing.Point(15, 11);
            this.dtpkFrom.Name = "dtpkFrom";
            this.dtpkFrom.Size = new System.Drawing.Size(290, 27);
            this.dtpkFrom.TabIndex = 0;
            // 
            // dtpkTo
            // 
            this.dtpkTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkTo.Location = new System.Drawing.Point(311, 11);
            this.dtpkTo.Name = "dtpkTo";
            this.dtpkTo.Size = new System.Drawing.Size(290, 27);
            this.dtpkTo.TabIndex = 1;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(607, 6);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(95, 38);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Location = new System.Drawing.Point(17, 6);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(79, 50);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFood.Location = new System.Drawing.Point(113, 6);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(79, 50);
            this.btnDeleteFood.TabIndex = 1;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // btnEditFood
            // 
            this.btnEditFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditFood.Location = new System.Drawing.Point(209, 6);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(79, 50);
            this.btnEditFood.TabIndex = 2;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.UseVisualStyleBackColor = true;
            // 
            // btnViewFood
            // 
            this.btnViewFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFood.Location = new System.Drawing.Point(306, 6);
            this.btnViewFood.Name = "btnViewFood";
            this.btnViewFood.Size = new System.Drawing.Size(79, 50);
            this.btnViewFood.TabIndex = 3;
            this.btnViewFood.Text = "Xem";
            this.btnViewFood.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnViewFood);
            this.panel3.Controls.Add(this.btnEditFood);
            this.panel3.Controls.Add(this.btnDeleteFood);
            this.panel3.Controls.Add(this.btnAddFood);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 63);
            this.panel3.TabIndex = 0;
            // 
            // dtgvFood
            // 
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvFood.Location = new System.Drawing.Point(0, 0);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.RowHeadersWidth = 51;
            this.dtgvFood.RowTemplate.Height = 24;
            this.dtgvFood.Size = new System.Drawing.Size(400, 435);
            this.dtgvFood.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvFood);
            this.panel4.Location = new System.Drawing.Point(0, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 435);
            this.panel4.TabIndex = 1;
            // 
            // tbxSearchFood
            // 
            this.tbxSearchFood.Location = new System.Drawing.Point(14, 17);
            this.tbxSearchFood.Name = "tbxSearchFood";
            this.tbxSearchFood.Size = new System.Drawing.Size(230, 28);
            this.tbxSearchFood.TabIndex = 0;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFood.Location = new System.Drawing.Point(250, 16);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(59, 30);
            this.btnSearchFood.TabIndex = 4;
            this.btnSearchFood.Text = "Tìm";
            this.btnSearchFood.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnSearchFood);
            this.panel5.Controls.Add(this.tbxSearchFood);
            this.panel5.Location = new System.Drawing.Point(406, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(317, 63);
            this.panel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // tbxFoodID
            // 
            this.tbxFoodID.Location = new System.Drawing.Point(107, 10);
            this.tbxFoodID.Name = "tbxFoodID";
            this.tbxFoodID.Size = new System.Drawing.Size(201, 28);
            this.tbxFoodID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên";
            // 
            // tbxFoodName
            // 
            this.tbxFoodName.Location = new System.Drawing.Point(107, 54);
            this.tbxFoodName.Name = "tbxFoodName";
            this.tbxFoodName.Size = new System.Drawing.Size(201, 28);
            this.tbxFoodName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh mục";
            // 
            // tbxFoodCagetory
            // 
            this.tbxFoodCagetory.Location = new System.Drawing.Point(107, 97);
            this.tbxFoodCagetory.Name = "tbxFoodCagetory";
            this.tbxFoodCagetory.Size = new System.Drawing.Size(201, 28);
            this.tbxFoodCagetory.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá";
            // 
            // tbxFoodPrice
            // 
            this.tbxFoodPrice.Location = new System.Drawing.Point(107, 141);
            this.tbxFoodPrice.Name = "tbxFoodPrice";
            this.tbxFoodPrice.Size = new System.Drawing.Size(201, 28);
            this.tbxFoodPrice.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbxFoodPrice);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.tbxFoodCagetory);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.tbxFoodName);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.tbxFoodID);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(406, 69);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(317, 435);
            this.panel6.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbxCagetoryName);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.tbxCagetoryID);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(406, 69);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(317, 435);
            this.panel7.TabIndex = 7;
            // 
            // tbxCagetoryName
            // 
            this.tbxCagetoryName.Location = new System.Drawing.Point(107, 54);
            this.tbxCagetoryName.Name = "tbxCagetoryName";
            this.tbxCagetoryName.Size = new System.Drawing.Size(201, 28);
            this.tbxCagetoryName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Danh mục";
            // 
            // tbxCagetoryID
            // 
            this.tbxCagetoryID.Location = new System.Drawing.Point(107, 10);
            this.tbxCagetoryID.Name = "tbxCagetoryID";
            this.tbxCagetoryID.Size = new System.Drawing.Size(201, 28);
            this.tbxCagetoryID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dtgvCagetory);
            this.panel9.Location = new System.Drawing.Point(0, 69);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(400, 435);
            this.panel9.TabIndex = 5;
            // 
            // dtgvCagetory
            // 
            this.dtgvCagetory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCagetory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCagetory.Location = new System.Drawing.Point(0, 0);
            this.dtgvCagetory.Name = "dtgvCagetory";
            this.dtgvCagetory.RowHeadersWidth = 51;
            this.dtgvCagetory.RowTemplate.Height = 24;
            this.dtgvCagetory.Size = new System.Drawing.Size(400, 435);
            this.dtgvCagetory.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnViewCagetory);
            this.panel10.Controls.Add(this.btnEditCagetory);
            this.panel10.Controls.Add(this.btnDeleteCagetory);
            this.panel10.Controls.Add(this.btnAddCagetory);
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(400, 63);
            this.panel10.TabIndex = 4;
            // 
            // btnViewCagetory
            // 
            this.btnViewCagetory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCagetory.Location = new System.Drawing.Point(306, 6);
            this.btnViewCagetory.Name = "btnViewCagetory";
            this.btnViewCagetory.Size = new System.Drawing.Size(79, 50);
            this.btnViewCagetory.TabIndex = 3;
            this.btnViewCagetory.Text = "Xem";
            this.btnViewCagetory.UseVisualStyleBackColor = true;
            // 
            // btnEditCagetory
            // 
            this.btnEditCagetory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCagetory.Location = new System.Drawing.Point(209, 6);
            this.btnEditCagetory.Name = "btnEditCagetory";
            this.btnEditCagetory.Size = new System.Drawing.Size(79, 50);
            this.btnEditCagetory.TabIndex = 2;
            this.btnEditCagetory.Text = "Sửa";
            this.btnEditCagetory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCagetory
            // 
            this.btnDeleteCagetory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCagetory.Location = new System.Drawing.Point(113, 6);
            this.btnDeleteCagetory.Name = "btnDeleteCagetory";
            this.btnDeleteCagetory.Size = new System.Drawing.Size(79, 50);
            this.btnDeleteCagetory.TabIndex = 1;
            this.btnDeleteCagetory.Text = "Xóa";
            this.btnDeleteCagetory.UseVisualStyleBackColor = true;
            // 
            // btnAddCagetory
            // 
            this.btnAddCagetory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCagetory.Location = new System.Drawing.Point(17, 6);
            this.btnAddCagetory.Name = "btnAddCagetory";
            this.btnAddCagetory.Size = new System.Drawing.Size(79, 50);
            this.btnAddCagetory.TabIndex = 0;
            this.btnAddCagetory.Text = "Thêm";
            this.btnAddCagetory.UseVisualStyleBackColor = true;
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
            this.tpBill.ResumeLayout(false);
            this.tpFood.ResumeLayout(false);
            this.tpFoodCagetory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCagetory)).EndInit();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.TabPage tpFoodCagetory;
        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DateTimePicker dtpkTo;
        private System.Windows.Forms.DateTimePicker dtpkFrom;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbxFoodPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxFoodCagetory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxFoodID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.TextBox tbxSearchFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnViewFood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbxCagetoryName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxCagetoryID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dtgvCagetory;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnViewCagetory;
        private System.Windows.Forms.Button btnEditCagetory;
        private System.Windows.Forms.Button btnDeleteCagetory;
        private System.Windows.Forms.Button btnAddCagetory;
    }
}