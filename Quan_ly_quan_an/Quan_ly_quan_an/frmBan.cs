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
    public partial class frmBan : Form
    {
        BindingSource TableList = new BindingSource();
        public frmBan()
        {
            InitializeComponent();
            txtIdBanAn.Enabled = false;
            txtTrangThai.Enabled = false;
            LoadData();
        }

        #region method
        void LoadData()
        {
            dtgvBanAn.DataSource = TableList;
            LoadListTable();
            AddTableBinding();
        }
        void LoadListTable()
        {
            TableList.DataSource = TableDAO.Instance.LoadTableList();
        }

        void AddTableBinding()
        {
            txtIdBanAn.DataBindings.Add(new Binding("Text", dtgvBanAn.DataSource, "idTable", true, DataSourceUpdateMode.Never));
            txtTenBanAn.DataBindings.Add(new Binding("Text", dtgvBanAn.DataSource, "TableName", true, DataSourceUpdateMode.Never));
            txtTrangThai.DataBindings.Add(new Binding("Text", dtgvBanAn.DataSource, "status", true, DataSourceUpdateMode.Never));
        }
        #endregion
        #region event
        private void btnThemBanAn_Click(object sender, EventArgs e)
        {
            txtIdBanAn.Enabled = true;
            txtIdBanAn.Clear();
            txtTenBanAn.Clear();
            txtTrangThai.Text = "Trống";
        }

        private void btnXoaBanAn_Click(object sender, EventArgs e)
        {
            string tableId = txtIdBanAn.Text;
            string status = TableDAO.Instance.GetStatusTable(tableId);
            if (status == "Có người")
            {
                MessageBox.Show("Hãy thanh toán hóa đơn trước khi xóa bàn này");
                return;
            }
            if (TableDAO.Instance.DeleteTable(tableId))
            {
                MessageBox.Show("Xóa bàn thành công");
                LoadListTable();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa bàn");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string idTable = txtIdBanAn.Text;
            string tableName = txtTenBanAn.Text;
            string status = txtTrangThai.Text;
            if (idTable == "" ||  tableName == "" || status == "")
            {
                MessageBox.Show("Phải điền đầy đủ dữ liệu");
                return;
            }
            if (TableDAO.Instance.IsIdTableExist(idTable) > 0)
            {
                MessageBox.Show("IdTable bàn đã tồn tại, vui lòng chọn một ID khác.");
                return;
            }

            if (TableDAO.Instance.InsertTableFood(idTable, tableName, status))
            {
                MessageBox.Show("Thêm bàn thành công");
                LoadListTable();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm bàn");
            }
            txtIdBanAn.Enabled = false;
        }

        private void btnSuaBanAn_Click(object sender, EventArgs e)
        {
            string tableId = txtIdBanAn.Text;
            string tableName = txtTenBanAn.Text;

            if (tableName == "")
            {
                MessageBox.Show("Không được bỏ trống tên bàn");
                return;
            }
            if (TableDAO.Instance.UpdateTableFood(tableId, tableName))
            {
                MessageBox.Show("Cập nhật bàn thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật bàn");
            }
        }
        #endregion
    }
}
