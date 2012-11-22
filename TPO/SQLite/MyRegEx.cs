namespace test
{
    using System;
    using System.Data.SQLite;
    using System.Text.RegularExpressions;

    [SQLiteFunction(Name="REGEXP", Arguments=2, FuncType=FunctionType.Scalar)]
    internal class MyRegEx : SQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            return Regex.IsMatch(Convert.ToString(args[1]), Convert.ToString(args[0]));
        }
    }
}

