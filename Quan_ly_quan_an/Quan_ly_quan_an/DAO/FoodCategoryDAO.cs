using Quan_ly_quan_an.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_quan_an.DAO
{
    public class FoodCategoryDAO
    {
        private static FoodCategoryDAO instance;
        public static FoodCategoryDAO Instance
        {
            get { if (instance == null) instance = new FoodCategoryDAO(); return FoodCategoryDAO.instance; }
            private set { FoodCategoryDAO.instance = value; }
        }
        private FoodCategoryDAO() { }
        public List<FoodCategory> LoadCategoryList()
        {
            List<FoodCategory> categoryList = new List<FoodCategory>();
            
            string query = "select * from FoodCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows) 
            {
                FoodCategory foodCategory = new FoodCategory(item);
                categoryList.Add(foodCategory);
            }
            return categoryList;
        }

        public FoodCategory GetCategoryById(string idFoodCategory) 
        {
            FoodCategory category = null;
            string query = "select * from FoodCategory where idFoodCategory = @idFoodCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idFoodCategory });
            foreach (DataRow item in data.Rows)
            {
                category = new FoodCategory(item);
                return category;
            }
            return category;
        }

        public bool InsertFoodCategory(string idFoodCategory, string categoryName)
        {
            string query = "INSERT INTO FoodCategory ( idFoodCategory, CategoryName) VALUES ( @idFoodCategory , @categoryName )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idFoodCategory, categoryName });
            return result > 0;
        }

        public bool UpdateFoodCategory(string idFoodCategory, string newCategoryName)
        {
            string query = "UPDATE FoodCategory SET CategoryName = @newCategoryName WHERE idFoodCategory = @idFoodCategory";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { newCategoryName, idFoodCategory });
            return result > 0;
        }

        public bool DeleteFoodCategory(string idFoodCategory)
        {
            string query = "DELETE FROM FoodCategory WHERE idFoodCategory = @idFoodCategory";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idFoodCategory });
            return result > 0;
        }
        public int IsIdCategoryExist(string idFoodCategory)
        {
            string query = "select * from FoodCategory where idFoodCategory = @idFoodCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idFoodCategory });
            int result = 0;
            foreach (DataRow item in data.Rows)
            {
                result = result + 1;
            }
            return result;
        }

    }
}
