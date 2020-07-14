using System;

namespace Variables
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //calculator
            //int number1, number2, IAsyncResult;
            int number1 = 51;
            int number2 = 603;
            double result;

            result = number2 + number1;
            Console.WriteLine($"Hello the result of {number2} + {number1} = {result}");
            result = number2 - number1;
            Console.WriteLine($"Hello the result of {number2} - {number1} = {result}");
            result = number2 * number1;
            Console.WriteLine($"Hello the result of {number2} * {number1} = {result}");
            result = number2 / (double)number1;
            Console.WriteLine($"Hello the result of {number2} / {number1} = {result}");




        }
    }
}
