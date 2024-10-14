using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class frmXuatHoaDon : Form
    {
        public frmXuatHoaDon(string idTable, int discount, double totalPirce, double giaGiamVnd, double thanhTien)
        {
            InitializeComponent();
            LoadReport(idTable, discount, totalPirce, giaGiamVnd, thanhTien);
        }
        private void LoadReport(string idTable, int discount, double totalPirce, double giaGiamVnd, double thanhTien)
        {
            try
            {
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load("C:\\Users\\truon\\OneDrive\\Máy tính\\Quan_ly_quan_an\\Quan_ly_quan_an\\rptXuatHoaDon.rpt");

                foreach (Table table in reportDocument.Database.Tables)
                {
                    TableLogOnInfo tableLogOnInfo = table.LogOnInfo;
                    tableLogOnInfo.ConnectionInfo.UserID = "sa";
                    tableLogOnInfo.ConnectionInfo.Password = "123456";
                    table.ApplyLogOnInfo(tableLogOnInfo);
                }
                reportDocument.SetParameterValue(0, idTable);
                reportDocument.SetParameterValue(1, discount);
                reportDocument.SetParameterValue(2, totalPirce);
                reportDocument.SetParameterValue(3, giaGiamVnd);
                reportDocument.SetParameterValue(4, thanhTien);


                reportXuatHoaDon.ReportSource = reportDocument;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the report: " + ex.Message);
            }
        }
    }
}
