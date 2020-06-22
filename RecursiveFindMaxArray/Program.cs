using System;

namespace RecursiveFindMaxArray
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] a = {3,11,22,14,5,16,7,18};
            Console.WriteLine($"The max value of array is: {findMax(a, a.Length - 1)}");
            Console.WriteLine($"The min value of array is: {findMin(a, a.Length - 1)}");
            Console.WriteLine($"The max distance of array is: {findMaxDistance(a, a.Length - 1)}");
            Console.WriteLine($"The min distance of array is: {findMinDistance(a, a.Length - 1)}");
            Console.WriteLine($"The total distance of array is: {findTotalDistance(a, a.Length - 1)}");
        }

        public static int findMax(int[] a, int index)
        {
            if (index > 0) {
                int currentNumber = a[index];
                int max = findMax(a, index - 1);//index = 3 (1-1 = 0)
                max =  Math.Max(currentNumber, max);//a[index] = max =3
                return max;
            }
            else
                return a[index];//end of array
        }
        public static int findMin(int[] a, int index)
        {
            if (index > 0)
            {
                int max = findMin(a, index - 1);//index = 3 (1-1 = 0)
                return Math.Min(a[index], max);//a[index] = max =3
            }
            else
                return a[index];//end of array
        }
        public static int findMaxDistance(int[] a, int index)
        {
            if (index > 1)
            {
                int distance = findMaxDistance(a, index - 1);
                return Math.Max(Math.Abs(a[index]- a[index-1]), distance);
            }
            else
                return Math.Abs(a[index] - a[0]);//22 10 or 10 22 ====> 12 |X|
        }
        public static int findMinDistance(int[] a, int index)
        {
            if (index > 1)
            {
                int distance = findMinDistance(a, index - 1);
                return Math.Min(Math.Abs(a[index] - a[index - 1]), distance);
            }
            else
                return Math.Abs(a[index] - a[0]);//22 10 or 10 22 ====> 12 |X|
        }
        public static int findTotalDistance(int[] a, int index)
        {
            if (index > 1)
            {
                int distance = findTotalDistance(a, index - 1);
                return distance + Math.Abs(a[index] - a[index - 1]);
            }
            else
                return Math.Abs(a[index] - a[0]);//22 10 or 10 22 ====> 12 |X|
        }
        //
    }
}
