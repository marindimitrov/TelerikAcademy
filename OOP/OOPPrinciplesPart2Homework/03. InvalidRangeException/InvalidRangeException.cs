using System;
using System.Linq;

namespace InvalidRangeExceptions
{
    class InvalidRangeException<T> : ApplicationException
    {
        public T MinValue { get; set; }
        public T MaxValue { get; set; }

        public InvalidRangeException(string message, T min, T max)
        {
            this.MinValue = min;
            this.MaxValue = max;
        }
    }
}