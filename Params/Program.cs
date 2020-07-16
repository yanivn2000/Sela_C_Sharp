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


            Test test = new Test(1, 4, 6, 7);
            //test.PrintArray();
            test.Name = 30;//assigment FAILED

            Console.WriteLine($"The height is {test.Name}");


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
        public bool[] arrayOfBools { get ; private set; } = new bool[max];

        private int name; // field
        public int Name   // property
        {
            get { return name; }
            set { name = value+10; }
        }

        public Test()
        {
            name = 100;
            for (int i = 0; i < max; i++)
            {
                arrayOfBools[i] = false;
            }
        }
        public Test(params int[] array) : base()
        {
            foreach (var item in array)
            {
                arrayOfBools[item] = true;
            }
        }
        public void PrintArray()
        {
            foreach (var item in arrayOfBools)
            {
                Console.WriteLine($"item: {item}");
            }
        }
    }

}
