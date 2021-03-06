﻿using System;
using Scratch.Exceptions;

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

            try
            {
                var myNumber = new Number(Convert.ToInt32(input));
                myNumber.canBeDivided();
                myNumber.isWithinLimits();
            }
            catch (IsZeroException e)
            {
                System.Console.WriteLine($"IsZeroException: {e}");
            }
            catch (FormatException e)
            {
                System.Console.WriteLine($"Format Exception: {e}");
            }
        }
    }
}