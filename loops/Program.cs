using System;

namespace conditions
{
    class MainClass
    {
        public static void Main(string[] args)
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