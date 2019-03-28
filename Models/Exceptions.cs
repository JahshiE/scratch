using System;

namespace Scratch.Exceptions
{
    public class DivideByZeroException : Exception
    {
        public DivideByZeroException(string message) : base(message)
        {
        }
    }
}

