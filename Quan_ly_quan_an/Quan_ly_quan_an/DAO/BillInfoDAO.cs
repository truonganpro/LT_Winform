using Quan_ly_quan_an.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_quan_an.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance 
        {
            get {if(instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance;}
            private set { BillInfoDAO.instance = value;}
        }

        private BillInfoDAO() { }
        public List<BillInfo> GetListBillInfo(int idBill) 
        {
            List<BillInfo> listBillinfo = new List<BillInfo>();
            string query = "select * from BillInfo where idBill = @idBill";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {idBill});
            foreach(DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillinfo.Add(info);
            }
            return listBillinfo;
        }

        public void InsertBillInfo(int idBill, string idFood, int count)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_InsertBillInfo @idBill , @idFood , @count ", new object[] { idBill, idFood, count });
        }

        public void DeleteBillInfoByIdFood(string idFood) 
        {
            string query = "delete BillInfo where idFood = @idFood";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idFood });
        }
    }
}
