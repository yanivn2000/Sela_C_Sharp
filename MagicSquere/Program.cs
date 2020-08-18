using System;

namespace MagicSquere
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            layers1();
        }
        public static void distance()
        {
            int row = 7, cols = 8;
            int[,] arr = new int[row, cols];
            int tmp = arr.GetLength(0);


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    //int shortest_distance_to_border = ????
                    tmp = arr.GetLength(0);
                    if (i < tmp)
                        tmp = i + 1;
                    if (j < tmp)
                        tmp = j + 1;
                    if ((arr.GetLength(0) - i) < tmp)
                        tmp = arr.GetLength(0) - i;
                    if ((arr.GetLength(1) - j) < tmp)
                        tmp = arr.GetLength(1) - j;
                    arr[i, j] = tmp;

                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
            }

        }

        public static void layers1()
        {
            int row = 5, cols = 15;
            int[,] array = new int[row, cols];
            int num = 1;

            while (num - 1 <= row - num)
            {
                for (int i = num - 1; i <= array.GetLength(0) - num; i++)//תורים
                {
                    for (int j = num - 1; j <= array.GetLength(1) - num; j++)//שורות
                    {
                        array[i, j] = num;
                    }
                }
                num++;
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }

        }
    }
}