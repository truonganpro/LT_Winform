using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_quan_an.DTO
{
    public class FoodCategory
    {
        private string idfoodcategory;
        private string categoryname;
        
        public FoodCategory() { }
        public FoodCategory(string idfoodcategory, string categoryname)
        {
            this.Idfoodcategory = idfoodcategory;
            this.Categoryname = categoryname;
        }

        public FoodCategory (DataRow row)
        {
            this.Idfoodcategory = row["idfoodcategory"].ToString();
            this.Categoryname = row["categoryname"].ToString();
        }
        public string Idfoodcategory 
        { get { return idfoodcategory; }
          set { idfoodcategory = value; }
        }

        public string Categoryname
        {
            get { return categoryname; }
            set { categoryname = value; }
        }   
    }
}
