using CafeManager2.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManager2
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = tbxUsername.Text;
            string passWord = tbxPassword.Text;
            if (Login(userName, passWord))
            {
                fMain main = new fMain();
                this.Hide();
                main.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }
        private bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }
    }
}
