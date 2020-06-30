using System;

namespace ArraySortIndex
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 19, 9, 22, 12, 33, 8, 99, 0, 22 };
            int[] arrIndex = GetSortedArrayIndex(arr);
            foreach (var item in arrIndex)
            {
                Console.Write($"{item} ");
            }
        }

        static int[] GetSortedArrayIndex(int[] arr)        {
            int temp, maxVal;            int[] arrIndex = new int[arr.Length];            for (int i = 0; i < arr.Length; i++)            {                arrIndex[i] = i;            }
            //loop array
            //All the idea is that the value apears in arr[arrIndex[i]]
            //Meaning that when we need to read the value we do arr[arrIndex[i]]
            //And when we want the index of the value in the original array we do arrIndex[i]
            for (int i = 0; i < arr.Length - 1; i++)            {                maxVal = arr[arrIndex[i]];
                for (int j = i + 1; j < arr.Length; j++)                {                    if (arr[arrIndex[j]] >= maxVal)                    {                        maxVal = arr[arrIndex[j]];                        temp = arrIndex[i];                        arrIndex[i] = arrIndex[j];                        arrIndex[j] = temp;
                    }                }            }            return arrIndex;        }
    }
}
