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

namespace 記帳程式_家用版
{
    public partial class Form_PL : Form
    {
        public Form_PL()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();

        private void Form_PL_Load(object sender, EventArgs e)
        {
            //預設選擇為目前的年分
            nud_year.Value = DateTime.Now.Year;
            btn_printout.Enabled = false;
        }

        //顯示結果
        private void btn_show_Click(object sender, EventArgs e)
        {
            string md_start = "0101"; //開始月日
            string md_end = "1231";   //結束月日
            //擷取自行選擇的年分
            string start = nud_year.Value.ToString().Trim() + md_start.Trim(); //開始擷取年月日
            string end = nud_year.Value.ToString().Trim() + md_end.Trim(); //結束擷取年月日
            ds.Tables.Clear();
            ds.Tables.Add(GetData.getbal(start, end)); //table 0
            DataView dv = new DataView(ds.Tables[0], "sub_type = '收入'", "sub_name", DataViewRowState.CurrentRows);
            ds.Tables.Add(dv.ToTable("profit")); //table 1
            dv.RowFilter = "sub_type = '支出'";
            ds.Tables.Add(dv.ToTable("loss")); //table 2
            //設定ListView格式
            lv_profit.Clear();
            lv_loss.Clear();
            lv_profit.Columns.Add("名稱");
            lv_profit.Columns.Add("餘額");
            lv_loss.Columns.Add("名稱");
            lv_loss.Columns.Add("餘額");
            lv_profit.View = View.Details;
            lv_loss.View = View.Details;

            //顯示收入
            foreach (DataRow row in ds.Tables[1].Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[2].ToString());
                lv_profit.Items.Add(item);
            }
            //顯示支出
            foreach (DataRow row in ds.Tables[2].Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[2].ToString());
                lv_loss.Items.Add(item);
            }
            //調整欄寬
            lv_profit.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lv_loss.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //計算餘額
            object sum_profit = ds.Tables[1].Compute("Sum(balance)", ""); // 收入總和
            object sum_loss = ds.Tables[2].Compute("Sum(balance)", ""); // 支出總和
            if (string.IsNullOrEmpty(sum_profit.ToString())) sum_profit = 0;
            if (string.IsNullOrEmpty(sum_loss.ToString())) sum_loss = 0;
            decimal total = Convert.ToDecimal(sum_profit) - Convert.ToDecimal(sum_loss);
            txt_total.Text = total.ToString();
            btn_printout.Enabled = true;
        }

        //列印報表
        private void btn_printout_Click(object sender, EventArgs e)
        {
            form_PrintOut fpo = new form_PrintOut(1, ds);
            fpo.ShowDialog(this);
        }
    }
}