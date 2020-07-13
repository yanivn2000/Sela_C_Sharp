using System;
using System.Threading.Tasks;

/*
if any process is blocked in a synchronous application,
the entire application gets blocked and our application stops responding until the whole task completes.
Asynchronous programming is very helpful in this condition.
By using Asynchronous programming, the Application can continue with
the other work that does not depend on the completion of the whole task.

We can run all the methods parallelly by using the simple thread programming
but it will block UI and wait to complete all the tasks. To come out of this problem,
we have to write too many codes in traditional programming but if we will
simply use the async and await keywords, then we will get the solutions in much less code.

*/
namespace asyncWait1
{
    class Program
    {
        static void Main(string[] args)
        {
            //In this example, we are going to take two methods, which are not dependent on each other.
            Method1();
            Method2();
            Console.ReadKey();
        }

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine(" Method 1");
                }
            });
        }


        public static void Method2()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(" Method 2*************");
            }
        }
    }
}
