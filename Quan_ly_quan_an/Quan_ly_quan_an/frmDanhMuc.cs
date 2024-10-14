using Quan_ly_quan_an.DAO;
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
    public partial class frmDanhMuc : Form
    {
        BindingSource categoryList = new BindingSource();
        public frmDanhMuc()
        {
            InitializeComponent();
            LoadData();
            txtIdDanhMuc.Enabled = false;
        }
        #region Methods
        void LoadData()
        {
            dtgvDanhMuc.DataSource = categoryList;
            LoadCategoryList();
            AddCategoryBinding();
        }

        void LoadCategoryList()
        {
            categoryList.DataSource = FoodCategoryDAO.Instance.LoadCategoryList();
        }

        void AddCategoryBinding()
        {
            txtIdDanhMuc.DataBindings.Add(new Binding("Text", dtgvDanhMuc.DataSource, "idFoodCategory", true, DataSourceUpdateMode.Never));
            txtTenDanhMuc.DataBindings.Add(new Binding("Text", dtgvDanhMuc.DataSource, "CategoryName", true, DataSourceUpdateMode.Never));
        }

        #endregion

        private void btnThemDanhMuc_Click(object sender, EventArgs e)
        {
            txtIdDanhMuc.Enabled = true;
            txtIdDanhMuc.Clear();
            txtTenDanhMuc.Clear();
        }

        private void btnXoaDanhMuc_Click(object sender, EventArgs e)
        {
            string idCategory = txtIdDanhMuc.Text;

            if (FoodCategoryDAO.Instance.DeleteFoodCategory(idCategory))
            {

                MessageBox.Show("Xóa danh mục thành công");
                LoadCategoryList();
                if (deleteFoodCategory != null)
                    deleteFoodCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa danh mục");
            }
        }

        private void btnSuaDanhMuc_Click(object sender, EventArgs e)
        {
            string idCategory = txtIdDanhMuc.Text;
            string categoryName = txtTenDanhMuc.Text;

            if (categoryName == "")
            {
                MessageBox.Show("Không được bỏ trống tên danh mục");
                return;
            }
            if (FoodCategoryDAO.Instance.UpdateFoodCategory(idCategory, categoryName))
            {
                MessageBox.Show("Cập nhật danh mục thành công");
                LoadCategoryList();
                if (updateFoodCategory != null)
                    updateFoodCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật danh mục");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string idCategory = txtIdDanhMuc.Text;
            string categoryName = txtTenDanhMuc.Text;
            if (idCategory == "" || categoryName == "")
            {
                MessageBox.Show("Phải điền đầy đủ dữ liệu");
                return;
            }
            if (FoodCategoryDAO.Instance.IsIdCategoryExist(idCategory) > 0)
            {
                MessageBox.Show("Id danh mục đã tồn tại, vui lòng chọn một ID khác.");
                return;
            }
            if (FoodCategoryDAO.Instance.InsertFoodCategory(idCategory, categoryName))
            {
                MessageBox.Show("Thêm danh mục thành công");
                LoadCategoryList();
                if (insertFoodCategory != null)
                    insertFoodCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm danh mục");
            }
            txtIdDanhMuc.Enabled = false;
        }

        private event EventHandler insertFoodCategory;
        public event EventHandler InsertFoodCategory
        {
            add { insertFoodCategory += value; }
            remove { insertFoodCategory -= value; }
        }

        private event EventHandler deleteFoodCategory;
        public event EventHandler DeleteFoodCategory
        {
            add { deleteFoodCategory += value; }
            remove { deleteFoodCategory -= value; }
        }

        private event EventHandler updateFoodCategory;
        public event EventHandler UpdateFoodCategory
        {
            add { updateFoodCategory += value; }
            remove { updateFoodCategory -= value; }
        }
    }
}
