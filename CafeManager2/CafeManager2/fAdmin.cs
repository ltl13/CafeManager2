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
        void LoadData()
        {
            LoadAccountList();
            LoadFoodList();
        }
        void LoadFoodList()
        {
            string query = "select * from dbo.Food";
            dtgvFood.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }
        void LoadAccountList()
        {
            string query = "SELECT * FROM dbo.Account";
            dtgvUser.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
