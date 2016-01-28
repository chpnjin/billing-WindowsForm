using AccountBook;
using DBtools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 記帳程式_家用版
{
    public partial class Form_enquiry : Form
    {
        public Form_enquiry()
        {
            InitializeComponent();
        }
        string startDay; //開始日期
        string endDay;   //結束日期

        private void Form_enquiry_Load(object sender, EventArgs e)
        {
            btn_clear_Click(btn_clear, e);
        }

        //依照查詢條件顯示交易資料
        private void btn_search_Click(object sender, EventArgs e)
        {
            startDay = dtp_start.Value.ToShortDateString().Trim();
            endDay = dtp_end.Value.ToShortDateString().Trim();
            ConnectSQL.ParametersAddWithValue("@start", startDay, true);
            ConnectSQL.ParametersAddWithValue("@end", endDay, false);
            dgv_ALLlot.DataSource = ConnectSQL.getTable("SELECT DISTINCT Tx_date,lot FROM GL WHERE Tx_date >= @start AND Tx_date <= @end");
            dgv_Txdata.DataSource = "";
            dgv_ALLlot.Columns[0].HeaderText = "日期";
            dgv_ALLlot.Columns[1].HeaderText = "批號";
            dgv_ALLlot.AutoResizeColumns();
            dgv_ALLlot.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        //修改選定的交易資料
        private void btn_editTxdata_Click(object sender, EventArgs e)
        {
            if (dgv_ALLlot.SelectedRows.Count == 0)
            {
                MessageBox.Show("未選擇交易批號", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            object date = dgv_ALLlot.SelectedRows[0].Cells[0].Value;
            DateTime dt = (DateTime)date;
            string lot = dgv_ALLlot.SelectedRows[0].Cells[1].Value.ToString().Trim();
            form_editTx et = new form_editTx(dt, lot);
            et.FormClosed += reload;
            et.ShowDialog(this);
        }

        //清空查詢條件
        private void btn_clear_Click(object sender, EventArgs e)
        {
            dtp_start.Value = DateTime.Today;
            dtp_end.Value = DateTime.Today;
            dgv_ALLlot.DataSource = "";
            dgv_Txdata.DataSource = "";
            dgv_ALLlot.Refresh();
            dgv_Txdata.Refresh();
        }

        //事件:關閉編輯交易資料視窗後重讀交易資料
        private void reload(object sender, FormClosedEventArgs e)
        {
            btn_search_Click(null, null);
        }

        //事件:顯示同一批號的交易資料
        private void dgv_ALLlot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object date = dgv_ALLlot.SelectedRows[0].Cells[0].Value;
            DateTime dt = (DateTime)date;
            string lot = dgv_ALLlot.SelectedRows[0].Cells[1].Value.ToString().Trim();
            ConnectSQL.ParametersAddWithValue("@Tx_date", dt.ToShortDateString().Trim(), true);
            ConnectSQL.ParametersAddWithValue("@lot", lot, false);
            dgv_Txdata.DataSource = ConnectSQL.getTable("SELECT sub_name,DC,money,remark FROM GL WHERE Tx_date = @Tx_date AND lot = @lot");
        }

        //事件:顯示同一批號的交易資料
        private void dgv_ALLlot_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv_ALLlot.SelectedRows.Count == 0) { return; }
            object date = dgv_ALLlot.SelectedRows[0].Cells[0].Value;
            DateTime dt = (DateTime)date;
            string lot = dgv_ALLlot.SelectedRows[0].Cells[1].Value.ToString().Trim();
            ConnectSQL.ParametersAddWithValue("@Tx_date", dt.ToShortDateString().Trim(), true);
            ConnectSQL.ParametersAddWithValue("@lot", lot, false);
            dgv_Txdata.DataSource = ConnectSQL.getTable("SELECT sub_name,DC,money,remark FROM GL WHERE Tx_date = @Tx_date AND lot = @lot");
        }

        //事件:當資料繫結變更時修改顯示設定
        private void dgv_Txdata_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgv_Txdata.Columns.Count == 0) return;
            dgv_Txdata.Columns[0].HeaderText = "科目名稱"; //sub_name
            dgv_Txdata.Columns[1].HeaderText = "借／貸";   //DC
            dgv_Txdata.Columns[2].HeaderText = "金額";     //money
            dgv_Txdata.Columns[3].HeaderText = "說明";     //remark
            dgv_Txdata.AutoResizeColumns();
            dgv_Txdata.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}