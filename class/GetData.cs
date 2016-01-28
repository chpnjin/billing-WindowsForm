using DBtools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AccountBook
{
    /// <summary>
    /// 類別:抓取資料方法群組
    /// </summary>
    static class GetData
    {
        /// <summary>
        /// 使用者登入驗證
        /// </summary>
        /// <returns></returns>
        static public string LoginCheck(string id, string password)
        {
            ConnectSQL.ParametersAddWithValue("@id", id, true);
            ConnectSQL.ParametersAddWithValue("@password", password, false);
            ConnectSQL.ParametersAddWithValue("@avl", "Y", false);
            object[] username_ = ConnectSQL.getAry("SELECT name FROM [user] WHERE id = @id AND password = @password AND avl = @avl");
            if (username_.Length == 0) { return ""; }
            string username = username_[0].ToString();
            return username;
        }

        /// <summary>
        /// 取得可用的科目名稱
        /// </summary>
        /// <param name="s">0:全部,1:資產,2:負債,3:收入,4:支出,5:淨值</param>
        /// <returns></returns>
        static public string[] getSubName(int s)
        {
            List<object> _subname = new List<object>();
            string[] subname;
            int index = 0;
            
            switch (s)
            {
                //所有科目
                case 0: _subname.AddRange(ConnectSQL.getAry("SELECT sub_name FROM Subjects")); break;
                //資產
                case 1: _subname.AddRange(ConnectSQL.getAry("SELECT sub_name FROM Subjects WHERE sub_type = '資產'")); break;
                //負債
                case 2: _subname.AddRange(ConnectSQL.getAry("SELECT sub_name FROM Subjects WHERE sub_type = '負債'")); break;
                //收入
                case 3: _subname.AddRange(ConnectSQL.getAry("SELECT sub_name FROM Subjects WHERE sub_type = '收入'")); break;
                //支出
                case 4: _subname.AddRange(ConnectSQL.getAry("SELECT sub_name FROM Subjects WHERE sub_type = '支出'")); break;
                //淨值
                case 5: _subname.AddRange(ConnectSQL.getAry("SELECT sub_name FROM Subjects WHERE sub_type = '淨值'")); break;
            }
            subname = new string[_subname.Count];
            //下達指令並回傳靜態陣列
            foreach (string submane in _subname)
            {
                subname[index] = submane;
                index++;
            }
            return subname;
        }

        /// <summary>
        /// 檢查科目名稱是否重複
        /// </summary>
        /// <param name="subname">要檢查的科目名稱</param>
        /// <returns></returns>
        static public bool rptchack(string subname)
        {

            ConnectSQL.ParametersAddWithValue("@subname", subname, true);
            object[] rep = ConnectSQL.getAry("SELECT TOP 1 * FROM subjects WHERE [sub_name] = @subname");
            if (rep.Length > 0) return true;
            else return false;
        }

        /// <summary>
        /// 取得同一天交易的最新批號
        /// </summary>
        /// <param name="Txdate">交易日期</param>
        /// <returns></returns>
        static public string getNewLot(string Txdate)
        {
            List<object> num = new List<object>();
            string lot;
            //撈取最新批號
            ConnectSQL.ParametersAddWithValue("@date", Txdate, true);

            num.AddRange(ConnectSQL.getAry("SELECT TOP 1 lot FROM GL WHERE [Tx_date] = @date ORDER BY lot DESC"));
            //若無任何資料則設為01
            if (num.Count == 0)
            {
                lot = "01";
                return lot;
            }
            //若有資料則+1後回傳最新值
            else
            {
                lot = "00" + (Convert.ToInt32(num[0]) + 1).ToString().Trim();
                lot = lot.Substring(lot.Length - 2);
                return lot;
            }
        }

        /// <summary>
        /// 取得指定日期的所有交易批號
        /// </summary>
        /// <param name="Txdate">特定的交易日期</param>
        /// <returns></returns>
        static public object[] getLots(string Txdate)
        {
            List<object> _lots = new List<object>();
            ConnectSQL.ParametersAddWithValue("@date", Txdate, true);
            _lots.AddRange(ConnectSQL.getAry("SELECT DISTINCT lot FROM GL WHERE [Tx_date] = @date ORDER BY lot"));
            object[] lots = new object[_lots.Count];
            _lots.CopyTo(lots);
            return lots;
        }

        /// <summary>
        /// 取得交易紀錄表資料
        /// </summary>
        /// <param name="select">0:前10筆有效紀錄,1:表頭</param>
        /// <returns></returns>
        static public DataTable getGivenTxData(int select)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            //傳回查詢結果
            if (select == 0) dt = ConnectSQL.getTable("SELECT TOP 10 * FROM GL ORDER BY [Tx_date] DESC"); //前10筆
            else if (select == 1) dt = ConnectSQL.getTable("SELECT * FROM GL WHERE 1 = 0"); //空表單
            return dt;
        }

        /// <summary>
        /// 取得需要編輯的交易資料
        /// </summary>
        /// <param name="date">日期</param>
        /// <param name="lot">批號</param>
        /// <returns></returns>
        static public DataTable getEditTxData(string date,string lot)
        {
            DataTable dt = new DataTable();
            ConnectSQL.ParametersAddWithValue("@date", date, true);
            ConnectSQL.ParametersAddWithValue("@lot", lot, false);
            dt = ConnectSQL.getTable("SELECT * FROM GL WHERE Tx_date = @date AND lot = @lot");
            return dt;
        }

        /// <summary>
        /// 取得一定區間的交易資料表
        /// </summary>
        /// <param name="begin">開始日期</param>
        /// <param name="end">結束日期</param>
        /// <returns></returns>
        static public DataTable getRangeTxData(string begin, string end)
        {
            DataTable dt = new DataTable();
            ConnectSQL.ParametersAddWithValue("@begin", begin, true);
            ConnectSQL.ParametersAddWithValue("@end", end, false);
            dt = ConnectSQL.getTable("SELECT * FROM GL WHERE Tx_date >= @begin AND Tx_date <= @end");
            return dt;
        }

        /// <summary>
        /// 取得科目總表
        /// </summary>
        /// <returns></returns>
        static public DataTable getSubList()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            //傳回查詢結果
            dt = ConnectSQL.getTable("SELECT * FROM Subjects");
            //修改表單名稱
            dt.TableName = "SubList";
            return dt;
        }

        /// <summary>
        /// 取得一張含有科目名稱,類別,餘額的DataTable
        /// </summary>
        /// <returns></returns>
        static public DataTable getbal()
        {
            //取得一張含有科目名稱,類別和借貸分別加總的資料表(sub_name,sub_type,sum_D,sum_C)
            DataTable dt = ConnectSQL.getTable("SELECT * FROM GL_total");
            //宣告需用變數
            string type;
            int n;
            decimal[] bal = new decimal[dt.Rows.Count];
            //逐一取得科目餘額
            for (n = 0; n < dt.Rows.Count; n++)
            {

                type = dt.Rows[n][1].ToString();
                if (type == "資產" || type == "支出") { bal[n] = (decimal)dt.Rows[n][2] - (decimal)dt.Rows[n][3]; }
                else if (type == "負債" || type == "淨值" || type == "收入")
                {
                    bal[n] = (decimal)dt.Rows[n][3] - (decimal)dt.Rows[n][2];
                }
            }
            dt.Columns.Remove("sum_D");
            dt.Columns.Remove("sum_C");
            //新增一列餘額資料列
            dt.Columns.Add("balance", typeof(decimal));
            for (n = 0; n < dt.Rows.Count; n++) { dt.Rows[n][2] = bal[n]; }
            return dt;
        }

        /// <summary>
        /// 取得一張含有科目名稱,類別,餘額的DataTable
        /// </summary>
        /// <param name="start">開始結算的年月日</param>
        /// <param name="end">結束結算的年月日</param>
        /// <returns></returns>
        static public DataTable getbal(string start, string end)

        {
            //取得一張依照日期區間擷取含有科目名稱,類別和借貸分別加總的資料表(sub_name,sub_type,sum_D,sum_C)
            ConnectSQL.ParametersAddWithValue("@s", start, true);
            ConnectSQL.ParametersAddWithValue("@e", end, false);
            DataTable dt = ConnectSQL.getTable("EXEC show_total @start = @s , @end = @e");
            //宣告需用變數
            string type;
            int n;
            decimal[] bal = new decimal[dt.Rows.Count];
            //逐一取得科目餘額
            for (n = 0; n < dt.Rows.Count; n++)
            {
                type = dt.Rows[n][1].ToString();
                if (type == "資產" || type == "支出") { bal[n] = (decimal)dt.Rows[n][2] - (decimal)dt.Rows[n][3]; }
                else if (type == "負債" || type == "淨值" || type == "收入")
                {
                    bal[n] = (decimal)dt.Rows[n][3] - (decimal)dt.Rows[n][2];
                }
            }
            dt.Columns.Remove("sum_D");
            dt.Columns.Remove("sum_C");
            //新增一列餘額資料列
            dt.Columns.Add("balance", typeof(decimal));
            for (n = 0; n < dt.Rows.Count; n++) { dt.Rows[n][2] = bal[n]; }
            return dt;
        }
    }
}