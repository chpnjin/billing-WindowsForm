using System;
using System.Data;
using System.Windows.Forms;

namespace AccountBook
{
    /// <summary>
    /// 類別:暫存區資料處理
    /// </summary>
    static public class DataHandling
    {
        static private string _username;

        //儲存使用者名稱
        static public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        /// <summary>
        /// 判斷輸入的科目名稱是否存在
        /// </summary>
        /// <param name="subname">目前輸入的科目名稱</param>
        /// <param name="sublist">目前存在的所有科目(陣列)</param>
        /// <returns></returns>
        static public int subexist(string subname, object[] sublist)
        {
            //先判斷是否輸入空值
            if (subname == "".Trim()) { MessageBox.Show("未輸入科目名稱!!!", "新增錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error); return 0; }
            //取得資料庫所有科目名稱逐筆判斷(物件陣列->字串)
            foreach (string sn in sublist)
            {
                //若科目名稱存在則回覆主程式繼續執行
                if (subname == sn)
                {
                    return 1;
                }
            }
            //若不存在則詢問是否新增科目並停止執行主程式
            if (MessageBox.Show("科目名稱不存在清單中,是否新增?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                return 2;
            }
            else MessageBox.Show("新增交易須輸入正確的科目名稱", "新增錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error); return 0;
        }

        /// <summary>
        /// 將DataGridView的內容轉成DataTable
        /// </summary>
        /// <param name="dgv">來源的DataGridView物件</param>
        /// <param name="dt">要存入資料的DataTable物件</param>
        static public void getTableFromdgv(DataGridView dgv,DataTable dt)
        {
            try
            {
                dt.Columns.Clear();
                if (dgv.Columns.Count == 0) return;
                foreach (DataGridViewColumn col in dgv.Columns) //逐一新增DataGridView的資料行到DataTable
                {
                    if (col.Name == string.Empty) continue; //略過沒有名稱的資料行
                    dt.Columns.Add(col.Name, col.ValueType); //設定資料行名稱與型態
                    dt.Columns[col.Name].Caption = col.HeaderText; //設定標題文字
                }
                if (dt.Columns.Count == 0) return; //若無資料行則回傳空值

                dt.Rows.Clear();
                if (dgv.Rows.Count == 0) return;
                foreach (DataGridViewRow row in dgv.Rows) //逐一新增DataGridView的資料列到DataTable
                {
                    DataRow dtNewRow = dt.NewRow();  //在DataTable新增一列與DataTable相同資料型態的Row
                    foreach (DataColumn col in dt.Columns)
                    {
                        dtNewRow[col.ColumnName] = row.Cells[col.ColumnName].Value; //以DataTable的ColumnName為標定,逐一新增row中每個Cell的值
                    }
                    dt.Rows.Add(dtNewRow); //把建立好的DataRow加到DataTable中
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.ToString());
                return;
            }
            return;
        }
    }
}
