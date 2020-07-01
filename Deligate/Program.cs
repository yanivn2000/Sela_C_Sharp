using System;

namespace Deligate
{
    class MainClass
    {
        public static void Main(string[] args)    
        {
            SomeClass obj = new SomeClass();
            obj.filter += OnFilter;
            //obj.deligated1 += OnCallBack2;
            //obj.deligated2 += OnCallBack3;
            //obj.deligated2 -= OnCallBack3;
            //Call a method and pass the OnCallBack Method to call
            //obj.addDeligation(OnCallBack1);
            //obj.printDeligations();
            //obj.addDeligation(OnCallBack2);
            //obj.printDeligations();
            //obj.removeDeligation(OnCallBack1);
            //obj.printDeligations();   
            obj.LongRunning();

            //reverse invocation
            //obj.addDeligation(OnCallBack1);
            Console.WriteLine("Print in reverse order:");
            obj.reverseOrderInvocation();
        }
        //The OnCallBack is the method to becalled when call back occures
        static bool OnFilter(int i)
        {
            return i > 5 ? true : false;
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

    class SomeClass
    {
        //deligation declaration
        public delegate bool CallBack1(int i);
        public delegate void CallBack2(int i, int j);

        public CallBack1 filter; //public bool filter(int i)
        public CallBack2 deligated2;



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
        public void reverseOrderInvocation()  
        {
            for (int ctr = filter.GetInvocationList().Length - 1; ctr >= 0; ctr--)
            {
                var outputMsg = filter.GetInvocationList()[ctr];
                outputMsg.DynamicInvoke(1);
            }
        }
        //add deligation option 2
        //method that gets a deligation
        public void LongRunning()
        {
            for (int i = 0; i < 10; i++)
            {   
                if(filter(i) == true)
                    Console.WriteLine($"Filter for index {i} is true");

                if(deligated2 != null)
                    deligated2(i, 5);
            }
        }
    }
}
