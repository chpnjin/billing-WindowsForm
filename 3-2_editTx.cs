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
    public partial class form_editTx : Form
    {
        public form_editTx()
        {
            InitializeComponent();
        }

        //建構子:選定特定交易序號進行編輯
        public form_editTx(DateTime Tx_date,string lot)
        {
            InitializeComponent();
            dtp_Txdate.Value = Tx_date;
            cbo_lot.SelectedItem = lot;
            btn_SelDate.Enabled = true;
            btn_SelDate_Click(null, null);
        }

        System.Data.DataSet ds = new System.Data.DataSet(); //儲存交易資料用
        DataView dv;
        Form_addSub f;
        object[] Txdata;
        string[] sublist;

        //讀取表單時的動作
        private void editTx_Load(object sender, EventArgs e)
        {
            if(dgv_D.DataSource == null && dgv_C.DataSource == null)
            {
                grp_Dr.Enabled = false;
                grp_Cr.Enabled = false;
                btn_delAll.Enabled = false;
            }
            btn_toDatabase.Enabled = false;
            nud_D.Minimum = 1;
            nud_D.Maximum = decimal.MaxValue;
            nud_C.Minimum = 1;
            nud_C.Maximum = decimal.MaxValue;
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


        //選擇交易日期與批號後顯示資料
        private void btn_SelDate_Click(object sender, EventArgs e)
        {
            dtp_Txdate.Enabled = false;
            if (cbo_lot.SelectedItem == null) { MessageBox.Show("未選擇交易批號", "提示",MessageBoxButtons.OK,MessageBoxIcon.Error); return; }
            string date = dtp_Txdate.Value.ToString("yyyyMMdd"); //輸出日期為字串,格式為yyyyMMdd(ex. 20150325)
            string lot = cbo_lot.SelectedItem.ToString().Trim();
            ds.Tables.Clear();
            ds.Tables.Add(GetData.getEditTxData(date, lot)); //0
            //把撈出的交易資料分別顯示於借貸兩區
            dv = new DataView(ds.Tables[0]);
            dv.RowFilter = "DC = '借'";
            ds.Tables.Add(dv.ToTable("Tx_D")); //1
            ds.Tables[1].AcceptChanges();
            dgv_D.DataSource = ds.Tables[1];
            dgv_D.Columns[0].Visible = false; //交易序號
            dgv_D.Columns[1].Visible = false; //日期
            dgv_D.Columns[2].Visible = false; //批號
            dgv_D.Columns[4].Visible = false; //借貸
            dgv_D.Columns[3].HeaderText = "科目名稱";
            dgv_D.Columns[5].HeaderText = "金額";
            dgv_D.Columns[6].HeaderText = "說明";
            dgv_D.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv_D.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dgv_D.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //remark

            dv = new DataView(ds.Tables[0]);
            dv.RowFilter = "DC = '貸'";
            ds.Tables.Add(dv.ToTable("Tx_C")); //2
            ds.Tables[2].AcceptChanges();
            dgv_C.DataSource = ds.Tables[2];
            dgv_C.Columns[0].Visible = false; //交易序號
            dgv_C.Columns[1].Visible = false; //日期
            dgv_C.Columns[2].Visible = false; //借貸
            dgv_C.Columns[4].Visible = false; //可用性
            dgv_C.Columns[3].HeaderText = "科目名稱";
            dgv_C.Columns[5].HeaderText = "金額";
            dgv_C.Columns[6].HeaderText = "說明";
            dgv_C.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv_C.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dgv_C.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //remark
            grp_Dr.Enabled = true;
            grp_Cr.Enabled = true;
            btn_delAll.Enabled = true;
            ReloadSublist();
        }

        //新增或修改交易資料
        private void btn_edit_Click(object sender, EventArgs e)
        {
            //借方
            if (sender == btn_Dadd || sender == btn_Dupdate)
            {
                //判斷科目名稱是否存在
                int choice = DataHandling.subexist(cbo_Dsub.Text, sublist);
                if (choice == 0) return;
                else if (choice == 2)
                {
                    f = new Form_addSub(cbo_Dsub.Text,0);
                    f.FormClosed += Reload_Sublist;
                    f.ShowDialog(this);
                    cbo_Dsub.Text = f.subname;
                }
                //新增
                if (sender == btn_Dadd)
                {
                    Txdata = new object[7] { "000", dtp_Txdate.Value, cbo_lot.Text, cbo_Dsub.Text, "借", nud_D.Value, txt_Dremark.Text };
                    ds.Tables[1].Rows.Add(Txdata);
                }
                //修改
                else if (sender == btn_Dupdate)
                {
                    object Tx_no = ds.Tables[1].Rows[dgv_D.SelectedRows[0].Index].ItemArray[0];
                    Txdata = new object[7] { Tx_no, dtp_Txdate.Value, cbo_lot.Text, cbo_Dsub.Text, "借", nud_D.Value, txt_Dremark.Text };
                    ds.Tables[1].Rows[dgv_D.SelectedRows[0].Index].ItemArray = Txdata;
                }
            }
            //貸方
            else if (sender == btn_Cadd || sender == btn_Cupdate)
            {
                //判斷科目名稱是否存在
                int choice = DataHandling.subexist(cbo_Csub.Text, sublist);
                if (choice == 0) return;
                else if (choice == 2)
                {
                    f = new Form_addSub(cbo_Csub.Text,0);
                    f.FormClosed += Reload_Sublist;
                    f.ShowDialog(this);
                    cbo_Csub.Text = f.subname;
                }
                //新增
                if (sender == btn_Cadd)
                {
                    Txdata = new object[7] { "000", dtp_Txdate.Value, cbo_lot.Text, cbo_Csub.Text, "貸", nud_C.Value, txt_Cremark.Text};
                    ds.Tables[2].Rows.Add(Txdata);
                }
                //修改
                else if (sender == btn_Cupdate)
                {
                    object Tx_no = ds.Tables[2].Rows[dgv_C.SelectedRows[0].Index].ItemArray[0];
                    Txdata = new object[7] { Tx_no, dtp_Txdate.Value, cbo_lot.Text, cbo_Csub.Text, "貸", nud_C.Value, txt_Cremark.Text};
                    ds.Tables[2].Rows[dgv_C.SelectedRows[0].Index].ItemArray = Txdata;
                }
            }
        }

        //刪除交易資料
        private void btn_del_Click(object sender, EventArgs e)
        {
            //借方
            if (sender == btn_Ddel)
            {
                if (dgv_D.SelectedRows.Count == 0) return;
                ds.Tables[1].Rows[dgv_D.SelectedRows[0].Index].Delete();
            }
            //貸方
            else if (sender == btn_Cdel)
            {
                if (dgv_C.SelectedRows.Count == 0) return;
                ds.Tables[2].Rows[dgv_C.SelectedRows[0].Index].Delete();
            }
        }

        //刪除整批交易資料
        private void btn_delAll_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否刪除同批次的所有交易資料?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                for(int i = ds.Tables[0].Rows.Count - 1; i > -1;i--)
                {
                    ds.Tables[0].Rows[i].Delete();
                }
                bool ok = EditData.editTx(ds.Tables[0]);
                if (ok) MessageBox.Show("刪除完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else if(dr == DialogResult.No) return;
        }

        //把修改結果回存至資料庫
        private void btn_toDatabase_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Merge(ds.Tables[1], true);
            dt.Merge(ds.Tables[2], true);
            bool ok = EditData.editTx(dt);
            if (ok)
            {
                MessageBox.Show("交易資料修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }


        //事件:修改交易資料時重新計算借貸平衡
        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (sender == dgv_D)
            {
                object bal = ds.Tables[1].Compute("Sum(money)", "");
                if (string.IsNullOrEmpty(bal.ToString().Trim())) txt_bal_D.Text = "0";
                else txt_bal_D.Text = bal.ToString().Trim();
            }
            else if (sender == dgv_C)
            {
                object bal = ds.Tables[2].Compute("Sum(money)", "");
                if (string.IsNullOrEmpty(bal.ToString().Trim())) txt_bal_C.Text = "0";
                else txt_bal_C.Text = bal.ToString().Trim();
            }
            if (string.IsNullOrEmpty(txt_bal_D.Text) || string.IsNullOrEmpty(txt_bal_C.Text)) { }
            else
            {
                decimal d = Convert.ToDecimal(txt_bal_D.Text);
                decimal c = Convert.ToDecimal(txt_bal_C.Text);
                txt_balance.Text = (d - c).ToString();
            }
        }

        //事件:判斷借貸平衡控制是否可回存資料庫
        private void txt_balance_TextChanged(object sender, EventArgs e)
        {
            if (txt_balance.Text == "0") btn_toDatabase.Enabled = true;
            else btn_toDatabase.Enabled = false;
        }

        //事件:當新增科目視窗關閉時重新讀取交易科目清單
        private void Reload_Sublist(object sender, FormClosedEventArgs e)
        {
            ReloadSublist();
        }

        //事件:當選擇日期後顯示當天的交易批號總表
        private void dtp_Txdate_ValueChanged(object sender, EventArgs e)
        {
            cbo_lot.DataSource = GetData.getLots(dtp_Txdate.Value.ToShortDateString());
        }
    }
}
