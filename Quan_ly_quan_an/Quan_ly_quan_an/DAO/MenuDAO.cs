using Quan_ly_quan_an.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_quan_an.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get { if  (instance == null) instance = new MenuDAO();return MenuDAO.instance;}
            private set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }
        public List<Menu> GetListMenuByTable(string idTable)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "select f.FoodName, bi.count, f.price, bi.count * f.price as totalpirce from BillInfo as bi, Bill as b, Food as f where bi.idBill = b.id and bi.idFood = f.idFood and b.status = 0 and b.idTable = @idTable";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {idTable});

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
