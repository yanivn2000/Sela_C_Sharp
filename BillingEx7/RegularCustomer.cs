using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingEx7
{
    class RegularCustomer : Customer
    {

        // constructors
       
        public RegularCustomer(string name, double balance) : base(name, balance) { }
        public RegularCustomer(string name) : base(name) { }

        

        // add the amount to current balance
        public override void addToBalance(double amount)
        {
            Balance +=  amount;
        }
    }
}
