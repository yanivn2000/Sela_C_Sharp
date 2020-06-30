using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingEx7
{
    class VIPCustomer : Customer
    {
        // constructors
       
        public VIPCustomer(string name, double balance) : base(name, balance) { }
        public VIPCustomer(string name) : base(name) { }

        // override section
        public override string ToString()
        {
            return String.Format("VIP Customer: {0}",base.ToString());
        }

        // as a VIP, we pay only 80% of the amound due
        // but if the amount is negative, we will also get only 80% of the reduction...
        public override void addToBalance(double amount)
        {
            Balance += 0.8 * amount;
        }
    }
}
