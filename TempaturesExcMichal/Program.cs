using System;

namespace TempaturesExcMichal
{
    class MainClass
    {
        static float FirstFunc(params float[] degrees)
        {
            float sum = 0;
            foreach (float degree in degrees)
            {
                sum += degree;
            }
            return sum / degrees.Length;
        }
        static string SecondFunc(float degree)
        {
            string res = "";
            if (degree > 15)
            {
                res = $"too high!";
            }
            else if (degree < 15)
            {
                res = "too low!";
            }
            else if (degree == 15)
            {
                res = "OK";
            }
            return $"The tempeture is {degree} and it's {res}";
        }

        static void Main(string[] args)
        {
            //take in the values
            Console.Write("Please enter the first temperature: ");
            float d1 = float.Parse(Console.ReadLine());

            Console.Write("Please enter the second temperature: ");
            float d2 = float.Parse(Console.ReadLine());

            Console.Write("Please enter the third temperature: ");
            float d3 = float.Parse(Console.ReadLine());

            //call the first static method
            float avgDegree = FirstFunc(d1, d2, d3);

            //call the second static method
            Console.WriteLine(SecondFunc(avgDegree));


            //if time permits:

            //ConsoleColor Enum
            //ConsoleColor currentColor = Console.ForegroundColor;
            ConsoleColor currentColor = ConsoleColor.Black;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Im Red... :)");

            Console.ForegroundColor = currentColor;
            Console.WriteLine("now im not... :(");

            //MessageBox
            Console.WriteLine($"This temperature was measured Today: {DateTime.Now}");


        }
    }
}

