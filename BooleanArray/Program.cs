using System;

namespace SstNumberBoolArray
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Set set1 = new Set();

            Console.WriteLine("Print set1:");
            foreach (var item in set1.GetSet())
            {
                Console.WriteLine(item);
            }
            int[] array = {5, 7, 20 , 33, 23};
            Set set2 = new Set(array);
            Console.WriteLine("Print set2:");
            foreach (var item in set2.GetSet())
            {
                Console.WriteLine(item);
            }
            set1.Insert(10);
            set1.Insert(20);
            set1.Insert(30);
            Console.WriteLine("Print set1:");
            foreach (var item in set1.GetSet())
            {
                Console.WriteLine(item);
            }

        }
    }
}
