using Quan_ly_quan_an.DAO;
using Quan_ly_quan_an.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_quan_an
{
    public partial class frmThucDon : Form
    {
        BindingSource foodList = new BindingSource();
        public frmThucDon()
        {
            InitializeComponent();
            txtIdThucAn.Enabled = false;
            LoadData();
        }
        #region method
        void LoadData()
        {
            dtgvFood.DataSource = foodList;
            LoadListFood();
            LoadCategoryIntoCombobox(cbbDanhMucThucAn);
            AddFoodBinding();
        }
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }

        void AddFoodBinding()
        {
            txtIdThucAn.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "idFood", true, DataSourceUpdateMode.Never));
            txtTenMonThucAn.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "FoodName", true, DataSourceUpdateMode.Never));
            nmrGiaThucAn.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "price", true, DataSourceUpdateMode.Never));
        }

        void LoadCategoryIntoCombobox(ComboBox cbb)
        {
            cbb.DataSource = FoodCategoryDAO.Instance.LoadCategoryList();
            cbb.DisplayMember = "CategoryName";
        }

        List<Food> SearchFoodByName(string FoodName)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(FoodName);
            return listFood;
        }

        #endregion

        #region event
        private void btnThemThucAn_Click(object sender, EventArgs e)
        {
            txtIdThucAn.Enabled = true;
            txtIdThucAn.Clear();
            txtTenMonThucAn.Clear();
            cbbDanhMucThucAn.ResetText();
            nmrGiaThucAn.ResetText();
        }

        private void btnXoaThucAn_Click(object sender, EventArgs e)
        {
            string idFood = txtIdThucAn.Text;
            if (FoodDAO.Instance.DeleteFood(idFood))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListFood();
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn");
            }
        }

        private void btnSuaThucAn_Click(object sender, EventArgs e)
        {
            string idFood = txtIdThucAn.Text;
            string FoodName = txtTenMonThucAn.Text;
            string idCategoryFood = (cbbDanhMucThucAn.SelectedItem as FoodCategory).Idfoodcategory;
            double price = (double)nmrGiaThucAn.Value;

            if (FoodName == "" || idCategoryFood == "")
            {
                MessageBox.Show("Không được bỏ trống dữ liệu");
                return;
            }
            if (price <= 0)
            {
                MessageBox.Show("Giá phải lớn hơn 0");
                return;
            }
            if (FoodDAO.Instance.UpdateFood(idFood, FoodName, idCategoryFood, price))
            {
                MessageBox.Show("Cập nhật thành công");
                LoadListFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật thức ăn");
            }
        }

        private void btnTimThucAn_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txtTimTenMonAn.Text);
        }

        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        private void txtIdThucAn_TextChanged(object sender, EventArgs e)
        {
            if (dtgvFood.Rows.Count > 0)
            {
                string idFoodName = dtgvFood.SelectedCells[0].OwningRow.Cells["idFoodCategory"].Value.ToString();
                FoodCategory category = FoodCategoryDAO.Instance.GetCategoryById(idFoodName);
                cbbDanhMucThucAn.SelectedItem = category;
                int index = -1;
                int i = 0;
                foreach (FoodCategory Item in cbbDanhMucThucAn.Items)
                {
                    if (Item.Idfoodcategory == category.Idfoodcategory)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbbDanhMucThucAn.SelectedIndex = index;
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string idFood = txtIdThucAn.Text;
            string FoodName = txtTenMonThucAn.Text;
            string idCategoryFood = (cbbDanhMucThucAn.SelectedItem as FoodCategory).Idfoodcategory;
            double price = (double)nmrGiaThucAn.Value;
            if (price <= 0)
            {
                MessageBox.Show("Giá phải lớn hơn 0");
                return;
            }
            if (idFood == "" || FoodName == "" || idCategoryFood == "")
            {
                MessageBox.Show("Không được bỏ trống dữ liệu");
                return;
            }
            if (FoodDAO.Instance.IsIdFoodExist(idFood) > 0)
            {
                MessageBox.Show("IdFood thức ăn đã tồn tại, vui lòng chọn một ID khác.");
                return;
            }
            if (FoodDAO.Instance.InsertFood(idFood, FoodName, idCategoryFood, price))
            {
                MessageBox.Show("Thêm thành công");
                LoadListFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
            txtIdThucAn.Enabled = false;
        }

        private void btnXemThucAn_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
        #endregion
    }
}
