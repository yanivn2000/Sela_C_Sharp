using System;

namespace classes_calc
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Calc calc = new Calc();
            int num1 = 5, num2 = 8;
            int result = calc.Add(num1, num2);
            Console.WriteLine($"The result of {num1} + {num2} is {result}");
        }
    }

    class Calc
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

    }
}
