﻿using System;

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
        public static void PrintBothSides2(int[] arr, int index = 0)
            {
            }

        public static void PrintBothSidesMain(int[] a)
        {
            PrintBothSides(a, 0, a.Length - 1);
        }
    }
}