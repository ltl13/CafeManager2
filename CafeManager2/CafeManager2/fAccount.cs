using CafeManager2.DTO;
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
    public partial class fAccount : Form
    {
        private Account loginAccount;
        #region method
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        public fAccount(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }
        void ChangeAccount(Account acc)
        {
            tbxUsername.Text = LoginAccount.UserName;
            tbxName.Text = LoginAccount.DisplayName;
        }
        void UpdateAccount()
        {

        }
        #endregion
        #region event
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }
        #endregion
    }
}
