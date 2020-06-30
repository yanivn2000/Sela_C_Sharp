using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingEx7
{

    class Accounting
    {
        public string Name { get; private set; }
        public void sendSMS(object sender, IrregularBalanceEventArgs args)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} Irregular balance detected. SMSing CFO we have a budget problem",Name);
            Console.WriteLine("Suspect is: {0}, Balance: {0}", args.Suspect, args.Balance);
            Console.ForegroundColor = oldColor;
        }
        public Accounting(BillingSystem bs, string name)
        {
            Name = name;
            bs.irregBalanceListner += sendSMS;
        }
    }

    class CustomerService
    {
        public string Name { get; private set; }
        public void sendSMS(object sender, IrregularBalanceEventArgs args)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} Irregular balance detected. Calling the customer to tell him someone is using his account too much", Name);
            Console.WriteLine("Suspect is: {0}, Balance: {0}", args.Suspect, args.Balance);
            Console.ForegroundColor = oldColor;
        }
        public CustomerService(BillingSystem bs, string name)
        {
            Name = name;
            bs.irregBalanceListner += sendSMS;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new RegularCustomer("John");
            Customer cust2 = new VIPCustomer("Smith", -100.0);
            Customer cust3 = new VIPCustomer("aaa", 100.0);
            try
            {
                BillingSystem bs1 = new BillingSystem(3);

                CustomerService cs1 = new CustomerService(bs1,"CService 1");
                CustomerService cs2 = new CustomerService(bs1, "CService 2");
                Accounting acc1 = new Accounting(bs1, "Accounting 1");

                bs1.addCustomer(cust1);
                bs1.addCustomer(cust2);
                bs1.addCustomer(cust3);

                //bs1.updateBalance(100000000);
                bool stop = false;
                while(!stop)
                {
                    Console.WriteLine("Continue? Y or N");
                    if (Console.ReadLine() == "Y")
                    {
                        bs1.ChargingCalls();
                    }
                    else
                        stop = true;
                }
               

                Console.WriteLine("Before adding 100 to balance");
                Console.WriteLine("============================");
                Console.WriteLine(bs1);

                bs1.updateBalance(100);

                Console.WriteLine("After adding 100 to balance");
                Console.WriteLine("============================");
                Console.WriteLine(bs1);

                Console.WriteLine("Customer John searched");
                Console.WriteLine(bs1["John"]);

                Console.WriteLine("Customer 1, John searched");
                Console.WriteLine(bs1[1, "John"]);

                //Console.WriteLine("Customer 3 searched");
                //Console.WriteLine(bs1[3]);

                Console.WriteLine("Before sort");
                Console.WriteLine("===========");
                Console.WriteLine(bs1);

                //bs1.Sort();
                bs1.Sort(new CompareCustomerByBalance());

                Console.WriteLine("After sort");
                Console.WriteLine("===========");
                Console.WriteLine(bs1);

                Console.WriteLine("Iterator issues");
                foreach (Customer cust in bs1)
                    Console.WriteLine(cust);

            }
            catch (TooManyCustomersExcpetion e)
            {
                Console.WriteLine("Exception caught, type: {0}", e.GetType());
                Console.WriteLine("Too many customers already in the system, current number is: {0}", e.MaxCutomers);
                Console.WriteLine(e);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            finally
            {

                Console.ReadLine();
            }
        }
    }
}
