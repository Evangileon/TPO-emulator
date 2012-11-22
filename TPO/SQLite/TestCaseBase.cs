namespace test
{
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    internal abstract class TestCaseBase
    {
        protected DbConnection _cnn;
        protected DbConnectionStringBuilder _cnnstring;
        protected DbProviderFactory _fact;
        protected Dictionary<string, bool> _tests;

        public event EventHandler OnAllTestsDone;

        public event TestCompletedEvent OnTestFinished;

        public event TestStartingEvent OnTestStarting;

        protected TestCaseBase()
        {
            this._tests = new Dictionary<string, bool>();
            SortedList<TestAttribute, MethodInfo> items = new SortedList<TestAttribute, MethodInfo>();
            foreach (MethodInfo mi in base.GetType().GetMethods(BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                object[] att = mi.GetCustomAttributes(typeof(TestAttribute), false);
                if (att.Length == 1)
                {
                    items.Add((TestAttribute) att[0], mi);
                }
            }
            foreach (KeyValuePair<TestAttribute, MethodInfo> pair in items)
            {
                this._tests.Add(pair.Value.Name, true);
            }
        }

        protected TestCaseBase(DbProviderFactory factory, string connectionString)
        {
            this._tests = new Dictionary<string, bool>();
            this._fact = factory;
            this._cnn = this._fact.CreateConnection();
            this._cnn.ConnectionString = connectionString;
            this._cnnstring = this._fact.CreateConnectionStringBuilder();
            this._cnnstring.ConnectionString = connectionString;
            this._cnn.Open();
        }

        internal void Run()
        {
            SortedList<TestAttribute, MethodInfo> items = new SortedList<TestAttribute, MethodInfo>();
            foreach (MethodInfo mi in base.GetType().GetMethods(BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                object[] att = mi.GetCustomAttributes(typeof(TestAttribute), false);
                if ((att.Length == 1) && this._tests[mi.Name])
                {
                    items.Add((TestAttribute) att[0], mi);
                }
            }
            foreach (KeyValuePair<TestAttribute, MethodInfo> pair in items)
            {
                if (this.OnTestStarting != null)
                {
                    this.OnTestStarting(this, new TestEventArgs(pair.Value.Name, TestResultEnum.Inconclusive, 0, null, null));
                }
                int start = Environment.TickCount;
                try
                {
                    object obj = pair.Value.Invoke(this, null);
                    int duration = Environment.TickCount - start;
                    if (this.OnTestFinished != null)
                    {
                        this.OnTestFinished(this, new TestEventArgs(pair.Value.Name, TestResultEnum.Succeeded, duration, null, (obj is string) ? ((string) obj) : string.Empty));
                    }
                }
                catch (Exception e)
                {
                    int duration = Environment.TickCount - start;
                    Exception inner = e.InnerException;
                    if (this.OnTestFinished != null)
                    {
                        if (inner is InconclusiveException)
                        {
                            this.OnTestFinished(this, new TestEventArgs(pair.Value.Name, TestResultEnum.Inconclusive, duration, null, inner.Message));
                        }
                        else
                        {
                            this.OnTestFinished(this, new TestEventArgs(pair.Value.Name, TestResultEnum.Failed, duration, inner, null));
                        }
                    }
                }
            }
            if (this.OnAllTestsDone != null)
            {
                this.OnAllTestsDone(this, EventArgs.Empty);
            }
        }

        internal Dictionary<string, bool> Tests
        {
            get
            {
                return this._tests;
            }
            set
            {
                this._tests = value;
            }
        }
    }
}

