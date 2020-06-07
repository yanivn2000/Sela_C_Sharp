using System;

namespace Params
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Testing Params");
            int[] array = new int[] { 3, 5, 7, 9, 11 };
            PrintArray("Send Array", array);
            PrintArray("Send List", 2, 4, 6, 8, 10);
        }
        public static void PrintArray(string str, params int [] array)
        {
            Console.WriteLine($"{str}");

            foreach (var item in array)
            {
                Console.WriteLine($"item: {item}");
            }
        }
    }

}
