using CrystalDecisions.CrystalReports.Engine;
using Quan_ly_quan_an.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Quan_ly_quan_an.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { instance = value; }
        }
        public static int TableWidth = 100;
        public static int TableHeight = 100;
        private TableDAO() { }

        public List<DTO.Table> LoadTableList()
        {
            List<DTO.Table> tableList = new List<DTO.Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
            foreach (DataRow item in data.Rows)
            {
                DTO.Table table = new DTO.Table(item);
                tableList.Add(table);
            }
            return tableList;
        }

        public void UpdateStatusTrongTable(string idTable)
        {
            string query = "update TableFood set status = N'Trống' where idTable = @idTable";
            DataProvider.Instance.ExecuteQuery(query, new object[] { idTable });
        }

        public void UpdateStatusCoNguoiTable(string idTable)
        {
            string query = "update TableFood set status = N'Có người' where idTable = @idTable";
            DataProvider.Instance.ExecuteQuery(query, new object[] { idTable });
        }

        public void SwitchTable(string idTable1, string idTable2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTable @idTable1 , @idTable2", new object[] { idTable1, idTable2 });

        }

        public bool InsertTableFood(string idTable, string TableName, string status)
        {
            string query = "INSERT INTO TableFood ( idTable, TableName, status) VALUES ( @idTable , @TableName , @status )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idTable, TableName, status });
            return result > 0;
        }

        public bool UpdateTableFood(string idTable, string TableName)
        {
            string query = "UPDATE TableFood SET TableName = @TableName WHERE idTable = @idTable";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { TableName, idTable });
            return result > 0;
        }

        public bool DeleteTable(string idTable)
        {
            string query = "DELETE FROM TableFood WHERE idTable = @idTable";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idTable });
            return result > 0;
        }

        public int IsIdTableExist(string idTable)
        {
            string query = "select * from TableFood where idTable = @idTable";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idTable });
            int result = 0;
            foreach (DataRow item in data.Rows)
            {
                result = result + 1;
            }
            return result;
        }
        public void MergeTable(string idTable1, string idTable2)
        {
            DataProvider.Instance.ExecuteQuery("USP_MergeTables @idTable1 , @idTable2", new object[] { idTable1, idTable2 });

        }

        public string GetStatusTable(string idTable)
        {
            string query = "SELECT status FROM TableFood WHERE idTable = @idTable";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idTable });

            if (data.Rows.Count > 0)
            {
                string status = data.Rows[0]["status"].ToString();
                return status;
            }
            return ""; 
        }
    }
}
