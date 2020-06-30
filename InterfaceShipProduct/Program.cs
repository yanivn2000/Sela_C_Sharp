using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceShipProduct
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //Using the interfaces we are able to hold these all classes in common List
            //We are sure that all the classes will implement at least the IProductModel interface
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (IProductModel prod in cart)
            {
                prod.ShipItem(customer);
                //we can check for specific case of DifitalProduct
                if (prod is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For the { digital.Title } you have { digital.TotalDownloadsLeft } downloads left.");
                }
            }

            Console.ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Yaniv",
                LastName = "Nuriel",
                City = "Tel Aviv",
                EmailAddress = "yaniv@eos-online.com",
                PhoneNumber = "972-544-903601"
            };
        }

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel { Title = "Beer glasses" });
            output.Add(new PhysicalProductModel { Title = "Coffee mugs" });
            output.Add(new PhysicalProductModel { Title = "Teapot" });
            output.Add(new DigitalProductModel { Title = "Learn how to make a coffee" });
            output.Add(new CourseProductModel { Title = "Be a Chef!" });

            return output;
        }
    }
}
