using System;
using System.Windows.Forms;
using AccountBook;

namespace 記帳程式_家用版
{
    public partial class Form_addSub : Form
    {
        //預設顯示的科目名稱
        string _subname;
        bool _set = false; //取得設定狀態
        bool setOK = false; //判斷設定是否完成
        public Form_addSub()
        {
            InitializeComponent();
            txt_subname.Text = subname;
            string[] subtype = new string[5] { "資產", "負債", "收入", "支出", "淨值" };
            cbo_subtype.Items.AddRange(subtype);
            cbo_subtype.SelectedIndex = 0;
        }
        public Form_addSub(string subname, int type)
        {
            InitializeComponent();
            txt_subname.Text = subname;
            string[] subtype = new string[5] { "資產", "負債", "收入", "支出", "淨值" };
            cbo_subtype.Items.AddRange(subtype);
            //無新增類別限制
            if (type == 0)
            {
                _subname = subname;
                cbo_subtype.SelectedIndex = 0;
            }
        }

        //預設科目名稱
        public string subname
        {
            get { return _subname; }
            set { _subname = value; }
        }

        //是否取消設定
        public bool set
        {
            get { return _set; }
            set { _set = value; }
        }

        //取消設定
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            set = false;
            setOK = true;
            Close();
        }

        //將科目新增至資料表中
        private void btn_Addcomplete_Click(object sender, EventArgs e)
        {
            if (txt_subname.Text.Trim() == "") { MessageBox.Show("未輸入科目名稱", "新增錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (cbo_subtype.SelectedItem == null) { MessageBox.Show("未選擇科目類別", "新增錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            bool check = EditData.Addsub(txt_subname.Text, cbo_subtype.SelectedItem.ToString().Trim(), txt_remark.Text);
            if (check)
            {
                subname = txt_subname.Text;
                setOK = true;
                set = true;
                Close();
            }
            else return;
        }

        //關閉時檢查輸入是否正確
        private void Form_addSub_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (setOK) { e.Cancel = false; }
            else
            {
                MessageBox.Show("設定未完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
    }
}
