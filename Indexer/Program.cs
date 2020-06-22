using System;

/*
 * Indexers are a syntactic convenience that enable you to create a class, struct, or interface
 * that client applications can access just as an array. Indexers are most frequently implemented
 * in types whose primary purpose is to encapsulate an internal collection or array. For example,
 * suppose you have a class TempRecord that represents the temperature in Fahrenheit as recorded
 * at 10 different times during a 24 hour period.
 * The class contains an array temps of type float[] to store the temperature values.
 * By implementing an indexer in this class, clients can access the temperatures in a
 * TempRecord instance as float temp = tr[4] instead of as float temp = tr.temps[4].
 * The indexer notation not only simplifies the syntax for client applications;
 * it also makes the class and its purpose more intuitive for other developers to understand.
 */
namespace Indexer
{
    /*
     * The following example shows how to declare a private array field, temps, and an indexer.
     * The indexer enables direct access to the instance tempRecord[i].
     * The alternative to using the indexer is to declare the array as a public member and access its members, tempRecord.temps[i], directly.
     * Notice that when an indexer's access is evaluated, for example, in a Console.Write statement, the get accessor is invoked.
     * Therefore, if no get accessor exists, a compile-time error occurs.
     * */
    class TempRecord
    {
        // Array of temperature values
        private float[] temps = new float[10] { 56.2F, 56.7F, 56.5F, 56.9F, 58.8F,
                                            61.3F, 65.9F, 62.1F, 59.2F, 57.5F };

        // To enable client code to validate input
        // when accessing your indexer.
        public int Length
        {
            get { return temps.Length; }
        }
        // Indexer declaration.
        // If index is out of range, the temps array will throw the exception.
        public float this[int index]
        {
            get
            {
                return temps[index];
            }

            set
            {
                temps[index] = value;
            }
        }
        //second signiture
        public float this[int index, int index2]
        {
            get
            {
                return temps[index];
            }

            set
            {
                temps[index] = value;
            }
        }
    }
    class MainClass
    {
        static void Main()
        {
            TempRecord tempRecord = new TempRecord();
            // Use the indexer's set accessor
            //tempRecord.temps[3] = 58.3F;
            tempRecord[3] = 58.3F;
            tempRecord[5] = 60.1F;

            // Use the indexer's get accessor
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Element #{0} = {1}", i, tempRecord[i]);
            }

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
    /* Output:
            Element #0 = 56.2
            Element #1 = 56.7
            Element #2 = 56.5
            Element #3 = 58.3
            Element #4 = 58.8
            Element #5 = 60.1
            Element #6 = 65.9
            Element #7 = 62.1
            Element #8 = 59.2
            Element #9 = 57.5
        */
}
