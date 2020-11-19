using System;

namespace conditions
{
    class MainClass
    {
        //6.	לקלוט 20 מספרים בלולאה ולמצוא מספר בעלי סכום הספרות המקסימלי ומינימלי ולהציג גם את המספר וגם את סכום הספרות שלו –גם עבור המקסימום וגם עבור המינימום
        public static void Main(string[] args)
        {
            int biggestDigitSum = int.MinValue, smallestDigitsSum = int.MaxValue, smallestNum = 0, biggestNum = 0;
            Console.WriteLine("insert 5 valid numbers:");            for (int i = 0; i < 5; i++)
            {
                int currentDigitSum = 0, num = 0;
                Console.Write("Please enter a number: ");                string str = Console.ReadLine();//read input from the user                while (!int.TryParse(str, out num))//loop until the input is an integer                {
                    Console.WriteLine("wrong input");
                }

                //Yea - I have a number
                int currentNum = num;//save the number before we manipulate it
                while (num != 0)
                {
                    currentDigitSum += (num % 10);//if we had 7654 % 10 //get the digit and add it to compet
                    num /= 10;//div by 10 (7654 --> 765)
                }
                //if the biggest
                if (currentDigitSum > biggestDigitSum)
                {
                    biggestDigitSum = currentDigitSum;//keep the biggest digits sum (22)
                    biggestNum = currentNum;//keep the number with the biggest digits sum (7654)
                }
                if (currentDigitSum < smallestDigitsSum)
                {
                    smallestDigitsSum = currentDigitSum;//keep the smallest digits sum (22)
                    smallestNum = currentNum;//keep the number with the smallest digits sum (7654)
                }
            }
            Console.WriteLine($"biggest num is {biggestNum} and digits value is {biggestDigitSum} smallest num is {smallestNum} and digits value is{smallestDigitsSum}");
        }
        //read 5 numbers and check if the least significant digits (LSD) equals to the most significant digit (NSD)
        public static void Main44(string[] args)
        {

            int equalNum = 0;            int cnt = 0, unit, num;            int maxDigit = 0;            Console.WriteLine("please enter five numbers");            while (cnt < 5)            {                while (!int.TryParse(Console.ReadLine(), out num))                {                    Console.WriteLine("invalid imput");
                }                unit = num % 10;                while (num != 0)                {                    maxDigit = num;                    num /= 10;                }                if (unit == maxDigit)                {                    equalNum++;                }                cnt++;

            }            Console.WriteLine($"the numbers of the num that the equal from both side {equalNum}"); 
        }
        //read 10 whola numbers using do while
        public static void Main33(string[] args)
        {
            int sum = 0;
            int count = 0;
            Console.WriteLine("Please enter 10 numbers: ");

            do
            {
                Console.Write($"Please enter number #{count+1}: ");
                string str = Console.ReadLine();
                int value;
                if (int.TryParse(str, out value))
                {
                    //here we for sure have a number
                    sum += value;
                    count++;
                }
                else
                {
                    Console.WriteLine("This was a wrong number");
                }
            } while (count != 10);

            Console.WriteLine($"The sum of all values is {sum}");
        }

