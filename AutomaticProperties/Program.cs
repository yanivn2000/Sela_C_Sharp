using System;

/*
Automatic properties are supported by C# since version 3.0 and as developers we use them almost every day.
Sometimes developers have questions about how automatic properties work and how to effectively use them.
Also I bust some myths about automatic properties and go deep with internals.
*/
namespace AutomaticProperties
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Dummy
    {
        //instead of this:
        //BUT IN THIS CASE WE CAN CONTROL THE SETTER AND THE GETTER!
        /* Automatic Properties*/
        /*
        private string _name;
        public string Name
        {
        get { return _name;  }
        set { _name = value;  }
        }
        */

        //we can write it like this as there is no additional logic involved in getter and setter:
        public string Name { get; set; }
        //automatic property is practically a synonym for regular property.


        /*Read-only automatic properties*/
        /*
        Sometimes we need to do ugly tricks when property is expected although we would like to go with public
        constant perhaps.Remember data and model binding mentioned before.
        Since C# 6.0 we can use automatic property initializers so we can directly assign initial value to automatic property.
        */
        public const string OfficialName = "The Very Big Corporation";
        public string CompanyName { get; } = OfficialName;

        /*
         * It seems clean and beautiful but it is actually an illusion. After building code in release mode,
         * removing program debug database and opening resulting library with decompiler we can see a little bit different code.
        */

        /*
        public class Dummy
        {
            public const string OfficialName = "The Very Big Corporation";

            [CompilerGenerated]
            private string <CompanyName>k__BackingField;
 
        public string Name
            {
                [CompilerGenerated]
                get { return < CompanyName > k__BackingField; }
            }

            public Dummy()
            {
        < CompanyName > k__BackingField = "The Very Big Corporation";
            }
        }
        */
    }
}
