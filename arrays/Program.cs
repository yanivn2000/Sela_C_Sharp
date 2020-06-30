using System;

namespace Today
{
    class MainClass
    {

        static void Main(string[] args)
        {

            Exc11(args);
            //Exc12(args);
            //Exc13(args);
            //Exc14(args);
            //Exc15(args);
            Console.ReadKey();
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
                {
                    isPolyndrom = false;
                }
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
