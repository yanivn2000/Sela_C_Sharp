using System;

namespace arrays
{
    class MainClass
    {
        public static void Main(string[] args)
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
