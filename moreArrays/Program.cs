using System;
using System.Linq;

namespace MoreArray
{
    class Program
    {

        /** LEARN FUNCTION **/
        //learning function that return value
        public static int IncreaseByOneNotRef(int num)
        {
            return ++num;
        }
        //learning ref
        public static void IncreaseByOne(ref int num)
        {
            num++;
        }
        //learning out
        public static void SetValueTo10(out int num)
        {
            num = 10;
        }
        //test functions
        public static void TestFunc(string[] args)
        {
            int number = 5;
            Console.WriteLine($"Number before is: {number}");
            number = IncreaseByOneNotRef(number);
            Console.WriteLine($"Number before is: {number}");
            IncreaseByOne(ref number);
            Console.WriteLine($"Number after is: {number}");
            SetValueTo10(out number);
            Console.WriteLine($"Number after is: {number}");
            int.TryParse("13", out number);

        }
        /*********************************************************/

        public static void Exc6(string[] args)
        {
            int[] arr5 = { 7, 6, 9, 10, 11, 15, 16, 12, 5, 6, 7, 8, 9, 7, 2, 3, 4 };
            PrintIntArray(arr5);

            int starting_index = 0; //start index of largest sequnce
            int current_number, max_sequence = 0;
            //running on arr5 (START WITH 1)
            for (int i = 0, current_seq_size = 1; i < arr5.Length - 1; i++)
            {
                current_number = arr5[i];//current value checked
                int next_number = arr5[i + 1];//this is the next value
                if (current_number + 1 == next_number)
                {
                    current_seq_size++;
                    //if we are in the largest sequence on numbers
                    if (max_sequence < current_seq_size)
                    {
                        max_sequence = current_seq_size;
                        starting_index = (i + 1) - (current_seq_size - 1);//update starting index
                    }
                }
                else
                {
                    current_seq_size = 1;//reset current sequnce
                }
            }
            int[] longest_seq = new int[max_sequence];//create array 
            for (int i = starting_index, j = 0; i < starting_index + max_sequence; i++, j++)
            {
                longest_seq[j] = arr5[i];
            }

            Console.WriteLine($"\nmax seq has {max_sequence} values, starting index is {starting_index}");
            PrintIntArray(longest_seq);
        }

        /** Function that creates arandom array **/
        public static int[] CreateArrayWithRandomNumbers(int size, int from, int to)
        {
            int[] array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(from, to);
            }
            return array;
        }
        /** Function that prints array **/
        public static void PrintIntArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        /** Function that check if item in array **/
        public static bool Contains(int[] arr, int item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == item) return true;
            }
            return false;
        }

        /** Exc **/
        public static void Exc5(string[] args)
        {

            int ARR_SIZE = 50;
            int MINVAL_EXR5 = 1, MAXVAL_EXR5 = 100;

            int[] arr1 = new int[ARR_SIZE];
            int[] arr2 = new int[ARR_SIZE];
            bool[] isRolled = new bool[MAXVAL_EXR5 + 1]; // dont use o place, default is false
            Random rnd = new Random();
            int counter = 0;

            for (int i = 0; i < ARR_SIZE; i++)
            {
                arr1[i] = rnd.Next(MINVAL_EXR5, MAXVAL_EXR5 + 1);
                arr2[i] = rnd.Next(MINVAL_EXR5, MAXVAL_EXR5 + 1);
            }
            Console.WriteLine("arr1: ");
            //printArr(arr1);
            Console.WriteLine("arr2: ");
            //printArr(arr2);
            for (int i = 0; i < ARR_SIZE; i++)
            {
                //check if value exists in array
                if (Contains(arr2, arr1[i]) && !isRolled[arr1[i]])
                {
                    counter++;//add 1 to counter
                    //Turn ON the flag in the value position
                    //e.g. if we found that value 3 is in both array we turn on
                    //the array in position 3
                    isRolled[arr1[i]] = true;
                }
            }


            Console.WriteLine($"in 2 arrays we have {counter} numbers same");

        }

        //
        //string s - input of the string to check
        //output - return true if polindrom otherwise return false
        //s=abccka
        private static bool isPolindrom(string s)
        {
            int i, j;
            for (i = 0, j = s.Length - 1; i < j && s[i] == s[j]; i++, j--) ;
            return (i >= j);
        }

        public static void Exc4(string[] args)
        {
            string input = "amddma";
            if (isPolindrom(input))
            {
                Console.WriteLine($"The string {input} is polindrom");
            }
            else
            {
                Console.WriteLine($"The string {input} is NOT polindrom");
            }

        }
        public static void Exc3(string[] args)
        {
            //create array in size of 100
            int arraySize = 20;
            int[] originalArray = new int[arraySize];

            //set the array with randome numbers between 0 to 1000
            Random rand = new Random();
            int evenTotal = 0, oddTotal = 0;
            for (int i = 0; i < arraySize; i++)
            {
                originalArray[i] = rand.Next(0, 100);
                if (originalArray[i] % 2 == 0)
                    evenTotal++;
                else
                    oddTotal++;
            }

            //the size of array1 and array2 is exactelly like the values in side.
            int[] evenArray = new int[evenTotal];
            int[] oddArray = new int[oddTotal];

            //set all the even numbers to evenArray
            //set all the odd numbers to oddArray
            int indexOdd = 0, indexEven = 0;
            for (int i = 0; i < arraySize; i++)
            {
                if (originalArray[i] % 2 == 0)
                    evenArray[indexEven++] = originalArray[i];
                else
                    oddArray[indexOdd++] = originalArray[i];
            }

            Console.WriteLine($"There are {evenTotal} even numbers:");
            for (int i = 0; i < evenTotal; i++)
            {
                Console.Write($"{evenArray[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"There are {oddTotal} odd numbers:");
            for (int i = 0; i < oddTotal; i++)
            {
                Console.Write($"{oddArray[i]} ");
            }
        }

        public static void Exc2(string[] args)
        {
            //init array
            int[] arr = { 1, 1, 10, 9, 9, 7, 7, 19, 4, 4 };

            //counter - set to 0
            int countOfPairs = 0;
            //loop on array and check if there are pairs
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    countOfPairs++;
                }
            }
            Console.WriteLine($"number of pairs is: {countOfPairs}");

            countOfPairs = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    countOfPairs++;
                }
            }
            Console.WriteLine($"number of pairs is: {countOfPairs}");
        }
        public static void Exc1(string[] args)
        {

            int arrSize = 100, num;
            int[] arr = new int[arrSize];

            bool isNum;
            Random rand = new Random();

            //Initilize array
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 21);//set random number into arr in position i
            }

            //read from user
            do
            {
                Console.WriteLine("Please enter num between 1-20");
                isNum = int.TryParse(Console.ReadLine(), out num);
            } while (!isNum || num > 20 || num < 1);

            //Here we have a user number between 1-20

            //Find how many times isNum in array
            int cntNumPick = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    cntNumPick++;//do something
                }
            }

            Console.WriteLine();
            Console.WriteLine($"The number of times of {num} is: {cntNumPick}");

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



        /*
        public static void ConsoleColorChange(string[] args)
        {
            //color array
            ConsoleColor[] colorArr = new ConsoleColor[]{
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
       */
    }
