using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingEx7
{
   
    public class TooManyCustomersExcpetion : Exception
    {
        // what is the current max number of customers, indicated by this exception that it is reached.
        public int MaxCutomers { get; private set; }

        public TooManyCustomersExcpetion() { }
        public TooManyCustomersExcpetion( string message ) : base( message ) { }
        public TooManyCustomersExcpetion( string message, Exception inner ) : base( message, inner ) { }

        public TooManyCustomersExcpetion(int num) { MaxCutomers = num; }
        public TooManyCustomersExcpetion(string message, int num) : base(message) { MaxCutomers = num; }
        
       
    }
   
}
