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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat;
            thoat = (MessageBox.Show("Bạn có muốn thoát không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }
        bool Login(string userName, string passWord)
        {
           return AccountDAO.Instance.Login(userName, passWord);
            
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtTenDangNhap.Text;
            string passWord = txtMatKhau.Text;
            if (Login(userName, passWord))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);

                if (loginAccount.Type == 1) 
                {
                    frmMain frmMain = new frmMain(loginAccount, loginAccount.Type);
                    frmMain.ShowDialog();
                }
                else if (loginAccount.Type == 0) 
                {
                    frmMain frmMain = new frmMain(loginAccount, loginAccount.Type);
                    frmMain.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            } 
        }
    }
}
