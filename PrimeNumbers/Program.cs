using System;

namespace PrimeNumbers
{
    class MainClass
    {

        public static void Main()
        {
            int[] arrPrimeNumbers = new int[10];
            Random rand = new Random();
            int primeIndex = 0;
            while(primeIndex < arrPrimeNumbers.Length)
            {
                //draw a number
                int number = rand.Next(100, 1001);
                //check if prime
                bool isDiveded = false;
                for (int i = 2; (i <= (int)Math.Sqrt(number)) && !isDiveded; i++)
                {
                    if((number % i) == 0)
                        isDiveded = true;
                }
                //if prime + //add to array + //add indexPrime+1
                if (!isDiveded)
                    arrPrimeNumbers[primeIndex++] = number;
            }
            PrintArray(arrPrimeNumbers);
        }

        public static void PrintArray(int []array)
        {
            foreach (int item in array)
            {
                Console.WriteLine($"{item}");
            }
        }

        public static void IsPrimeWithFunctions()
        {
            int[] numbers = { 11, 17, 654, 989, 666, 123139 };

            int[] primes = { };
            isPrimeArray(numbers, out primes);

            //print the original array:
            foreach (int number in numbers)
                Console.WriteLine($"number: {number}");

            //print the prime numbers
            foreach (int prime in primes)
                Console.WriteLine($"Prime number: {prime}");


        }

        public static void isPrimeArray(int[] numbers, out int[] primes)
        {
            int[] tempArray = new int[numbers.Length];
            int counter = 0, divider = 0;
            foreach (var number in numbers)
            {
                if (isPrime(number, out divider))
                {
                    //found prime
                    tempArray[counter++] = number;
                }
            }

            primes = new int[counter];
            for (int i = 0; i < counter; i++)
            {
                primes[i] = tempArray[i];
            }

        }



        public static void Main1(string[] args)
        {
            //the number to check
            int[] numbers = { 11, 17, 654, 989, 666, 123139 };

            foreach (var number in numbers)
            {
                int divider;
                if (isPrime(number, out divider))
                {
                    Console.WriteLine($"Number {number} is a prime number");
                }
                else
                {
                    Console.WriteLine($"Number {number} is NOT a prime number and it is divided by {divider}");
                }
            }

        }

        public static bool isPrime(int number, out int divider)
        {
            divider = 0;
            //exceptions
            if (number == 1) return false;
            if (number == 2) return true;

            //sqrt
            int sqrt = (int)Math.Sqrt(number);

            for (int i = 2; i < sqrt; i++)
            {
                if (number % i == 0)
                {
                    divider = i;
                    return false;//is not a prime number
                }
            }
            return true;//is a prime number 
        }
    }
}