using System;

namespace LinkedListGeneric
{
    public class Node<T>
    {
        public Node<T> next;
        public Node<T> pre;
        public T data;
        public Node(T value)
        {
            data = value;
        }
        public override string ToString()
        {
            return data.ToString();
        }
    }
}
