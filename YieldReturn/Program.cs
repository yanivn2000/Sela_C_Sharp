using System;

/*
 * A yield return statement can't be located in a try-catch block.
 * A yield return statement can be located in the try block of a try-finally statement.
 * */
namespace YieldReturn
{
    public class PowersOf2
    {
        static void Main()
        {
            // Display powers of 2 up to the exponent of 8:
            /*
             * The following example has a yield return statement that's inside a for loop.
             * Each iteration of the foreach statement body in the Main method creates a call to the Power iterator function.
             * Each call to the iterator function proceeds to the next execution of the yield return statement,
             * which occurs during the next iteration of the for loop.
             */
            foreach (int i in Power(2, 8))
            {
                Console.Write("{0} ", i);
            }
        }
        //The return type of the iterator method is IEnumerable, 
        public static System.Collections.Generic.IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                yield return result;
            }
        }

        // Output: 2 4 8 16 32 64 128 256
    }
}
