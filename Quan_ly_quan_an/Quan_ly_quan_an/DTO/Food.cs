using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_quan_an.DTO
{
    public class Food
    {
        private string idFood;
        public string IdFood 
        { 
            get { return idFood; }
            set { idFood = value; } 
        }

        private string foodName;
        public string FoodName 
        {
            get { return foodName; }
            set { foodName = value; }
        }

        private string idFoodCategory;
        public string IdFoodCategory
        {
            get { return idFoodCategory; }
            set { idFoodCategory = value; }
        }

        private float price;
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public Food(string idFood, string foodName, string idCategory, float price)
        {
            this.IdFood = idFood;
            this.FoodName = foodName;
            this.IdFoodCategory = idCategory;
            this.Price = price;
        }

        public Food(DataRow row)
        {
            this.IdFood = row["idFood"].ToString();
            this.FoodName = row["foodName"].ToString();
            this.IdFoodCategory = row["idFoodCategory"].ToString();
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }
    }
}
