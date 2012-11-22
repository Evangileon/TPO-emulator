namespace test
{
    using System;
    using System.Data.SQLite;

    [SQLiteFunction(Name="CASETEST", Arguments=2, FuncType=FunctionType.Scalar)]
    internal class CaseTestFunc : SQLiteFunctionEx
    {
        public override object Invoke(object[] args)
        {
            return base.GetCollationSequence().Compare(args[0].ToString(), args[1].ToString());
        }
    }
}

