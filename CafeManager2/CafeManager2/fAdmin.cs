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
        }
        #region method
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFrom.Value = new DateTime(today.Year, today.Month, 1);
            dtpkTo.Value = dtpkFrom.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {

        }
        #endregion
        #region event
        private void btnView_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFrom.Value, dtpkTo.Value);
        }
        #endregion

    }
}
