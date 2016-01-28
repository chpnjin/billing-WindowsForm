using System;
using System.Data;
using System.Windows.Forms;
using AccountBook;

namespace 記帳程式_家用版
{
    public partial class Form_firstUse : Form
    {
        public Form_firstUse()
        {
            InitializeComponent();
            btn_addsub.Enabled = false;
            btn_delsub.Enabled = false;
            btn_balance.Enabled = false;
            btn_finish.Enabled = false;
        }

        //新增交易科目資料表與新科目物件陣列
        DataTable dt = new DataTable();
        object[] newsub = new object[6];
        bool SetOK = false;
        DataGridViewComboBoxColumn dcom = new DataGridViewComboBoxColumn();

        private void Form_firstUse_Load(object sender, EventArgs e)
        {
            //設定顯示資料
            dgv_NewSub.Columns.Add("sub_no", "");           //0
            dgv_NewSub.Columns.Add("sub_name", "科目名稱"); //1
            //下拉式科目類別選擇清單
            dcom.Items.Add("資產");
            dcom.Items.Add("負債");
            dcom.Items.Add("淨值");
            dcom.Name = "sub_type";
            dgv_NewSub.Columns.Add(dcom); //2
            dgv_NewSub.Columns[2].HeaderText = "科目類別";
            dgv_NewSub.Columns.Add("remark", "說明"); //3
            dgv_NewSub.Columns.Add("avl", ""); //4
            dgv_NewSub.Columns.Add("money", "初始金額"); //5
            for(int n = 0;n < 5;n++)
            {
                dgv_NewSub.Columns[n].ValueType = typeof(string);
            }
            dgv_NewSub.Columns[5].ValueType = typeof(decimal);
            //隱藏資料列行首與可用性欄位
            dgv_NewSub.RowHeadersVisible = false;
            dgv_NewSub.Columns[0].Visible = false;
            dgv_NewSub.Columns[4].Visible = false;
            //重新設定參數
            dgv_NewSub.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_NewSub.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv_NewSub.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            //說明資料行寬度填滿整個表單
            dgv_NewSub.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        //方法--借貸平衡計算
        private void balance()
        {
            DataHandling.getTableFromdgv(dgv_NewSub, dt);
            object a = dt.Compute("Sum(money)", "sub_type = '資產' ").ToString().Trim();
            object b = dt.Compute("Sum(money)", "sub_type = '負債' ").ToString().Trim();
            object c = dt.Compute("Sum(money)", "sub_type = '淨值' ").ToString().Trim();
            if (a.ToString() == "") a = "0"; if (b.ToString() == "") b = "0"; if (c.ToString() == "") c = "0";
            txt_A.Text = a.ToString().Trim(); //資產
            txt_L.Text = b.ToString().Trim(); //負債
            txt_N.Text = c.ToString().Trim(); //淨值
            int bal = Convert.ToInt32(a) - Convert.ToInt32(b) - Convert.ToInt32(c);
            txt_bal.Text = bal.ToString().Trim();
        }

        //新增科目
        private void btn_addsub_Click(object sender, EventArgs e)
        {
            //sub_no,sub_name,sub_type,remark,avl,money
            object[] newrow = new object[6] { "000", "", "", "", "Y", "" };
            dgv_NewSub.Rows.Add(newrow);
        }

        //刪除科目
        private void btn_delsub_Click(object sender, EventArgs e)
        {
            if (dgv_NewSub.SelectedRows.Count == 0) return;
            dgv_NewSub.Rows.Remove(dgv_NewSub.SelectedRows[0]);
        }

        //平衡試算
        private void btn_balance_Click(object sender, EventArgs e)
        {
            balance();
        }

        //設定完成關閉視窗
        private void btn_finish_Click(object sender, EventArgs e)
        {
            decimal a = Convert.ToDecimal(txt_A.Text); //資產
            decimal l = Convert.ToDecimal(txt_L.Text); //負債
            decimal n = Convert.ToDecimal(txt_N.Text); //淨值
            decimal bal = Convert.ToDecimal(txt_bal.Text); //平衡
            //資產設定
            if (a <= 0) { MessageBox.Show("未設定資產", "設定錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            else
            {
                //負債或淨值設定
                if ((l + n) <= 0) { MessageBox.Show("未設定負債或淨值", "設定錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                else
                {
                    //借貸是否平衡
                    if (bal == 0)
                    {
                        DataHandling.getTableFromdgv(dgv_NewSub,dt);
                        SetOK = EditData.InitialSetting(dt, dtp_startday.Value.ToShortDateString().Trim());
                        if (SetOK) MessageBox.Show("初始設定完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else MessageBox.Show("借貸未平衡", "設定錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
            }
        }

        //事件:關閉時檢查
        private void Form_firstUse_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SetOK == false)
            {
                MessageBox.Show("請完成初次使用設定", "設定未完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
            else e.Cancel = false;
        }

        //事件:選擇起始日期後允許輸入資料
        private void dtp_startday_ValueChanged(object sender, EventArgs e)
        {
            btn_addsub.Enabled = true;
            btn_delsub.Enabled = true;
            btn_balance.Enabled = true;
            btn_finish.Enabled = true;
            dtp_startday.Enabled = false;
        }
    }
}
