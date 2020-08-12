using System;
using System.Collections.Generic;
using System.Text;

namespace GraphD
{
    class Linked_List
    {
        Node start = null;
        Node end = null;
       
        public void AddFirst(int value) //O(1)
        {
            Node n = new Node(value);
            n.next = start;
            start = n;

            //update end in case of empty list
            if (end == null) end = n;
            //if(start.next == null) end = n;
        }

        public bool RemoveFirst(out int removedValue)  // O(1)
        {
            removedValue = 0;
            if (start == null) return false;

            removedValue = start.data;
            start = start.next;
            //if removed item is a last item - update the end
            if (start == null) end = null;
            return true;
        }

        public void AddLast(int value) //O(1)
        {
            if (start == null)
            {
                AddFirst(value);
                return;
            }

            Node n = new Node(value);
            end.next = n;
            end = n;
        }

        private void AddLast_bad(int value) //O(n)
        {
            if (start == null)
            {
                AddFirst(value);
                return;
            }

            Node n = new Node(value);
            Node tmp = start;
            while (tmp.next != null) tmp = tmp.next;

            tmp.next = n;
        }

        //public bool RemoveLast(out int removedValue)  // O(??)
        //{
        //}

        public override string ToString() 
        {
            StringBuilder sb = new StringBuilder();
            Node tmp = start;
            while(tmp != null)
            {
                sb.AppendLine(tmp.data.ToString());
                tmp = tmp.next;
            }

            return sb.ToString();
        }

        class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                next = null;
            }
        }
    }
}


