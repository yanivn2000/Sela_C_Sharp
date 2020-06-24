using System;

namespace CompareInterfaces
{
    class MainClass
    {
        static void Main(string[] args)
        {
            // Create an arary of car objects.
            car[] arrayOfCars = new car[6]
            {
            new car("Ford",1992, "Red"),
            new car("Fiat",1988, "Blue"),
            new car("Buick",1932, "Green"),
            new car("Ford",1932, "Brawn"),
            new car("Dodge",1999, "Black"),
            new car("Honda",1977, "Yellow")
            };

            // Write out a header for the output.
            Console.WriteLine("Array - Unsorted\n");

            foreach (car c in arrayOfCars)
                Console.WriteLine(c.Manufecturer + "\t\t" + c.Year);

            // Demo IComparable by sorting array with "default" sort order.
            //sortYearAscendingHelper(arrayOfCars);
            //Console.WriteLine("\nArray - Sorted by Make (Ascending - IComparable)\n");

            Array.Sort(arrayOfCars);
            Console.WriteLine("\nArray - default Sort\n");

            foreach (car c in arrayOfCars)
                Console.WriteLine(c.Manufecturer + "\t\t" + c.Year);

            // Demo ascending sort of numeric value with IComparer.
            //car.sortYearAscending() - returns an object of a class that inherits IComparer
            Array.Sort(arrayOfCars, car.sortYearAscending());
            Console.WriteLine("\nArray - Sorted by Year (Ascending - IComparer)\n");

            foreach (car c in arrayOfCars)
                Console.WriteLine(c.Manufecturer + "\t\t" + c.Year);

            // Demo descending sort of string value with IComparer.
            //car.sortMakeDescending() - returns an object of a class that inherits IComparer
            Array.Sort(arrayOfCars, car.sortMakeDescending());
            Console.WriteLine("\nArray - Sorted by Make (Descending - IComparer)\n");

            foreach (car c in arrayOfCars)
                Console.WriteLine(c.Manufecturer + "\t\t" + c.Year);

            // Demo descending sort of numeric value using IComparer.
            //car.sortYearDescending() - returns an object of a class that inherits IComparer
            Array.Sort(arrayOfCars, car.sortYearDescending());
            Console.WriteLine("\nArray - Sorted by Year (Descending - IComparer)\n");

            foreach (car c in arrayOfCars)
                Console.WriteLine(c.Manufecturer + "\t\t" + c.Year);

            Array.Sort(arrayOfCars, car.sortColorAscending());
            Console.WriteLine("\nArray - Sorted by Color (Ascending - IComparer)\n");
            foreach (car c in arrayOfCars)
                Console.WriteLine(c.Manufecturer + "\t\t" + c.Color);


            Console.ReadLine();
        }
    }
}
