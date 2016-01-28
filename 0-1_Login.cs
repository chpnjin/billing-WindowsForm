using System;
using System.Windows.Forms;
using AccountBook;

namespace 記帳程式_家用版
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        //設定變數fm
        Form_main fm;
        //登入驗證
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = GetData.LoginCheck(txt_ID.Text, txt_PASSWORD.Text);
            //驗證成功
            if (username.Length > 0)
            {
                //暫存目前的使用者名稱
                DataHandling.username = username;
                fm = new Form_main();
                DialogResult dr = MessageBox.Show("歡迎使用");
                Hide();
                fm.Show();
                //於主畫面標題顯示登入者名稱
                fm.Text += "[登入者:" + username + "]";
                //設定關閉視窗後重新顯示登入畫面事件
                fm.FormClosed += new FormClosedEventHandler(fm_FormClosed);
            }
            //驗證失敗
            else
            {
                DialogResult dr = MessageBox.Show("使用者名稱或密碼錯誤", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Focus();
            }
        }

        //事件:當主畫面關閉時重新顯示登入畫面
        private void fm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            fm = null;
        }

        //事件:登入畫面關閉確認
        private void Form_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("程式即將結束", "未登入", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (r == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (r == DialogResult.No)
            {
                //取消關閉事件
                e.Cancel = true;
            }
        }

        private void btn_creatNewUser_Click(object sender, EventArgs e)
        {

        }
    }
}
