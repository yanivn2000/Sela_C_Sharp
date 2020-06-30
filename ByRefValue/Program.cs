using System;

namespace ByRefValue
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
             * Simple passing by ref value
             */
            int argument = 30;
            TestClass obj = new TestClass();
            Console.WriteLine($"argument value is {argument}");
            Console.WriteLine($"add 20 by ref to argument");

            obj.Add20ByValue(argument);
            Console.WriteLine($"argument value is {argument}");

            obj.Add20ByRef(ref argument);
            Console.WriteLine($"argument value is {argument}");

            /*
             * Passing reference by reference test
             */
            // Declare an instance of Product and display its initial values.
            Product item = new Product("Fasteners", 54321);
            System.Console.WriteLine("Original values in Main.  Name: {0}, ID: {1}\n",
                item.ItemName, item.ItemID);

            // Pass the product instance to ChangeByReference.
            ChangeByReference(ref item);
            System.Console.WriteLine("Back in Main.  Name: {0}, ID: {1}\n",
                item.ItemName, item.ItemID);

            /*
             * get local value by ref
             */
            obj.PrintPrice();
            ref decimal refPrice = ref obj.GetCurrentPrice();
            refPrice = 200.50M;
            obj.PrintPrice();

            /*
             * get local value by ref readonly
             */
            obj.PrintAge();
            int refReadOnlyAge = obj.GetCurrentAge();
            refReadOnlyAge = 20;
            obj.PrintAge();

            /*
             * pass in value
             */
            int readonlyArgument = 55;
            obj.InArgExample(readonlyArgument);
            Console.WriteLine(readonlyArgument);     // value is still 55

            /*
             * Pass out value
             */
            int initializeInMethod;
            obj.OutArgExample(out initializeInMethod);
            Console.WriteLine(initializeInMethod);     // value is now 44

        }
        private static void ChangeByReference(ref Product itemRef)
        {
            // Change the address that is stored in the itemRef parameter.
            itemRef = new Product("Stapler", 99999);

            // You can change the value of one of the properties of
            // itemRef. The change happens to item in Main as well.
            itemRef.ItemID = 12345;
        }
    }
    class TestClass
    {
        private decimal Price = 300;//this will be returned by ref
        private int Age = 30;//this will be returned by ref
        public void Add20ByValue(int val)
        {
            //(int val = argument)
            //val += 30;
            val += 20;
        }
        public void Add20ByRef(ref int val)
        {
            val += 20;
        }
        //return by reference
        public ref decimal GetCurrentPrice()
        {
            return ref Price;
        }
        /*
         * Ref readonly
         * It returns a reference to the local variable
         * But it can not be modified
         */
        public ref readonly int GetCurrentAge()
        {
            return ref Age;
        }
        public void PrintPrice(){
            Console.WriteLine($"Price is {Price}");
        }
        public void PrintAge()
        {
            Console.WriteLine($"Age is {Age}");
        }
        /* In keyword
         * The in keyword causes arguments to be passed by reference.
         * It makes the formal parameter an alias for the argument,
         * which must be a variable. In other words, any operation on the parameter is made on the argument.
         * It is like the ref or out keywords, except that in arguments cannot be modified by the called method.
         * Whereas ref arguments may be modified, out arguments must be modified by the called method,
         * and those modifications are observable in the calling context.
         */
        public void InArgExample(in int number)
        {
            // Uncomment the following line to see error CS8331
            //number = 19;
        }
        /* Out keyword
         * The out keyword causes arguments to be passed by reference.
         * It makes the formal parameter an alias for the argument, which must be a variable.
         * In other words, any operation on the parameter is made on the argument.
         * It is like the ref keyword, except that ref requires that the variable be initialized before it is passed.
         * It is also like the in keyword, except that in does not allow the called method to modify the argument value.
         * To use an out parameter, both the method definition and the calling method must explicitly use the out keyword.
         * For example:
         */
        public void OutArgExample(out int number)
        {
            number = 44;
        }
    }
    class CS0663_Example
    {
        //SAME SIGNITURE!!
        // Compiler error CS0663: "Cannot define overloaded
        // methods that differ only on ref and out".
        //public void SampleMethod(out int i) { }
        //public void SampleMethod(ref int i) { }
    }
    class RefOverloadExample
    {
        //THAT IS ALLOWED!!
        public void SampleMethod(int i) { }
        public void SampleMethod(ref int i) { }
    }

    /*
     * Passing referenceby ref
     */
        class Product
    {
        public Product(string name, int newID)
        {
            ItemName = name;
            ItemID = newID;
        }

        public string ItemName { get; set; }
        public int ItemID { get; set; }
    }
}
