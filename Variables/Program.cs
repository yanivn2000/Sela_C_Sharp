using System;

namespace Variables
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int myAge = 16;

            bool result = myAge > 18;

            Console.WriteLine($"Your age is greater than 18: {result}");


            Console.WriteLine();

            int num = -128;
            byte x = (byte)num;


            /*
             *
            int number2;
            double result;
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            string welcomeMessage = $"Welcome {name} to our magnificent calculator";
            Console.WriteLine(welcomeMessage);


            Console.WriteLine("Please enter the first number:");
            //value = Console.ReadLine();
            number1 = int.Parse(Console.ReadLine());
            //dog
            Console.WriteLine("Please enter the second number:");
            //value = Console.ReadLine();
            number2 = int.Parse(Console.ReadLine());

            //add the 2 numbers
            result = number2 + number1;
            Console.WriteLine($"The result of {number2} + {number1} = {result}");
            //deduct the 2 numbers
            result = number2 - number1;
            Console.WriteLine($"The result of {number2} - {number1} = {result}");
            result = number2 * number1;
            Console.WriteLine($"The result of {number2} * {number1} = {result}");
            result = number2 / (double)number1;
            Console.WriteLine($"The result of {number2} / {number1} = {result}");
            result = number2 % number1;
            Console.WriteLine($"The result of {number2} % {number1} = {result}");
            result = (number2 + number1) / 2.0;
            Console.WriteLine($"Average result of {number2} and {number1} = {result}");
             */

        }
    }
}
