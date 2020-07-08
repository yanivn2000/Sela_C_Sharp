using System;

namespace DeligateGeneric2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SomeClass<int> obj = new SomeClass<int>();
            obj.filter += OnFilter;
            Console.WriteLine("Print in reverse order:");
            obj.Test(4);
            obj.Test(10);

            SomeClass<string> obj2 = new SomeClass<string>();
            obj2.filter += OnFilterString;
            Console.WriteLine("Print in reverse order:");
            obj2.Test("Yan");
            obj2.Test("Berkovich");
        }
        //The OnCallBack is the method to becalled when call back occures
        static bool OnFilter(int num)
        {
            return num > 5 ? true : false;
        }
        static bool OnFilterString(string i)
        {
            if (i.Length > 5) return true;
            return false;
        }
        //The OnCallBack is the method to becalled when call back occures
        static void OnCallBack2(int i)
        {
            Console.WriteLine($"OnCallBack2: {i}");
        }
        static void OnCallBack3(int i, int j)
        {
            Console.WriteLine($"OnCallBack2: {i}, {j}");
        }
    }

    class SomeClass<T>
    {
        //deligation declaration
        public delegate bool CallBack1(T i);

        public CallBack1 filter; //public bool filter(int i)

        //add deligation option 1
        public void addDeligation(CallBack1 obj)
        {
            filter += obj;

        }
        public void removeDeligation(CallBack1 obj)
        {
            filter -= obj;

        }
        public void printDeligations()
        {
            Console.WriteLine("Invocation list has {0} methods.",
                        filter.GetInvocationList().Length);
        }
        //add deligation option 2
        //method that gets a deligation
        public void Test(T test)
        {
            if (filter(test) == true)
                Console.WriteLine($"Filter for index {test} is true");
            else
                Console.WriteLine($"Filter for index {test} is false");

        }
    }
}
