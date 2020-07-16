using System;
namespace LinkedListGeneric
{
    public class LinkedList<T>
    {
        private Node<T> first;
        private Node<T> last;
        private Node<T> current;

        public void AddFirst(T data)
        {
            Node<T> toAdd = new Node<T>(data);
            // traverse all nodes (see the print all nodes method for an example)
            if (first == null)
            {
                last = toAdd;
            }
            else
            {
                toAdd.next = first;
                first.pre = toAdd;
            }
            first = toAdd;
            current = first;
        }
        public void AddLast(T data)
        {
            Node<T> toAdd = new Node<T>(data);
            // traverse all nodes (see the print all nodes method for an example)
            if (first == null)
            {
                first = toAdd;
            }
            else
            {
                last.next = toAdd;
                toAdd.pre = last;
            }
            last = toAdd;
            current = first;
        }
        public Node<T> RemoveFirstNode()
        {
            Node<T> firstNode = first;
            first = first.next;
            first.pre = null;
            current = first;
            return firstNode;
        }
        public Node<T> RemoveLastNode()
        {
            Node<T> lastNode = last;
            last = last.pre;
            last.next = null;
            current = first;
            return lastNode;
        }
        public void printAllNodes()
        {
            Node<T> current = first;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
        public void printAllNodesBackward()
        {
            Node<T> current = last;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.pre;
            }
        }
        public bool Next(out T value)
        {
            if (current != null)
            {
                value = current.data;
                current = current.next;
                return true;
            }
            else
            {
                value = default(T);
                return false;
            }
        }
    }
}
