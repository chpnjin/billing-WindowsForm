using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

/// <summary>
/// 資料庫工具包
/// </summary>
namespace DBtools
{
    /// <summary>
    /// 連線MS資料庫工具包
    /// </summary>
    static class ConnectSQL
    {
        static private string _forlink;  //連線用字串
        //SQLServer專用物件
        static private SqlConnection _conn; //連線用物件
        static private SqlCommand _cmd; //設定SQL語法指令用物件
        static private SqlDataAdapter _da; //DataSet中執行SQL指令存取資料庫資料用物件
        static private SqlCommandBuilder _scb; //配合SqlDataAdapter的Update方法逐筆將指定的DataTable內容回寫到資料庫,可依照內容自動生成SQL指令
        static private SqlBulkCopy _sbc; //將整張DataTable的內容批次修改回寫到資料庫用物件

        /// <summary>
        /// 連線資料庫字串
        /// </summary>
        static public string forlink
        {
            get { return _forlink; }
            set { _forlink = value; }
        }
        static private SqlConnection conn
        {
            get { if (_conn == null) { _conn = new SqlConnection(forlink); return _conn; } return _conn; }
            set { _conn = value; }
        }
        static private SqlCommand cmd
        {
            get { if (_cmd == null) _cmd = new SqlCommand("", conn); return _cmd; }
            set { _cmd = value; }
        }
        static private SqlDataAdapter da
        {
            get { if (_da == null) _da = new SqlDataAdapter("", conn); return _da; }
            set { _da = value; }
        }
        static private SqlCommandBuilder scb
        {
            get { if (_scb == null) _scb = new SqlCommandBuilder(da); return _scb; }
            set { _scb = value; }
        }
        static private SqlBulkCopy sbc
        {
            get { if (_sbc == null) _sbc = new SqlBulkCopy(forlink, SqlBulkCopyOptions.FireTriggers); return _sbc; }
            set { _sbc = value; }
        }

        //--------------------加入參數--------------------

        /// <summary>
        /// 在SqlCommand加入SQL指令參數及其值
        /// </summary>
        /// <param name="sName">參數名稱</param>
        /// <param name="oValue">參數值</param>
        /// <param name="bClear">加入參數前是否先清除所有參數</param>
        static public void ParametersAddWithValue(string sName, object oValue, bool bClear)
        {
            //以布林值判斷是否清除全部參數
            if (bClear)
            {
                if (cmd.Parameters == null) { }
                else cmd.Parameters.Clear();
            }
            cmd.Parameters.AddWithValue(sName, oValue);
        }

        /// <summary>
        /// 加入SqlBulkCopy物件的資料行關聯性
        /// </summary>
        /// <param name="sColumn">DataTable資料行名稱</param>
        /// <param name="dColumn">DataBase資料表資料行名稱</param>
        /// <param name="cmClear">是否清除所有Mappings</param>
        static public void AddColumnMappings(string sColumn, string dColumn, bool cmClear)
        {
            if (cmClear) sbc.ColumnMappings.Clear();
            sbc.ColumnMappings.Add(sColumn, dColumn);
        }

        //---------------------使用SqlCommand物件-------------------------

        /// <summary>
        /// 使用SqlCommand執行SQL指令編輯資料庫,並回傳執行結果
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns>除了SELECT之外的SQL指令</returns>
        static public bool cmdExecute(string sqlStr)
        {
            try
            {
                cmd.CommandText = sqlStr;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.ToString());
                conn.Close();
                return false;
            }
        }

