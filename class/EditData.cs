using DBtools;
using System;
using System.Data;
using System.Windows.Forms;

namespace AccountBook
{
    /// <summary>
    /// 類別:編輯資料庫方法群組
    /// </summary>
    static class EditData
    {
        /// <summary>
        /// 設定剛開始使用時的科目與金額
        /// </summary>
        /// <param name="dt_new">初始設定資料表</param>
        /// <returns></returns>
        static public bool InitialSetting(DataTable dt_new,string startday)
        {
            //存入科目清單資料表
            DataTable dt_sublist = dt_new.Copy();
            dt_sublist.Columns.Remove("money");
            //轉回英文後存入
            ConnectSQL.daUpdate(dt_sublist, "Subjects");

            //新增初始交易紀錄至總帳資料表
            for (int i = 0; i < dt_new.Rows.Count; i++)
            {
                ConnectSQL.ParametersAddWithValue("@startday", startday, true);
                ConnectSQL.ParametersAddWithValue("@name", dt_new.Rows[i].ItemArray[1], false); //科目名稱
                ConnectSQL.ParametersAddWithValue("@type", dt_new.Rows[i].ItemArray[2], false); //類別
                ConnectSQL.ParametersAddWithValue("@m", dt_new.Rows[i].ItemArray[5], false); //金額
                ConnectSQL.cmdExecute("EXECUTE first_use @Tx_date = @startday, @sub_name = @name, @sub_type = @type , @money = @m");
            }
            return true;
        }

        /// <summary>
        /// 新增科目至資料庫
        /// </summary>
        /// <param name="subname">科目名稱</param>
        /// <param name="subtype">科目類別</param>
        /// <param name="remark">備註</param>
        /// <returns></returns>
        static public bool Addsub(string subname, string subtype, string remark)
        {
            //判斷是否已存在相同的科目名稱
            bool rep = GetData.rptchack(subname);
            if (rep)
            {
                MessageBox.Show("已有相同的科目名稱", "新增錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                //設定具名參數值
                ConnectSQL.ParametersAddWithValue("@sub_no", "000", true);
                ConnectSQL.ParametersAddWithValue("@sub_name", subname, false);
                ConnectSQL.ParametersAddWithValue("@sub_type", subtype, false);
                ConnectSQL.ParametersAddWithValue("@remark", remark, false);
                ConnectSQL.ParametersAddWithValue("@avl", "Y", false);
                bool r = ConnectSQL.cmdExecute("INSERT INTO Subjects(sub_no,sub_name,sub_type,remark,avl) VALUES (@sub_no,@sub_name,@sub_type,@remark,@avl)");
                if (r) { MessageBox.Show("新增科目完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); return true; }
                else return false;
            }
        }

        /// <summary>
        /// 將修改完的科目總表回存至資料庫,並回傳執行結果
        /// </summary>
        /// <param name="dt">科目資料總表</param>
        /// <returns></returns>
        static public bool UpdataSub(DataTable dt_new)
        {
            //回存資料表
            ConnectSQL.AddColumnMappings("sub_no", "sub_no", true);
            ConnectSQL.AddColumnMappings("sub_name", "sub_name", false);
            ConnectSQL.AddColumnMappings("sub_type", "sub_type", false);
            ConnectSQL.AddColumnMappings("remark", "remark", false);
            ConnectSQL.AddColumnMappings("avl", "avl", false);
            try
            {
                ConnectSQL.daUpdate(dt_new, "Subjects");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 新增交易紀錄至資料庫
        /// </summary>
        /// <param name="dt">DataTable物件</param>
        /// <param name="s">新增方式(0 = 逐筆 ; 1 = SqlBulkCopy)</param>
        static public bool addTx(DataTable dt, int s)
        {
            //使用SqlCommand逐筆新增
            if (s == 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ConnectSQL.ParametersAddWithValue("@Tx_no", dt.Rows[i][0], true); //交易序號
                    ConnectSQL.ParametersAddWithValue("@Tx_date", dt.Rows[i][1], false); //交易日期
                    ConnectSQL.ParametersAddWithValue("@lot", dt.Rows[i][2], false); //批次
                    ConnectSQL.ParametersAddWithValue("@sub_name", dt.Rows[i][3], false); //科目名稱
                    ConnectSQL.ParametersAddWithValue("@DC", dt.Rows[i][4], false); //借貸
                    ConnectSQL.ParametersAddWithValue("@money", dt.Rows[i][5], false); //金額
                    ConnectSQL.ParametersAddWithValue("@remark", dt.Rows[i][6], false); //備註
                    ConnectSQL.cmdExecute("INSERT INTO GL(Tx_no,Tx_date,lot,sub_name,DC,money,remark) VALUES (@Tx_no,@Tx_date,@lot,@sub_name,@DC,@money,@remark)");
                }
                return true;
            }
            //使用SqlBulkCopy物件批次新增
            else if (s == 1)
            {
                //設定對應欄位
                ConnectSQL.AddColumnMappings("Tx_no", "Tx_no", true);
                ConnectSQL.AddColumnMappings("Tx_date", "Tx_date", false);
                ConnectSQL.AddColumnMappings("lot", "lot", false);
                ConnectSQL.AddColumnMappings("sub_name", "sub_name", false);
                ConnectSQL.AddColumnMappings("DC", "DC", false);
                ConnectSQL.AddColumnMappings("money", "money", false);
                ConnectSQL.AddColumnMappings("remark", "remark", false);
                ConnectSQL.sbcUpdate(dt, "GL", 1);
                return true;
            }
            return false;
        }

        /// <summary>
        /// 修改既有的交易紀錄
        /// </summary>
        /// <param name="dt">包含修改過紀錄的資料表</param>
        /// <returns></returns>
        static public bool editTx(DataTable dt)
        {
            bool updataOK = ConnectSQL.daUpdate(dt, "GL");
            if (updataOK) return true;
            else return false;
        }
    }
}