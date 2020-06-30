using System;
using System.Linq;

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
            linqAggregate(args);
            //test(args);
            Console.ReadKey();

        }

        static void linqAggregate(string[] args)
        {

            string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape" };

            // Determine whether any string in the array is longer than "banana".
            string longestName =
            fruits.Aggregate("banana",
                            (longest, next) =>
                                next.Length > longest.Length ? next : longest,
                            // Return the final result as an upper case string.
                            fruit => fruit.ToUpper());

            Console.WriteLine(
            "The fruit with the longest name is {0}.",
            longestName);

            // This code produces the following output:
            //
            // The fruit with the longest name is PASSIONFRUIT.
        }
    static void test(string[] args)
        {
            int max = 1000;
            int []arr = new int[max];
            Random rand = new Random();
            for (int i = 0; i < max; i++)
            {
                arr[i] = rand.Next(0, 10);
                arr[i] = rand.Next(0, 100);
                arr[i] = rand.Next(0, 1000);
                arr[i] = rand.Next(0, 10000);
                arr[i] = rand.Next(0, 100000);
                arr[i] = rand.Next(0, 1000000);
            }
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine($"{arr[i]}");
            }
        }

    }
}
