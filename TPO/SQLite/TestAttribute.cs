namespace test
{
    using System;

    [AttributeUsage(AttributeTargets.Method, Inherited=false, AllowMultiple=false)]
    public sealed class TestAttribute : Attribute, IComparable<TestAttribute>
    {
        private int _sequence = _start;
        private static int _start = 0xffff;

        public TestAttribute()
        {
            _start++;
        }

        public int CompareTo(TestAttribute other)
        {
            return this._sequence.CompareTo(other._sequence);
        }

        public int Sequence
        {
            get
            {
                return this._sequence;
            }
            set
            {
                this._sequence = value;
            }
        }
    }
}

