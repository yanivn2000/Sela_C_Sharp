using System;

namespace Hash_Chaining
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            HashLinkList<int, int> hashCars = new HashLinkList<int, int>(2048);
            for (int i = 0; i < 5120; i++)
            {
                hashCars.Add(rand.Next(1111111, 9999999), rand.Next(1930, 2020));
            }

            Console.WriteLine();
        }
    }
}
