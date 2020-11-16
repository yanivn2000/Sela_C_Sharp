using System;

namespace BillingSystem
{
    public class Customer
    {
        //Members
        //a string that holds the customer's name
        private string _name;
        //a double that holds the customer's current bill
        private double _currentBill;
        private bool _is_limited = false;

        //Props
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double CurrentBill
        {
            get { return _currentBill; }
            set { _currentBill = value; UpdateIsLimited(); }
        }
        public bool IsLimited
        {
            get { return _is_limited; }
            set { _is_limited = value; }
        }

        //Ctor
        public Customer(string name, double current_bill)
        {
            _name = name;
            _currentBill = current_bill;
            UpdateIsLimited();
        }
        public Customer(string name)
        {
            _name = name;
            _currentBill = 0;
            UpdateIsLimited();
        }
        //More
        private void UpdateIsLimited()
        {
            if (_currentBill > 10000) _is_limited = true; else _is_limited = false;
        }
        public void PrintMe()
        {
            Console.WriteLine($"Name: {_name}, Current Bill: {_currentBill}");
        }
    }
}
