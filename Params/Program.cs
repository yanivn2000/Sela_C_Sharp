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


            Test test1 = new Test(array);
            Test test2 = new Test(1, 4, 6, 7);

        }
        public static void PrintArray(string str, params int [] array)
        {
            Console.WriteLine($"{str}");

            foreach (var item in array)
            {
                Console.WriteLine($"item: {item}");
            }
        }
        public static void PrintArrayOnly(params int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine($"item: {item}");
            }
        }
    }

    class Test
    {
        static int max = 100;
        public bool[] arrayOfBools { get; set; }

        public Test()
        {
            arrayOfBools = new bool[max];
            for (int i = 0; i < max; i++)
            {
                arrayOfBools[i] = false;
            }
        }
        public Test(params int[] array) : this()
        {
            foreach (var item in array)
            {
                arrayOfBools[item] = true;
            }
        }
        public Test(params long[] array) : this()
        {
            foreach (var item in array)
            {
                arrayOfBools[item] = true;
            }
        }
        public static void PrintArrayOnly(params int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine($"item: {item}");
            }
        }
    }

}
