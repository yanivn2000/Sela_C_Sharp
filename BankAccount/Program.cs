using System;

namespace BankAccount
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO MY BANK!");

            //create Object of aNCK ACCOUNT FOR TOM
            BankAccount Tom = new BankAccount(2040.50F, "Magniv", "Tom", "034455989");
            int amount = 100;
            if (!Tom.Deposit(amount))//DEPOSIT OF 100
                Console.WriteLine($"Deposit of {amount} has failed");
            else
                Console.WriteLine($"Deposit of {amount} has been succeeded");

            amount = -100;
            if (!Tom.Deposit(amount))//DEPOST OF -100
                Console.WriteLine($"Deposit of {amount} has failed");
            else
                Console.WriteLine($"Deposit of {amount} has been succeeded");

            amount = 1000;
            if (!Tom.Withdraw(amount))//WITHDRAW OF 1000
                Console.WriteLine($"Withdraw of {amount} has failed");
            else
                Console.WriteLine($"Withdraw of {amount} has been succeeded");


            amount = 2000;
            if (!Tom.Withdraw(amount))//WITHDRAW OF 2000 (EXCEEDED)
                Console.WriteLine($"Withdraw of {amount} has failed");
            else
                Console.WriteLine($"Withdraw of {amount} has been succeeded");

            Console.WriteLine(Tom.ToString());

        }
    }

    class BankAccount
    {
        float _balance;
        string _lname;
        string _fname;
        string _owner_id;

        public BankAccount(float balance, string lname, string fname, string owner_id)
        {
            _balance = balance;
            _lname = lname;
            _fname = fname;
            _owner_id = owner_id;
        }

        public override string ToString()        {            return $"{_fname} {_lname} : {_owner_id} has - {_balance}";        }
        //deposit money to the account
        public bool Deposit(int amount)
        {
            if (amount <= 0) return false;//check that amout is positive
            _balance += amount;//add the amount to the balance
            return true;
        }
        public bool Withdraw(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"Amount {amount} must be a positive value");
                return false;//check amount is positive
            }
            if (_balance < amount)
            {
                Console.WriteLine($"Amount requested {amount} is greater than balance {_balance}");
                return false;//check balance greater than amount
            }
            _balance -= amount;//deduct amount from the balance
            return true;
        }

    }
}
