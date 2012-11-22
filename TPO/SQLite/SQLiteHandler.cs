using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.Common;
using System.Data.SQLite;
using System.Collections;
using TPO.Common;


namespace TPO.SQLite
{
	class SQLiteHandler
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
            cnn.ConnectionString = "Data Source=db/history.s3db;Pooling=true;FailIfMissing=false";
            return cnn;
        }
	}

    class SQLiteDB
    {
        private static DbProviderFactory fact = DbProviderFactories.GetFactory("System.Data.SQLite");
        //private static SQLiteFactory fact = (SQLiteFactory)DbProviderFactories.GetFactory("System.Data.SQLite");
        //private static DbProviderFactory fact = new SQLiteFactory();
        private DbConnection conn;
        private DbConnectionStringBuilder connBuilder;

        public SQLiteDB()
        {
            if (!Directory.Exists("history"))
            {
                Directory.CreateDirectory("history");
            }
            //檔案不存在時就建立
            if (!File.Exists("history/history.db"))
            {
                //自動建立SQLite檔案
                SQLiteConnection.CreateFile("history/history.db");
            }
            this.conn = fact.CreateConnection();
            this.conn.ConnectionString = "Data Source=history/history.db;Pooling=true;FailIfMissing=false";
            this.connBuilder = fact.CreateConnectionStringBuilder();
            this.connBuilder.ConnectionString = "Data Source=history/history.db;Pooling=true;FailIfMissing=false";
            this.conn.Open();
            this.CheckTables();
        }

        private bool TableExist(string table)
        {
            int nRet = 0;
            using(DbCommand cmd = this.conn.CreateCommand())
            {
                string fmt = String.Format("select count(*) from sqlite_master where type='table' and name='{0}'", table);
                cmd.CommandText = fmt;
                nRet = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return (nRet > 0);
        }

        public bool CheckTables()
        {
            if(!this.TableExist("Reading"))
            {
                this.CreateTable(String.Format("CREATE TABLE {0} ({1})", "Reading",
                    @"ID integer primary key autoincrement,
					TPONO integer,
                    Score integer,
                    Ans1 VARCHAR(4), Ans2 VARCHAR(4), Ans3 VARCHAR(4), Ans4 VARCHAR(4), 
                    Ans5 VARCHAR(4), Ans6 VARCHAR(4), Ans7 VARCHAR(4), Ans8 VARCHAR(4), 
                    Ans9 VARCHAR(4), Ans10 VARCHAR(4), Ans11 VARCHAR(4), Ans12 VARCHAR(4), 
                    Ans13 VARCHAR(4), Ans14 VARCHAR(4), Ans15 VARCHAR(4), Ans16 VARCHAR(4), 
                    Ans17 VARCHAR(4), Ans18 VARCHAR(4), Ans19 VARCHAR(4), Ans20 VARCHAR(4), 
                    Ans21 VARCHAR(4), Ans22 VARCHAR(4), Ans23 VARCHAR(4), Ans24 VARCHAR(4), 
                    Ans25 VARCHAR(4), Ans26 VARCHAR(4), Ans27 VARCHAR(4), Ans28 VARCHAR(4)"));
            }

            if (!this.TableExist("Listening"))
            {
                this.CreateTable(String.Format("CREATE TABLE {0} ({1})", "Listening",
                    @"ID integer primary key autoincrement,
					TPONO integer,
                    Score integer,
                    Ans1 VARCHAR(4), Ans2 VARCHAR(4), Ans3 VARCHAR(4), Ans4 VARCHAR(4), 
                    Ans5 VARCHAR(4), Ans6 VARCHAR(4), Ans7 VARCHAR(4), Ans8 VARCHAR(4), 
                    Ans9 VARCHAR(4), Ans10 VARCHAR(4), Ans11 VARCHAR(4), Ans12 VARCHAR(4), 
                    Ans13 VARCHAR(4), Ans14 VARCHAR(4), Ans15 VARCHAR(4), Ans16 VARCHAR(4), 
                    Ans17 VARCHAR(4), Ans18 VARCHAR(4), Ans19 VARCHAR(4), Ans20 VARCHAR(4), 
                    Ans21 VARCHAR(4), Ans22 VARCHAR(4), Ans23 VARCHAR(4), Ans24 VARCHAR(4), 
                    Ans25 VARCHAR(4), Ans26 VARCHAR(4), Ans27 VARCHAR(4), Ans28 VARCHAR(4), 
                    Ans29 VARCHAR(4), Ans30 VARCHAR(4), Ans31 VARCHAR(4), Ans32 VARCHAR(4), 
                    Ans33 VARCHAR(4), Ans34 VARCHAR(4)"));
            }

            return true;
        }

        private void CreateTable(string tableString)
        {
            using (DbCommand cmd = this.conn.CreateCommand())
            {
                cmd.CommandText = tableString;
                cmd.ExecuteNonQuery();
            }
        }

        public ArrayList ExcuteQuery(string sql)
        {
            using (DbCommand cmd = this.conn.CreateCommand())
            {
                cmd.CommandText = sql;
                DbParameter[] ans;
                cmd.Prepare();
                int nCount = 0;
                using (DbDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        
                        nCount++;
                    }
                }
            }
            return null;
        }

        public void QueryByTPO(string table, int TPONO)
        {
            using (DbCommand cmd = this.conn.CreateCommand())
            {
                //cmd.CommandText = sql;
                cmd.CommandText = String.Format("SELECT ID, TPONO, Score, CURRENT_TIMESTAMP FROM {0} WHERE TPONO={1}", table, TPONO);
                
                /*if (table.Equals("Reading"))
                {
                    cmd.CommandText = "SELECT * FROM Reading WHERE TPONO=@p1";
                }
                else if (table.Equals("Listening"))
                {

                }*/
                cmd.ExecuteNonQuery();
                int nCount = 0;
                using (DbDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        for(int i=0; i < rd.FieldCount; i++)
                        {
                            
                        }
                        nCount++;
                    }
                }

               
            }
        }

        //public void Excute()

        //public void CreateTable(s)

        /*public static DbConnection getConnection()
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
            cnn.ConnectionString = "Data Source=db/history.s3db;Pooling=true;FailIfMissing=false";
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
            return new SQLiteConnection("Data Source=db/history.s3db;Pooling=true;FailIfMissing=false");
        }*/
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
