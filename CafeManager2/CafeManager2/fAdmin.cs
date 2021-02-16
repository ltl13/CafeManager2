﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CafeManager2.DAO;
using CafeManager2.DTO;

namespace CafeManager2
{
    public partial class fAdmin : Form
    {
        BindingSource foodList = new BindingSource();
        BindingSource accountList = new BindingSource();
        public fAdmin()
        {
            InitializeComponent();
            LoadData();
        }
        #region method
        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = new List<Food>();
            listFood = FoodDAO.Instance.SearchFoodByName(name);
            return listFood;
        }
        void LoadData()
        {
            dtgvFood.DataSource = foodList;
            dtgvUser.DataSource = accountList;
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFrom.Value, dtpkTo.Value);
            LoadListFood();
            AddFoodBinding();
            LoadCategoryIntoCombobox(cbFoodCategory);
            LoadAccount();
            AddAccountBinding();
        }
        void AddAccountBinding()
        {
            tbxUsername.DataBindings.Add("Text", dtgvUser.DataSource, "UserName", true, DataSourceUpdateMode.Never);
            tbxUserDisplayName.DataBindings.Add("Text", dtgvUser.DataSource, "DisplayName", true, DataSourceUpdateMode.Never);
            tbxAccoutType.DataBindings.Add("Text", dtgvUser.DataSource, "Type", true, DataSourceUpdateMode.Never);
        }
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFrom.Value = new DateTime(today.Year, today.Month, 1);
            dtpkTo.Value = dtpkFrom.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            if (checkIn <= checkOut)
                dtgvBill.DataSource = BillDAO.Instance.GetListBillByDate(checkIn, checkOut);
            else
                MessageBox.Show("Ngày không hợp lệ");
        }
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }
        void AddFoodBinding()
        {
            tbxFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            tbxFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "id", true, DataSourceUpdateMode.Never));
            nudFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "price", true, DataSourceUpdateMode.Never));
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCagetory();
            cb.DisplayMember = "Name";
        }
        #endregion
        #region event
        private void btnView_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFrom.Value, dtpkTo.Value);
        }

        private void btnViewFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void tbxFoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvFood.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;
                    Category category = CategoryDAO.Instance.GetCategoryByID(id);
                    int i = 0;
                    foreach (Category item in cbFoodCategory.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            cbFoodCategory.SelectedIndex = i;
                            break;
                        }
                        i++;
                    }
                }
            }
            catch { }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = tbxFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nudFoodPrice.Value;
            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else { MessageBox.Show("Thêm món lỗi, vui lòng kiểm tra lại thông tin"); }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string name = tbxFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nudFoodPrice.Value;
            int id = Convert.ToInt32(tbxFoodID.Text);
            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else { MessageBox.Show("Sửa món lỗi, vui lòng kiểm tra lại thông tin"); }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxFoodID.Text);
            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListFood();
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());
            }
            else { MessageBox.Show("Xóa món lỗi, vui lòng thử lại sau"); }
        }
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }
        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }
        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            foodList.DataSource =  SearchFoodByName(tbxSearchFood.Text);
        }
        #endregion

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
    }
}
