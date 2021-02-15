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

namespace CafeManager2
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadData();
        }
        #region method
        void LoadData()
        {
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFrom.Value, dtpkTo.Value);
            LoadListFood();
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
            dtgvFood.DataSource = FoodDAO.Instance.GetListFood();
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
        #endregion
    }
}
