namespace test
{
    using System;

    internal class TestEventArgs : EventArgs
    {
        public readonly int Duration;
        public readonly System.Exception Exception;
        public readonly string Message;
        public readonly TestResultEnum Result;
        public readonly string TestName;

        internal TestEventArgs(string testName, TestResultEnum success, int duration, System.Exception e, string message)
        {
            this.TestName = testName;
            this.Result = success;
            this.Exception = e;
            this.Message = message;
            this.Duration = duration;
        }
    }
}

