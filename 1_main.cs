using System;
using System.Windows.Forms;
using System.Data;
//使用自訂類別
using AccountBook;

namespace 記帳程式_家用版
{
    public partial class Form_main : Form
    {
        //宣告全域變數fm為Form屬性
        Form f = null;
        DataTable dt;
        System.Data.DataSet ds;
        public Form_main()
        {
            InitializeComponent();
            tsmi_close.Enabled = false;
        }
        private void Form_main_Load(object sender, EventArgs e)
        {
            reload();
        }

        //方法:重新讀取交易與科目現況資料
        private void reload()
        {
            //使用自訂方法連線資料庫並傳回最近日期的前十筆交易紀錄後把資料表顯示於DataGridView
            dgv_near.DataSource = GetData.getGivenTxData(0);
            //隱藏表頭與交易序號
            dgv_near.RowHeadersVisible = false;
            dgv_near.Columns[0].Visible = false;
            //重新設定表頭寬度
            dgv_near.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv_near.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            //設定備註資料行寬度填滿整個表單
            dgv_near.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //資料行標題中文化
            dgv_near.Columns[1].HeaderText = "交易日期";
            dgv_near.Columns[2].HeaderText = "批次";
            dgv_near.Columns[3].HeaderText = "科目名稱";
            dgv_near.Columns[4].HeaderText = "借／貸";
            dgv_near.Columns[5].HeaderText = "金額";
            dgv_near.Columns[6].HeaderText = "說明";
            //分別顯示各類餘額
            dt = GetData.getbal();
            DataView dv = new DataView(dt);
            ds = new System.Data.DataSet();
            dv.RowFilter = "sub_type = '資產'";
            ds.Tables.Add(dv.ToTable("Asset")); //0
            dv.RowFilter = "sub_type = '負債'";
            ds.Tables.Add(dv.ToTable("Liability")); //1
            dv.RowFilter = "sub_type = '收入'";
            ds.Tables.Add(dv.ToTable("Income")); //2
            dv.RowFilter = "sub_type = '支出'";
            ds.Tables.Add(dv.ToTable("Loss")); //3
            dv.RowFilter = "sub_type = '淨值'";
            ds.Tables.Add(dv.ToTable("Equity")); //4
            dgv_Asset.DataSource = ds.Tables[0];
            dgv_Liability.DataSource = ds.Tables[1];
            dgv_Income.DataSource = ds.Tables[2];
            dgv_Loss.DataSource = ds.Tables[3];
            dgv_Equity.DataSource = ds.Tables[4];
        }

        //事件:初次使用時檢查是否有設定科目
        private void Form_main_Shown(object sender, EventArgs e)
        {
            //判斷是否有設定科目
            object[] sublist = GetData.getSubName(0);
            if (sublist.Length == 0)
            {
                //顯示初次設定畫面並新增"於關閉後顯示主畫面"的事件
                DialogResult dr2 = MessageBox.Show("未設定任何科目,請先設定科目之後再開始使用", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr2 == DialogResult.OK)
                {
                    Form fu = new Form_firstUse();
                    fu.FormClosed += new FormClosedEventHandler(whenFormClosed);
                    fu.ShowDialog(this);
                }
                else
                {
                    Form fu = new Form_firstUse();
                    fu.FormClosed += new FormClosedEventHandler(whenFormClosed);
                    fu.ShowDialog(this);
                }
            }
        }


        //新增交易(按鈕)
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            f = new form_addTx();
            f.FormClosed += new FormClosedEventHandler(whenFormClosed);
            f.ShowDialog(this);
        }

        //新增交易(下拉式選單)
        private void 新增交易ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new form_addTx();
            f.FormClosed += new FormClosedEventHandler(whenFormClosed);
            f.ShowDialog(this);
        }

        //編輯交易資料(下拉式選單)
        private void 編輯交易資料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new form_editTx();
            f.FormClosed += new FormClosedEventHandler(whenFormClosed);
            f.ShowDialog(this);
        }

        //查詢交易資料(下拉式選單)
        private void 查詢交易紀錄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new Form_enquiry();
            f.FormClosed += new FormClosedEventHandler(whenFormClosed);
            f.ShowDialog(this);
        }

        //虛帳戶結清(下拉式選單)
        private void 虛帳戶結帳ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form_ClosingAccount();
            f.FormClosed += new FormClosedEventHandler(whenFormClosed);
            f.ShowDialog(this);
        }

        //新增科目(下拉式選單)
        private void 新增科目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new Form_addSub();
            f.FormClosed += new FormClosedEventHandler(whenFormClosed);
            f.ShowDialog(this);
        }

        //編輯現有科目(下拉式選單)
        private void 編輯現有科目ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            f = new Form_SubSetting();
            f.FormClosed += new FormClosedEventHandler(whenFormClosed);
            f.ShowDialog(this);
        }

        //顯示目前狀態的資產負債表
        private void 資產負債表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new Form_BS();
            f.ShowDialog(this);
        }

        //顯示目前狀態的損益表
        private void 損益表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new Form_PL();
            f.ShowDialog(this);
        }

        //事件:當關閉表單後重新讀取最新交易資料
        private void whenFormClosed(object sender, FormClosedEventArgs e)
        {
            reload();
        }

        private void dgv_DataSourceChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            dgv.Columns[1].Visible = false;
            dgv.Columns[0].HeaderText = "名稱";
            dgv.Columns[2].HeaderText = "餘額";
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.ClearSelection();
        }
    }
}
