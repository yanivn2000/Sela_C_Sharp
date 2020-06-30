using System;

namespace Enum
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine($"{Season.Autumn}");

            string str = $"{Days.Friday}";
            string str1 = Days.Friday.ToString();

            //c = 0x00001010 = 10
            //a = 0x00000001 = 1
            //b = 0x00000010 = 2
            //M = a & b = 0x00000011 = 3 = 1 | 2 = 3
            //N = c & a = 0x00000000
            //K = b & c = 0x00000010
            //L = b | a = 0x00001011

            Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday; //0x00010101

            Console.WriteLine(meetingDays);
            // Output:
            // Monday, Wednesday, Friday

            if((meetingDays & Days.Monday) == Days.Monday) //0x10011011 | 0x00000001 = 0x00000001 (Monday)
            {
                Console.WriteLine("Yes you have a meeting on Monday");
            }

            Days workingFromHomeDays = Days.Thursday | Days.Friday;
            Console.WriteLine($"Join a meeting by phone on {meetingDays & workingFromHomeDays}");
            // Output:
            // Join a meeting by phone on Friday

            bool isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;
            Console.WriteLine($"Is there a meeting on Tuesday: {isMeetingOnTuesday}");
            // Output:
            // Is there a meeting on Tuesday: False

            var a = (Days)37;
            Console.WriteLine(a);
            // Output:
            // Monday, Wednesday, Saturday

            Random rand = new Random();
            int num = rand.Next((int)Season.FIRST, (int)Season.LAST+1);
            Console.WriteLine($"Random season: {(Season)num}");
            //More testing:
            Console.WriteLine($"Random season: {(Season)0}");
            Console.WriteLine($"Random season: {(Season)1}");
            Console.WriteLine($"Random season: {(Season)2}");
            Console.WriteLine($"Random season: {(Season)3}");
            Console.WriteLine($"Random season: {Season.Autumn}");

        }
    }
    enum Season
    {
        Spring,
        FIRST = Spring,
        Summer,
        Autumn,
        Winter,
        LAST = Winter
    }
    enum ErrorCode : ushort
    {
        None = 0,
        Unknown = 1,
        ConnectionLost = 100,
        OutlierReading = 200
    }
    //bit
    public enum Days
    {
        None = 0b_0000_0000,  // 0
        Monday = 0b_0000_0001,  // 1
        Tuesday = 0b_0000_0010,  // 2
        Wednesday = 0b_0000_0100,  // 4
        Thursday = 0b_0000_1000,  // 8
        Friday = 0b_0001_0000,  // 16
        Saturday = 0b_0010_0000,  // 32
        Sunday = 0b_0100_0000,  // 64
        Weekend = Saturday | Sunday // 0b_0010_0000 | 0b_0100_0000 = 0b_0110_0000
    }


    enum Colors { Red = 1, Green = 2, Blue = 4, Yellow = 8 };

}
