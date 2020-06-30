using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BillingEx7
{
    class CompareCustomerByBalance : IComparer
    {
        public int Compare(object x, object y)
        {
            Customer cust1 = x as Customer;
            Customer cust2 = y as Customer;
            if (cust1 == null || cust2 == null)
                throw new InvalidCastException();
            return cust1.Balance.CompareTo(cust2.Balance);
        }
    }
}
