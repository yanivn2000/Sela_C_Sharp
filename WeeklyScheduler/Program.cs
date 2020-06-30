using System;

namespace WeeklyScheduler
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class WeeklyWork
    {
        public const int num_of_hours_per_day = 24;
        enum Days
        {
            Sun,
            Mon,
            Tue,
            Wed,
            Thu,
            Fri,
            Sat,
            NUMBER_OF_DAYS = Sat,
        }
        Emplyee? [,] schedule;
        public WeeklyWork()
        {
            schedule = new Emplyee [(int)Days.NUMBER_OF_DAYS + 1, num_of_hours_per_day];

            for (int i = 0; i <= (int) Days.NUMBER_OF_DAYS; i++)
            {
                for (int j = 0; j < num_of_hours_per_day; j++)
                {
                    schedule[i,j] = null;
                }
            }
        }

    }
    public class Emplyee
    {
        public int id { get; set; }
        public string name { get; set; }

        public Emplyee(int n_id, string n_name)
        {
            id = n_id;
            name = n_name;
        }
        public override string ToString()
        {
            return $"Emplyee id {id}, name {name}";
        }
    }
}
