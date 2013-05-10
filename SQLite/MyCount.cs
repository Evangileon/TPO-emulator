namespace test
{
    using System;
    using System.Data.SQLite;

    [SQLiteFunction(Name="MyCount", Arguments=-1, FuncType=FunctionType.Aggregate)]
    internal class MyCount : SQLiteFunction
    {
        public override object Final(object contextData)
        {
            return contextData;
        }

        public override void Step(object[] args, int nStep, ref object contextData)
        {
            if (contextData == null)
            {
                contextData = 1;
            }
            else
            {
                contextData = ((int) contextData) + 1;
            }
        }
    }
}

