using System;

namespace Variable1
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int a = 6;
            int b = a++ + a++;

            Console.WriteLine(b);
            Console.WriteLine(b);

            //Test1();
            //Test2();
            //TestRead();
            //SecondsBreakdown();
            //popsicles();
        }
        public static void popsicles()
        {
            Console.WriteLine("Please enter the number of popsicles: ");
            int numOfPopsicles = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number of popsicles in box: ");
            int numOfPopsiclesInBox = int.Parse(Console.ReadLine());

            Console.WriteLine($"The number of full boxes is: {numOfPopsicles / numOfPopsiclesInBox}");
            Console.WriteLine($"The number of leftovers is: {numOfPopsicles % numOfPopsiclesInBox}");
        }
        public static void SecondsBreakdown()
        {
            int days, hours, minutes, seconds;
            int secondsInDay = 86400, secondsInHour = 3600, secondsInMinute = 60;

            Console.WriteLine("Please enter the number of seconds:");
            seconds = int.Parse(Console.ReadLine());
            days = seconds / secondsInDay;
            seconds = seconds % secondsInDay;
            hours = seconds / secondsInHour;
            seconds = seconds % secondsInHour;
            minutes = seconds / secondsInMinute;
            seconds = seconds % secondsInMinute;
            Console.WriteLine("Days: " + days + ", Hours: " + hours + ",Minutes: " + minutes + ", Seconds: " + seconds);
        }
        public static void TestRead()
        {
            float f = 21.5F;
            Console.WriteLine($"{f} mod 10 = {f % 10}");


            string input1, input2;

            Console.Write("Hello, please enter number 1: ");
            input1 = Console.ReadLine();
            Console.Write("Hello, please enter number 2: ");
            input2 = Console.ReadLine();

            //"123" - > 123 (int)
            //"123.44 -> 123.44 (float)

            byte number1 = byte.Parse(input1);//input1 = "123" --> number1 = 13
            byte number2 = byte.Parse(input2);

            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");

        }

        public static void TestBool()
        {
            bool isAccountActive = false;
            Console.WriteLine($"Your account status is {isAccountActive}");

            isAccountActive = true;
            Console.WriteLine($"Your account status is {isAccountActive}");

        }
        public static void TestChar()
        {
            char c = 'A';

        }
        public static void Test2()
        {
            int age = 44;
            age = age + 10;
            string str = $"I am {age} years old";
            str = str + " .Bye";
            Console.WriteLine(str);
        }

        //public static void Main(string[] args)
        public static void Test1()
        {
            int testNumber = 1;
            int number1;
            int number2;
            float result;

            string hey = $"Welcome to test number: {testNumber}";
            Console.WriteLine(hey);

            number1 = 45;
            number2 = 12;

            //add (+)
            result = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {result}");

            //minus (-)
            result = number1 - number2;
            Console.WriteLine($"{number1} - {number2} = {result}");

            //Mult (*)
            result = number1 * number2;
            Console.WriteLine($"{number1} * {number2} = {result}");

            //div (/)
            result = number1 / number2;
            //int MEM = (float)number1 / number1
            //result = MEM
            Console.WriteLine($"{number1} / {number2} = {result}");
        }

    }
}
