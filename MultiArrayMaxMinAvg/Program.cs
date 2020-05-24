using System;

namespace MultiArrayMaxMinAvg
{
    class MainClass
    {


        public static void Main(string[] args)
        {
            //int [5,4]
            int[,] array = { { -33, -22, -44, -11 }, { 1, 2, 3, 4 }, { 9, 8, 6, 3 }, { 87, 35, 21, 22 }, { 87, 5, 21, 22 } };

            int counter = 0;
            foreach (var number in array)
            {
                Console.Write($"{number}\t");
                if(++counter % array.GetLength(1) == 0)
                    Console.WriteLine();
            }

            /*another way to print 2D array
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i,j]} \t");
                }
                Console.WriteLine();
            }
            */

            //GETS THE MAX SUM LINE
            int maxLineSum = int.MinValue, maxLineIndex = 0;
            for (int r = 0; r < array.GetLength(0); r++)
            {
                int lineSum = 0;
                for (int c = 0; c < array.GetLength(1); c++)
                {
                    lineSum += array[r, c];
                }
                if (lineSum > maxLineSum)
                {
                    maxLineSum = lineSum;
                    maxLineIndex = r;
                }
            }

            Console.WriteLine($"Max Line is line {maxLineIndex+1} and its value is {maxLineSum}");

            //GETS THE MIN AVG COLUMN
            float columAvr = 0;            int minColAvgIndex = 0;            float columMinAvr = float.MaxValue;
            for (int c = 0; c < array.GetLength(1); c++)            {                int columSum = 0;
                for (int r = 0; r < array.GetLength(0); r++)                {                    columSum += array[r, c];
                }                columAvr = (float) columSum / array.GetLength(0);                if (columAvr < columMinAvr)                {                    columMinAvr = columAvr;                    minColAvgIndex = c;                }            }
            Console.WriteLine($"Min Avg column line {minColAvgIndex + 1} and its value is {columMinAvr}");


            //CHECK IF PRIMERY Diagonal is greater than the SECONDERY Diagonal
            int mainDiagonal = 0, subDiagonal = 0;
            for (int i = 0; i < array.GetLength(0); i++)            {                if (i >= array.GetLength(1)) break;                mainDiagonal += array[i, i];                subDiagonal += array[i, array.GetLength(1) - 1 - i];            }

            Console.WriteLine($"Main diagonal sum is {mainDiagonal} and secondery diagonal value is {subDiagonal}");

        }

    }
}
