using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.Common;
using System.Data.SQLite;


namespace TPO.SQLite
{
	class SQLiteHandler
	{
	}

    class SQLiteDB
    {
        private static DbProviderFactory fact = DbProviderFactories.GetFactory("System.Data.SQLite");
        //private static SQLiteFactory fact = (SQLiteFactory)DbProviderFactories.GetFactory("System.Data.SQLite");
        //private static DbProviderFactory fact = new SQLiteFactory();

        public static DbConnection getConnection()
        {

            if (!Directory.Exists("db"))
            {
                Directory.CreateDirectory("db");
            }
            //檔案不存在時就建立
            if (!File.Exists("db/db.s3db"))
            {
                //自動建立SQLite檔案
                SQLiteConnection.CreateFile("db/history.s3db");
            }
            DbConnection cnn = fact.CreateConnection();
            cnn.ConnectionString = "Data Source=db/history.s3db";
            return cnn;
        }

        public static SQLiteConnection getSqliteConnection()
        {
            if (!Directory.Exists("db"))
            {
                Directory.CreateDirectory("db");
            }
            if (!File.Exists("db/history.s3db"))
                SQLiteConnection.CreateFile("db/history.s3db");
            return new SQLiteConnection("Data Source=db/history.s3db");
        }
    }

    //使用SQLiteConnection
    public class AnswerList2
    {
        private String SectionName = "Reading";
        
        public AnswerList2(String section)
        {
            SectionName = section;
        }
        
        //利用資料庫查詢把內容查出後存到List的泛型裡
        /*public List<Answer> getAllList()
        {
            List<Answer> list = new List<Answer>();
            SQLiteConnection conn = SQLiteDB.getSqliteConnection();

            conn.Open();
            try
            {
                String sql = "select * from " + SectionName;
                SQLiteCommand com = conn.CreateCommand();
                com.CommandText = sql;
                SQLiteDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    Answer idc = new Answer();

                    idc.ItemNo = reader.GetInt32(0);
                    idc.ItemAnswer = reader.GetString(1);

                    list.Add(idc);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
            return list;
        }*/
    }

    //使用DbConnection
    public class AnswerList
    {
        private String SectionName = "Reading";
        
        public AnswerList(String section)
        {
            SectionName = section;
        }
        
        //利用資料庫查詢把內容查出後存到List的泛型裡
        /*public List<Answer> getAllList()
        {
            List<Answer> list = new List<Answer>();
            DbConnection conn = SQLiteDB.getConnection();

            conn.Open();
            try
            {
                String sql = "select * from " + SectionName;
                DbCommand com = conn.CreateCommand();
                com.CommandText = sql;
                DbDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    Answer idc = new Answer();
                    idc.ItemNo = reader.GetInt32(0);
                    idc.ItemAnswer = reader.GetString(1);
                    list.Add(idc);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
            return list;
        }*/
    }

    //資料型態與名稱
    public class Answer
    {
        public int ItemNo
        {
            set;
            get;
        }
        public String ItemAnswer
        {
            set;
            get;
        }
    }
}
