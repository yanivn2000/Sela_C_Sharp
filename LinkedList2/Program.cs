using System;

namespace LinkedListObject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Console.WriteLine("List 2: Add to first");
            linkedList.AddFirst("Hey");
            linkedList.AddFirst("My");
            linkedList.AddFirst("name");
            linkedList.AddFirst("is");
            linkedList.AddFirst("John");
            Console.WriteLine("Print forward:");
            linkedList.printAllNodes();
            Console.WriteLine("Print backward:");
            linkedList.printAllNodesBackward();


            Console.WriteLine("List 2: Add to last");
            LinkedList linkedListLast = new LinkedList();
            linkedListLast.AddLast("Word");
            linkedListLast.AddLast("last");
            linkedListLast.AddLast("the");
            linkedListLast.AddLast("is");
            linkedListLast.AddLast("This");
            Console.WriteLine("Print forward:");
            linkedListLast.printAllNodes();
            Console.WriteLine("Print backward:");
            linkedListLast.printAllNodesBackward();

        }
    }
}
