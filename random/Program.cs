using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("This is Main");
            //MainRandom1(args);
            //MainRandom2(args);
            //MainRandom3(args);
            MainRandom4(args);
            Console.ReadKey();

        }
        /*
        static public int Min(int number1, int number2)
        {
            if (number1 > number2) return number2;
            else return number2;
        }
        static public int Max(int number1, int number2)
        {
            if (number1 < number2) return number2;
            else return number2;
        }*/
        static void MainRandom4(string[] args)
        {
            int TOTAL_DRAWS = 10;
            int NUMBER_OF_REAL_NUMBERS_DRAWS = 20;
            Random rand = new Random();

            for (int i = 0; i < TOTAL_DRAWS; i++)
            {
                //draw 2 numbers between 40-100
                int FROM_NUMBER = 40, TO_NUMBER = 101;
                int number1 = rand.Next(FROM_NUMBER, TO_NUMBER);
                int number2 = rand.Next(FROM_NUMBER, TO_NUMBER);
                //identify min max
                int min = Math.Min(number1, number2);
                int max = Math.Max(number1, number2);
                //set minimal value to maximum
                double minimalValue = max;

                //draw real numbers between min to max
                double sumOfRealNumbers = 0;
                for (int j = 0; j < NUMBER_OF_REAL_NUMBERS_DRAWS; j++)
                {
                    //rand.NextDouble() draw real number between 0-1
                    //realNumber: 40.000001 - 99.9999999999
                    double realNumber = (max - min) * rand.NextDouble() + min;//(50 - 20) * 0.24 + 20
                    if (realNumber < minimalValue)
                        minimalValue = realNumber;//found a new minimal value (beside min)
                    //add the real number to Sum
                    sumOfRealNumbers += realNumber;
                }

                //Print
                //minimum
                Console.WriteLine($"The minimum value found between {min} to {max} is: {minimalValue:F2}");
                //average of the numbers
                Console.WriteLine($"The average numbers between {min} to {max} is: {(sumOfRealNumbers / NUMBER_OF_REAL_NUMBERS_DRAWS):F2}");
            }
        }
        static void MainRandom3(string[] args)
        {

            int TOTAL_DRAWS = 10;
            Random rand = new Random();

            for (int i = 0; i < TOTAL_DRAWS; i++)
            {
                int number = rand.Next(-30, 31);

                if (number == 0)
                    Console.Write($"{number} ");
                if (number > 0)//if number > 0 do something 1
                {
                    while (number > 0)//as long as the number > 0
                    {
                        Console.Write($"{number} ");
                        number--;//reduce by 1
                    }
                }
                else//if number < 0 do something else
                {
                    while (number < 0)//as long as the number < 0
                    {
                        Console.Write($"{number} ");
                        number += 2;//incease by 2
                    }
                }

                Console.WriteLine();
            }
        }
        static void MainRandom2(string[] args)
        {
            int totalSumTillZero = 0;//sum of all zero counters finding (this will be divided by countZero...)
            int countZero = 0;
            Random rand = new Random();
            int NUMBER_OF_DRAWS_OF_ZERO = 10;

            int countNoZeroSinceLastZero = 0;//how long we didn't get zero
            Console.Write("Aver(");

            //Logic
            while (countZero < NUMBER_OF_DRAWS_OF_ZERO)
            {
                int newNumber = rand.Next(-30, 31);//draw a number
                if (newNumber == 0)//draw zero!!
                {
                    countZero++;//we found zero...add + 1
                    totalSumTillZero += countNoZeroSinceLastZero;//add count till zero to sum
                    Console.Write($"{countNoZeroSinceLastZero} ");
                    countNoZeroSinceLastZero = 0;//reset
                }
                else//draw NO zero
                    countNoZeroSinceLastZero++;
            }

            //Print
            Console.Write(") -> ");
            Console.WriteLine($"Average for drawing zero was: {totalSumTillZero / (float)countZero}");
            //Console.WriteLine($"Average for drawing zero was: {countNoZero / (float)NUMBER_OF_DRAWS_OF_ZERO}");
        }
        static void MainRandom1(string[] args)
        {
            int numberOfIterations = 21; // number of iterations
            Random rand = new Random();
            int biggestSum = 0;
            int number1 = 0, number2 = 0;//with the greatest sum
            int locationNumber2 = 0;

            //Logic
            int lastNumber = 0;
            for (int i = 1; i <= numberOfIterations; i++)
            {
                int newNumber = rand.Next(0, 100);//draw a number
                Console.Write($"{newNumber} ({newNumber + lastNumber}), ");
                if (newNumber + lastNumber > biggestSum)
                {
                    biggestSum = newNumber + lastNumber;
                    number1 = lastNumber;
                    number2 = newNumber;
                    locationNumber2 = i;
                }
                lastNumber = newNumber;
            }

            //Printing
            Console.WriteLine();
            Console.WriteLine($"Numbers {number1}, {number2}");
            Console.WriteLine($"Their sum {biggestSum}");
            Console.WriteLine($"The location {locationNumber2 - 1}, {locationNumber2}");
        }
        static void MainLoops9(string[] args)
        {
            int length = 20;
            Random rand = new Random();
            int biggestNumber = 0, secondBiggestNumber = 0;
            int biggestNumberSumDigits = 0, secondBiggestNumberSumDigits = 0;
            for (int i = 0; i < length; i++)
            {
                //draw a number
                int newNumber = rand.Next(0, 10000);
                //sum the digits of the new number
                int tmp_number = newNumber;
                int sumDigits = 0;//sum digits of the new number
                while (tmp_number > 0)
                {
                    //get the last digit
                    sumDigits += tmp_number % 10;//(3) --> 124 --> (4) --> 12
                    //divid by 10
                    tmp_number /= 10; // 1243 -- > 124 -- > 12
                }
                Console.Write($"{newNumber}({sumDigits}), ");

                //check if the sum digits of the new number is greater than the biggest one
                if (sumDigits > biggestNumberSumDigits)
                {
                    //repalce the second with the first
                    secondBiggestNumber = biggestNumber;
                    secondBiggestNumberSumDigits = biggestNumberSumDigits;
                    //This is the biggetst one
                    biggestNumber = newNumber;
                    biggestNumberSumDigits = sumDigits;
                }
                else if (sumDigits > secondBiggestNumberSumDigits)
                {
                    //repalce the second
                    secondBiggestNumber = newNumber;
                    secondBiggestNumberSumDigits = sumDigits;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Biggest Number Digits is {biggestNumber}({biggestNumberSumDigits}), and second is {secondBiggestNumber}({secondBiggestNumberSumDigits})");
        }

    }
}
