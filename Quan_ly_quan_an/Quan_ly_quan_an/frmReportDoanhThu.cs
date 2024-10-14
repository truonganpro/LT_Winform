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
    public partial class frmReportDoanhThu : Form
    {
        public frmReportDoanhThu(DateTime checkIn, DateTime checkOut)
        {
            InitializeComponent();
            LoadReport(checkIn, checkOut);

        }

        private void reportDoanhThu_Load(object sender, EventArgs e)
        {

        }
        private void LoadReport(DateTime checkIn, DateTime checkOut)
        {
            try
            {
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load("C:\\Users\\truon\\OneDrive\\Máy tính\\Quan_ly_quan_an\\Quan_ly_quan_an\\rptDoanhThu.rpt");

                foreach (Table table in reportDocument.Database.Tables)
                {
                    TableLogOnInfo tableLogOnInfo = table.LogOnInfo;
                    tableLogOnInfo.ConnectionInfo.UserID = "sa";
                    tableLogOnInfo.ConnectionInfo.Password = "123456";
                    table.ApplyLogOnInfo(tableLogOnInfo);
                }
                reportDocument.SetParameterValue(0, checkIn);
                reportDocument.SetParameterValue(1, checkOut);



                reportDoanhThu.ReportSource = reportDocument;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the report: " + ex.Message);
            }
        }
    }
}
