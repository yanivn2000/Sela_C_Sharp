using System;
using System.Threading.Tasks;


namespace Lock1
{
   class Program
    {
        static private readonly object runLock = new object();
        static int X;
        static bool flag = true;
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            

            //In this example, we are going to take two methods, which are not dependent on each other.
            //Task a = Method1("first method");
            //Task b = Method1("second method!!!!!!!!!!!!!!!!!!!!!!!");
            //Task.WaitAll(a, b);

            Task a = Ping();
            Task b = Pong();
            Task.WaitAll(a, b);
            //not in tasks
            //Method2("first method");
            //Method2("second method!!!!!!!!!!!!!!!!!!!!!!!");


            // the code that you want to measure comes here
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine($"X: {X}");
            Console.WriteLine($"The tasks took {elapsedMs} ms");

            //Console.ReadKey();

            //Run();
        }
        //Executes loop of 1000 in a Task
        public static async Task Ping()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 1000;)
                {
                    lock (runLock)
                    {
                        if (flag) {
                            Console.WriteLine($" Ping =======>      0 ) ) ) ");
                            i++;
                            flag = false;
                        }
                    }
                }
            });

        }
        //Executes loop of 1000 in a Task
        public static async Task Pong()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 1000;)
                {
                    lock (runLock)
                    {
                        if (!flag)
                        {
                            Console.WriteLine($"\t\t\t( ( ( 0       <====== Pong");
                            i++;
                            flag = true;
                        }
                    }
                }
            });

        }
        //Executes loop of 1000 in a Task
        public static async Task Method1(string word)
        {
            await Task.Run(() =>
            {
                lock (runLock)
                {
                    for (int i = 0; i < 100000; i++)
                    {
                        Console.WriteLine($" Method {word}");
                        X++;
                    }
                }

            });

        }

        //Executes loop of 1000 in a Task
        public static async Task Method2(string word)
        {
            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine($" Method {word}");
                X++;
            }
        }
        async static void Run()
        {
            Task<int>[] array = new Task<int>[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = Process(i);
            }
            int[] values = await Task.WhenAll(array);

            foreach (var item in values)
            {
                Console.WriteLine($"Value: {item}");
            }
        }
        async static Task<int> Process(int test)
        {
            await Task.Run(() =>
            {
                test += 5;
            });
            return test;
        }


    }

}
