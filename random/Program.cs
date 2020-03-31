using System;

namespace conditions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello raandom!");
            Random rand = new Random();
            int lines = 100000;
            for (int i = 0; i < lines; i++)
            {
                int value = rand.Next(1,50);
                for (int j = 0; j < value; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                System.Threading.Thread.Sleep(50);
            }
        }
    }
}