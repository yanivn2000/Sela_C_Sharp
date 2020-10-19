using System;

namespace Bank
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Yaniv's International Bank");
        }
    }

    class Account
    {
        //Person _person;
        string _accountNumber;
        string _password;
        float _balance;

        public float Deposit(float x)
        {
            if (x > 0)
                _balance += x;
            return _balance;
        }
        public float Withdraw(float x)
        {
            if(x > _balance)
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
