using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_quan_an.DTO
{
    public class Table
    {
        private string idtable;
        private string tablename;
        private string status;

        public Table(string idtable, string tablename, string status)
        {
            this.Idtable = idtable;
            this.Tablename  = tablename;
            this.Status = status;
        }

        public Table (DataRow row)
        {
            this.Idtable = row["idtable"].ToString();
            this.Tablename = row["tablename"].ToString ();
            this.Status = row["status"].ToString ();
        }
        public string Idtable 
        { get { return idtable; }
          set { idtable = value; }
        }

        public string Tablename
        {
            get { return tablename; }
            set { tablename = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
