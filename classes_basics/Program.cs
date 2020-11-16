using System;

namespace classes_basics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //DateTime today = DateTime.Now;
            int day;
            int month;
            int year;

            int toContinue;
            do
            {
                //get a date from the user
                Console.WriteLine("Please enter a date: ");

                Console.WriteLine("Day: ");
                int.TryParse(Console.ReadLine(), out day);
                Console.WriteLine("Month: ");
                int.TryParse(Console.ReadLine(), out month);
                Console.WriteLine("Year: ");
                int.TryParse(Console.ReadLine(), out year);

                //create an instance of a date
                Date date1 = new Date(day, month, year);
                //check if the date is valid
                if (date1.isValid())
                    Console.WriteLine($"Date is valid: {date1}");
                else
                    Console.WriteLine($"Date is invalid!");
                //add 1 days to the date
                Date nextDate = date1.GetNextDay();
                if (nextDate != null)
                    Console.WriteLine($"Next date is: {nextDate}");

                //add 5 days to the date
                Date next5Date = date1.GetNextDays(5);
                if(nextDate != null)
                    Console.WriteLine($"5 days after is: {next5Date}");


                Console.WriteLine("Enter 1 to quit, or enter to continue:");
                int.TryParse(Console.ReadLine(), out toContinue);

            } while (toContinue != 1);

        }

    }

    class Date
    {
        private int _day;
        private int _month;
        private int _year;
        //props
        /*
        public int Day { get { return _day; } set { _day = value; } }
        public int Month { get { return _month; } set { _month = value; } }
        public int Year { get { return _year; } set { _year = value; } }
        */

        //ctor
        public Date(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }
        //to string
        public override string ToString()
        {
            //MM.d.yyyy
            return $"{_day}.{_month}.{_year}";
        }
        //add days to the date
        public Date GetNextDays(int days)
        {
            if (isValid())            {                Date nextDay = new Date(_day, _month, _year);                //add day by day                for (int i = 0; i < days; i++)
                {
                    nextDay._day += 1;//add 1 day
                    if (!nextDay.isValid())//in case of day overflow
                    {
                        nextDay._day = 1;//reset day to 1
                        nextDay._month += 1;//add 1 to the month
                        if (!nextDay.isValid())//in case of month overflow
                        {
                            nextDay._month = 1;//rest month to 1
                            nextDay._year += 1;//add 1 to year
                        }
                    }
                }                return nextDay;            }            return null;
        }
        //return the following date
        //in case the date is invalid the method returns null
        public Date GetNextDay()        {            if (isValid())            {                //THIS IS NOT OPTIMIZED                 Date nextDay = new Date(_day, _month, _year);                nextDay._day += 1;//add 1 day                if (!nextDay.isValid())//in case of day overflow                {                    nextDay._day = 1;//reset day to 1                    nextDay._month += 1;//add 1 to the month
                    if (!nextDay.isValid())//in case of month overflow
                    {
                        nextDay._month = 1;//rest month to 1
                        nextDay._year += 1;//add 1 to year
                    }                }                return nextDay;//return the next day            }            return null;//return null when date is invalid        } 
        //return false in case the date is invalid
        //and return true when it is valid
        public bool isValid()
        {
            //year 1970+9999
            if (_year < 1970 || _year > 9999)
                return false;

            //day
            switch (_month)
            {
                case 2:
                    {
                        if (_year % 100 == 0)
                            if (_day < 1 || _day > 28)
                                return false;//day is invalid
                        else if (_year % 4 == 0)
                        {
                            if (_day < 1 || _day > 29)
                                return false;//day is invalid
                        }
                        else
                        {
                            if (_day < 1 || _day > 28)
                                return false;//day is invalid
                        }
                        break;
                    }
                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        if (_day < 1 || _day > 30)
                            return false;//day is invalid
                        break;
                    }
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        if (_day < 1 || _day > 31)
                            return false;//day is invalid
                        break;
                    }
                default:
                    return false;//month is invalid
            }

            return true;
        }
    }
}
