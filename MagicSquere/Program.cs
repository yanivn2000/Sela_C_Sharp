using System;

namespace MagicSquere
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            //distance();
            layers1();
        }
        //Yorai
        public static void distance()
        {
            int row = 10, cols = 5;
            int[,] arr = new int[row, cols];
            int MaxMetrixLength = Math.Max(arr.GetLength(0), arr.GetLength(1));

            for (int i = 0; i < arr.GetLength(0); i++)//row
            {
                for (int j = 0; j < arr.GetLength(1); j++)//col
                {
                    //Ofek
                    arr[i, j] = Math.Min(Math.Min(j, i), Math.Min(cols - 1 - j, row - 1 - i));                     /*
                    //get the max length 
                    int tmp = MaxMetrixLength;
                    if (i < tmp)//if the current row is smaller than the MaxMetrixLength
                        tmp = i + 1;//the current row + 1 (because we start from 0)
                    if (j < tmp)//if thew current col is smaller than tmp
                        tmp = j + 1;//the current col + 1 (because we start from 0)
                    if ((arr.GetLength(0) - i) < tmp)//check right
                        tmp = arr.GetLength(0) - i;
                    if ((arr.GetLength(1) - j) < tmp)//check bottom
                        tmp = arr.GetLength(1) - j;
                    arr[i, j] = tmp;
                    */
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }

        }

        //Ofek
        public static void layers1()
        {
            int row = 5, col = 15;            int minLen = Math.Min(row, col);            int[,] ar = new int[row, col];            int counter = 1;            int i, j;             while (counter <= minLen/2 +1)            {                for (i = counter - 1; i <= row - counter; i++)                {                    for (j = counter - 1; j <= col - counter; j++)                    {                        ar[i, j] = counter;                    }                }                counter++;
            }            for (int l = 0; l < ar.GetLength(0); l++)            {                for (int k = 0; k < ar.GetLength(1); k++)                {                    Console.Write(ar[l, k] + " ");                }                Console.WriteLine();            }

        }

    }
}