        //read 10 whola numbers using for and while
        public static void Main22(string[] args)
        {
            int sum = 0;
            for (int cnt = 0; cnt < 5; cnt++)
            {                Console.Write("Enter a number: ");                int num;                while (!int.TryParse(Console.ReadLine(), out num))                {                    Console.WriteLine("Unvalid number, please try again!");                }                //Logic:                sum += num;            }            Console.WriteLine($"The sum of all values is {sum}");
        }

        public static void Main7(string[] args)
        {
            int number = 10;
            while (number > 0)
            {
                number-=3;
                Console.Write($"{number++} ");
            }
        }

        static void Main6(String[] args)
        {
            int number = 0;
            string input = "";
            while (true)
            {
                do
                {
                    Console.Write($"Please enter first number (enter 0 to stop):");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out number));
                if (number == 0) break;//break the loop in case calue is 0
                int firstDigit = number % 10; //123 % 10 ======= > 3

                int last_digit = number; //123
                while (last_digit > 9)
                {
                    last_digit = last_digit / 10;//123 == > 12 == > 1
                }
                if (last_digit == firstDigit)
                    Console.WriteLine($"Last digit equals to first digit in number {number}");
                else
                    Console.WriteLine($"Last digit does not equal to first digit in number {number}");

            }
        }
        static void MainLoops5(String[] args)
        {
            int number1 = 0, number2 = 0;
            string input = "";
            do
            {
                Console.Write($"Please enter first number:");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out number1));
            do
            {
                Console.Write($"Please enter second number:");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out number2));

            //here we have 2 numbers

            int max = Math.Max(number1, number2);
            int min = Math.Min(number1, number2);

            for (int i = min; i <= max; i += 3)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("");

            for (int i = max; i >= min; i -= 2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("");
        }
        static void MainLoops4(String[] args)
        {
            int total_of_whole_numbers = 0, total_of_real_numbers = 0, total_of_strings = 0;
            int TOTAL_NUMBER_OF_STRINGS = 5;
            string input = "";

            for (int i = 0; i < TOTAL_NUMBER_OF_STRINGS; i++)
            {
                Console.Write("Type whole number, decimal unmber or just a string: ");
                input = Console.ReadLine();
                int value_i;
                float value_f;
                if (int.TryParse(input, out value_i))
                    total_of_whole_numbers++;
                else if (float.TryParse(input, out value_f))
                    total_of_real_numbers++;
                else
                    total_of_strings++;
            }

            Console.WriteLine($"Total of whole numbers is {total_of_whole_numbers}");
            Console.WriteLine($"Total of real numbers is {total_of_real_numbers}");
            Console.WriteLine($"Total of string numbers is {total_of_strings}");
        }

        static void MainLoops3(String[] args)
        {
            int max = 0;
            string longest_string = "";
            int TOTAL_NUMBER_OF_STRINGS = 5;


            for (int i = 0; i < TOTAL_NUMBER_OF_STRINGS; i++)
            {
                string last_string_read = "";
                do
                {
                    Console.Write("type string as long as u want: ");
                    last_string_read = Console.ReadLine();
                } while (last_string_read.Length == 0);//break if string is not empty

                if (last_string_read.Length > max)
                {
                    longest_string = last_string_read;
                    max = longest_string.Length;
                }

            }
            Console.WriteLine(longest_string);
        }

        static void MainLoops2(String[] args)
        {
            int rows, asterisk;
            string input;

            //READ ROWS AND ASTERISKS
            //A: Read number of asterisks
            do
            {
                Console.Write($"Please enter number of asterisk:");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out asterisk) || asterisk < 0);//break if input is a number > 0

            //B: Read number of rows
            do
            {
                Console.Write($"Please enter number of rows:");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out rows) || rows < 0);//break if input is a number > 0

            //C: PRINT
            //here we have 2 numbers - for sure!!!
            for (int i = 0; i < rows; i++)
            {
                //first and last line 
                if (i == 0 || i == (rows - 1))
                {
                    //print entire line
                    for (int j = 0; j < asterisk; j++)
                    {
                        Console.Write("*");
                    }
                }
                else//NOT the first or the last line
                {
                    Console.Write("*");
                    for (int j = 1; j < (asterisk - 1); j++)
                        Console.Write(" ");
                    Console.Write("*");
                }
                //new line
                Console.WriteLine("");
            }

        }
        //Loops
        static void MainLoops1(String[] args)
        {

            int number;
            string input;
            bool isNumber;
            //Read number from the user
            do
            {
                Console.Write($"Please enter a number:");
                input = Console.ReadLine();
                //verify that input is a number
                isNumber = int.TryParse(input, out number);
            } while (!isNumber || number < 0);//break if input is a number > 0

            //print * x times (x= number)
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");

        }
    }

}