using System;

namespace scratch
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("My example of creating a user defined exception:\n");

            var myNumber = new DivideByZero();

            try
            {
                myNumber.isNotZero();
            }
            catch (DivideByZeroException e)
            {
                System.Console.WriteLine($"DivideByZeroException: {e.Message}");
            }
        }
    }
}

public class DivideByZeroException : Exception
{
    public DivideByZeroException(string message) : base(message)
    {
    }
}

public class DivideByZero
{
    int number = 0;

    public void isNotZero() {
        if (number == 0)
        {
            throw (new DivideByZeroException("Number was zero! Can't divide."));
        }
        else
        {
            System.Console.WriteLine($"Number: {number}");
        }
    }
}
