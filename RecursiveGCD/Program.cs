using System;

namespace RecursiveGCD
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int g = gcd(16, 25);
            Console.WriteLine($"Greatest common divider is {g}");
        }
        static int gcd(int n1, int n2)
        {
            if (n2 == 0)//when we find divider
            {
                return n1;
            }
            else
            {
                return gcd(n2, n1 % n2);
            }
        }
        public static int findBiggestDivideOfTwoNumbers(int firstNum, int secondNum)        {            if (firstNum == secondNum) return firstNum;            int max = Math.Max(firstNum, secondNum);            int min = Math.Min(firstNum, secondNum);            return findBiggestDivideOfTwoNumbers(max - min, min);        }
    }

}
