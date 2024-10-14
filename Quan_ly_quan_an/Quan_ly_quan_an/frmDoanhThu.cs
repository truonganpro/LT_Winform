using Quan_ly_quan_an.DAO;
using Quan_ly_quan_an.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_quan_an
{
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
            LoadData();
        }

        #region method
        void LoadData()
        {
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        #endregion

        #region event
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }
        private void btnXuatBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            DateTime checkIn = dtpkFromDate.Value;
            DateTime checkOut = dtpkToDate.Value;
            frmReportDoanhThu frmReportDoanhThu = new frmReportDoanhThu(checkIn, checkOut);
            frmReportDoanhThu.Show();
        }
        #endregion
    }
}
