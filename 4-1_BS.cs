using System;
using System.Data;
using System.Windows.Forms;
using AccountBook;

namespace 記帳程式_家用版
{
    public partial class Form_BS : Form
    {
        public Form_BS()
        {
            InitializeComponent();
        }

        DataSet total = new DataSet();
        DataView dv;

        private void Form_BS_Load(object sender, EventArgs e)
        {
            //預設選擇為目前的年分
            nud_year.Value = DateTime.Now.Year;
            btn_printout.Enabled = false;
        }

        //依照選擇的年分與季別顯示報表
        private void btn_show_Click(object sender, EventArgs e)
        {
            string md_start = "0101"; //開始月日
            string md_end = "1231";   //結束月日
            //擷取自行選擇的整年份資料
            string start = nud_year.Value.ToString().Trim() + md_start.Trim(); //開始擷取年月日
            string end = nud_year.Value.ToString().Trim() + md_end.Trim(); //結束擷取年月日
            total.Tables.Clear();
            total.Tables.Add(GetData.getbal(start, end)); //table 0
            dv = new DataView(total.Tables[0], "sub_type = '資產' ", "sub_name", DataViewRowState.CurrentRows);
            total.Tables.Add(dv.ToTable("Assets")); //table 1 資產類
            dv.RowFilter = "sub_type = '負債' ";
            total.Tables.Add(dv.ToTable("Liabilities")); //table 2 負債類
            dv.RowFilter = "sub_type = '淨值' ";
            total.Tables.Add(dv.ToTable("Net")); //table 3 淨值類
            //設定ListView格式
            lv_Assets.Clear();
            lv_Liabilities.Clear();
            lv_Net.Clear();
            lv_Assets.Columns.Add("名稱");
            lv_Assets.Columns.Add("餘額");
            lv_Liabilities.Columns.Add("名稱");
            lv_Liabilities.Columns.Add("餘額");
            lv_Net.Columns.Add("名稱");
            lv_Net.Columns.Add("餘額");
            lv_Assets.View = View.Details;
            lv_Liabilities.View = View.Details;
            lv_Net.View = View.Details;
            //顯示資產清單
            foreach (DataRow row in total.Tables[1].Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[2].ToString());
                lv_Assets.Items.Add(item);
            }

            //顯示負債清單
            foreach (DataRow row in total.Tables[2].Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[2].ToString());
                lv_Liabilities.Items.Add(item);
            }

            //顯示淨值清單
            foreach (DataRow row in total.Tables[3].Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[2].ToString());
                lv_Net.Items.Add(item);
            }
            lv_Assets.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lv_Liabilities.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lv_Net.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            btn_printout.Enabled = true;
        }

        //報表列印
        private void btn_printout_Click(object sender, EventArgs e)
        {
            form_PrintOut fpo = new form_PrintOut(0,total);
            fpo.ShowDialog(this);
        }
    }
}