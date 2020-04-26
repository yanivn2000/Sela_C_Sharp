using System;

namespace arrays
{
    class MainClass
    {

        static void Main(string[] args)
        {
            //test(args);
            //Exc1(args);
            //Exc2(args);
            //Exc3(args);
            Exc4(args);
            Console.ReadKey();
        }


        static void test(string[] args)
        {
            string newPath = @"c:\Program Files\Microsoft \\n ewfolder";// \\ -> \
            //newPath = "c:\\Program Files\\Microsoft\nVisual Studio 9.0";
            Console.WriteLine($"{newPath}");
        }

        private static void printArray(string[] array)
        {
            foreach (string number in array)
            {
                Console.Write($"{number}\t");
            }
            Console.WriteLine();
        }
        private static void printArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write($"{number}\t");
            }
            Console.WriteLine();
        }

        private static void printMultTable(int[,] array2D)
        {
            int countPrinted = 0;
            foreach (int number in array2D)
            {
                Console.Write($"{number}");
                if (++countPrinted % array2D.GetLength(1) == 0)
                    Console.WriteLine();
                else
                    Console.Write("\t");
            }
            Console.WriteLine();
        }
        static void Exc4(string[] args)
        {
            string[] nameArray = { "John", "Emma", "Tom", "Marry" };
            int[] ageArray = { 40, 20, 23, 29 };

            for (int j = 0; j < ageArray.Length - 1; j++)
            {
                for (int i = 0; i < ageArray.Length - j - 1; i++)
                {
                    if (ageArray[i] > ageArray[i + 1])
                    {
                        int temp = ageArray[i + 1];
                        ageArray[i + 1] = ageArray[i];
                        ageArray[i] = temp;

                        string tempString = nameArray[i + 1];
                        nameArray[i + 1] = nameArray[i];
                        nameArray[i] = tempString;

                    }
                }
            }
            printArray(ageArray);
            printArray(nameArray);


        }
        static void Exc3(string[] args)
        {
            int N = 5, M = 3;
            int[,] mulTable = new int[N, M];
            Random rand = new Random();
            for (int i = 0; i < N; i++)//row
            {
                for (int j = 0; j < M; j++)//cloumn
                {
                    mulTable[i, j] = rand.Next(0, 100);
                }
            }
            //Print array
            printMultTable(mulTable);

            //****Print the maximum row value*****//
            int maxRowSum = int.MinValue;
            int maxRowIndex = -1;
            for (int i = 0; i < N; i++)//row
            {
                int sumCurrentRow = 0;
                for (int j = 0; j < M; j++)//cloumn
                {
                    sumCurrentRow += mulTable[i, j];//0,0 + 0,1 + 0,2
                }
                if (maxRowSum < sumCurrentRow)
                {
                    maxRowSum = sumCurrentRow;
                    maxRowIndex = i;
                }
                Console.WriteLine($"sum of line {i + 1} is {sumCurrentRow}");
            }

            Console.WriteLine($"Max sum of row is {maxRowSum} in line {maxRowIndex + 1}");


            //****Print the minimal column*****//
            int minAvgCol = int.MaxValue;
            int minColIndex = -1;
            for (int j = 0; j < M; j++)//column
            {
                int sumCurrentCol = 0;
                for (int i = 0; i < N; i++)//row //0,0 1,0 2,0 3,0....1,0 1,1...2,1 
                {
                    sumCurrentCol += mulTable[i, j];
                }
                if (minAvgCol > sumCurrentCol / N)
                {
                    minAvgCol = sumCurrentCol / N;
                    minColIndex = j;
                }
                Console.WriteLine($"avg of col {j + 1} is {sumCurrentCol / N}");
            }
            Console.WriteLine($"Min avg of col is {minAvgCol} in line {minColIndex + 1}");

            //****Print the main Diagonal column*****//
            //N - rows, M - Cols
            int mainDiagonal = 0;
            for (int row = 0, col = 0; row < N && col < M; row++, col++)
            {
                mainDiagonal += mulTable[row, col];
            }

            //****Print the sub Diagonal column*****//
            //N - rows, M - Cols
            int subDiagonal = 0;
            for (int row = 0, col = M - 1; row < N && col >= 0; row++, col--)
            {
                subDiagonal += mulTable[row, col];
            }
            Console.WriteLine($"Main Diagonal: {mainDiagonal}");
            Console.WriteLine($"Sub Diagonal: {subDiagonal}");
            string biggerDiagonal = mainDiagonal > subDiagonal ? "Main" : "Sub";
            Console.WriteLine($"{biggerDiagonal} diagonal is the biggest one");

        }
        static void Exc2(string[] args)
        {
            int N = 0;
            Console.WriteLine("We are about to print a multiplication table");
            Console.Write($"Please enter N: ");
            int.TryParse(Console.ReadLine(), out N);
            int[,] mulTable = new int[N, N];
            for (int i = 0; i < N; i++)//row
            {
                for (int j = 0; j < N; j++)//cloumn
                {
                    mulTable[i, j] = (i + 1) * (j + 1);//i=0,j=0 -- 
                }
            }
            //print using for
            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        Console.Write($"{mulTable[i, j]}\t");
            //    }
            //    Console.WriteLine();
            //}
            //Print using foreach
            int countPrinted = 0;
            foreach (int number in mulTable)
            {
                Console.Write($"{number}");
                if (++countPrinted % N == 0)
                    Console.WriteLine();
                else
                    Console.Write("\t");
            }
        }

        static void Exc1(string[] args)
        {
            int[] array = { 333, 4, 33, 55, 23, 155, 100, 500, 400, 88 };

            //find minmal value
            int minValue = int.MaxValue; //
            foreach (int number in array)
            {
                if (minValue > number)
                    minValue = number;
            }
            Console.WriteLine($"minmum value in array is {minValue}");

            //find Max value
            int maxValue = int.MinValue; //
            foreach (int number in array)
            {
                if (maxValue < number)
                    maxValue = number;
            }
            Console.WriteLine($"maximum value in array is {maxValue}");

            //avg Max value
            int totalValue = 0; //
            foreach (int number in array)
            {
                totalValue += number;
            }
            float avgValue = (float)totalValue / array.Length;
            Console.WriteLine($"The average value of the array is {avgValue}");

            Array.Sort(array);//SORT
            foreach (int number in array)
            {
                Console.WriteLine($"number: {number}");
            }

            //array.Length // size of array
            int midIndex = array.Length / 2; // (11 or 10) / 2 = 5
            //mid + mid < Length ==> (mid + 1)
            float median = array[midIndex];
            if (array.Length % 2 == 0)
            {
                median += array[midIndex - 1];
                median /= 2;
            }
            //double median = array.Length % 2 == 0 ? 
            //    (array[array.Length / 2] + array[(array.Length / 2) - 1]) / 2 
            //    : array[array.Length / 2];
            Console.WriteLine($"The mid value of the array is {median}");


            int k = 0;
            Console.Write($"Please enter K: ");
            int.TryParse(Console.ReadLine(), out k);
            //if k > array.Length then k = array.Length
            k = k > array.Length ? array.Length : k;

            //bottom to up
            Console.WriteLine($"Print values up to {k} from bottom:");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
            Console.WriteLine($"Print last {k} values:");
            //array.Length = 10: (k=3) 7, 8, 9
            for (int i = array.Length - k; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }



        }
        static void GetLength2(string[] args)
        {
            // Two-dimensional GetLength example.
            int[,] two = new int[5, 10];
            Console.WriteLine("GETLENGTH: " + two.GetLength(0)); // Writes 5
            Console.WriteLine("GETLENGTH: " + two.GetLength(1)); // Writes 10

            // Two-dimensional Length example.
            Console.WriteLine("LENGTH: " + two.Length); // Writes 50
        }
        static void GetLength0(string[] args)
        {

            // create and initalize array 
            int[] myarray = { 445, 44, 66, 6666667, 78, 878, 1 };

            // Display the array 
            Console.WriteLine("The elements of myarray :");

            foreach (int i in myarray)
            {
                Console.WriteLine(i);
            }

            // Find the number of element in myarray 
            int result = myarray.GetLength(0);
            Console.WriteLine("Total Elements: {0}", result);

        }


        public static void ConsoleColors(string[] args)
        {
            //color array
            ConsoleColor[] colorArr = new ConsoleColor[]{
                ConsoleColor.Black, ConsoleColor.DarkBlue,
                ConsoleColor.DarkGreen,
                ConsoleColor.DarkCyan,
                ConsoleColor.DarkRed,
                ConsoleColor.DarkMagenta,
                ConsoleColor.DarkYellow,
                ConsoleColor.Gray,
                ConsoleColor.DarkGray,
                ConsoleColor.Blue,
                ConsoleColor.Green,
                ConsoleColor.Cyan,
                ConsoleColor.Red,
                ConsoleColor.Magenta,
                ConsoleColor.Yellow,
                ConsoleColor.White,
                ConsoleColor.Black,
                ConsoleColor.DarkBlue,
                ConsoleColor.DarkGreen,
                ConsoleColor.DarkCyan,
                ConsoleColor.DarkRed,
                ConsoleColor.DarkMagenta,
                ConsoleColor.DarkYellow,
                ConsoleColor.Gray,
                ConsoleColor.DarkGray,
                ConsoleColor.Blue,
                ConsoleColor.Green,
                ConsoleColor.Cyan,
                ConsoleColor.Red,
                ConsoleColor.Magenta,
                ConsoleColor.Yellow,
                ConsoleColor.White
            };

            Random rand = new Random();
            int max = colorArr.Length;
            while (true)
            {
                int color_picked;
                string input;
                do
                {
                    Console.WriteLine($"Please enter a number between 0 to {max - 1}: ");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out color_picked) || color_picked < 1 || color_picked > max);
                Console.ForegroundColor = colorArr[color_picked];
            }

        }
    }
}
