using System;

namespace BillingSystem
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our system billing ver 2");

            Customer[] customers = new Customer[3];
            for (int i = 0; i < customers.Length; i++)
            {
                Console.Write("What your name? ");
                string name = Console.ReadLine();
                customers[i] = Customer.Create(name);
            }


            foreach (var customer in customers)
            {
                customer.PrintMe();
            }
        }
    }

}
