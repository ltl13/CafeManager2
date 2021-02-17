using CafeManager2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager2.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        internal static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string userName, string passWord)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hashPass =  "";
            foreach(byte item in hashData)
            {
                hashPass += item;
            }
            //var list = hashData.ToString();
            //list.Reverse();
            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { userName, hashPass/*list*/ });
            return result.Rows.Count > 0;
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable data =  DataProvider.Instance.ExcuteQuery("select * from account where userName = '" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            byte[] temp1 = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] hashData1 = new MD5CryptoServiceProvider().ComputeHash(temp1);
            string hashPass1 = "";
            foreach(byte item in hashData1) { hashPass1 += item; }
            byte[] temp2 = ASCIIEncoding.ASCII.GetBytes(newPass);
            byte[] hashData2 = new MD5CryptoServiceProvider().ComputeHash(temp2);
            string hashPass2 = "";            
            if (newPass != "") { foreach (byte item in hashData2) { hashPass2 += item; } }
            int result = DataProvider.Instance.ExecuteNonQuery("USP_UpdateAccount @userName , @displayName , @password , @newPassword", new object[] { userName, displayName, hashPass1, hashPass2 });
            return result > 0;
        }
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExcuteQuery("select UserName, DisplayName, Type from dbo.Account");
        }
        public bool InsertAccount(string userName, string displayName, int type)
        {
            string query = string.Format("insert dbo.Account (UserName, DisplayName, Type, Password) values (N'{0}', N'{1}', {2}, N'{3}')", userName, displayName, type, "1962026656160185351301320480154111117132155");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateAccount(string userName, string displayName, int type)
        {
            string query = string.Format("update dbo.Account set DisplayName = N'{0}', Type = {1} where UserName = N'{2}'", displayName, type, userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteAccount(string userName)
        {            
            string query = string.Format("delete dbo.Account where UserName = N'{0}'", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool ResetPassword(string userName)
        {
            string query = string.Format("update dbo.Account set Password = N'1962026656160185351301320480154111117132155' where UserName = N'{0}'", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
