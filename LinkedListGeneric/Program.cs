using System;

namespace LinkedListGeneric
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            Console.WriteLine("List 2: Add to first");
            linkedList.AddFirst("Hey");
            linkedList.AddFirst("My");
            linkedList.AddFirst("name");
            linkedList.AddFirst("is");
            linkedList.AddFirst("John");
            Console.WriteLine("Print forward:");

            linkedList.printAllNodes();
            //Console.WriteLine("Print backward:");
            //linkedList.printAllNodesBackward();

            //Node <string> node = linkedList.RemoveFirstNode();
            //Console.WriteLine($"First node removed {node.data}");

            Console.WriteLine("Print forward:");
            linkedList.printAllNodes();

            Console.WriteLine("List 2: Add to last");
            LinkedList<string> linkedListLast = new LinkedList<string>();
            linkedListLast.AddLast("Word");
            linkedListLast.AddLast("last");
            linkedListLast.AddLast("the");
            linkedListLast.AddLast("is");
            linkedListLast.AddLast("This");
            Console.WriteLine("Print forward:");
            linkedListLast.printAllNodes();
            Console.WriteLine("Print backward:");
            linkedListLast.printAllNodesBackward();


            Console.WriteLine("Get all values using the method Next");
            string value;
            while(linkedList.Next(out value))
            {
                Console.WriteLine($"Value: {value}");
            }
        }
    }
}
