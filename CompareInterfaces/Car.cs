using System;
using System.Collections;


/*  IComparable *
 * The role of IComparable is to provide a method of comparing two objects of a particular type.
 * This is necessary if you want to provide any ordering capability for your object.
 * Think of IComparable as providing a default sort order for your objects.
 * For example, if you have an array of objects of your type, and you call the Sort method on that array,
 * IComparable provides the comparison of objects during the sort.
 * When you implement the IComparable interface, you must implement the CompareTo method.
 */

/* IComparer *גק
 * The role of IComparer is to provide additional comparison mechanisms.
 * For example, you may want to provide ordering of your class on several fields or properties,
 * ascending and descending order on the same field, or both.
 * Using IComparer is a two-step process. First, declare a class that implements IComparer, and then implement the Compare method:
*/

namespace CompareInterfaces
{
    public class car : System.IComparable
    {
        // End of nested classes.
        private int _year;
        private string _manufecturer;
        private string _color;

        // Implement IComparable CompareTo to provide default sort order.
        //-1 0 1
        int IComparable.CompareTo(object obj)
        {
            car c = (car)obj;
            int res = String.Compare(this._manufecturer, c._manufecturer);// -1 a z or +1 z a
            return res;
        }

        // Beginning of nested classes.

        // Nested class to do ascending sort on year property.
        private class sortYearAscendingHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                car c1 = (car)a;
                car c2 = (car)b;

                if (c1._year > c2._year)
                    return 1;

                if (c1._year < c2._year)
                    return -1;

                else
                    return 0;
            }
        }

        // Nested class to do descending sort on make property.
        private class sortMakeDescendingHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                car c1 = (car)a;
                car c2 = (car)b;
                return String.Compare(c2._manufecturer, c1._manufecturer);
            }
        }
        
        private class sortColorAscendingHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                car c1 = (car)a;
                car c2 = (car)b;
                return String.Compare(c1._color, c2._color);
            }
        }

        public car(string Make, int Year, string Color)
        {
            _manufecturer = Make;
            _year = Year;
            _color = Color;
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public string Manufecturer
        {
            get { return _manufecturer; }
            set { _manufecturer = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        // Method to return IComparer object for sort helper.
        public static IComparer sortYearAscending()
        {
            return new sortYearAscendingHelper();
        }

        // Method to return IComparer object for sort helper.
        public static IComparer sortYearDescending()
        {
            return new sortYearDescendingHelper();
        }

        // Method to return IComparer object for sort helper.
        public static IComparer sortMakeDescending()
        {
            return new sortMakeDescendingHelper();
        }
        // Method to return IComparer object for sort helper.
        public static IComparer sortColorAscending()
        {
            return new sortColorAscendingHelper();
        }
    }
    // NOT a nested class to do descending sort on year property.
    public class sortYearDescendingHelper : IComparer
    {
        int IComparer.Compare(object a, object b)
        {
            car c1 = (car)a;
            car c2 = (car)b;

            if (c1.Year < c2.Year)
                return 1;

            if (c1.Year > c2.Year)
                return -1;

            else
                return 0;
        }
    }
}
