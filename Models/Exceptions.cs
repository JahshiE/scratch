using System;

namespace Scratch.Exceptions
{
    public class IsZeroException : Exception
    {
        public IsZeroException(string message) : base(message)
        {
        }
    }
}

