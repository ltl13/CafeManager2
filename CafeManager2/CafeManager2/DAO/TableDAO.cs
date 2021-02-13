using CafeManager2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager2.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        private static int tableWidth = 90;
        private static int tableHeight = 50;
        public static TableDAO Instance 
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        public static int TableWidth { get => tableWidth; set => tableWidth = value; }
        public static int TableHeight { get => tableHeight; set => tableHeight = value; }

        private TableDAO() { }
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetTableList");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public void SwitchTable(int idTable1, int idTable2)
        {
            DataProvider.Instance.ExcuteQuery("USP_SwitchTable @idTable1 , @idTable2", new object[] { idTable1, idTable2 });
        }
    }
}
