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
    public partial class frmTaiKhoan : Form
    {
        BindingSource accountList = new BindingSource();
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }

        public frmTaiKhoan(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            txtTenTaiKhoan.Enabled = false;
            LoadData();
        }

        #region method
        void LoadData()
        {
            dtgvTaiKhoan.DataSource = accountList;
            LoadAccount();
            AddAccountBinding();
        }
        void AddAccountBinding()
        {
            txtTenTaiKhoan.DataBindings.Add(new Binding("Text", dtgvTaiKhoan.DataSource, "userName", true, DataSourceUpdateMode.Never));
            txtTenHienThi.DataBindings.Add(new Binding("Text", dtgvTaiKhoan.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nmrLoaiTaiKhoan.DataBindings.Add(new Binding("Value", dtgvTaiKhoan.DataSource, "type", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccout();
        }


        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
            LoadAccount();
        }

        void UpdateAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }
            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Vui lòng không xóa tài khoản hiện tại đang đăng nhập");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
            LoadAccount();
        }

        void ResetPassWord(string userName)
        {
            if (AccountDAO.Instance.ResetPassWord(userName))
            {
                MessageBox.Show("Reset mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Reset mật khẩu thất bại");
            }
        }
        #endregion
        #region event
        private void btnDatLaiMatKhau_Click(object sender, EventArgs e)
        {
            string userName = txtTenTaiKhoan.Text;
            ResetPassWord(userName);
        }

        private void btnXemTaiKhoan_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            string userName = txtTenTaiKhoan.Text;
            string displayName = txtTenHienThi.Text;
            int type = (int)nmrLoaiTaiKhoan.Value;
            if (userName == "" || displayName == "")
            {
                MessageBox.Show("Phải điền đầy đủ thông tin tài khoản");
            }
            else
            {
                UpdateAccount(userName, displayName, type);
            }
            
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            string userName = txtTenTaiKhoan.Text;
            DeleteAccount(userName);
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Enabled = true;
            txtTenTaiKhoan.Clear();
            txtTenHienThi.Clear();            
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string userName = txtTenTaiKhoan.Text;
            string displayName = txtTenHienThi.Text;
            int type = (int)nmrLoaiTaiKhoan.Value;
            if (userName == "" || displayName == "")
            {
                MessageBox.Show("Phải điền đầy đủ thông tin tài khoản");
            }
            else
            {
                AddAccount(userName, displayName, type);
            }
        }
        #endregion
    }
}