        /// <summary>
        /// 使用SqlCommand執行SELECT指令並回傳一個整數值
        /// </summary>
        /// <param name="sqlStr">SQL語法字串</param>
        /// <returns></returns>
        static public int[] getIntValue(string sqlStr)
        {
            cmd.CommandText = sqlStr;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();  //在從 DataReader 讀資料前 , 一定要執行一次 Read() 才行
                int[] IntValue = new int[dr.FieldCount];
                for (int n = 0; n < dr.FieldCount; n++)
                {
                    int value;
                    if (dr.IsDBNull(n) || dr.GetValue(n).ToString() == "") { value = 0; }
                    else value = Convert.ToInt32(dr.GetDecimal(n));
                    IntValue[n] = value;
                }
                dr.Close();
                conn.Close();
                return IntValue;
            }
            return null;
        }

        /// <summary>
        /// 取得SQLserver中的欄位值並回傳物件陣列
        /// </summary>
        /// <param name="sqlStr">SQL語法字串</param>
        /// <returns></returns>
        static public object[] getAry(string sqlStr)
        {
            try
            {
                //建立不限長度物件陣列
                List<object> _ary = new List<object>();
                //把SqlCommand的查詢結果存至DataReader
                cmd.CommandText = sqlStr;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    //把查詢結果存入陣列
                    while (dr.Read())
                    {
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            _ary.Add(dr[i]);
                        }
                    }
                }
                dr.Close();
                conn.Close();
                //建立靜態陣列,長度預設為動態陣列的值
                object[] ary = new object[_ary.Count];
                //把動態陣列的所有物件複製到靜態陣列並回傳
                for (int i = 0; i < _ary.Count; i++) ary[i] = _ary[i];
                return ary;
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }

        }

        /// <summary>
        /// 取得SQLserver中的欄位值並回傳DataTable
        /// </summary>
        /// <param name="sqlStr">SQL語法字串</param>
        /// <returns></returns>
        static public DataTable getTable(string sqlStr)
        {
            try
            {
                DataTable dt = new DataTable();
                //實體化並設定SQL指令
                cmd.CommandText = sqlStr;
                //把SqlCommand的查詢結果存至DataReader
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
                conn.Close();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        /// <summary>
        /// 取得SQLserver中的欄位值並回傳DataTable
        /// </summary>
        /// <param name="sqlStr">SQL語法字串</param>
        /// <param name="TableName">Table名稱</param>
        /// <returns></returns>
        static public DataTable getTable(string sqlStr, string TableName)
        {
            DataTable dt = new DataTable(TableName);
            //實體化並設定SQL指令
            cmd.CommandText = sqlStr;
            //把SqlCommand的查詢結果存至DataReader
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows) { dt.Load(dr); }
            conn.Close();
            return dt;
        }

        /// <summary>
        /// 聚合函數,取得資料表中特定資料行的統計數據
        /// </summary>
        /// <param name="TableName">資料表名稱</param>
        /// <param name="ColumnName">資料行名稱</param>
        /// <param name="select">參數(0:資料總筆數,1:加總,2:平均,3:最大值,4:最小值)</param>
        /// <returns></returns>
        static public long AggregateFunction(string TableName, string ColumnName, int select)
        {
            int result;
            conn.Open();
            switch (select)
            {
                case 0: cmd.CommandText = "SELECT COUNT" + " " + "(" + ColumnName + ")" + "FROM" + " " + TableName; result = Convert.ToInt32(cmd.ExecuteScalar()); break;
                case 1: cmd.CommandText = "SELECT SUM" + " " + "(" + ColumnName + ")" + "FROM" + " " + TableName; result = Convert.ToInt32(cmd.ExecuteScalar()); break;
                case 2: cmd.CommandText = "SELECT AVG" + " " + "(" + ColumnName + ")" + "FROM" + " " + TableName; result = Convert.ToInt32(cmd.ExecuteScalar()); break;
                case 3: cmd.CommandText = "SELECT Max" + " " + "(" + ColumnName + ")" + "FROM" + " " + TableName; result = Convert.ToInt32(cmd.ExecuteScalar()); break;
                case 4: cmd.CommandText = "SELECT Min" + " " + "(" + ColumnName + ")" + "FROM" + " " + TableName; result = Convert.ToInt32(cmd.ExecuteScalar()); break;
                default: result = -1; break;
            }
            conn.Close();
            return result;
        }

        //---------------------使用SqlDataAdapter物件-------------------------

        /// <summary>
        /// 使用DataAdapter執行SQL指令編輯資料庫,並回傳執行結果
        /// </summary>
        /// <param name="sqlStr">包含INSERT,UPDATE,DELETE的SQL指令</param>
        static public bool daExecute(string sqlStr)
        {
            //新增指令
            if (sqlStr.StartsWith("INSERT"))
            {
                try
                {
                    da.InsertCommand = new SqlCommand(sqlStr, conn);
                    conn.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (Exception)
                {
                    conn.Close();
                    return false;
                }
            }
            //修改指令
            else if (sqlStr.StartsWith("UPDATE"))
            {
                try
                {
                    da.UpdateCommand = new SqlCommand(sqlStr, conn);
                    conn.Open();
                    da.UpdateCommand.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (Exception)
                {
                    conn.Close();
                    return false;
                }
            }
            //刪除指令
            else if (sqlStr.StartsWith("DELETE"))
            {
                try
                {
                    da.DeleteCommand = new SqlCommand(sqlStr, conn);
                    conn.Open();
                    da.DeleteCommand.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (Exception)
                {
                    conn.Close();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 使用DataAdapter的Update方法配合SqlCommandBuilder物件自動生成SQL語法,將整張DataTable的內容逐筆回寫到資料庫中
        /// </summary>
        /// <param name="dt">要回寫進資料庫的DataTable物件</param>
        /// <param name="TableName">資料庫中指定要更新的資料表名稱</param>
        static public bool daUpdate(DataTable dt, string TableName)
        {
            try
            {
                da.SelectCommand.CommandText = "SELECT * FROM" + " " + TableName;
                scb.SetAllValues = true;
                da.Update(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //---------------------其他資料庫物件-------------------------

        /// <summary>
        /// 使用SqlBulkCopy物件將整張DataTable的內容批次回寫到資料庫中
        /// </summary>
        /// <param name="dt">要回寫進資料庫的DataTable物件</param>
        /// <param name="TableName">資料庫中指定要更新的資料表名稱</param>
        /// <param name="BatchSize">每批次的處理量</param>
        static public bool sbcUpdate(DataTable dt, string TableName, int BatchSize)
        {
            sbc.BatchSize = BatchSize;
            sbc.DestinationTableName = TableName;
            conn.Open();
            try { sbc.WriteToServer(dt); }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
            conn.Close();
            return true;
        }
    }
}
