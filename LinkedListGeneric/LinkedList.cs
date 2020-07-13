using System;
namespace LinkedListGeneric
{
    public class LinkedList<T>
    {
        private Node<T> start;
        private Node<T> end;
        public void AddFirst(T data)
        {
            Node<T> toAdd = new Node<T>(data);
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
        public Node<T> RemoveFirstNode()
        {
            Node<T> firstNode = start;
            start = start.next;
            start.pre = null;
            return firstNode;
        }
        public Node<T> RemoveLastNode()
        {
            Node<T> lastNode = end;
            end = end.pre;
            end.next = null;
            return lastNode;
        }
        public void AddLast(T data)
        {
            Node<T> toAdd = new Node<T>(data);
            // traverse all nodes (see the print all nodes method for an example)
            if (end == null)
            {
                start = toAdd;
            }
            else
            {
                end.next = toAdd;
                toAdd.pre = end;
            }
            end = toAdd;

        }
        public void printAllNodes()
        {
            Node<T> current = start;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
        public void printAllNodesBackward()
        {
            Node<T> current = end;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.pre;
            }
        }
    }
}
