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
    public partial class frmTTCaNhan : Form
    {
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        public frmTTCaNhan(Account acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
            ChangeAccount(acc);
        }

        void ChangeAccount(Account acc)
        {
            txtTenDangNhap.Text = acc.UserName;
            txtTenHienThi.Text = acc.DisplayName;  
        }

        void UpdateAccountInfo()
        {
            string displayName = txtTenHienThi.Text;
            string password = txtMatKhau.Text;
            string newpass = txtMatKhauMoi.Text;
            string reenterpass = txtNhapLaiMatKhauMoi.Text;
            string userName = txtTenDangNhap.Text;

            if (!newpass.Equals(reenterpass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, password, newpass))
                {
                    MessageBox.Show("Cập nhật thành công");
                    if (updateAccount != null)
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu");
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        public class AccountEvent : EventArgs
        {
            private Account acc;

            public Account Acc
            {
                get { return acc; }
                set { acc = value; }
            }

            public AccountEvent(Account acc)
            {
                this.Acc = acc;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
