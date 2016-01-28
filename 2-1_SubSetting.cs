using System;
using System.Data;
using System.Windows.Forms;
using DBtools;
using AccountBook;
using System.Collections.Generic;

namespace 記帳程式_家用版
{
    public partial class Form_SubSetting : Form
    {
        public Form_SubSetting()
        {
            InitializeComponent();
        }

        //建立資料表物件
        DataTable dt_old;
        DataTable dt_new;
        string[] type = new string[5] { "資產", "負債", "收入", "支出", "淨值" };

        private void Form_SubSetting_Load(object sender, EventArgs e)
        {
            cbo_subtype.Items.Clear();
            cbo_subtype.Items.AddRange(type);
            //顯示所有科目資料表
            ShowSublist();
        }

        //方法:顯示科目清單
        private void ShowSublist()
        {
            dt_old = GetData.getSubList();
            dt_new = dt_old.Copy();
            dgv_sublist.DataSource = dt_new;
            dgv_sublist.RowHeadersVisible = false;
            dgv_sublist.ColumnHeadersVisible = false;
            dgv_sublist.Columns[0].Visible = false; //sub_no
            dgv_sublist.Columns[2].Visible = false; //sub_type
            dgv_sublist.Columns[3].Visible = false; //remark
            dgv_sublist.Columns[4].Visible = false; //avl
            dgv_sublist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv_sublist.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            //設定備註資料行寬度填滿整個表單
            dgv_sublist.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        //新增科目
        private void btn_INSERTsub_Click(object sender, EventArgs e)
        {
            //實體化新增科目視窗並新增關閉表單事件
            Form_addSub f = new Form_addSub();
            f.FormClosed += new FormClosedEventHandler(addSub_over);
            f.ShowDialog(this);
        }

        //修改科目資料
        private void btn_UPDATAsub_Click(object sender, EventArgs e)
        {
            //檢查有無重複科目名稱
            bool rep = false;
            for (int i = 0;i < dt_new.Rows.Count; i++)
            {
                if (txt_subname.Text == dt_new.Rows[i][1].ToString())
                {
                    rep = true;
                    break;
                }
            }
            //若重複則提示並禁止修改
            if (rep) { MessageBox.Show("已存在相同科目名稱", "修改錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);return; }
            //修改科目總表
            else
            {
                dt_new.Rows[dgv_sublist.SelectedRows[0].Index][1] = txt_subname.Text; //名稱
                dt_new.Rows[dgv_sublist.SelectedRows[0].Index][2] = cbo_subtype.SelectedItem; //類別
                dt_new.Rows[dgv_sublist.SelectedRows[0].Index][3] = txt_remark.Text; //說明
            }
            //檢查舊科目是否在總帳有資料，若有則同步更改

            //比對新舊科目總表相異的科目名稱並更新總帳資料表(手動關聯)
            for(int i = 0;i < dt_new.Rows.Count; i++)
            {
                if(dt_new.Rows[i][1].ToString() != dt_old.Rows[i][1].ToString())
                {
                    ConnectSQL.ParametersAddWithValue("@old", dt_old.Rows[i][1].ToString(), true);
                    ConnectSQL.ParametersAddWithValue("@new", dt_new.Rows[i][1].ToString(), false);
                    ConnectSQL.cmdExecute("UPDATE GL SET sub_name = @new WHERE sub_name = @old");
                }
            }
            bool ok = ConnectSQL.daUpdate(dt_new, "Subjects");
            if (ok) MessageBox.Show("科目資料修改完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowSublist();
        }

        //刪除科目
        private void btn_DELETEsub_Click(object sender, EventArgs e)
        {
            //判斷總帳資料表有無相關交易資料
            ConnectSQL.ParametersAddWithValue("@del", dt_new.Rows[dgv_sublist.SelectedRows[0].Index][1], true);
            object[] Tx = ConnectSQL.getAry("SELECT TOP 1 Tx_no FROM GL WHERE sub_name = @del");
            if (Tx.Length > 0)
            {
                MessageBox.Show("該科目含有交易資料,不能直接刪除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ConnectSQL.ParametersAddWithValue("@del", dt_new.Rows[dgv_sublist.SelectedRows[0].Index][1], true);
                bool delok = ConnectSQL.cmdExecute("DELETE FROM subjects WHERE[sub_name] = @del");
                if (delok) MessageBox.Show("科目刪除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ShowSublist();
        }

        //更改完成關閉表單
        private void btn_overset_Click(object sender, EventArgs e)
        {
            Close();
        }


        //---事件

        //新增完成後重新讀取科目總表
        private void addSub_over(object sender, FormClosedEventArgs e)
        {
            ShowSublist();
        }

        //當點中清單中的資料名稱,自動秀出相關科目資料
        private void dgv_sublist_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgv_sublist.SelectedRows.Count == 0) return;
            txt_subname.Text = dgv_sublist.SelectedRows[0].Cells[1].Value.ToString().Trim(); //科目名稱
            cbo_subtype.SelectedItem = dgv_sublist.SelectedRows[0].Cells[2].Value.ToString(); //科目類別
            txt_remark.Text = dgv_sublist.SelectedRows[0].Cells[3].Value.ToString(); //備註
        }
    }
}
