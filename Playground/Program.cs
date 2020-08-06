using System;

namespace w3resourceExercisesLoop
{
    class MainClass
    {
        //https://www.w3resource.com/csharp-exercises/for-loop/index.php
        public static void Main(string[] args)
        {
            string[] words = new string[5];//0...9...
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine("Insert a word: ");
                string value = Console.ReadLine();
                words[i] = value;
            }

            Console.WriteLine();
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{words[i]}");
            }

            //Main23();

        }

        //23. Write a program in C# Sharp to display the sum of the series [ 1+x+x^2/2!+x^3/3!+....]. Go to the editor
        public static void Main22()
        {
            int repeat = 10;

            for (int i = 0; i < repeat; i++) //10 lines
            {
                for (int j = i+1; j > 0; j--)
                {
                    Console.Write($"{j % 2}"); //1(1) 2(0) 3(1) 4(0)
                }
                Console.WriteLine();
            }
        }
        //24. Write a program in C# Sharp to find the sum of the series [ x - x^3 + x^5 - x^7 + x^9 -.....]. Go to the editor
        public static void Main23()
        {
            int repeat, x;
            Console.Write("Pleasae enter x: ");
            string value = Console.ReadLine();
            int.TryParse(value, out x);
            Console.Write("Please enter repeation: ");
            value = Console.ReadLine();
            int.TryParse(value, out repeat);

            int sum = 0;
            int pow = 1;
            for (int i = 0; i < repeat; i++) //repeat = 4 -> 1, 3, 5, 7
            {
                //1->1, 2->3, 3->5, 4->7, 5->9
                sum += (i%2 == 0) ? (int)Math.Pow(x,pow) : -1*(int)Math.Pow(x, pow);
                pow += 2;
            }
            Console.WriteLine($"The sum of x {x} and repeat {repeat} is {sum}");
        }

    }
}
