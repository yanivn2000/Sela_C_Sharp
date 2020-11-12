using System;

namespace Module8Loops
{
    class MainClass
    {

        //Roy questions
        //Q3
        //122 -> 2 == 2 and the number is even
        //388 -> 8 == 8 and the number is even
        public static void question3(int min, int max)
        {
            for (int i = min; i <= max; i++)
            {
                if ((i % 10) == (i / 10 % 10))
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void Average()
        {

            int number1 = ReadNumber("Please enter a score 1", "Invalid score");
            int number2 = ReadNumber("Please enter a score 2", "Invalid score");
            Console.WriteLine($"The average of {number1} and {number2} is {(number1 + number2) / 2F}");
        }
        //request_info - this is the request text for the user
        //error - this will be printed as error to the user in case the user insert a NON number
        private static int ReadNumber(string request_info, string error)
        {

            string val;
            int num;
            bool isNumber = true;
            do
            {
                if (isNumber == false)
                    Console.WriteLine(error);

                Console.Write(request_info + ": ");
                val = Console.ReadLine();
                if (val == "q")
                {
                    num = 0;
                    break;
                }
                isNumber = int.TryParse(val, out num);
            } while (isNumber == false);

            Console.WriteLine("read ended");
            return num;
            /*
            Console.Write(request_info + ": ");
            string val = Console.ReadLine();
            int num;
            while (int.TryParse(val, out num) == false)
            {
                Console.WriteLine(error);
                Console.Write(request_info + ": ");
                val = Console.ReadLine();
            }
            return num;
            */
        }

        private static void PrintLoop(int numOfLoop)
        {
            for (int i = 0; i < numOfLoop; i++)
            {
                Console.WriteLine($"number: {i}");
            }
        }

        //len = the lenght of the series
        public static void FibonacciVer2(int len)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < len; i++)
            {
                int c = a + b;
                Console.Write($"{a} ");
                a = b;
                b = c;
            }
        }


        public static void Fibonacci(int len)
        {
            int a = 0, b = 1, c = 0;
            if (len >= 1)
                Console.Write($"{a}");
            if (len >= 2)
                Console.Write($" {b}");
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write($" {c}");
                a = b;
                b = c;
            }
        }


        public static void sqrt()
        {
            int num = 0;
            int max = 5;
            Console.WriteLine("I will print the square root of 5 numbers");
            Console.WriteLine("(enter 0 to exit)\n");


            //for (int i = 0; i < max; i++)


            while (true)
            {
                num = 0;
                Console.WriteLine("Enter the next number => ");
                int.TryParse(Console.ReadLine(), out num);
                if (num == 0)
                    break;
                if (num > 10)
                    continue;
                Console.WriteLine(Math.Sqrt(num));
            }

        }

        public static void NestingLoops()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j);
                    Console.Write("\t");
                }
                Console.WriteLine("");
            }

        }

        /*
        ****
        ****
        ****
        */
        public static void PrintSqrLab12_1(int rows, int cols)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }
        /*
        *
        **
        ***
        ****
        *****
        */
        public static void PrintSqrLab12_2(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }

        /*
        *****
        ****
        ***
        **
        *
        */
        public static void PrintSqrLab12_3(int rows)
        {
            for (int i = rows; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }

        public static int ConclusionLabs01(int number, int dividing)
        {
            int count = 0;
            do
            {
                if (number % dividing != 0)
                    break;
                else
                {
                    count++;
                    number /= dividing;
                }
            } while (true);
            return count;
        }

        public static void ConclusionLabs07()
        {
            int number = 0;

            //initialize 4 variales with int.MaxValue
            int min1 = int.MaxValue, min2 = int.MaxValue, min3 = int.MaxValue, min4 = int.MaxValue;

            //init the max value
            int MaxValue = int.MaxValue;

            //Read a sequence of positive numbers, until the number -1
            while (true)
            {
                int newNumber = ReadNumber("Please enter a positive number (or -1 to quit)", "Invalid number");
                if (newNumber == -1)
                    break;

                //Check if the new value is smaller than the max value
                if (newNumber < MaxValue)
                {
                    //replace the variable that hold the max value with the new value
                    if (MaxValue == min1)
                        min1 = newNumber;
                    else if (MaxValue == min2)
                        min2 = newNumber;
                    else if (MaxValue == min3)
                        min3 = newNumber;
                    else if (MaxValue == min4)
                        min4 = newNumber;

                    //Check which of the variables hold the max value
                    MaxValue = Math.Max(Math.Max(min1, min2), Math.Max(min3, min4));
                }
            }

            //Output: The four numbers who’s sum is the lowest
            Console.WriteLine($"The minimal sum for the minimal values is: {min1}, {min2}, {min3}, {min4} = {min1 + min2 + min3 + min4}");

        }

        //Factiroal -
        //in case of error return 0
        public static int Factorial(int numberInt)
        {
            if (numberInt < 0) return 0;

            int result = 1;

            for (int i = 1; i <= numberInt; i++)
            {
                result *= i;
            }

            return result;
        }

        public static long Something(int a, int b)
        {
            long result = 1;
            for (int i = 1; i < b; i++)
                result *= a;
            return result;
        }

        public static void Main(string[] args)
        {









            Console.WriteLine(Something(3,5));
            
            /*
            int num = 1;
            int res = 0;
            Console.WriteLine($"The factorial of {num} is {res}");

            //-5
            if(Factorial(-5) == 0)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            //0
            if (Factorial(0) == 1)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            //1
            if (Factorial(1) == 1)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            //5
            if (Factorial(5) == 120)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            //11
            if (Factorial(11) == 39916800)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            */
            /*
            ConclusionLabs07();
            */

            /*
            int number = 76566;
            int dividing = 3;
            int diviBy2 = ConclusionLabs01(number, dividing);
            Console.WriteLine($"the number {number} is divded by {dividing} {diviBy2} times");
            */

            /*
            //PrintSqrLab12_1(5, 5);
            //PrintSqrLab12_2(5);
            PrintSqrLab12_3(5);
            */

            /*
            NestingLoops();
            */
            /*
            sqrt();
            */

            /*
            for (int i = 0; i < 12; Console.WriteLine(i++), i++) ;
            */
            //2, 5, 8, 11,14, 17, 20
            /*
            for (int i = 2; i < 21 ; i+=3)
            {

            }
            */
            /*
            int num = 9;
            while (num != 0)
            {
                num = num - 2;
                Console.WriteLine(num);
            }

            for (int i = 100, j = 0; i > j; i-=2, j+=2)
            {
                Console.WriteLine($"{i}, {j}");
            }
            */
            //Fibonacci(1);
            //FibonacciVer2(10);

            /*
            Console.WriteLine("Before Q3");
            Console.WriteLine("between 100 - 999");
            question3(100, 999);
            Console.WriteLine("between 1000 - 1160");
            question3(1000, 1160);
            */


            //int number1 = ReadNumber("Please enter number of loops", "Invalid number");
            //PrintLoop(number1);

            //Average();

        }

    }
}
