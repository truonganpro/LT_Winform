using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_quan_an.DTO
{
    public class Account
    {
        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string displayName;
        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set {  password = value; }
        }

        private int type;
        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public Account(string userName, string displayName, string password, int type)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Password = password;
            this.Type = type;
        }

        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString() ;  
            this.Password = row["password"].ToString() ;
            this.Type = (int)row["type"];
        }
    }
}
