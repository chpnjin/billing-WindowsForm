using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using AccountBook;

namespace 記帳程式_家用版
{
    public partial class form_addTx : Form
    {
        public form_addTx()
        {
            InitializeComponent();
        }

        System.Data.DataSet ds = new System.Data.DataSet();
        Form_addSub f;
        object[] newTx;
        object[] sublist;

        private void form_addTx_Load(object sender, EventArgs e)
        {
            btn_toDatabase.Enabled = false;
            grp_Cr.Enabled = false;
            grp_Dr.Enabled = false;
            nud_D.Maximum = decimal.MaxValue;
            nud_D.Minimum = 1;
            nud_C.Maximum = decimal.MaxValue;
            nud_C.Minimum = 1;
            dgv_D.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_C.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        //方法:重新抓取科目清單
        private void ReloadSublist()
        {
            sublist = GetData.getSubName(0);
            cbo_Dsub.Items.Clear();
            cbo_Csub.Items.Clear();
            cbo_Dsub.Items.AddRange(sublist);
            cbo_Csub.Items.AddRange(sublist);
        }

        /// <summary>
        /// 方法:編輯欄位資料
        /// </summary>
        /// <param name="cbo">科目名稱</param>
        /// <param name="nud">金額</param>
        /// <param name="txt_remark">備註</param>
        /// <param name="txt_total">顯示借貸平衡的區域</param>
        /// <param name="dt">目標資料表</param>
        /// <param name="dgv">顯示區域</param>
        /// <param name="s">0:新增,1:編輯,2:刪除</param>
        private void editRow(ComboBox cbo, NumericUpDown nud, TextBox txt_remark, TextBox txt_total, DataTable dt, DataGridView dgv, int s)
        {
            //新增或修改
            if (s == 0 || s == 1)
            {
                //判斷科目名稱是否存在
                int station = DataHandling.subexist(cbo.Text.ToString(), sublist);
                //不存在--不新增
                if (station == 0) return;
                //不存在--新增
                if (station == 2)
                {
                    f = new Form_addSub(cbo.Text,0);
                    f.FormClosed += F_FormClosed;
                    f.ShowDialog(this);
                    cbo.Text = f.subname;
                    if (f.set == false) { MessageBox.Show("取消新增交易","提示",MessageBoxButtons.OK,MessageBoxIcon.Information); return; } 
                }
                //判斷作用於借項或貸項
                if (cbo == cbo_Dsub) newTx = new object[7] { "000", dtp_Txdate.Value, txt_lot.Text, cbo.Text, "借", nud.Value, txt_remark.Text };
                else newTx = new object[7] { "000", dtp_Txdate.Value, txt_lot.Text, cbo.Text, "貸", nud.Value, txt_remark.Text };
                //判斷新增或修改
                if (s == 0) dt.Rows.Add(newTx);
                else if (s == 1)
                {
                    if (dgv.SelectedRows.Count == 0) return;
                    dt.Rows[dgv.SelectedRows[0].Index].ItemArray = newTx;
                }
            }
            //刪除
            else if (s == 2)
            {
                if (dgv.SelectedRows.Count == 0) return;
                dt.Rows[dgv.SelectedRows[0].Index].Delete();
            }
            //計算並顯示借方或貸方餘額
            object bal = dt.Compute("Sum(money)", "");
            txt_total.Text = bal.ToString();
            //清空欄位值
            cbo.Text = "";
            nud.Value = 1;
            txt_remark.Text = "";
            //取消選擇
            dgv.ClearSelection();
        }

        //選定日期後顯示空表單
        private void btn_SelDate_Click(object sender, EventArgs e)
        {
            dtp_Txdate.Enabled = false;
            btn_SelDate.Enabled = false;
            txt_lot.Text = GetData.getNewLot(dtp_Txdate.Value.ToShortDateString());
            //啟用區塊與整批刪除按鈕
            grp_Cr.Enabled = true;
            grp_Dr.Enabled = true;
            //讀取所有科目清單並新增至下拉式選單
            ReloadSublist();
            //分別新增借貸兩張DataTable
            ds.Tables.Clear();
            ds.Tables.Add(GetData.getGivenTxData(1)); //0
            ds.Tables[0].TableName = "dt_D";
            ds.Tables.Add(GetData.getGivenTxData(1)); //1
            ds.Tables[1].TableName = "dt_C";
            //繫結資料
            dgv_D.DataSource = ds.Tables["dt_D"];
            dgv_C.DataSource = ds.Tables["dt_C"];
            //修改顯示方式

            //借項
            dgv_D.RowHeadersVisible = false;
            dgv_D.Columns[0].Visible = false; //Tx_no
            dgv_D.Columns[1].Visible = false; //Tx_date
            dgv_D.Columns[2].Visible = false; //lot
            dgv_D.Columns[4].Visible = false; //DC
            dgv_D.Columns[3].HeaderText = "科目名稱".Trim(); //sub_name
            dgv_D.Columns[5].HeaderText = "金額".Trim(); //maney
            dgv_D.Columns[6].HeaderText = "說明".Trim(); //remark
            dgv_D.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv_D.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dgv_D.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //remark
            //貸項
            dgv_C.RowHeadersVisible = false;
            dgv_C.Columns[0].Visible = false; //Tx_no
            dgv_C.Columns[1].Visible = false; //Tx_date
            dgv_C.Columns[2].Visible = false; //lot
            dgv_C.Columns[4].Visible = false; //DC
            dgv_C.Columns[3].HeaderText = "科目名稱".Trim(); //sub_name
            dgv_C.Columns[5].HeaderText = "金額".Trim(); //maney
            dgv_C.Columns[6].HeaderText = "說明".Trim(); //remark
            dgv_C.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv_C.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dgv_C.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //remark
        }

        //借項新增
        private void btn_Dadd_Click(object sender, EventArgs e)
        {
            editRow(cbo_Dsub, nud_D, txt_Dremark, txt_bal_D, ds.Tables[0], dgv_D, 0);
        }

        //借項修改
        private void btn_Dupdate_Click(object sender, EventArgs e)
        {
            editRow(cbo_Dsub, nud_D, txt_Dremark, txt_bal_D, ds.Tables[0], dgv_D, 1);
        }

        //借項刪除
        private void btn_Ddel_Click(object sender, EventArgs e)
        {
            editRow(cbo_Dsub, nud_D, txt_Dremark, txt_bal_D, ds.Tables[0], dgv_D, 2);
        }

        //貸項新增
        private void btn_Cadd_Click(object sender, EventArgs e)
        {
            editRow(cbo_Csub, nud_C, txt_Cremark, txt_bal_C, ds.Tables[1], dgv_C, 0);
        }

        //貸項修改
        private void btn_Cupdate_Click(object sender, EventArgs e)
        {
            editRow(cbo_Csub, nud_C, txt_Cremark, txt_bal_C, ds.Tables[1], dgv_C, 1);
        }

        //貸項刪除
        private void btn_Cdel_Click(object sender, EventArgs e)
        {
            editRow(cbo_Csub, nud_C, txt_Cremark, txt_bal_C, ds.Tables[1], dgv_C, 2);
        }

        //存入資料庫
        private void btn_toDatabase_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Count < 3) ds.Tables.Add(); //2
            else ds.Tables[2].Reset();
            ds.Tables[2].Merge(ds.Tables[0], true);
            ds.Tables[2].Merge(ds.Tables[1], true);
            bool addok = EditData.addTx(ds.Tables[2], 1);
            if (addok)
            {
                MessageBox.Show("新增交易成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        //事件:當新增科目視窗關閉時重新讀取科目清單
        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReloadSublist();
        }

        //事件:當文字變更時重新計算借貸平衡
        private void txt_bal_D_TextChanged(object sender, EventArgs e)
        {
            //若借貸計算無值則當0
            if (string.IsNullOrEmpty(txt_bal_D.Text)) txt_bal_D.Text = "0";
            if (string.IsNullOrEmpty(txt_bal_C.Text)) txt_bal_C.Text = "0";
            //借貸平衡計算
            txt_balance.Text = (Convert.ToDecimal(txt_bal_D.Text) - Convert.ToDecimal(txt_bal_C.Text)).ToString().Trim();
        }

        //事件:若借貸不平衡顯示紅色
        private void txt_balance_TextChanged(object sender, EventArgs e)
        {
            if (txt_balance.Text != "0" || ds.Tables[0].Rows.Count == 0 || ds.Tables[1].Rows.Count == 0)
            {
                btn_toDatabase.Enabled = false;
                txt_balance.ForeColor = Color.Red;
            }
            else if (txt_balance.Text == "0" && ds.Tables[0].Rows.Count > 0 && ds.Tables[1].Rows.Count > 0)
            {
                txt_balance.ForeColor = Color.Black;
                btn_toDatabase.Enabled = true;
            }
        }
    }
}