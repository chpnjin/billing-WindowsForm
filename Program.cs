using DBtools;
using System;
using System.Windows.Forms;

namespace 記帳程式_家用版
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //起始畫面
            ConnectSQL.forlink = Properties.Settings.Default.ConnectToHome;
            Application.Run(new Form_Login());
        }
    }
}
