using AccountBook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace 記帳程式_家用版
{
    public partial class form_PrintOut : Form
    {
        public form_PrintOut()
        {
            InitializeComponent();
        }

        //建構子:選擇資料來源
        public form_PrintOut(int select,DataSet ds)
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.Add("name");
            dt.Rows.Add(new object[1] { DataHandling.username.ToString().Trim() });
            //資產負債表
            if (select == 0)
            {
                //顯示資料
                reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\..\..\Reports\Report_BS.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dt_Asset", ds.Tables[1]));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dt_Liabilities", ds.Tables[2]));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dt_Net", ds.Tables[3]));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dt_username", dt));
                reportViewer1.RefreshReport();
            }
            //損益表
            else if(select == 1)
            {
                //顯示資料
                reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\..\..\Reports\Report_PL.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dt_income", ds.Tables[1]));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dt_loss", ds.Tables[2]));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dt_username", dt));
                reportViewer1.RefreshReport();
            }
        }

        private void form_PrintOut_Load(object sender, EventArgs e)
        {

        }
    }
}
