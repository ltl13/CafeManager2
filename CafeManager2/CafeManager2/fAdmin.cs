using System;
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
        public fAdmin()
        {
            InitializeComponent();
            LoadData();
        }
        #region method
        void LoadData()
        {
            dtgvFood.DataSource = foodList;
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFrom.Value, dtpkTo.Value);
            LoadListFood();
            AddFoodBinding();
            LoadCategoryIntoCombobox(cbFoodCategory);
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

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = tbxFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nudFoodPrice.Value;
            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListFood();
            }
            else { MessageBox.Show("Thêm món lỗi, vui lòng kiểm tra lại thông tin"); }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
