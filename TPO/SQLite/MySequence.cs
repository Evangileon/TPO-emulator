namespace test
{
    using System;
    using System.Data.SQLite;

    [SQLiteFunction(Name="MYSEQUENCE", FuncType=FunctionType.Collation)]
    internal class MySequence : SQLiteFunction
    {
        public override int Compare(string param1, string param2)
        {
            if (param1 == "Fi\x00ebld3")
            {
                return 1;
            }
            if (param2 == "Fi\x00ebld3")
            {
                return -1;
            }
            return string.Compare(param1, param2, true);
        }
    }
}

