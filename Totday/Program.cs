using System;

namespace Today
{
    class MainClass
    {

        static DateTime TodaysDate()
        {
            DateTime date = DateTime.Now;
            return date;
        }

        //Previous Day Date    

        static DateTime AddDayDate(int change)
        {
            DateTime date = DateTime.Now.AddDays(change);
            return date;
        }
        public static void Main(string[] args)
        {
            DateTime today = TodaysDate();
            int day = today.Day;
            int month = today.Month;
            int year = today.Year;
            Console.WriteLine($"Day {day}, Month {month}, Year {year}");

            DateTime tomorrow = AddDayDate(1);
            Console.WriteLine($"Day {tomorrow.Day}, Month {tomorrow.Month}, Year {tomorrow.Year}");


            Console.WriteLine($"Today Format yyyy MMMM {today.ToString("yyyy MMMM")}");

        }

    }

}
