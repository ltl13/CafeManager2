using CafeManager2.DAO;
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
            string displayName = tbxName.Text;
            string password = tbxPassword.Text;
            string newPassword = tbxNewPassword.Text;
            string reenterPassword = tbxEnterAgain.Text;
            string userName = tbxUsername.Text;
            if (!newPassword.Equals(reenterPassword))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, password, newPassword))
                {
                    MessageBox.Show("Cập nhật thành công");
                    if (updateAccount != null)
                    {
                        updateAccount(this, new EventAccount(AccountDAO.Instance.GetAccountByUserName(userName)));
                    }
                }
                else { MessageBox.Show("Cập nhật thất bại, vui lòng kiểm tra lại thông tin"); }
            }
        }
        #endregion
        #region event
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }
        private event EventHandler<EventAccount> updateAccount;
        public event EventHandler<EventAccount> eUpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        #endregion
    }
    public class EventAccount : EventArgs
    {
        private Account acc;

        public EventAccount(Account account) { this.Acc = account; }
        public Account Acc { get => acc; set => acc = value; }
    }
}
