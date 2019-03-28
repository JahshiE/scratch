using System;

namespace Scratch
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("My example of creating a user defined exception:\n");

            var lowerLimit = 5;
            var upperLimit = 12;

            System.Console.Write($"Give me a number between {lowerLimit} and {upperLimit}: ");
            
            var input = Console.ReadLine();
            
            System.Console.WriteLine($"You have given me {input}");
            
            var myNumber = new Number(Convert.ToInt32(input));

            try
            {
                myNumber.canBeDivided();
            }
            catch (Exception e)
            {
                System.Console.WriteLine($"DivideByZeroException: {e.Message}");
            }
        }
    }
}