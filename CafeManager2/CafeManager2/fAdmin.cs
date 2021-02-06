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

namespace CafeManager2
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList();
        }
        void LoadAccountList()
        {
            string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=CafeManager;Integrated Security=True";
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            string query = "SELECT * FROM dbo.Account";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            dtgvUser.DataSource = data;
        }
    }
}
