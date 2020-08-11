using System;

namespace Deligate
{
    class MainClass
    {
        public static void Main(string[] args)    
        {
            Button btn = new Button();
            btn.click += Login;

            btn.Load();

            //reverse invocation
            //obj.addDeligation(OnCallBack1);
            //Console.WriteLine("Print in reverse order:");
            //obj.reverseOrderInvocation();
        }
        //The OnCallBack is the method to becalled when call back occures
        static void Login(string user_name)
        {
            Console.WriteLine($"Welcome {user_name}!");
        }
    }

    class Button
    {
        //deligation declaration
        public delegate void CallBack1(string u);

        public CallBack1 click;

        public void printDeligations()
        {
            Console.WriteLine("Invocation list has {0} methods.",
                        click.GetInvocationList().Length);
        }
        public void reverseOrderInvocation()  
        {
            for (int ctr = click.GetInvocationList().Length - 1; ctr >= 0; ctr--)
            {
                var outputMsg = click.GetInvocationList()[ctr];
                outputMsg.DynamicInvoke();
            }
        }
        //add deligation option 2
        //method that gets a deligation
        public void Load()
        {
            Console.Write("Please enter you user: ");
            string user_name = Console.ReadLine();
            click(user_name);

        }
    }
}
