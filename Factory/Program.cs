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
        Drink[] _drinks = new Drink[(int)Drink.DRINKS.LAST];
        public void AddDrinks()
        {
            _drinks[Coffee.code] = new Coffee();
            _drinks[Tea.code] = new Tea();
            _drinks[Espresso.code] = new Espresso();
            _drinks[HotChocolate.code] = new HotChocolate();
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
        public enum DRINKS {Coffee, Tea, Espresso, HotChocolate, LAST}

        protected string _name;
        public string Prepare()
        {
            return _name;
        }
    }

    class Coffee : Drink
    {
        public static int code = (int)Drink.DRINKS.Coffee;
        public Coffee()
        {
            _name = "Coffee";
        }
    }
    class Tea : Drink
    {
        public static int code = (int)Drink.DRINKS.Tea;
        public Tea()
        {
            _name = "Tea";
        }
    }
    class Espresso : Drink
    {
        public static int code = (int)Drink.DRINKS.Espresso;
        public Espresso()
        {
            _name = "Espresso";
        }
    }
    class HotChocolate : Drink
    {
        public static int code = (int)Drink.DRINKS.HotChocolate;
        public HotChocolate()
        {
            _name = "Hot Chocolate";
        }
    }
}
