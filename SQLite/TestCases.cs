namespace test
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Data.SQLite;
    using System.Globalization;
    using System.Reflection;
    using System.Text;
    using System.Threading;
    using System.Transactions;

    internal class TestCases : TestCaseBase
    {
        private List<string> droptables;
        private long logevents;
        private List<string> maydroptable;
        private const int NumThreads = 8;
        private const int ThreadTimeout = 0xea60;

        internal TestCases()
        {
            this.droptables = new List<string>();
            this.maydroptable = new List<string>();
        }

        internal TestCases(DbProviderFactory factory, string connectionString) : base(factory, connectionString)
        {
            this.droptables = new List<string>();
            this.maydroptable = new List<string>();
        }

        internal void BinaryInsert()
        {
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO TestCase(Field6) VALUES(@bin)";
                DbParameter Field6 = cmd.CreateParameter();
                byte[] b = new byte[0xfa0];
                b[0] = 1;
                b[100] = 2;
                b[0x3e8] = 3;
                b[0x7d0] = 4;
                b[0xbb8] = 5;
                Field6.ParameterName = "@bin";
                Field6.Value = b;
                cmd.Parameters.Add(Field6);
                cmd.ExecuteNonQuery();
            }
        }

        internal void CheckLocked()
        {
            using (DbConnection newcnn = ((ICloneable) base._cnn).Clone() as DbConnection)
            {
                using (DbCommand cmd = newcnn.CreateCommand())
                {
                    if (newcnn.State != ConnectionState.Open)
                    {
                        newcnn.Open();
                    }
                    cmd.CommandText = "INSERT INTO TestCase (Field1) SELECT 1 WHERE 1 = 2";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal void CheckSQLite()
        {
            if (base._fact.GetType().Name.IndexOf("SQLite", StringComparison.OrdinalIgnoreCase) == -1)
            {
                throw new InconclusiveException("Not a SQLite database");
            }
        }

        [Test(Sequence=100)]
        internal void ClearAllPoolsTest()
        {
            object value;
            string table = "clearpool";
            string temp = "TEMP";
            string exists = " IF NOT EXISTS ";
            if (base._fact.GetType().Name.IndexOf("SQLite", StringComparison.OrdinalIgnoreCase) == -1)
            {
                temp = string.Empty;
                exists = string.Empty;
                table = "#clearpool";
            }
            if (!base._cnnstring.TryGetValue("Pooling", out value))
            {
                throw new Exception("Pooling not present in connection string");
            }
            if (!((bool) value))
            {
                throw new InconclusiveException("Pooling not enabled in the connection string");
            }
            string sql = string.Format("CREATE {0} TABLE {2}{1}(id int primary key);", temp, table, exists);
            base._cnn.GetType().InvokeMember("ClearAllPools", BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static, null, null, null);
            DbConnection[] arr = new DbConnection[10];
            try
            {
                for (int n = 0; n < 10; n++)
                {
                    arr[n] = ((ICloneable) base._cnn).Clone() as DbConnection;
                    if (arr[n].State != ConnectionState.Open)
                    {
                        arr[n].Open();
                    }
                    using (DbCommand cmd = arr[n].CreateCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("INSERT INTO {1} (id) VALUES({0})", n, table);
                        cmd.ExecuteNonQuery();
                    }
                    switch (n)
                    {
                        case 2:
                            arr[n].Dispose();
                            arr[n] = null;
                            break;

                        case 4:
                            base._cnn.GetType().InvokeMember("ClearAllPools", BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static, null, null, null);
                            break;
                    }
                }
                for (int n = 0; n < 10; n++)
                {
                    if (arr[n] != null)
                    {
                        arr[n].Dispose();
                        arr[n] = null;
                    }
                }
                for (int n = 0; n < 10; n++)
                {
                    arr[n] = ((ICloneable) base._cnn).Clone() as DbConnection;
                    if (arr[n].State != ConnectionState.Open)
                    {
                        arr[n].Open();
                    }
                    using (DbCommand cmd = arr[n].CreateCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = string.Format("SELECT [id] FROM {0}", table);
                        object o = cmd.ExecuteScalar();
                        if (((o != null) && (o != DBNull.Value)) && (Convert.ToInt32(o) < 5))
                        {
                            throw new Exception("Unexpected data returned from table!");
                        }
                    }
                }
                base._cnn.GetType().InvokeMember("ClearAllPools", BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static, null, null, null);
            }
            finally
            {
                for (int n = 0; n < 10; n++)
                {
                    if (arr[n] != null)
                    {
                        arr[n].Dispose();
                        arr[n] = null;
                    }
                }
                base._cnn.GetType().InvokeMember("ClearAllPools", BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static, null, null, null);
            }
        }

        [Test(Sequence=90)]
        internal void ClearPoolTest()
        {
            object value;
            string table = "clearpool";
            string temp = "TEMP";
            if (base._fact.GetType().Name.IndexOf("SQLite", StringComparison.OrdinalIgnoreCase) == -1)
            {
                temp = string.Empty;
                table = "#clearpool";
            }
            if (!base._cnnstring.TryGetValue("Pooling", out value))
            {
                throw new Exception("Pooling not present in connection string");
            }
            if (!((bool) value))
            {
                throw new InconclusiveException("Pooling not enabled in the connection string");
            }
            string sql = string.Format("CREATE {0} TABLE {1}(id int primary key);", temp, table);
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            for (int n = 0; n < 10; n++)
            {
                using (DbConnection newcnn = ((ICloneable) base._cnn).Clone() as DbConnection)
                {
                    if (newcnn.State != ConnectionState.Open)
                    {
                        newcnn.Open();
                    }
                    using (DbCommand cmd = newcnn.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }
                    newcnn.GetType().InvokeMember("ClearPool", BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static, null, null, new object[] { newcnn });
                }
            }
        }

        [Test(Sequence=50)]
        internal void CoersionTest()
        {
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                cmd.CommandText = "SELECT Field1, Field2, [Fi\x00ebld3], [Fi\x00e6ld4], Field5, 'A', 1, 1 + 1, 3.14159 FROM TestCase";
                using (DbDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        rd.GetInt32(0);
                        rd.GetDouble(1);
                        rd.GetString(2);
                        rd.GetString(3).TrimEnd(new char[0]);
                        rd.GetDateTime(4);
                        try
                        {
                            rd.GetString(0);
                            throw new Exception("Should have failed type checking!");
                        }
                        catch (InvalidCastException)
                        {
                        }
                        try
                        {
                            rd.GetString(1);
                            throw new Exception("Should have failed type checking!");
                        }
                        catch (InvalidCastException)
                        {
                        }
                        rd.GetString(2);
                        rd.GetString(3);
                        rd.GetInt32(0);
                        try
                        {
                            rd.GetInt32(1);
                            throw new Exception("Should have failed type checking!");
                        }
                        catch (InvalidCastException)
                        {
                        }
                        try
                        {
                            rd.GetInt32(2);
                            throw new Exception("Should have failed type checking!");
                        }
                        catch (InvalidCastException)
                        {
                        }
                        try
                        {
                            rd.GetInt32(3);
                            throw new Exception("Should have failed type checking!");
                        }
                        catch (InvalidCastException)
                        {
                        }
                        try
                        {
                            rd.GetInt32(4);
                            throw new Exception("Should have failed type checking!");
                        }
                        catch (InvalidCastException)
                        {
                        }
                        try
                        {
                            rd.GetDecimal(2);
                            throw new Exception("Should have failed type checking!");
                        }
                        catch (InvalidCastException)
                        {
                        }
                        catch (FormatException)
                        {
                        }
                        try
                        {
                            rd.GetDecimal(3);
                            throw new Exception("Should have failed type checking!");
                        }
                        catch (InvalidCastException)
                        {
                        }
                        catch (FormatException)
                        {
                        }
                        try
                        {
                            rd.GetDecimal(4);
                            throw new Exception("Should have failed type checking!");
                        }
                        catch (InvalidCastException)
                        {
                            return;
                        }
                        catch (FormatException)
                        {
                            return;
                        }
                    }
                    throw new Exception("No data in table");
                }
            }
        }

        [Test]
        internal void ConnectionStringBuilder()
        {
            DbConnectionStringBuilder builder = base._fact.CreateConnectionStringBuilder();
            if (builder is SQLiteConnectionStringBuilder)
            {
                bool pooling = ((SQLiteConnectionStringBuilder) builder).Pooling;
            }
        }

        [Test(Sequence=10)]
        internal void CreateTable()
        {
            this.droptables.Add("TestCase");
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                if (base._fact.GetType().Name.IndexOf("SQLite", StringComparison.OrdinalIgnoreCase) == -1)
                {
                    cmd.CommandText = "CREATE TABLE TestCase (ID bigint primary key identity, Field1 integer, Field2 Float, [Fi\x00ebld3] VARCHAR(50), [Fi\x00e6ld4] CHAR(10), Field5 DateTime, Field6 Image)";
                }
                else
                {
                    cmd.CommandText = "CREATE TABLE TestCase (ID integer primary key autoincrement, Field1 int, Field2 Float, [Fi\x00ebld3] VARCHAR(50), [Fi\x00e6ld4] CHAR(10), Field5 DateTime, Field6 Image)";
                }
                cmd.ExecuteNonQuery();
            }
        }

        internal string DataAdapter(bool bWithIdentity)
        {
            StringBuilder builder = new StringBuilder();
            using (DbTransaction dbTrans = base._cnn.BeginTransaction())
            {
                using (DbDataAdapter adp = base._fact.CreateDataAdapter())
                {
                    using (DbCommand cmd = base._cnn.CreateCommand())
                    {
                        cmd.Transaction = dbTrans;
                        cmd.CommandText = "SELECT * FROM TestCase WHERE 1 = 2";
                        adp.SelectCommand = cmd;
                        using (DbCommandBuilder bld = base._fact.CreateCommandBuilder())
                        {
                            bld.DataAdapter = adp;
                            using (adp.InsertCommand = (DbCommand) ((ICloneable) bld.GetInsertCommand()).Clone())
                            {
                                if (bWithIdentity)
                                {
                                    if (base._fact.GetType().Name.IndexOf("SQLite", StringComparison.OrdinalIgnoreCase) == -1)
                                    {
                                        DbCommand insertCommand = adp.InsertCommand;
                                        insertCommand.CommandText = insertCommand.CommandText + ";SELECT SCOPE_IDENTITY() AS [ID]";
                                    }
                                    else
                                    {
                                        DbCommand command2 = adp.InsertCommand;
                                        command2.CommandText = command2.CommandText + ";SELECT last_insert_rowid() AS [ID]";
                                    }
                                    adp.InsertCommand.UpdatedRowSource = UpdateRowSource.FirstReturnedRecord;
                                }
                                bld.DataAdapter = null;
                                using (DataTable tbl = new DataTable())
                                {
                                    adp.Fill(tbl);
                                    for (int n = 0; n < 0x2710; n++)
                                    {
                                        DataRow row = tbl.NewRow();
                                        row[1] = n + (0xc350 * (bWithIdentity ? 2 : 1));
                                        tbl.Rows.Add(row);
                                    }
                                    int dtStart = Environment.TickCount;
                                    adp.Update(tbl);
                                    int dtEnd = Environment.TickCount - dtStart;
                                    builder.AppendFormat("Insert Ends in {0} ms ... ", dtEnd);
                                    dtStart = Environment.TickCount;
                                    dbTrans.Commit();
                                    dtEnd = Environment.TickCount - dtStart;
                                    builder.AppendFormat("Commits in {0} ms", dtEnd);
                                    if (bWithIdentity)
                                    {
                                        using (DataTable tbl2 = new DataTable())
                                        {
                                            adp.SelectCommand.CommandText = "SELECT * FROM TestCase WHERE Field1 BETWEEN 100000 AND 199999 ORDER BY Field1";
                                            adp.Fill(tbl2);
                                            if (tbl2.Rows.Count != tbl.Rows.Count)
                                            {
                                                throw new Exception("Selected data doesn't match updated data!");
                                            }
                                            for (int n = 0; n < tbl.Rows.Count; n++)
                                            {
                                                if (!tbl.Rows[n][0].Equals(tbl2.Rows[n][0]))
                                                {
                                                    throw new Exception("Fetched identity doesn't match selected identity!");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return builder.ToString();
        }

        [Test(Sequence=0x44c)]
        internal string DataAdapterTest()
        {
            return this.DataAdapter(false);
        }

        [Test(Sequence=0x4b0)]
        internal string DataAdapterWithIdentityFetch()
        {
            return this.DataAdapter(true);
        }

        [Test]
        internal void DataReaderCleanup()
        {
            DbConnection newcnn = ((ICloneable) base._cnn).Clone() as DbConnection;
            DbCommand cmd = newcnn.CreateCommand();
            try
            {
                if (newcnn.State != ConnectionState.Open)
                {
                    newcnn.Open();
                }
                cmd.CommandText = "SELECT 1, 2, 3";
                using (DbDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    cmd.Dispose();
                    try
                    {
                        reader.Read();
                    }
                    catch
                    {
                        throw new Exception("Unable to read from a DataReader!");
                    }
                    if (((reader.GetInt32(0) != 1) || (reader.GetInt32(1) != 2)) || (reader.GetInt32(2) != 3))
                    {
                        throw new Exception("Unexpected return values from reader!");
                    }
                    reader.Close();
                    if (newcnn.State != ConnectionState.Closed)
                    {
                        throw new Exception("DataReader failed to cleanup!");
                    }
                }
            }
            finally
            {
                cmd.Dispose();
                newcnn.Dispose();
            }
        }

        [Test]
        internal void DataTypesSchema()
        {
            using (base._cnn.GetSchema("DataTypes"))
            {
            }
        }

        [Test]
        internal void DataTypeTest()
        {
            DateTime now = DateTime.Now;
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                this.droptables.Add("datatypetest");
                if (base._fact.GetType().Name.IndexOf("SQLite", StringComparison.OrdinalIgnoreCase) == -1)
                {
                    cmd.CommandText = "create table datatypetest(id bigint identity primary key, myvalue sql_variant, datetimevalue datetime, decimalvalue decimal(38,18))";
                }
                else
                {
                    cmd.CommandText = "create table datatypetest(id integer primary key, myvalue sql_variant, datetimevalue datetime, decimalvalue decimal(38,18))";
                }
                cmd.ExecuteNonQuery();
                CultureInfo oldculture = Thread.CurrentThread.CurrentCulture;
                CultureInfo olduiculture = Thread.CurrentThread.CurrentUICulture;
                Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
                Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
                try
                {
                    cmd.CommandText = "insert into datatypetest(myvalue, datetimevalue, decimalvalue) values(@p1,@p2,@p3)";
                    DbParameter p1 = cmd.CreateParameter();
                    DbParameter p2 = cmd.CreateParameter();
                    DbParameter p3 = cmd.CreateParameter();
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    p1.ParameterName = "@p1";
                    p2.ParameterName = "@p2";
                    p3.ParameterName = "@p3";
                    p1.Value = 1L;
                    p2.Value = new DateTime(0x6d9, 1, 1);
                    p3.Value = 1.05M;
                    cmd.ExecuteNonQuery();
                    p1.ResetDbType();
                    p2.ResetDbType();
                    p3.ResetDbType();
                    p1.Value = "One";
                    p2.Value = "2001-01-01";
                    p3.Value = 1M;
                    cmd.ExecuteNonQuery();
                    p1.ResetDbType();
                    p2.ResetDbType();
                    p3.ResetDbType();
                    p1.Value = 1.01;
                    p2.Value = now;
                    p3.Value = 9.91M;
                    cmd.ExecuteNonQuery();
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                    Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
                    cmd.CommandText = "select myvalue, datetimevalue, decimalvalue from datatypetest";
                    cmd.Parameters.Clear();
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        for (int n = 0; n < 3; n++)
                        {
                            reader.Read();
                            if (reader.GetValue(1).GetType() != reader.GetDateTime(1).GetType())
                            {
                                throw new Exception("DateTime type non-match");
                            }
                            if (reader.GetValue(2).GetType() != reader.GetDecimal(2).GetType())
                            {
                                throw new Exception("Decimal type non-match");
                            }
                            switch (n)
                            {
                                case 0:
                                    if (reader.GetValue(0).GetType() != typeof(long))
                                    {
                                        throw new Exception("long type non-match");
                                    }
                                    break;

                                case 1:
                                    if (reader.GetValue(0).GetType() != typeof(string))
                                    {
                                        throw new Exception("String type non-match");
                                    }
                                    goto Label_045C;

                                case 2:
                                    if (reader.GetValue(0).GetType() != typeof(double))
                                    {
                                        throw new Exception("Double type non-match");
                                    }
                                    goto Label_05B1;

                                default:
                                {
                                    continue;
                                }
                            }
                            if (!reader.GetValue(0).Equals(1L))
                            {
                                throw new Exception("long value non-match");
                            }
                            if (!reader.GetValue(1).Equals(new DateTime(0x6d9, 1, 1)))
                            {
                                throw new Exception(string.Format("DateTime value non-match expected {0} got {1}", new DateTime(0x6d9, 1, 1), reader.GetValue(1)));
                            }
                            if (!reader.GetValue(2).Equals(1.05M))
                            {
                                throw new Exception("Decimal value non-match");
                            }
                            if (!reader.GetValue(0).Equals(reader.GetInt64(0)))
                            {
                                throw new Exception(string.Format("long value failed to match itself, {0} and {1}", reader.GetValue(0), reader.GetInt64(0)));
                            }
                            if (!reader.GetValue(1).Equals(reader.GetDateTime(1)))
                            {
                                throw new Exception(string.Format("DateTime failed to match itself {0} and {1}", reader.GetValue(1), reader.GetDateTime(1)));
                            }
                            if (reader.GetValue(2).Equals(reader.GetDecimal(2)))
                            {
                                continue;
                            }
                            throw new Exception(string.Format("Decimal failed to match itself {0} and {1}", reader.GetValue(2), reader.GetDecimal(2)));
                        Label_045C:
                            if (!reader.GetValue(0).Equals("One"))
                            {
                                throw new Exception("String value non-match");
                            }
                            if (!reader.GetValue(1).Equals(new DateTime(0x7d1, 1, 1)))
                            {
                                throw new Exception(string.Format("DateTime value non-match expected {0} got {1}", new DateTime(0x7d1, 1, 1), reader.GetValue(1)));
                            }
                            if (!reader.GetValue(2).Equals(1M))
                            {
                                throw new Exception("Decimal value non-match");
                            }
                            if (reader.GetString(0) != "One")
                            {
                                throw new Exception("String value non-match");
                            }
                            if (!reader.GetValue(1).Equals(reader.GetDateTime(1)))
                            {
                                throw new Exception(string.Format("DateTime failed to match itself {0} and {1}", reader.GetValue(1), reader.GetDateTime(1)));
                            }
                            if (reader.GetValue(2).Equals(reader.GetDecimal(2)))
                            {
                                continue;
                            }
                            throw new Exception(string.Format("Decimal failed to match itself {0} and {1}", reader.GetValue(2), reader.GetDecimal(2)));
                        Label_05B1:
                            if (!reader.GetValue(0).Equals(1.01))
                            {
                                throw new Exception("Double value non-match");
                            }
                            if (reader.GetValue(1).ToString() != now.ToString())
                            {
                                throw new Exception(string.Format("DateTime value non-match, expected {0} got {1}", now, reader.GetValue(1)));
                            }
                            if (!reader.GetValue(2).Equals(9.91M))
                            {
                                throw new Exception("Decimal value non-match");
                            }
                            if (reader.GetDouble(0) != 1.01)
                            {
                                throw new Exception("Double value non-match");
                            }
                            if (!reader.GetValue(1).Equals(reader.GetDateTime(1)))
                            {
                                throw new Exception(string.Format("DateTime failed to match itself {0} and {1}", reader.GetValue(1), reader.GetDateTime(1)));
                            }
                            if (!reader.GetValue(2).Equals(reader.GetDecimal(2)))
                            {
                                throw new Exception(string.Format("Decimal failed to match itself {0} and {1}", reader.GetValue(2), reader.GetDecimal(2)));
                            }
                        }
                    }
                }
                finally
                {
                    Thread.CurrentThread.CurrentCulture = oldculture;
                    Thread.CurrentThread.CurrentUICulture = olduiculture;
                }
            }
        }

        [Test]
        internal void DecimalTest()
        {
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                this.droptables.Add("DECTEST");
                cmd.CommandText = "CREATE TABLE DECTEST(x DECIMAL(38,18))";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO DECTEST(x) VALUES(0.00001)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT * FROM DECTEST";
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    decimal decimal1 = (decimal) reader.GetValue(0);
                    reader.GetDecimal(0);
                }
            }
        }

        [Test(Sequence=0x7fffffff)]
        internal void DropTable(string table)
        {
            this.DropTables(new string[]{table}, true);
        }

        internal void DropTables(string[] tables, bool throwError = true)
        {
            string errors = string.Empty;
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                foreach (string table in tables)
                {
                    try
                    {
                        cmd.CommandText = string.Format("DROP TABLE{1} [{0}]", table, !throwError ? " IF EXISTS" : "");
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        if (throwError)
                        {
                            errors = errors + string.Format("{0}\r\n", e.Message);
                        }
                    }
                }
                foreach (string table in this.maydroptable)
                {
                    try
                    {
                        cmd.CommandText = string.Format("DROP TABLE{1} [{0}]", table, !throwError ? " IF EXISTS" : "");
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            if (!string.IsNullOrEmpty(errors))
            {
                throw new Exception(errors);
            }
        }

        [Test]
        internal void ExtendedResultCodesTest()
        {
            if (base._fact.GetType().Name.IndexOf("SQLite", StringComparison.OrdinalIgnoreCase) > -1)
            {
                SQLiteConnection cnn = new SQLiteConnection(base._cnnstring.ConnectionString);
                cnn.Open();
                cnn.SetExtendedResultCodes(true);
                cnn.ResultCode();
                cnn.ExtendedResultCode();
                cnn.Close();
            }
        }

        [Test(Sequence=0x3e8)]
        internal string FastInsertMany()
        {
            StringBuilder builder = new StringBuilder();
            using (DbTransaction dbTrans = base._cnn.BeginTransaction())
            {
                int dtStart;
                int dtEnd;
                using (DbCommand cmd = base._cnn.CreateCommand())
                {
                    cmd.Transaction = dbTrans;
                    cmd.CommandText = "INSERT INTO TestCase(Field1) VALUES(@p1)";
                    DbParameter Field1 = cmd.CreateParameter();
                    Field1.ParameterName = "@p1";
                    cmd.Parameters.Add(Field1);
                    dtStart = Environment.TickCount;
                    for (int n = 0; n < 0x186a0; n++)
                    {
                        Field1.Value = n + 0x30d40;
                        cmd.ExecuteNonQuery();
                    }
                    dtEnd = Environment.TickCount - dtStart;
                    builder.AppendFormat("Ends in {0} ms ... ", dtEnd);
                }
                dtStart = Environment.TickCount;
                dbTrans.Commit();
                dtEnd = Environment.TickCount - dtStart;
                builder.AppendFormat("Commits in {0} ms", dtEnd);
            }
            return builder.ToString();
        }

        [Test]
        internal void FullTextTest()
        {
            this.CheckSQLite();
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                int n;
                this.droptables.Add("FullText");
                cmd.CommandText = "CREATE VIRTUAL TABLE FullText USING FTS3(name, ingredients);";
                cmd.ExecuteNonQuery();
                string[] names = new string[] { "broccoli stew", "pumpkin stew", "broccoli pie", "pumpkin pie" };
                string[] ingredients = new string[] { "broccoli peppers cheese tomatoes", "pumpkin onions garlic celery", "broccoli cheese onions flour", "pumpkin sugar flour butter" };
                cmd.CommandText = "insert into FullText (name, ingredients) values (@name, @ingredient);";
                DbParameter name = cmd.CreateParameter();
                DbParameter ingredient = cmd.CreateParameter();
                name.ParameterName = "@name";
                ingredient.ParameterName = "@ingredient";
                cmd.Parameters.Add(name);
                cmd.Parameters.Add(ingredient);
                for (n = 0; n < names.Length; n++)
                {
                    name.Value = names[n];
                    ingredient.Value = ingredients[n];
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = "select rowid, name, ingredients from FullText where name match 'pie';";
                cmd.Parameters.Clear();
                int[] rowids = new int[] { 3, 4 };
                n = 0;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.GetInt64(0) != rowids[n++])
                        {
                            throw new Exception("Unexpected rowid returned");
                        }
                        if (n > rowids.Length)
                        {
                            throw new Exception("Too many rows returned");
                        }
                    }
                }
            }
        }

        [Test]
        internal void GuidTest()
        {
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                Guid guid = Guid.NewGuid();
                this.droptables.Add("GuidTest");
                cmd.CommandText = "CREATE TABLE GuidTest(MyGuid uniqueidentifier)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO GuidTest(MyGuid) VALUES(@b)";
                DbParameter parm = cmd.CreateParameter();
                parm.ParameterName = "@b";
                parm.Value = guid;
                cmd.Parameters.Add(parm);
                cmd.ExecuteNonQuery();
                cmd.Parameters[0].Value = guid.ToString();
                cmd.Parameters[0].DbType = DbType.String;
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT MyGuid FROM GuidTest";
                cmd.Parameters.Clear();
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    if (reader.GetFieldType(0) != typeof(Guid))
                    {
                        throw new Exception("Column is not a Guid");
                    }
                    if (reader.GetGuid(0) != guid)
                    {
                        throw new Exception(string.Format("Got guid {0}, expected {1}", reader.GetGuid(0), guid));
                    }
                    reader.Read();
                    if (reader.GetFieldType(0) != typeof(Guid))
                    {
                        throw new Exception("Column is not a Guid");
                    }
                    if (reader.GetGuid(0) != guid)
                    {
                        throw new Exception(string.Format("Got guid {0}, expected {1}", reader.GetGuid(0), guid));
                    }
                }
            }
        }

        [Test(Sequence=20)]
        internal void InsertTable(string table)
        {
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO TestCase(Field1, Field2, [Fi\x00ebld3], [Fi\x00e6ld4], Field5) VALUES(1, 3.14159, 'Fi\x00ebld3', 'Fi\x00e6ld4', '2005-01-01 13:49:00')";
                //cmd.CommandText = "";
                cmd.ExecuteNonQuery();
            }
        }

        #region IterationTests
        [Test]
        internal string IterationTest1()
        {
            this.CheckSQLite();
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                int dtEnd;
                cmd.CommandText = "SELECT Foo(ID, ID) FROM TestCase";
                cmd.Prepare();
                int dtStart = Environment.TickCount;
                int nCount = 0;
                using (DbDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        rd.GetInt64(0);
                        nCount++;
                    }
                    dtEnd = Environment.TickCount;
                }
                return string.Format("User Function iteration of {0} records in {1} ms", nCount, dtEnd - dtStart);
            }
        }

        [Test]
        internal string IterationTest2()
        {
            new StringBuilder();
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                int dtEnd;
                cmd.CommandText = "SELECT ID FROM TestCase";
                cmd.Prepare();
                int dtStart = Environment.TickCount;
                int nCount = 0;
                using (DbDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        rd.GetInt64(0);
                        nCount++;
                    }
                    dtEnd = Environment.TickCount;
                }
                return string.Format("Raw iteration of {0} records in {1} ms", nCount, dtEnd - dtStart);
            }
        }

        [Test]
        internal string IterationTest3()
        {
            new StringBuilder();
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                int dtEnd;
                cmd.CommandText = "SELECT ABS(ID) FROM TestCase";
                cmd.Prepare();
                int dtStart = Environment.TickCount;
                int nCount = 0;
                using (DbDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        rd.GetInt64(0);
                        nCount++;
                    }
                    dtEnd = Environment.TickCount;
                }
                return string.Format("Intrinsic Function iteration of {0} records in {1} ms", nCount, dtEnd - dtStart);
            }
        }
        #endregion IterationTests

        [Test(Sequence=0x15)]
        internal void KeyInfoTest()
        {
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                this.droptables.Add("keyinfotest");
                cmd.CommandText = "Create table keyinfotest (id integer primary key, myuniquevalue integer unique not null, myvalue varchar(50))";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select * from keyinfotest";
                using (DbDataReader reader = cmd.ExecuteReader(CommandBehavior.KeyInfo | CommandBehavior.SchemaOnly))
                {
                    using (DataTable tbl = reader.GetSchemaTable())
                    {
                        if (tbl.Rows.Count != 3)
                        {
                            throw new Exception("Wrong number of columns returned");
                        }
                    }
                }
                cmd.CommandText = "SELECT MyValue FROM keyinfotest";
                using (DbDataReader reader = cmd.ExecuteReader(CommandBehavior.KeyInfo | CommandBehavior.SchemaOnly))
                {
                    using (DataTable tbl = reader.GetSchemaTable())
                    {
                        if (tbl.Rows.Count != 2)
                        {
                            throw new Exception("Wrong number of columns returned");
                        }
                    }
                }
                cmd.CommandText = "DROP TABLE keyinfotest";
                cmd.ExecuteNonQuery();
                this.droptables.Remove("keyinfotest");
                this.droptables.Add("keyinfotest");
                cmd.CommandText = "Create table keyinfotest (id char primary key, myuniquevalue integer unique not null, myvalue varchar(50))";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT MyValue FROM keyinfotest";
                using (DbDataReader reader = cmd.ExecuteReader(CommandBehavior.KeyInfo | CommandBehavior.SchemaOnly))
                {
                    using (DataTable tbl = reader.GetSchemaTable())
                    {
                        if (tbl.Rows.Count != 2)
                        {
                            throw new Exception("Wrong number of columns returned");
                        }
                    }
                }
                cmd.CommandText = "Select * from keyinfotest";
                using (DbDataReader reader = cmd.ExecuteReader(CommandBehavior.KeyInfo | CommandBehavior.SchemaOnly))
                {
                    using (DataTable tbl = reader.GetSchemaTable())
                    {
                        if (tbl.Rows.Count != 3)
                        {
                            throw new Exception("Wrong number of columns returned");
                        }
                    }
                }
                using (DbDataAdapter adp = base._fact.CreateDataAdapter())
                {
                    using (DbCommandBuilder builder = base._fact.CreateCommandBuilder())
                    {
                        adp.SelectCommand = cmd;
                        builder.DataAdapter = adp;
                        builder.ConflictOption = ConflictOption.OverwriteChanges;
                        using (DbCommand updatecmd = builder.GetUpdateCommand())
                        {
                            if (updatecmd.Parameters.Count != 4)
                            {
                                throw new Exception("Wrong number of parameters in update command!");
                            }
                        }
                    }
                }
            }
        }

        [Test]
        internal void LeakyCommands()
        {
            for (int n = 0; n < 0x186a0; n++)
            {
                DbCommand cmd = base._cnn.CreateCommand();
                cmd.CommandText = "SELECT * FROM sqlite_master";
                cmd.Prepare();
            }
            this.CheckLocked();
        }

        [Test(Sequence=40)]
        internal void LeakyDataReaders()
        {
            try
            {
                DbConnection newcnn = null;
                try
                {
                    for (int x = 0; x < 0x2710; x++)
                    {
                        if (newcnn == null)
                        {
                            newcnn = ((ICloneable) base._cnn).Clone() as DbConnection;
                        }
                        if (newcnn.State != ConnectionState.Open)
                        {
                            newcnn.Open();
                        }
                        DbCommand cmd = newcnn.CreateCommand();
                        cmd.CommandText = "SELECT * FROM TestCase";
                        DbDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        object obj1 = reader[0];
                        if ((x % 500) == 0)
                        {
                            newcnn.Close();
                            newcnn = null;
                        }
                    }
                }
                finally
                {
                    if (newcnn != null)
                    {
                        newcnn.Close();
                    }
                    newcnn = null;
                }
                this.CheckLocked();
            }
            catch (Exception)
            {
            }
        }

        [Test(Sequence=60)]
        internal void LockTest()
        {
            this.CheckSQLite();
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                cmd.CommandText = "SELECT Field6 FROM TestCase WHERE Field6 IS NOT NULL";
                byte[] b = new byte[0xfa0];
                using (DbDataReader rd = cmd.ExecuteReader())
                {
                    if (!rd.Read())
                    {
                        throw new Exception("No data to read!");
                    }
                    rd.GetBytes(0, 0L, b, 0, 0xfa0);
                    if (b[0] != 1)
                    {
                        throw new Exception("Binary value non-match byte 0");
                    }
                    if (b[100] != 2)
                    {
                        throw new Exception("Binary value non-match byte 100");
                    }
                    if (b[0x3e8] != 3)
                    {
                        throw new Exception("Binary value non-match byte 1000");
                    }
                    if (b[0x7d0] != 4)
                    {
                        throw new Exception("Binary value non-match byte 2000");
                    }
                    if (b[0xbb8] != 5)
                    {
                        throw new Exception("Binary value non-match byte 3000");
                    }
                    using (DbConnection clone = (DbConnection) ((ICloneable) base._cnn).Clone())
                    {
                        if (clone.State != ConnectionState.Open)
                        {
                            clone.Open();
                        }
                        using (DbCommand newcmd = clone.CreateCommand())
                        {
                            newcmd.CommandText = "DELETE FROM TestCase WHERE Field6 IS NULL";
                            newcmd.CommandTimeout = 2;
                            int cmdStart = Environment.TickCount;
                            try
                            {
                                newcmd.ExecuteNonQuery();
                                throw new ArgumentException("Should not have allowed an execute with an open reader");
                            }
                            catch (Exception e)
                            {
                                if (e is ArgumentException)
                                {
                                    throw new Exception(e.Message);
                                }
                                int cmdEnd = Environment.TickCount;
                                if (((cmdEnd - cmdStart) < 0x7d0) || ((cmdEnd - cmdStart) > 0xbb8))
                                {
                                    throw new Exception("Did not give up the lock at the right time!");
                                }
                            }
                        }
                    }
                }
            }
        }

        [Test(Sequence=0x27)]
        internal void MultipleFunctions()
        {
            this.CheckSQLite();
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                cmd.CommandText = "SELECT MYCOUNT(Field1), MYCOUNT(Field2) FROM TestCase";
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                }
            }
        }

        [Test]
        internal void MultiStepReaderTest()
        {
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                this.droptables.Add("stepreader");
                cmd.CommandText = "CREATE TABLE stepreader (id int primary key);INSERT INTO stepreader values(1);SELECT * FROM stepreader;UPDATE stepreader set id = id + 1;";
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        throw new Exception("Failed to read from the table");
                    }
                    if (reader.GetInt32(0) != 1)
                    {
                        throw new Exception(string.Format("Expected {0} got {1}", 1, reader.GetInt32(0)));
                    }
                }
                cmd.CommandText = "SELECT * FROM stepreader";
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        throw new Exception("Failed to read from the table");
                    }
                    if (reader.GetInt32(0) != 2)
                    {
                        throw new Exception(string.Format("Expected {0} got {1}", 2, reader.GetInt32(0)));
                    }
                }
            }
        }

        internal void MultithreadedTestThread(object obj)
        {
            MTTest test = obj as MTTest;
            if (test.cnn.State != ConnectionState.Open)
            {
                test.cnn.Open();
            }
            int start = Environment.TickCount;
            try
            {
                using (DbCommand cmd = test.cnn.CreateCommand())
                {
                    for (bool once = false; !once || ((Environment.TickCount - start) < 0x7d0); once = true)
                    {
                        using (DbTransaction trans = test.cnn.BeginTransaction())
                        {
                            cmd.CommandText = string.Format("SELECT * FROM MultiThreadedTest WHERE ThreadId = {0}", test.t.ManagedThreadId);
                            cmd.Transaction = trans;
                            using (DbDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    test.value += Convert.ToInt32(reader[2]);
                                }
                            }
                            cmd.CommandText = string.Format("INSERT INTO MultiThreadedTest(ThreadId, MyValue) VALUES({0}, {1})", test.t.ManagedThreadId, Environment.TickCount);
                            cmd.ExecuteNonQuery();
                            trans.Commit();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                test.e = e;
            }
            finally
            {
                test.ev.Set();
            }
        }

        [Test(Sequence=11)]
        internal void MultithreadingTest()
        {
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                this.droptables.Add("MultiThreadedTest");
                if (base._fact.GetType().Name.IndexOf("SQLite", StringComparison.OrdinalIgnoreCase) == -1)
                {
                    cmd.CommandText = "CREATE TABLE MultiThreadedTest(ID integer identity primary key, ThreadId integer, MyValue integer)";
                }
                else
                {
                    cmd.CommandText = "CREATE TABLE MultiThreadedTest(ID integer primary key, ThreadId integer, MyValue integer)";
                }
                cmd.ExecuteNonQuery();
            }
            ManualResetEvent[] events = new ManualResetEvent[8];
            MTTest[] arr = new MTTest[8];
            for (int n = 0; n < arr.Length; n++)
            {
                arr[n] = new MTTest();
                arr[n].t = new Thread(new ParameterizedThreadStart(this.MultithreadedTestThread));
                arr[n].t.IsBackground = true;
                arr[n].cnn = ((ICloneable) base._cnn).Clone() as DbConnection;
                arr[n].ev = events[n] = new ManualResetEvent(false);
                arr[n].t.Start(arr[n]);
            }
            WaitHandle.WaitAll(events, 0xea60);
            bool failed = false;
            Exception e = null;
            for (int n = 0; n < arr.Length; n++)
            {
                if (!arr[n].t.Join(0))
                {
                    failed = true;
                    arr[n].t.Abort();
                    arr[n].t.Join();
                }
                if (arr[n].e != null)
                {
                    e = arr[n].e;
                }
                arr[n].cnn.Dispose();
                arr[n].ev.Close();
            }
            if (failed)
            {
                throw new Exception("One or more threads deadlocked");
            }
            if (e != null)
            {
                throw e;
            }
        }

        public void OnLogEvent(object sender, LogEventArgs logEvent)
        {
            int errorCode = logEvent.ErrorCode;
            string message = logEvent.Message;
            this.logevents += 1L;
        }

        [Test]
        internal void ParameterizedInsert()
        {
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO TestCase(Field1, Field2, [Fi\x00ebld3], [Fi\x00e6ld4], Field5) VALUES(@p1,@p2,@p3,@p4,@p5)";
                DbParameter Field1 = cmd.CreateParameter();
                DbParameter Field2 = cmd.CreateParameter();
                DbParameter Field3 = cmd.CreateParameter();
                DbParameter Field4 = cmd.CreateParameter();
                DbParameter Field5 = cmd.CreateParameter();
                Field1.ParameterName = "@p1";
                Field2.ParameterName = "@p2";
                Field3.ParameterName = "@p3";
                Field4.ParameterName = "@p4";
                Field5.ParameterName = "@p5";
                Field1.Value = 2;
                Field2.Value = 3.14159;
                Field3.Value = "Param Field3";
                Field4.Value = "Field4 Par";
                Field5.Value = DateTime.Now;
                cmd.Parameters.Add(Field1);
                cmd.Parameters.Add(Field2);
                cmd.Parameters.Add(Field3);
                cmd.Parameters.Add(Field4);
                cmd.Parameters.Add(Field5);
                cmd.ExecuteNonQuery();
            }
        }

        [Test]
        internal void ParameterizedInsertMissingParams()
        {
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO TestCase(Field1, Field2, [Fi\x00ebld3], [Fi\x00e6ld4], Field5) VALUES(@p1,@p2,@p3,@p4,@p5)";
                DbParameter Field1 = cmd.CreateParameter();
                DbParameter Field2 = cmd.CreateParameter();
                DbParameter Field3 = cmd.CreateParameter();
                DbParameter Field4 = cmd.CreateParameter();
                DbParameter Field5 = cmd.CreateParameter();
                Field1.ParameterName = "@p1";
                Field2.ParameterName = "@p2";
                Field3.ParameterName = "@p3";
                Field4.ParameterName = "@p4";
                Field5.ParameterName = "@p5";
                Field1.DbType = DbType.Int32;
                Field1.Value = 2;
                Field2.Value = 3.14159;
                Field3.Value = "Field3 Param";
                Field4.Value = "Field4 Par";
                Field5.Value = DateTime.Now;
                cmd.Parameters.Add(Field1);
                cmd.Parameters.Add(Field2);
                cmd.Parameters.Add(Field3);
                cmd.Parameters.Add(Field4);
                try
                {
                    cmd.ExecuteNonQuery();
                    throw new Exception("Executed with a missing parameter");
                }
                catch (Exception)
                {
                }
            }
        }

        internal void ParseTest()
        {
            base._cnn.GetSchema("ViewColumns");
            base._cnn.GetSchema("Views");
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                cmd.Parameters.Add(cmd.CreateParameter());
                cmd.Parameters[0].Value = 1;
                cmd.Parameters.Add(cmd.CreateParameter());
                cmd.Parameters[1].Value = 1;
                cmd.CommandText = "select * from sqlite_master limit ? offset ?";
                cmd.ExecuteScalar();
                cmd.CommandText = "\r\nCREATE TEMP TABLE A(ID INTEGER, BID INTEGER);CREATE TEMP TABLE B(ID INTEGER, MYVAL VARCHAR);\r\nINSERT INTO A (ID, BID) VALUES(2, 1);\r\nINSERT INTO B (ID, MYVAL) VALUES(1,'TEST');\r\n";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select *, (select 1 as c from b where b.id = a.bid) from a;";
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                }
                cmd.CommandText = "select a.id as aa from a where (select 1 from (select 1 where 1 = aa));";
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                }
                cmd.CommandText = "select *, (select count(c) from (select 1 as c from b where b.id = a.bid)) from a;";
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                }
            }
        }

        [Test]
        internal void PoolingWithStealthTransactionTest()
        {
            object value;
            if (!base._cnnstring.TryGetValue("Pooling", out value))
            {
                throw new Exception("Pooling not present in connection string");
            }
            if (!((bool) value))
            {
                throw new InconclusiveException("Pooling not enabled in the connection string");
            }
            this.maydroptable.Add("PoolTest");
            for (int n = 0; n < 100; n++)
            {
                using (DbConnection newcnn = ((ICloneable) base._cnn).Clone() as DbConnection)
                {
                    if (newcnn.State != ConnectionState.Open)
                    {
                        newcnn.Open();
                    }
                    using (DbCommand cmd = newcnn.CreateCommand())
                    {
                        cmd.CommandText = "BEGIN TRANSACTION";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "CREATE TABLE PoolTest(ID int primary key)";
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        [Test]
        internal void PoolingWithTransactionTest()
        {
            object value;
            if (!base._cnnstring.TryGetValue("Pooling", out value))
            {
                throw new Exception("Pooling not present in connection string");
            }
            if (!((bool) value))
            {
                throw new InconclusiveException("Pooling not enabled in the connection string");
            }
            this.maydroptable.Add("PoolTest");
            for (int n = 0; n < 100; n++)
            {
                using (DbConnection newcnn = ((ICloneable) base._cnn).Clone() as DbConnection)
                {
                    if (newcnn.State != ConnectionState.Open)
                    {
                        newcnn.Open();
                    }
                    DbTransaction trans = newcnn.BeginTransaction();
                    using (DbCommand cmd = newcnn.CreateCommand())
                    {
                        cmd.Transaction = trans;
                        cmd.CommandText = "CREATE TABLE PoolTest(ID int primary key)";
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        [Test]
        internal void PrepareTest()
        {
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                this.droptables.Add("nonexistent");
                cmd.CommandText = "CREATE TABLE nonexistent(id int primary key);SELECT id FROM nonexistent UNION SELECT 1";
                cmd.Prepare();
                object ob = cmd.ExecuteScalar();
                if ((ob == null) || (ob == DBNull.Value))
                {
                    throw new Exception("Multiple statements may not be supported");
                }
                if (Convert.ToInt32(ob) != 1)
                {
                    throw new Exception(string.Format("Expected {0} got {1}", 1, ob));
                }
            }
        }

        [Test]
        internal void ReadOnlyTest()
        {
            object value;
            string RO_connectionString = base._cnnstring.ConnectionString;
            if (!base._cnnstring.TryGetValue("Read Only", out value))
            {
                throw new Exception("Read Only not supported by connection string");
            }
            if (!((bool) value))
            {
                RO_connectionString = RO_connectionString + ";Read Only=true";
            }
            this.maydroptable.Add("ReadOnlyTest");
            using (DbConnection newcnn = ((ICloneable) base._cnn).Clone() as DbConnection)
            {
                if (newcnn.State == ConnectionState.Open)
                {
                    newcnn.Close();
                }
                newcnn.ConnectionString = RO_connectionString;
                newcnn.Open();
                newcnn.Dispose();
            }
        }

        [Test(Sequence=0x62)]
        internal void ScalarPreTest()
        {
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                this.droptables.Add("SCALARTEST");
                cmd.CommandText = "CREATE TABLE SCALARTEST(x INTEGER PRIMARY KEY, y)";
                cmd.ExecuteNonQuery();
                for (int i = 1; i <= 0x3e8; i++)
                {
                    DbParameter param1 = cmd.CreateParameter();
                    param1.ParameterName = "param1";
                    param1.DbType = DbType.Int32;
                    param1.Value = i;
                    DbParameter param2 = cmd.CreateParameter();
                    param2.ParameterName = "param2";
                    param2.DbType = DbType.Int32;
                    param2.Value = i;
                    cmd.CommandText = "INSERT OR REPLACE INTO SCALARTEST(x, y) VALUES(?, ?)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(param1);
                    cmd.Parameters.Add(param2);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        [Test(Sequence=0x63)]
        internal void ScalarTest()
        {
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                cmd.CommandText = "SELECT x FROM SCALARTEST ORDER BY x";
                cmd.ExecuteScalar();
            }
        }

        [Test]
        internal void SetLogCallbackTest()
        {
            if (base._fact.GetType().Name.IndexOf("SQLite", StringComparison.OrdinalIgnoreCase) > -1)
            {
                SQLiteConnection cnn = new SQLiteConnection(base._cnnstring.ConnectionString);
                SQLiteLogEventHandler logHandler = new SQLiteLogEventHandler(this.OnLogEvent);
                SQLiteFactory sqlite_fact = (SQLiteFactory) base._fact;
                sqlite_fact.Log += logHandler;
                cnn.Open();
                this.logevents = 0L;
                cnn.LogMessage(1, "test log event");
                if (this.logevents != 1L)
                {
                    throw new Exception(string.Format("Log event count {0} incorrect.", this.logevents));
                }
                cnn.Close();
                sqlite_fact.Log -= logHandler;
            }
        }

        internal void TimeoutTest()
        {
            this.CheckSQLite();
            using (DbCommand cmdRead = base._cnn.CreateCommand())
            {
                cmdRead.CommandText = "SELECT ID FROM TestCase";
                using (cmdRead.ExecuteReader())
                {
                    using (DbCommand cmdwrite = base._cnn.CreateCommand())
                    {
                        cmdwrite.CommandText = "UPDATE [KeyInfoTest] SET [ID] = [ID]";
                        cmdwrite.CommandTimeout = 5;
                        int dwtick = Environment.TickCount;
                        try
                        {
                            cmdwrite.ExecuteNonQuery();
                        }
                        catch (Exception)
                        {
                            dwtick = (Environment.TickCount - dwtick) / 0x3e8;
                            if ((dwtick < 5) || (dwtick > 6))
                            {
                                throw new Exception("Timeout didn't wait long enough!");
                            }
                            return;
                        }
                        throw new Exception("Operation should have failed but completed successfully");
                    }
                }
            }
        }

        [Test(Sequence=0x29)]
        internal void TransactionScopeTest()
        {
            using (new TransactionScope())
            {
                using (DbConnection cnn2 = ((ICloneable) base._cnn).Clone() as DbConnection)
                {
                    if (cnn2.State != ConnectionState.Open)
                    {
                        cnn2.Open();
                    }
                    using (DbCommand cmd = cnn2.CreateCommand())
                    {
                        cmd.CommandText = "CREATE TABLE VolatileTable (ID INTEGER PRIMARY KEY, MyValue VARCHAR(50))";
                        cmd.ExecuteNonQuery();
                        this.maydroptable.Add("VolatileTable");
                        using (DbCommand cmd2 = cnn2.CreateCommand())
                        {
                            using (cmd2.Transaction = cnn2.BeginTransaction())
                            {
                                cmd2.CommandText = "INSERT INTO VolatileTable (ID, MyValue) VALUES(1, 'Hello')";
                                cmd2.ExecuteNonQuery();
                                cmd2.Transaction.Commit();
                            }
                        }
                    }
                }
            }
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                cmd.CommandText = "SELECT COUNT(*) FROM VolatileTable";
                try
                {
                    cmd.ExecuteScalar();
                    cmd.CommandText = "DROP TABLE VolatileTable";
                    cmd.ExecuteNonQuery();
                    throw new InvalidOperationException("Transaction failed! The table exists!");
                }
                catch (Exception e)
                {
                    if (e is InvalidOperationException)
                    {
                        throw new Exception(e.Message);
                    }
                }
            }
        }

        [Test]
        internal string UserAggregate()
        {
            this.CheckSQLite();
            StringBuilder builder = new StringBuilder();
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                int n = 0;
                cmd.CommandText = "SELECT MyCount(*) FROM TestCase";
                int nCount = 0;
                int dtStart = Environment.TickCount;
                while ((Environment.TickCount - dtStart) < 0x3e8)
                {
                    n = Convert.ToInt32(cmd.ExecuteScalar());
                    nCount++;
                }
                if (n != 0x1d4c3)
                {
                    throw new Exception("Unexpected count");
                }
                builder.Append(string.Format("UserAggregate executed {0} times in 1 second.", nCount));
            }
            return builder.ToString();
        }

        [Test]
        internal void UserCollation()
        {
            this.CheckSQLite();
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                cmd.CommandText = "SELECT [Fi\x00ebld3] FROM TestCase ORDER BY [Fi\x00ebld3] COLLATE MYSEQUENCE DESC";
                string s = (string) cmd.ExecuteScalar();
                if (s != "Fi\x00ebld3")
                {
                    throw new Exception("MySequence didn't sort properly");
                }
            }
        }

        #region UserFunctions
        [Test]
        internal string UserFunction1()
        {
            this.CheckSQLite();
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                int nTimes = 0;
                cmd.CommandText = "SELECT Foo('ee','foo')";
                int dtStart = Environment.TickCount;
                while ((Environment.TickCount - dtStart) < 0x3e8)
                {
                    cmd.ExecuteNonQuery();
                    nTimes++;
                }
                return string.Format("User (text) command executed {0} times in 1 second.", nTimes);
            }
        }

        [Test]
        internal string UserFunction2()
        {
            this.CheckSQLite();
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                int nTimes = 0;
                cmd.CommandText = "SELECT Foo(10,11)";
                int dtStart = Environment.TickCount;
                while ((Environment.TickCount - dtStart) < 0x3e8)
                {
                    cmd.ExecuteNonQuery();
                    nTimes++;
                }
                return string.Format("UserFunction command executed {0} times in 1 second.", nTimes);
            }
        }

        [Test]
        internal string UserFunction3()
        {
            this.CheckSQLite();
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                int nTimes = 0;
                cmd.CommandText = "SELECT ABS(1)";
                int dtStart = Environment.TickCount;
                while ((Environment.TickCount - dtStart) < 0x3e8)
                {
                    cmd.ExecuteNonQuery();
                    nTimes++;
                }
                return string.Format("Intrinsic command executed {0} times in 1 second.", nTimes);
            }
        }

        [Test]
        internal string UserFunction4()
        {
            this.CheckSQLite();
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                int nTimes = 0;
                cmd.CommandText = "SELECT lower('FOO')";
                int dtStart = Environment.TickCount;
                while ((Environment.TickCount - dtStart) < 0x3e8)
                {
                    cmd.ExecuteNonQuery();
                    nTimes++;
                }
                return string.Format("Intrin (txt) command executed {0} times in 1 second.", nTimes);
            }
        }

        [Test]
        internal string UserFunction5()
        {
            this.CheckSQLite();
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                int nTimes = 0;
                cmd.CommandText = "SELECT 1";
                int dtStart = Environment.TickCount;
                while ((Environment.TickCount - dtStart) < 0x3e8)
                {
                    cmd.ExecuteNonQuery();
                    nTimes++;
                }
                return string.Format("Raw Value command executed {0} times in 1 second.", nTimes);
            }
        }
        #endregion UserFunctions

        [Test(Sequence=0x2a)]
        internal void VerifyBinaryData()
        {
            this.BinaryInsert();
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                cmd.CommandText = "SELECT Field6 FROM TestCase WHERE Field6 IS NOT NULL";
                byte[] b = new byte[0xfa0];
                using (DbDataReader rd = cmd.ExecuteReader())
                {
                    if (!rd.Read())
                    {
                        throw new Exception("No data to read!");
                    }
                    if (rd.GetBytes(0, 0L, null, 0, 0) != 0xfa0L)
                    {
                        throw new Exception("Invalid byte length!");
                    }
                    rd.GetBytes(0, 0L, b, 0, 0xfa0);
                    if (b[0] != 1)
                    {
                        throw new Exception("Binary value non-match byte 0");
                    }
                    if (b[100] != 2)
                    {
                        throw new Exception("Binary value non-match byte 100");
                    }
                    if (b[0x3e8] != 3)
                    {
                        throw new Exception("Binary value non-match byte 1000");
                    }
                    if (b[0x7d0] != 4)
                    {
                        throw new Exception("Binary value non-match byte 2000");
                    }
                    if (b[0xbb8] != 5)
                    {
                        throw new Exception("Binary value non-match byte 3000");
                    }
                }
            }
        }

        [Test(Sequence=30)]
        internal void VerifyInsert()
        {
            using (DbCommand cmd = base._cnn.CreateCommand())
            {
                cmd.CommandText = "SELECT Field1, Field2, [Fi\x00ebld3], [Fi\x00e6ld4], Field5 FROM TestCase";
                cmd.Prepare();
                using (DbDataReader rd = cmd.ExecuteReader())
                {
                    if (!rd.Read())
                    {
                        throw new Exception("No data in table");
                    }
                    int Field1 = rd.GetInt32(0);
                    double Field2 = rd.GetDouble(1);
                    string Field3 = rd.GetString(2);
                    string Field4 = rd.GetString(3).TrimEnd(new char[0]);
                    DateTime Field5 = rd.GetDateTime(4);
                    if (Field1 != 1)
                    {
                        throw new Exception(string.Format("Field1 {0} did not match {1}", Field1, 1));
                    }
                    if (Field2 != 3.14159)
                    {
                        throw new Exception(string.Format("Field2 {0} did not match {1}", Field2, 3.14159));
                    }
                    if (Field3 != "Fi\x00ebld3")
                    {
                        throw new Exception(string.Format("Field3 {0} did not match {1}", Field3, "Fi\x00ebld3"));
                    }
                    if (Field4 != "Fi\x00e6ld4")
                    {
                        throw new Exception(string.Format("Field4 {0} did not match {1}", Field4, "Fi\x00e6ld4"));
                    }
                    if (Field5.CompareTo(DateTime.Parse("2005-01-01 13:49:00")) != 0)
                    {
                        throw new Exception(string.Format("Field5 {0} did not match {1}", Field4, DateTime.Parse("2005-01-01 13:49:00")));
                    }
                    if (rd.GetName(0) != "Field1")
                    {
                        throw new Exception("Non-Match column name Field1");
                    }
                    if (rd.GetName(1) != "Field2")
                    {
                        throw new Exception("Non-Match column name Field2");
                    }
                    if (rd.GetName(2) != "Fi\x00ebld3")
                    {
                        throw new Exception("Non-Match column name Field3");
                    }
                    if (rd.GetName(3) != "Fi\x00e6ld4")
                    {
                        throw new Exception("Non-Match column name Field4");
                    }
                    if (rd.GetName(4) != "Field5")
                    {
                        throw new Exception("Non-Match column name Field5");
                    }
                }
            }
        }

        [Test(Sequence=1)]
        internal string VersionTest()
        {
            this.CheckSQLite();
            string[] version = base._cnn.ServerVersion.Split(new char[] { '.' });
            if (((Convert.ToInt32(version[0]) < 3) || ((Convert.ToInt32(version[0]) == 3) && (Convert.ToInt32(version[1]) < 6))) || (((Convert.ToInt32(version[0]) == 3) && (Convert.ToInt32(version[1]) == 6)) && (Convert.ToInt32(version[2]) < 1)))
            {
                throw new Exception(string.Format("SQLite Engine is {0}.  Minimum supported version is 3.6.1", base._cnn.ServerVersion));
            }
            return string.Format("SQLite Engine is {0}", base._cnn.ServerVersion);
        }

        internal class MTTest
        {
            internal DbConnection cnn;
            internal Exception e;
            internal ManualResetEvent ev;
            internal Thread t;
            internal int value;
        }
    }
}

