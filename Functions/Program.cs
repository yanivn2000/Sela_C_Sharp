using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exc1();
            //Exc2();
            //Exc3();
            Exc4();
        }
        //*************************  EXC 4 *************************//
        //Retrun common strings
        static void Exc4()
        {

            string[] arr1 = { "hi", "ron", "hello", "hi" };             string[] arr2 = { "hi", "ofek", "hello" };             string[] arrCom = new string[Math.Min(arr1.Length, arr2.Length)];             int counter = 0;             for (int i = 0; i < arr1.Length; i++)             {                 if (!inArray(arrCom, arr1[i]) && inArray(arr2, arr1[i]))                 {                     arrCom[counter++] = arr1[i];                 }             }             string[] finalArray = new string[counter];             for (int i = 0; i < finalArray.Length; i++)
            {
                finalArray[i] = arrCom[i];
            }              PrintArray(finalArray);          }         public static bool inArray(string[] arr, string input)         {             foreach (var item in arr)             {                 if (input == item)                 {                     return true;                 }             }             return false;         }          static void PrintArray(string [] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
        //*************************  EXC 3 *************************//
        //Find if Arrays is sorted and to which direction
        static void Exc3()
        {
            int [] array1 = { 1,2,3,4,5,4,3,2};
            bool isAsc = false;
            Console.WriteLine("Testing #1");
            PrintArray(array1);
            PrintArrayStatus(AscOrDec(array1, ref isAsc), isAsc);

            Console.WriteLine("Testing #2");
            int[] array2 = { 1, 2, 3, 4, 5};
            PrintArray(array2);
            PrintArrayStatus(AscOrDec(array2, ref isAsc), isAsc);

            Console.WriteLine("Testing #3");
            int[] array3 = { 5,4,3,2,1};
            PrintArray(array3);
            PrintArrayStatus(AscOrDec(array3, ref isAsc), isAsc);


            Console.WriteLine("Testing #4");
            int[] array4 = { 5, 5 ,5 ,5 ,5 , 5};
            PrintArray(array4);
            PrintArrayStatus(AscOrDec(array4, ref isAsc), isAsc);


        }
        static void PrintArrayStatus(bool isSorted, bool isAsc)
        {
            if(isSorted)
            {
                if(isAsc)
                    Console.WriteLine($"Array is sorted as Asc");
                else
                    Console.WriteLine($"Array is sorted as Desc");
            }
            else
            {
                Console.WriteLine($"Array is not sorted");
            }
        }

        //Method returns true is the array is sorted and false if not
        //In case the array is sorted the method insearts the sort direction into isAsc
        //If Array is sorted Ascending isAsc = true, otherwise false
        //NOTE: in case array contains the same values the function returns true and isAsk is true
        static bool AscOrDec(int[] arr, ref bool isAsc)        {            bool arrDown = false;            bool arrUp = false;            for (int i = 0; i < arr.Length - 1; i++)            {                //5,5,5,5                if (arr[i] < arr[i + 1])//desc
                {                    if (arrDown)                        return false;//array is not sorted
                    arrUp = true;                }                else if (arr[i] > arr[i + 1])//asc
                {                    if (arrUp)                        return false;//array is not sorted                    arrDown = true;                }            }            if (!arrUp && !arrDown)
            {
                isAsc = true;//I decide that array with the same values is Asc
                return true;
            }
            if (arrUp)
                isAsc = true;            else                isAsc = false;            return true;

        }
        static void PrintArray(int [] array)
        {
            foreach (int item in array)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }

        /** START OF EXC 2 **/
        //Find a substring
        static void Exc2()
        {
            string str = "Breaking Bed";
            int len = 4;
            Console.WriteLine($"The first {len} of string {str} is {MySubString(str,len)}");
        }

        static string MySubString(string s, int len)        {
            return s.Substring(0, len);        } 

        /** END OF EXC 2 **/


        /** START OF EXC 1 **/
        static void Exc1()
        {
            int number = 0;
            Console.WriteLine($"The biggest digit of {number} is {BiggestDigit(number)}");
        }          static bool IsNumberInOrder(int[] array1, ref bool isAsc)
        {
            bool isSorted = false;
            return isSorted;
        }
        //find the biggest digit in number
        static int BiggestDigit(int num)        {            int bigDig = 0;            while (num > 0)            {                bigDig = bigDig < (num % 10) ? num % 10 : bigDig;                num /= 10;            }            return bigDig;        }
        /** END OF EXC 1 **/

    }
}
