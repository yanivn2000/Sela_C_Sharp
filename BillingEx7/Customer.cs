using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BillingEx7 
{
    public abstract class Customer :IComparable
    {
        // class data
        private static int _lastID;

        // instance data 
        private readonly int _id;
        private string _name;
        private double _balance;

        // Properties
        public int Id
        {
            get
            {
                return _id;
            }

        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }


        // constructors

        // class constructor
        static Customer()
        {
            _lastID = 1;
        }

        // instance constructors
        public Customer(string name, double balance)
        {
            _id = Customer.getNewID();
            Name = name;
            Balance = balance;


        }
        public Customer(string name) : this(name, 0.0) { } // avoid code duplication

        // public interface
        public override string ToString()
        {

            return String.Format("Name: {0}, ID: {1}, Balance: {2}", Name, Id, Balance);
        }

        // addToBalance should update the customer balance using amount as input critera
        public abstract void addToBalance(double amount);

        // internal implementation
        // getNewID retrieves the lastID used and increment it by one for the next user.
        private static int getNewID()
        {
            return _lastID++;
        }


        // default comparison method: compare by name
        public int CompareTo(object obj)
        {
            Customer cust = obj as Customer;
            if (cust == null)
                throw new InvalidCastException();
            return (Name.CompareTo(cust.Name));
        }

        
    }
}
