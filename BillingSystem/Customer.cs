using System;

namespace BillingSystem
{
    public class Customer
    {
        //a string that holds the customer's name
        private string _name;
        //a double that holds the customer's current bill
        private double _currentBill;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double CurrentBill
        {
            get { return _currentBill; }
            set { _currentBill = value; }
        }
        public Customer(string name, double current_bill)
        {
            _name = name;
            _currentBill = current_bill;
        }
        public void PrintMe()
        {
            Console.WriteLine($"Name: {_name}, Current Bill: {_currentBill}");
        }
    }
}
