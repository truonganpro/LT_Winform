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
    public partial class frmMain : Form
    {
        private Account loginAccount;
        private int type;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        public frmMain(Account acc, int type)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            this.type = type;
            DisableButtons();
        }
        private void DisableButtons()
        {
            if (type == 0) 
            {
                btnDanhMuc.Enabled = false;
                btnThucDon.Enabled = false;
                btnDSBan.Enabled = false;
                btnDoanhThu.Enabled = false;
                btnTaiKhoan.Enabled = false ;
                btnHoaDon.Enabled = true;
                btnTTCaNhan.Enabled = true; 
            }
        }

        public void AddControls(Form frm)   
        {
            CenterPanel.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            CenterPanel.Controls.Add(frm);
            frm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AddControls(new frmHoaDon());
        }

        private void btnTTCaNhan_Click(object sender, EventArgs e)
        {
            AddControls(new frmTTCaNhan(LoginAccount));
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            AddControls(new frmHoaDon());
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            AddControls(new frmDanhMuc());
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            AddControls(new frmThucDon());
        }

        private void btnDSBan_Click(object sender, EventArgs e)
        {
            AddControls(new frmBan());
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            AddControls(new frmDoanhThu());
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            AddControls(new frmTaiKhoan(loginAccount));
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
