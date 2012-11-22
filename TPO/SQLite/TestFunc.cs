namespace test
{
    using System;
    using System.Data.SQLite;

    [SQLiteFunction(Name="TestFunc", Arguments=2, FuncType=FunctionType.Scalar), SQLiteFunction(Name="Foo", Arguments=2, FuncType=FunctionType.Scalar)]
    internal class TestFunc : SQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            if (args[0].GetType() != typeof(int))
            {
                return args[0];
            }
            int Param1 = Convert.ToInt32(args[0]);
            int Param2 = Convert.ToInt32(args[1]);
            return (Param1 + Param2);
        }
    }
}

