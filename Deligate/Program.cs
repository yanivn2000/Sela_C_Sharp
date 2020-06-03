using System;

namespace Deligate
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            //Call a method and pass the OnCallBack Method to call
            obj.LongRunning(OnCallBack);
        }
        //The OnCallBack is the method to becalled when call back occures
        static void OnCallBack(int i)
        {
            Console.WriteLine(i);
        }
    }
    class MyClass
    {
        //deligation
        public delegate void CallBack(int i);
        //method that gets a deligation
        public void LongRunning(CallBack obj)
        {
            for (int i = 0; i < 1000; i++)
            {
                obj(i);
            }
        }
    }
}
