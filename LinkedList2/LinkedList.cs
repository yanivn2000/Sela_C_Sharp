using System;
namespace LinkedListObject
{
    public class LinkedList
    {
        private Node start;
        private Node end;
        public void AddFirst(Object data)
        {
            Node toAdd = new Node();
            toAdd.data = data;
            // traverse all nodes (see the print all nodes method for an example)
            if (start == null)
            {
                end = toAdd;
            }
            else
            {
                toAdd.next = start;
                start.pre = toAdd;
            }
            start = toAdd;
        }
        public void AddLast(Object data)
        {
            Node toAdd = new Node();
            toAdd.data = data;
            // traverse all nodes (see the print all nodes method for an example)
            if (end == null)
            {
                end = toAdd;
                start = toAdd;
            }
            else
            {
                end.next = toAdd;
                toAdd.pre = end;
                end = toAdd;
            }
        }
        public void printAllNodes()
        {
            Node current = start;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
        public void printAllNodesBackward()
        {
            Node current = end;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.pre;
            }
        }
    }
}
