using System;

namespace conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("enter num:");
            string inp = Console.ReadLine();
            bool ch1 = int.TryParse(inp, out num1);
            Console.Write("enter num:");
            inp = Console.ReadLine();
            bool ch2 = int.TryParse(inp, out num2);
            Console.Write("enter num:");
            inp = Console.ReadLine();
            bool ch3 = int.TryParse(inp, out num3);

            if (!ch1 || !ch2 || !ch3)
            {
                Console.WriteLine("One of the values is not a number");
                return;
            }

            //calculate the average
            float avg = (num1 + num2 + num3) / 3F;
            //check if max > min
            int tmp, max = num1, middle = num2, min = num3;
            if (max < min)//check if max is smaller than min
            {
                //swap
                tmp = min;
                min = max;
                max = tmp;
            }
            if (max < middle)//check if max is smaller than middle
            {
                //swap
                tmp = middle;
                middle = max;
                max = tmp;
            }
            //in this line we are sure that the "max" holds the maximum value for sure!
            if (middle < min)//check if middle is smaller than min
            {
                //swap
                tmp = middle;
                middle = min;
                min = tmp;
            }
            //middle is set
            if (middle > avg)
            {
                Console.WriteLine($"Middle ({middle}) is greater than avg ({avg})");
            }
            else
            {
                Console.WriteLine($"Middle ({middle}) is smaller than avg ({avg})");
            }
        }
        static void Main5(string[] args)
        {
            int num1, num2, num3, num4, count = 0;
            Console.Write("enter num:");
            string inp = Console.ReadLine();
            bool ch1 = int.TryParse(inp, out num1);
            Console.Write("enter another num:");
            inp = Console.ReadLine();
            bool ch2 = int.TryParse(inp, out num2);
            Console.Write("enter num:");
            inp = Console.ReadLine();
            bool ch3 = int.TryParse(inp, out num3);
            Console.Write("enter num:");
            inp = Console.ReadLine();
            bool ch4 = int.TryParse(inp, out num4);

            if (ch1 && ch2 && ch3 && ch4)
            {
                if (num1 % 2 == 0)
                    count++;
                if (num2 % 2 == 0)
                    count++;
                if (num3 % 2 == 0)
                    count++;
                if (num4 % 2 == 0)
                    count++;
                Console.WriteLine($" {count} numbers are even");
            }
            else
            {
                Console.WriteLine("One of the values is not a number");
            }
        }
        static void Main4(string[] args)
        {
            int num1, num2, num3, num4;
            Console.Write("enter num:");
            string inp = Console.ReadLine();
            bool ch1 = int.TryParse(inp, out num1);
            Console.Write("enter num:");
            inp = Console.ReadLine();
            bool ch2 = int.TryParse(inp, out num2);
            Console.Write("enter num:");
            inp = Console.ReadLine();
            bool ch3 = int.TryParse(inp, out num3);
            Console.Write("enter num:");
            inp = Console.ReadLine();
            bool ch4 = int.TryParse(inp, out num4);

            if (ch1 == true && ch2 == true && ch3 == true && ch4 == true)
            {
                int max = Math.Max(Math.Max(num1, num2), Math.Max(num3, num4));
                int min = Math.Min(Math.Min(num1, num2), Math.Min(num3, num4));
                Console.WriteLine($"Max num is: {max}, Min num is: {min}");
            }
            else
            {
                Console.WriteLine("incorrect number");
            }
        }
        static void Main3(string[] args)
        {
            int number;
            //read number 1
            Console.WriteLine("Please enter number: ");
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out number);
            if (!isNumber)//!true == > false ... !false == > true
            {
                Console.WriteLine("The input insearted is not a number!!! bye bye");
                return;
            }
            //THIS IS FOR SURE A NUMBER
            //check if the nuber has 2 digits
            if ((number <= 9) || (number >= 100))
            {
                //if not 2 gitis ... 8, 0, 102, 100, 9,
                Console.WriteLine("The input insearted is not composed of 2 digits!!! bye bye");
                return;
            }

            //This is a number & this is a number with 2 digits
            int secondDigit = number / 10; // 6.4 ==> 6
            int firstDigit = number % 10; // 4
            if (secondDigit > firstDigit)
            {
                Console.WriteLine($"Second digit ({secondDigit}) is greater than first digit ({firstDigit})");
            }
            else
            {
                Console.WriteLine($"Second digit ({secondDigit}) is NOT greater than first digit ({firstDigit})");
            }
        }
        static void Main2(string[] args)
        {
            int number1, number2;
            string input;
            bool isNumber1, isNumber2;

            //read number 1
            Console.WriteLine("Please enter first number: ");
            input = Console.ReadLine();
            isNumber1 = int.TryParse(input, out number1);

            //read number 2
            Console.WriteLine("Please enter second number: ");
            input = Console.ReadLine();
            isNumber2 = int.TryParse(input, out number2);

            if (!isNumber1 || !isNumber2)
            {
                Console.WriteLine("Incorrect values!!");
                return;
            }
            else
            {
                int max = number1, min = number2;
                if (number2 > number1)
                {
                    max = number2;
                    min = number1;
                }
                //max and min are fine

                Console.WriteLine($"intDiv = {max / min}");
                Console.WriteLine($"reminder = {max % min}");
                Console.WriteLine($"floatDiv = {max / (float)min}");
            }


        }
    }
}
