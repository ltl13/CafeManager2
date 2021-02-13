using CafeManager2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager2.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }
        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetUncheckBillByTableID @tableID", new object[] { id });
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBill @idTable", new object[] { id });
        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(id) from dbo.Bill");
            }
            catch { return 1; }
        }
        public void CheckOut(int id, int discount)
        {
            string query = "update dbo.Bill set status = 1, DateCheckOut = getdate(), " + "discount = " + discount + " where id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
