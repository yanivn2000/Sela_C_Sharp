using System;

namespace Hash_SeparateChaining
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Random rand = new Random();
            Hash_SeparateChaining<int, int> hashCars = new Hash_SeparateChaining<int,int>(2048);
            for (int i = 0; i < 5120; i++)
            {
                hashCars.Add(rand.Next(1111111, 9999999), rand.Next(1930, 2020));
            }
            
            Console.WriteLine();
        }

    }

}
