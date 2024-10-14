using Quan_ly_quan_an.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_quan_an.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO() { }
        public List<Food> GetFoodByCategoryId(string idFoodCategory)
        {
            List<Food> list = new List<Food>();
            string query = "select * from Food where idFoodCategory = @idFoodCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idFoodCategory });
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }

        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();
            string query = "select * from Food";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }

        public bool InsertFood(string idFood, string FoodName, string idFoodCategory, double price)
        {
            string query = "INSERT INTO Food ( idFood, FoodName, idFoodCategory, price ) VALUES ( @idFood , @FoodName , @idFoodCategory , @price )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idFood, FoodName, idFoodCategory, price });
            return result > 0;
        }

        public bool UpdateFood(string idFood, string FoodName, string idFoodCategory, double price)
        {
            string query = "UPDATE Food SET FoodName = @FoodName , idFoodCategory = @idFoodCategory , price = @price WHERE idFood = @idFood";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { FoodName, idFoodCategory, price, idFood });
            return result > 0;
        }

        public bool DeleteFood(string idFood)
        {
            BillInfoDAO.Instance.DeleteBillInfoByIdFood(idFood);
            string query = "Delete Food WHERE idFood = @idFood";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idFood });
            return result > 0;
        }

        public List<Food> SearchFoodByName(string FoodName)
        {
            List<Food> list = new List<Food>();
            string query = string.Format("select * from Food where FoodName like N'%{0}%'", FoodName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }

        public int IsIdFoodExist(string idFood)
        {
            string query = "select * from Food where idFood = @idFood";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idFood });
            int result = 0;
            foreach (DataRow item in data.Rows)
            {
                result = result + 1;
            }
            return result;
        }
    }
}
