using System;

namespace RecursivePrintStringBothWays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 4, 2, 66, 3, 2, 11, 3, 87 };

            PrintBothSidesMain(a);
            PrintBothSides2(a);
        }
        public static void PrintBothSides2(int[] arr, int index = 0)        {            if (index > (arr.Length - 1) / 2) return;            if (index == (arr.Length - 1) / 2)
            {                Console.WriteLine($"arr[{index}]: {arr[index]}");                return;
            }            Console.WriteLine($"arr[{index}]: {arr[index]}, arr[{arr.Length - 1 - index}]: {arr[arr.Length - 1 - index]}");            PrintBothSides2(arr, ++index);        }

        public static void PrintBothSidesMain(int[] a)
        {
            PrintBothSides(a, 0, a.Length - 1);            void PrintBothSides(int[] arr, int left, int right)            {                if (left == right)                {                    Console.WriteLine(arr[left]);                    return;                }                else if (left < right)                {                    Console.WriteLine(arr[left] + " " + arr[right]);                    PrintBothSides(arr, left + 1, right - 1);                }                return;            }
        }
    }
}
