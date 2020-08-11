using System;

namespace Deligate
{
    class MainClass
    {
        public static void Main(string[] args)    
        {
            Form form = new Form();
            /*4*/
            form.submit += Login;
            /*4*/
            form.submit += Navigate;

            form.OnSubmit();

        }
        //The OnCallBack is the method to becalled when call back occures
        static void Login(string user_name)
        {
            Console.WriteLine($"Welcome {user_name}!");
        }
        //The OnCallBack is the method to becalled when call back occures
        static void Navigate(string user_name)
        {
            Console.WriteLine($"{user_name}, you are now on the dashboard!");
        }
    }

    class Form
    {
        //deligation declaration
        /*1*/ public delegate void Submit(string u);//Click is a type of deligate: void (string)

        /*2*/ public Submit submit;

        //The method that will execute the submit
        /*3*/public void OnSubmit()
        {
            Console.Write("Please enter you user: ");
            string user_name = Console.ReadLine();
            submit(user_name);

        }
    }
}
