using System;

namespace Hash_Chaining
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            HashLinkList<int, int> hashCars = new HashLinkList<int, int>(600);
            for (int i = 0; i < 512; i++)
            {
                try
                {
                    hashCars.Add(rand.Next(1111111, 9999999), rand.Next(1930, 2020));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine($"{e.Message}");
                }
            }

            //try to add the same key
            try
            {
                hashCars.Add(6554736, rand.Next(1930, 2020));
                hashCars.Add(6554736, rand.Next(1930, 2020));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"{e.Message}");
            }

            hashCars.Delete(6554736);

            hashCars.Add(5556644, 1988);
            hashCars.Edit(5556644, 2020);

            //
            Console.WriteLine();
        }
    }
}
