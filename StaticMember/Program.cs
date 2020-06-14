using System;

namespace StaticMember
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            RandomProducer randProducer = new RandomProducer(100);
            Console.WriteLine($"Retrieve a number: {randProducer.GetRandnumber()}");
            Console.WriteLine($"Retrieve a number: {randProducer.GetRandnumber()}");
            Console.WriteLine($"Retrieve a number: {randProducer.GetRandnumber()}");
            Console.WriteLine($"Retrieve a number: {randProducer.GetRandnumber()}");

            RandomProducer randProducer2 = new RandomProducer(200);
            Console.WriteLine($"Retrieve a number: {randProducer2.GetRandnumber()}");
            Console.WriteLine($"Retrieve a number: {randProducer2.GetRandnumber()}");

            //Object counter
            Console.WriteLine($"randProducer counter is {randProducer.ObjectCounter}");
            Console.WriteLine($"randProducer2 counter is {randProducer2.ObjectCounter}");
            //Static
            Console.WriteLine($"RandomProducer counter is {RandomProducer.GlobalCounter}");

        }
    }

    class RandomProducer
    {
       
        Random rand;
        //Static counter
        public static int GlobalCounter { get; set; } //RandomProducer.coutner
        //Per object counter
        public int ObjectCounter { get; set; } //RandomProducer.coutner
        public RandomProducer(int seed)
        {
            rand = new Random(seed);
        }


        public int GetRandnumber()
        {
            GlobalCounter++;//increase the static counter
            ObjectCounter++;//increase the object counter
            return rand.Next(0, 100);
        }
    }
}
