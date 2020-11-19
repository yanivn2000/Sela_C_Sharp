using System;

namespace Today
{
    class Calc
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

    }
    class MainClass
    {
        static void CreateRandomArray2D(int [,] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(1, 100);
                }
            }
        }


        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void ArrayOfArray()
        {
            string a = "hello dear students";
            char[] letters = a.ToCharArray();
            letters[6] = 'D';
            Console.WriteLine(a[0]);

            string alphabet = new string(letters);

            double[,] y = new double[5, 10];

            double[] x1 = new double[5];
            double[][] x = new double[5][];

            x[0] = new double[10];
            x[1] = new double[9];
            x[2] = new double[8];
            x[3] = new double[7];
            x[4] = new double[5];

            x[3][2] = 10;
        }
        static void Main(string[] args)
        {

            /*
            int a = 10, b = 5 ;
            Console.WriteLine($"a: {a}, b {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"a: {a}, b {b}");
            */

            /*
            int[,] array = new int[4, 5];
            CreateRandomArray2D(array);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
            */
            /*
            //int [3,4]
            int[,] gameBoard = { { 1, 2, 3, 4}, { 2, 3, 5, 16 }, { 5, 8, 6, 4 } };
            Console.WriteLine(gameBoard.Length);
            //gameBoard.GetLength(0) - number of rows (3)
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                //gameBoard.GetLength(1) - number of cols (4)
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    Console.Write($"{gameBoard[i, j]}\t");
                }
                Console.WriteLine();
            }


            //Max value from each row
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                int maxRow = int.MinValue;
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    if (maxRow < gameBoard[i, j])
                        maxRow = gameBoard[i, j];
                }
                Console.WriteLine($"The max value in row {i} is {maxRow}");
            }

            //Sum of each row
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                int sumRow = 0;
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    sumRow += gameBoard[i, j];
                }
                Console.WriteLine($"The sum value in row {i} is {sumRow}");
            }

            //Sum of each column
            for (int i = 0; i < gameBoard.GetLength(1); i++)
            {
                int sumCol = 0;
                for (int j = 0; j < gameBoard.GetLength(0); j++)
                {
                    sumCol += gameBoard[j, i];
                }
                Console.WriteLine($"The sum value in col {i} is {sumCol}");
            }
            */

            /*

            int[] arr = { 5, 55, 99, 98, 13, 77, 80, 50 };

            //Bubble sort
            BubbleSort(arr);
            Console.WriteLine($"Sorted: {string.Join(", ", arr)}");

            Console.WriteLine($"Search for 55: {BinarySearch(arr, 55)}");
            Console.WriteLine($"Search for 80: {BinarySearch(arr, 80)}");
            Console.WriteLine($"Search for 56: {BinarySearch(arr, 56)}");
            */



            /*
            Random rand = new Random();
            int arraySize = 10;
            int[] arr1 = new int[arraySize];
            int[] arr2 = new int[arraySize];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rand.Next(100, 200);
                arr2[i] = rand.Next(0, 10);
            }
            //arr1 = 100\t   150,    167
            //arr2 = 0,     6,      8
            //arr3 = 100,   156,    175
            int[] arr3 = new int[arraySize];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i] + arr2[i];
            }
            Console.WriteLine($"arr1\tarr2\tarr3");

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine($"{arr1[i]}\t{arr2[i]}\t{arr3[i]}");
            }
            */
            /*
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Please neter a number: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            //print the bigest number in the array


            //Calculate the sum of the array
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                //check if arr[i] is divided by 2
                if(arr[i] % 2 == 0)
                    sum += arr[i];
            }
            //calculate the average
            Console.WriteLine($"The sum of the all the even elements in the array is {sum}");
            //Console.WriteLine($"The average of the {arr.Length} elements in the array is {sum / arr.Length}");
            */
            /*

            const int numberOfMonths = 100;

            Random rand = new Random();

            //create array of 50 int
            int arraySize = 10;
            int[] arrayInt2 = new int[arraySize];
            //set random values into the array
            for (int i = 0; i < arrayInt2.Length; i++)
            {
                arrayInt2[i] = i;
            }
            Console.WriteLine("print array from beginning to end");
            for (int i = 0; i < arrayInt2.Length; i++)
            {
                Console.WriteLine(arrayInt2[i]);
            }
            Console.WriteLine("print array from end to beginning");
            for (int i = arrayInt2.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arrayInt2[i]);
            }
            */


            //forEach();
            //Exc11(args);
            //Exc12(args);
            //Exc13(args);
            //Exc14(args);
            //Exc15(args);
            Console.ReadKey();
        }

        public static int BinarySearch(int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (key == arr[mid])
                    return mid;
                else if (key < arr[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return -1;
        }

        static void BubbleSort(int []arr)
        {
            int temp;
            for (int j = 0; j < arr.Length - 1; j++)//
            {
                //bubble up the largest element
                for (int i = 0; i < arr.Length - 1 - j; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
        public static void MaxNumArray(int[] r) //get the max num in array
        {            int location = 0, maxnum = int.MinValue;            for (int i = 0; i < r.Length; i++)            {                if (maxnum < r[i])                {                    maxnum = r[i];                    location = i;                }            }            Console.WriteLine($" The max num is {maxnum} in location {location}");        }
        static void forEach()
        {


            string name = "Yaniv Nuriel";

            foreach (char item in name)
            {
                Console.WriteLine($"{item}");
            }

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"{name[i]}");
            }


            int[] arr1 = { 1, 4, 5, 2, 3, 7, 1 };
            foreach (int number in arr1)
                Console.WriteLine($"{number}");

            Console.WriteLine("Array start pow .....");

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr1[i] * arr1[i];
            }
            Console.WriteLine("Array end pow .....");

            Console.WriteLine("Array after pow");
            foreach (int number in arr1)
                Console.WriteLine($"{number}");

        }
        static void Fibonaci()
        {            
            int[] arrys1 = new int[30];            arrys1[0] = 0;            arrys1[1] = 1;            //build            for (int i = 2; i < arrys1.Length; i++)            {                arrys1[i] = arrys1[i - 2] + arrys1[i - 1];            }            //print            for (int i = arrys1.Length - 1; i > 0; i--)            {                Console.Write($"{arrys1[i]}  ");            }

        }
        static void Main88()
        {
            int[] a = new int[50];            int[] ab = new int[50];            Random r = new Random();
            int count = 0;
            for (int i = 0; i < 50; i++)            {                a[i] = r.Next(100);                ab[i] = r.Next(100);            }            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    if(a[i] == ab[j])
                    {
                        count++;
                        //break;
                    }
                }
            }            Console.WriteLine($"We have found {count} identical items on both arrays");            /*            for (int i = 0; i < a.Length; i++)            {                if (ab.Contains(a[i]))                {                    Console.WriteLine(a[i]);                }            }*/
        }
        //•	לבנות מערך בגודל 100 של מספרים אקראים בטווח של 1-20, לקלוט מספר בין 1-20 מהמשתמש ולספור כמה פעמים המספר נמצא במערך
        static void Exc11(string[] args)
        {
            //Create an array of 100
            int[] arr = new int[100];
            //int size = 100;
            //create Random generator
            Random rand = new Random();
            //fill the array with random numbers between 1-20
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 21);
            }

            int number;
            do
            {
                Console.Write($"Please enter a number between 1-20: ");
                //} while ((!int.TryParse(Console.ReadLine(), out number)) || (!(number >= 1 && number <= 20)));
                //} while (int.TryParse(Console.ReadLine(), out number) == false || number < 1 || number > 20);
            } while (!(int.TryParse(Console.ReadLine(), out number) && (number >= 1 && number <= 20)));


            int counter = 0;
            foreach (int num in arr)
            {
                if (num == number) counter++;
            }

            foreach (int num in arr)
            {
                Console.Write($"{num}\t");
            }
            Console.WriteLine($"You number is {number} and it exits {counter} time in the array");

        }
        //•	לבנות מערך של מספרים אקראים שלמים ולספור כמה ערכים זוגיים ואיזוגיים יש במערך. לבנות עוד 2 מערכי עזר לערך זוגיים בלבד ולערכים האי זוגיים בלבד – כל אחד בגודל המתאים ולמלא אותם בערכים בהתאמה
        static void Exc12(string[] args)
        {

            //Create an array of 100
            int[] arr = new int[100];
            //int size = 100;
            //create Random generator
            Random rand = new Random();
            //fill the array with random numbers between 1-100
            int oddCounter = 0, evenCoutner = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);
                if (arr[i] % 2 == 0) // even
                    evenCoutner++;
                else
                    oddCounter++;
            }

            //create odd and even array
            int[] arrEven = new int[evenCoutner];
            int[] arrOdd = new int[oddCounter];

            int indexEven = 0, indexOdd = 0;
            foreach (int item in arr)//arr = {5 7 3} ==> arr[0] = 5, arrp[1] = 7
            {
                if (item % 2 == 0)
                    arrEven[indexEven++] = item;
                else
                    arrOdd[indexOdd++] = item;
            }

            //print arrays
            //Print even array:
            Console.WriteLine($"Even Array size: {evenCoutner}");
            //printArray(arrEven,5);
            int index = 0;
            foreach (int num in arrEven)
            {
                Console.Write($"{num}\t");
                if (++index % 5 == 0)
                    Console.WriteLine();
            }

            Console.WriteLine();


            Console.WriteLine($"Odd Array size: {oddCounter}");
            printArray(arrOdd, 5);

        }

        //Palindrome
        static void Exc13(string[] args)
        {
            string str = "AbcFcbA";
            bool isPolyndrom = true;

            for (int i = 0, j = str.Length - 1; i < j && isPolyndrom; i++, j--)
            {
                if (str[i] != str[j])
                    isPolyndrom = false;
            }                                                                                                                                                                   

            if (isPolyndrom)
                Console.WriteLine($"String {str} is Polyndrom");
            else
                Console.WriteLine($"String {str} is not Polyndrom");
        }

        static void Exc14(string[] args)
        {
            int[] arr1 = { 1, 4, 5, 2, 3, 7, 1 };
            int[] arr2 = { 3, 3, 6, 2, 2, 7, 1 };
            int[] arrCommon = new int[100];

            int indexCommon = 0;
            foreach (var item1 in arr1)
            {
                foreach (var item2 in arr2)
                {
                    //if found
                    if (item1 == item2)
                    {
                        bool isFoundAlready = false;
                        //check if we already found this number (if we did we do not count it again)
                        foreach (var item3 in arrCommon)
                        {
                            if (item1 == item3)
                            {
                                isFoundAlready = true;
                                break;//break here because we found that this number was already found in the past
                            }
                        }
                        //check if number found already
                        if (isFoundAlready == false)
                        {
                            arrCommon[indexCommon++] = item1;//update the found array with this new value and increase counter by 1
                        }
                        break;//anyway we want to break here from loop #2
                    }
                }
            }

            Console.WriteLine($"The number of existed values in arr1 and arr2 is {indexCommon}");
            for (int i = 0; i < indexCommon; i++)
            {
                Console.WriteLine($"{arrCommon[i]}, ");
            }


        }

        public static void Exc15(string[] args)
        {
            int[] arr5 = { 7, 6, 9, 10, 11, 15, 16, 12, 5, 6, 7, 8, 9, 7, 2, 3, 4 };
            printArray(arr5);

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
            printArray(longest_seq);
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
            foreach (int num in array)
            {
                Console.Write($"{num}\t");
            }

            Console.WriteLine();
        }
        private static void printArray(int[] array, int lineSize)
        {
            int index = 0;
            foreach (int num in array)
            {
                Console.Write($"{num}\t");
                if (++index % lineSize == 0)
                    Console.WriteLine();
            }

            Console.WriteLine();
        }
    }

}
