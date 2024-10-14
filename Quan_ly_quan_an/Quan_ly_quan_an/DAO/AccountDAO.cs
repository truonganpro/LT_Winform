using Microsoft.SqlServer.Server;
using Quan_ly_quan_an.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Quan_ly_quan_an.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }
        public bool Login (string username, string password) 
        {
            string query = "USP_Login @UserName , @PassWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {username, password});
            return result.Rows.Count > 0;
        }

        public Account GetAccountByUserName(string userName)
        {
            string query = "select * from account where userName = @userName";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {userName});
            foreach (DataRow item in data.Rows) 
            {
                return new Account(item);
            }
            return null;
        }

        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int results = DataProvider.Instance.ExecuteNonQuery("USP_UpdateAccount @userName , @displayName , @password , @newPassword ", new object[] { userName, displayName, pass, newPass });
            return results > 0;
        }

        public DataTable GetListAccout()
        {
            return DataProvider.Instance.ExecuteQuery("select UserName, DisplayName, type from Account");
        }

        public bool InsertAccount(string userName, string displayName, int type)
        {
            string query = "INSERT INTO Account ( userName, displayName, type ) VALUES ( @userName , @displayName , @type )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, displayName, type });
            return result > 0;
        }

        public bool UpdateAccount(string userName, string displayName, int type)
        {
            string query = "UPDATE Account SET displayName = @displayName , type = @type WHERE userName = @userName";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { displayName, type, userName });
            return result > 0;
        }


        public bool DeleteAccount(string userName)
        {
            string query = "Delete Account WHERE userName = @userName";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName });
            return result > 0;
        }

        public bool ResetPassWord(string userName)
        {
            string query = "UPDATE Account SET PassWord = N'0' WHERE userName = @userName";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName});
            return result > 0;
        }
    }
}
