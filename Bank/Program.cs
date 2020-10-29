using System;

namespace Bank
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //Write a program that reads 3 numbers
            //print the biggest number

            Console.Write("Please enter a grade: ");
            string val = Console.ReadLine();
            //int grade = int.Parse(val);
            int grade;
            if(int.TryParse(val, out grade))
            {
                if (grade >= 60)
                    Console.WriteLine("Passed");
                else
                    Console.WriteLine("Failed");
            }
            else
            {
                Console.WriteLine("This is not a grade..it must ne a number");
            }




            /*
            Console.WriteLine("Welcome to Yaniv's International Bank");

            Account account = new Account();
            Console.WriteLine($"Deposit of 1000$: {account.Deposit(1000)}");
            Console.WriteLine($"Withdraw of 100$: {account.Withdraw(100)}");
            Console.WriteLine($"Withdraw of 1400$: {account.Withdraw(1400)}");
            */
        }
    }

    class Account
    {
        //Person _person;
        private string _accountNumber;
        private string _password;
        private float _balance = 0;

        public float Deposit(float x)
        {
            if (x > 0)
                _balance += x;
            return _balance;
        }
        public float Withdraw(float x)
        {
            if (x > _balance)
                Console.WriteLine("There is not enough money .. go to work");
            else
                _balance -= x;
            return _balance;
        }
        public float GetCurrentBalance()
        {
            return _balance;
        }
    }
    /*
    class Person
    {
        string _id;
        string _firstName;
        string _lastName;
        string _address;
    }
    */
}
