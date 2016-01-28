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
    public partial class Form_ClosingAccount : Form
    {
        public Form_ClosingAccount()
        {
            InitializeComponent();
        }

        System.Data.DataSet ds = new System.Data.DataSet();

        //方法：結算損益
        private decimal Balance_count()
        {
            object profit = ds.Tables[1].Compute("sum(balance)", "");
            object loss = ds.Tables[2].Compute("sum(balance)", "");
            if (string.IsNullOrEmpty(profit.ToString().Trim())) profit = "0";
            if (string.IsNullOrEmpty(loss.ToString().Trim())) loss = "0";
            txt_total.Text = (Convert.ToInt32(profit) - Convert.ToInt32(loss)).ToString().Trim();
            decimal total = Convert.ToDecimal(txt_total.Text);
            return total;
        }

        private void Form_ClosingAccount_Load(object sender, EventArgs e)
        {
            ds.Tables.Clear();
            ds.Tables.Add(GetData.getbal()); //0
            DataView dv = new DataView(ds.Tables[0]);
            dv.RowFilter = "sub_type = '收入'";
            ds.Tables.Add(dv.ToTable("in")); //1
            dv.RowFilter = "sub_type = '支出'";
            ds.Tables.Add(dv.ToTable("out")); //2
            //顯示收入
            dgv_profit.DataSource = ds.Tables[1];
            dgv_profit.Columns[1].Visible = false;
            dgv_profit.Columns[0].HeaderText = "科目名稱";
            dgv_profit.Columns[2].HeaderText = "餘額";
            dgv_profit.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //顯示支出
            dgv_loss.DataSource = ds.Tables[2];
            dgv_loss.Columns[1].Visible = false;
            dgv_loss.Columns[0].HeaderText = "科目名稱";
            dgv_loss.Columns[2].HeaderText = "餘額";
            dgv_loss.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_loss.AutoResizeColumns();
            dgv_loss.AutoResizeColumns();
            Balance_count();
        }

        private void btn_closing_Click(object sender, EventArgs e)
        {
            if (txt_total.Text == "0")
            {
                MessageBox.Show("餘額為0，不須結清", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable dt_close = GetData.getGivenTxData(1);
            object[] c = new object[7];
            c[0] = 000; //Tx_no
            c[1] = DateTime.Now.ToString(); //Tx_date
            c[2] = GetData.getNewLot(DateTime.Now.ToShortDateString()); //lot
            c[4] = "借"; //DC
            c[6] = "虛帳戶結清"; //remark
            //新增收入類結帳交易
            for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
            {
                c[3] = ds.Tables[1].Rows[i][0]; //sub_name
                c[5] = ds.Tables[1].Rows[i][2]; //money
                dt_close.Rows.Add(c);
            }
            //新增支出類結帳交易
            c[4] = "貸"; //DC
            for (int i = 0; i < ds.Tables[2].Rows.Count; i++)
            {
                c[3] = ds.Tables[2].Rows[i][0]; //sub_name
                c[5] = ds.Tables[2].Rows[i][2]; //money
                dt_close.Rows.Add(c);
            }
            //判斷"保留盈餘"與"累計虧損"科目是否存在,若不存在則新增
            object[] sub = ConnectSQL.getAry("SELECT sub_name FROM Subjects WHERE sub_name = '保留盈餘'");
            if (sub.Length == 0) { EditData.Addsub("保留盈餘", "淨值", "虛帳戶結清後的盈餘"); }
            //判斷收益或虧損
            decimal total = Balance_count();
            if (total > 0)
            {
                c[3] = "保留盈餘";
                c[4] = "貸";
                c[5] = total;
                c[6] = "收支結清--盈餘";
                dt_close.Rows.Add(c);
            }
            else if (total < 0)
            {
                c[3] = "保留盈餘";
                c[4] = "借";
                c[5] = total * -1;
                c[6] = "收支結清--虧損";
                dt_close.Rows.Add(c);
            }
            EditData.addTx(dt_close, 1);
            MessageBox.Show("已結清所有虛帳戶金額至指定的淨值類科目", "結清完成");
            Close();
        }
    }
}
