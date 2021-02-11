using CafeManager2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager2.DAO
{
    public class CagetoryDAO
    {
        private static CagetoryDAO instance;

        public static CagetoryDAO Instance {
            get { if (instance == null) instance = new CagetoryDAO(); return CagetoryDAO.instance; }
            private set { CagetoryDAO.instance = value; }
        }
        private CagetoryDAO() { }
        public List<Cagetory> GetListCagetory()
        {
            List<Cagetory> list = new List<Cagetory>();
            string query = "select * from Cagetory";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Cagetory cagetory = new Cagetory(item);
                list.Add(cagetory);
            }
            return list;
        }
    }
}
