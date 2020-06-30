using System;

namespace SyncAges
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] names = { "Tomer", "Emma", "John", "Guy", "Sara" };
            int[] ages = { 33, 27, 44, 23, 40 };

            int t;
            string tempName = "";
            for (int p = 0; p < ages.Length - 1; p++)
            {
                for (int i = 0; i < ages.Length - 1 - p; i++)
                {
                    if (ages[i] > ages[i + 1])
                    {
                        //sort on ages
                        t = ages[i + 1];
                        ages[i + 1] = ages[i];
                        ages[i] = t;

                        //sort names per to the ages
                        tempName = names[i + 1];
                        names[i + 1] = names[i];
                        names[i] = tempName;
                    }
                }
            }
            //print syned and sorted arrays
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"name: {names[i]}, age: {ages[i]}");
            }
        }
    }
}
