using System;

namespace BubbleSort
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Exc1();

        }
        public static void Exc1()
        {
            int[] a = { 11, -5, 13, 33, 3, 0, 2, 5, -1, 4, 1, 88 };
            Console.WriteLine("Original array :");
            foreach (int aa in a)
                Console.Write(aa + " ");

            //int k = 5;
            float avg;
            float mediant;
            int k = 1000;
            int[] b = new int[k];
            int[] c = new int[k];

            Work1(a, out avg, out mediant, k ,b, c);

            Console.WriteLine("\n" + "Sorted array :");
            foreach (int aa in a)
                Console.Write(aa + " ");
            Console.WriteLine();

            Console.WriteLine($"The average is {avg}");
            Console.WriteLine($"The mediant is {mediant}");


        }
        public static void Work1(int [] a, out float avg, out float mediant, int k, int[] smallest, int[] biggest)
        {
            //AVG
            int total = 0;
            foreach (var item in a)
            {
                total += item;
            }
            avg = total / (float)a.Length;

            //Now sort (bubble)
            int t;
            for (int p = 0; p < a.Length - 1; p++)
            {
                for (int i = 0; i < a.Length - 1 - p; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
            }

            //Find the mediant
            if (a.Length % 2 != 0)// 7: 0 1 2 3 4 5 6 ==> 7/2
                mediant = a[a.Length / 2];
            else{//in case the array has even number of elements
                //8 ==> 0 1 2 3 4 5 6 7 ==> (8/2 + 8/2 -1) / 2
                mediant = (a[a.Length / 2] + a[a.Length / 2 - 1]) / 2F;
            }

            //check if k is greater than the array size.
            int fixedK = k;
            if (k > a.Length)
                fixedK = a.Length;

            //get the k smallest values and put them in b
            for (int i = 0; i < fixedK; i++)
            {
                smallest[i] = a[i];
            }

            //get the k largest values and put them in c
            for (int i = a.Length - fixedK; i < a.Length; i++) // 1 3 55 88 99 (k=3)
            {
                biggest[i - (a.Length - fixedK)] = a[i];
            }

        }
        public static void BubblelSort(int[] a)
        {
            int t;
            for (int p = 0; p < a.Length - 1; p++)
            {
                for (int i = 0; i < a.Length - 1 - p; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
            }

        }
    }
}
