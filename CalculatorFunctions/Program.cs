using System;

namespace CalculatorFunctions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello calculator!");
            PrintWelcomeMessage();
            while (true)
            {
                Random rand = new Random();
                Console.WriteLine("Please enter a number 1:");
                double number1 = ReadNumber();
                Console.WriteLine("Please enter a number 2:");
                double number2 = ReadNumber();
                //double result = Operator();
                //Console.WriteLine($"The result is {result}");
            }
        }
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("This is the new calculator");
            Console.WriteLine("We love to calculat things");
            Console.WriteLine("No..we don't");
            Console.WriteLine("but anyway we will do it:");
        }
        public static double ReadNumber()
        {
            double number;
            do
            {
            } while (!double.TryParse(Console.ReadLine(), out number));
            return number;
        }
        public static double Operator(double number1, double number2)
        {
            Console.Write("Please enter an opeartor (+, -, *, /):");
            string operator1 = Console.ReadLine();
            double result = 0;
            switch (operator1)
            {
                case "+":
                    {
                        result = number1 + number2;
                        break;
                    }
            }
            return result;
        }
        /*
        double add(double num1, double num2);
        double subtraction(double num1, double num2);
        void PrintResult();
        */
    }
}
