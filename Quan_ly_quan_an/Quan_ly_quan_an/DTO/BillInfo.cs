using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_quan_an.DTO
{
    public class BillInfo
    {
        private int iD;
        public int ID 
        { get { return iD; }
          set { iD = value; } 
        }

        private int billID;
        public int BillID 
        { 
            get {  return billID; } 
            set {  billID = value; } 
        }
        private string iDFood;
        public string IDFood 
        {  
            get { return iDFood; } 
            set {  iDFood = value; } 
        }
        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public BillInfo(int id, int billID, string idFood, int count)
        {
            this.ID = id;
            this.BillID = billID;
            this.IDFood = idFood;
            this.count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.BillID = (int)row["idBill"];
            this.IDFood = row["idFood"].ToString();
            this.count = (int)row["count"];
        }
    }
}
