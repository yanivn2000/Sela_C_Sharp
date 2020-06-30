using System;

namespace ObjectOriented1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Vehicle [] vehicles = new Vehicle[5];
            vehicles[0] = new FormulaCar(
                6,
                "red",
                "Mecedes",
                "F1",
                1000,
                380,
                8,
                1000,
                200,
                false);
            vehicles[1] = new FormulaCar(
                5,
                "white",
                "Macleren",
                "F1",
                1100,
                370,
                7,
                1000,
                200,
                false);
            vehicles[2] = new FormulaCar(
                7,
                "Black & Red",
                "Red bull",
                "F1",
                990,
                367,
                8,
                1000,
                200,        
                false);

            vehicles[3] = new FormulaCar(
                7,
                "White",
                "Whilmas",
                "F1",
                880,
                345,
                8,
                1200,
                200,
                false);


            vehicles[4] = new FormulaCar(
                7,
                "Black",
                "Hyundai",
                "i10",
                500,
                280,
                5,
                67,
                200,
                false);

            Address address = new Address("Monco", "Monte Carlo");
            Track track = new Track(address, 3000, 12, "road", 5500, 4);
            Showdown showdown = new Showdown(track, 1000, 20, vehicles);

            showdown.StartRace();
            showdown.PrintResults();
            //Console.WriteLine(showdown);


        }
    }
}
