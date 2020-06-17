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
public class car : IComparable
{
    // Beginning of nested classes.

    // Nested class to do ascending sort on year property.
    private class sortYearAscendingHelper : IComparer
    {
        int IComparer.Compare(object a, object b)
        {
            car c1 = (car)a;
            car c2 = (car)b;

            if (c1.year > c2.year)
                return 1;

            if (c1.year < c2.year)
                return -1;

            else
                return 0;
        }
    }

    // Nested class to do descending sort on year property.
    private class sortYearDescendingHelper : IComparer
    {
        int IComparer.Compare(object a, object b)
        {
            car c1 = (car)a;
            car c2 = (car)b;

            if (c1.year < c2.year)
                return 1;

            if (c1.year > c2.year)
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
            return String.Compare(c2.make, c1.make);
        }
    }

    // End of nested classes.

    private int year;
    private string make;

    public car(string Make, int Year)
    {
        make = Make;
        year = Year;
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public string Make
    {
        get { return make; }
        set { make = value; }
    }

    // Implement IComparable CompareTo to provide default sort order.
    int IComparable.CompareTo(object obj)
    {
        car c = (car)obj;
        return String.Compare(this.make, c.make);
    }

    // Method to return IComparer object for sort helper.
    public static IComparer sortYearAscending()
    {
        return (IComparer)new sortYearAscendingHelper();
    }

    // Method to return IComparer object for sort helper.
    public static IComparer sortYearDescending()
    {
        return (IComparer)new sortYearDescendingHelper();
    }

    // Method to return IComparer object for sort helper.
    public static IComparer sortMakeDescending()
    {
        return (IComparer)new sortMakeDescendingHelper();
    }

}
}
