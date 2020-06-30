using System;

namespace Nullable
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int? n = 30;
            //null the n
            n = null;

            if(n == null)
            {
                Console.WriteLine("n is null");
            }

            int? a = 28;
            //int? h = a == null ? -1 : a; // must declar h as int?

            int b = a ?? -1;//will never return null
            Console.WriteLine($"b is {b}");  // output: b is 28

            int? c = null;
            int d = c ?? -1;//will never return null
            Console.WriteLine($"d is {d}");  // output: d is -1


        }
    }
}
