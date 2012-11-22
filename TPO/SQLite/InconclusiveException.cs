namespace test
{
    using System;

    internal class InconclusiveException : Exception
    {
        internal InconclusiveException()
        {
        }

        internal InconclusiveException(string message) : base(message)
        {
        }
    }
}

