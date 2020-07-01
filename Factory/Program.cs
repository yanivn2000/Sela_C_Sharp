using System;

namespace Factory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Manager manager = new Manager();
            
            manager.AddDrinks();
            manager.Start();

        }

    }

    class Manager
    {
        Drink[] _drinks = new Drink[3];
        public void AddDrinks()
        {
            _drinks[Coffee.code] = new Coffee();
            _drinks[Tea.code] = new Tea();
            _drinks[Espresso.code] = new Espresso();
        }
        public void Start()
        {
            while (true)
            {
                Console.WriteLine($"Please select drink (0, {_drinks.Length-1}):");//0 coffee 1 tea
                int drink;
                int.TryParse(Console.ReadLine(), out drink);

                string drink_ready = _drinks[drink].Prepare();
                Console.WriteLine($"Drink is ready: {drink_ready}");
            }
        }
    }
    class Drink
    {
        protected string _name;
        public string Prepare()
        {
            return _name;
        }
    }
    class Coffee : Drink
    {
        public static int code = 0;
        public Coffee()
        {
            _name = "Coffee";
        }
    }
    class Tea : Drink
    {
        public static int code = 1;
        public Tea()
        {
            _name = "Tea";
        }
    }
    class Espresso : Drink
    {
        public static int code = 2;
        public Espresso()
        {
            _name = "Espresso";
        }
    }
}
