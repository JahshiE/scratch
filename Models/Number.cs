using Scratch.Exceptions;

namespace Scratch
{
    public class Number
    {
        private int _value;

        public Number(int value)
        {
            _value = value;
        }

        public void canBeDivided() {
            if (_value == 0)
            {
                throw (new DivideByZeroException("Number was zero! Can't divide."));
            }
            else
            {
                System.Console.WriteLine($"Yes, {_value} can be divided because it is not zero.");
            }
        }
    }
}