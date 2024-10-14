using Quan_ly_quan_an.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_quan_an.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if  (instance == null) instance = new BillDAO(); return BillDAO.instance; } 
            private set { BillDAO.instance = value; }
        }

        private BillDAO() 
        { }
        public int GetUncheckBillIdByTableId(string idTable)
        {
            string query = "SELECT * FROM Bill WHERE idTable = @idTable AND status = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idTable });

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        public void InsertBill(string idTable)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_InsertBill @idTable", new object[] { idTable });
        }

        public int GetMaxIdBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(id) from Bill");
            }
            catch 
            {
                return -1;
            }  
        }
        public void CheckOut(int id, int discount, double totalPrice)
        {
            string query = "update Bill set DateCheckOut = getdate(), status = 1, " + "discount = " + discount + ", totalPrice = "  + totalPrice + " where id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public  DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }
    }
}

