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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
            LoadCbbTable(cbbSwitchTable);
        }

        #region method
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableWidth };
                btn.Text = item.Tablename + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightGreen;
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }
        void ShowBill(string idtable)
        {
            lsvBill.Items.Clear();

            List<Quan_ly_quan_an.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(idtable);
            float totalPrice = 0;

            foreach (Quan_ly_quan_an.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            txtTongCong.Text = totalPrice.ToString();
            /* CultureInfo culture = new CultureInfo("vi-VN");
             txtTongCong.Text = totalPrice.ToString("c",culture);*/

        }

        void LoadCategory()
        {
            List<FoodCategory> listCategory = FoodCategoryDAO.Instance.LoadCategoryList();
            cbbCategory.DataSource = listCategory;
            cbbCategory.DisplayMember = "categoryname";
        }

        void LoadFoodListByCategory(string idCategory)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryId(idCategory);
            cbbFood.DataSource = listFood;
            cbbFood.DisplayMember = "foodName";
        }

        void LoadCbbTable(ComboBox cbb)
        {
            cbb.DataSource = TableDAO.Instance.LoadTableList();
            cbb.DisplayMember = "tablename";
        }
        #endregion
        private void btn_Click(object sender, EventArgs e)
        {
            string Idtable = ((sender as Button).Tag as Table).Idtable;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(Idtable);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = lsvBill.Tag as Table;
                if (table == null)
                {
                    MessageBox.Show("Hãy chọn bàn");
                    return;
                }
                int idBill = BillDAO.Instance.GetUncheckBillIdByTableId(table.Idtable);
                string idFood = (cbbFood.SelectedItem as Food).IdFood;
                int count = (int)nrmFoodCount.Value;
                if (idBill == -1)
                {
                    BillDAO.Instance.InsertBill(table.Idtable);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIdBill(), idFood, count);
                }
                else
                {
                    BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, count);
                }
                ShowBill(table.Idtable);
                //TableDAO.Instance.UpdateStatusCoNguoiTable(table.Idtable);
                LoadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // Displaying SQL error message
            }

        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idFoodCategory;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            FoodCategory selected = cb.SelectedItem as FoodCategory;
            idFoodCategory = selected.Idfoodcategory;
            LoadFoodListByCategory(idFoodCategory);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIdByTableId(table.Idtable);
            int discount = (int)nrmDisCount.Value;
            double totalPrice = Convert.ToDouble(txtTongCong.Text);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho {0} \n Tổng tiền - (Tổng tiền / 100) x Giảm giá = {1} - ({1} / 100) x {2} = {3}", table.Tablename, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, finalTotalPrice);
                    ShowBill(table.Idtable);
                    //TableDAO.Instance.UpdateStatusTrongTable(table.Idtable);
                    LoadTable();
                }
            }
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            string idtable1 = (lsvBill.Tag as Table).Idtable;
            string idtable2 = (cbbSwitchTable.SelectedItem as Table).Idtable;
            if (MessageBox.Show(string.Format("Bạn có muốn chuyển bàn {0} qua bàn {1}", (lsvBill.Tag as Table).Tablename, (cbbSwitchTable.SelectedItem as Table).Tablename), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(idtable1, idtable2);
                LoadTable();
            }
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            string idTable = table.Idtable;
            int discount = (int)nrmDisCount.Value;
            double totalPrice = Convert.ToDouble(txtTongCong.Text);
            double giaGiamVnd = totalPrice * discount / 100;
            double thanhTien = totalPrice - giaGiamVnd;
            frmXuatHoaDon frmXuatHoaDon = new frmXuatHoaDon(idTable, discount, totalPrice, giaGiamVnd, thanhTien);
            frmXuatHoaDon.Show();
        }

        private void btnGopBan_Click(object sender, EventArgs e)
        {
            string idtable1 = (lsvBill.Tag as Table).Idtable;
            string idtable2 = (cbbSwitchTable.SelectedItem as Table).Idtable;
            if (MessageBox.Show(string.Format("Bạn có muốn gộp bàn {0} qua bàn {1}", (lsvBill.Tag as Table).Tablename, (cbbSwitchTable.SelectedItem as Table).Tablename), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.MergeTable(idtable1, idtable2);
                LoadTable();
            }
        }
    }
}
