using System;

/*
 * The "as" operator perform conversions between compatible types.
 * It is like a cast operation and it performs only reference conversions, nullable conversions, and boxing conversions.
 * The as operator can't perform other conversions, such as user-defined conversions,
 * which should instead be performed by using cast expressions.
 */


// Classes 
class Y { }
class Z { }

namespace AsOperator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // creating and initializing object array 
            object[] o = new object[5];
            o[0] = new Y();
            o[1] = new Z();
            o[2] = "Hello";
            o[3] = 4759.0;
            o[4] = null;

            for (int q = 0; q < o.Length; ++q)
            {

                // using as operator 
                string str1 = o[q] as string;

                Console.Write("{0}:", q);

                // checking for the result 
                if (str1 != null)
                {
                    Console.WriteLine("'" + str1 + "'");
                }
                else
                {
                    Console.WriteLine("Is is not a string");
                }
            }
        }
        /*
         * Output
        0: 'jack'
        1: This is not a string!
        */
    }
}
