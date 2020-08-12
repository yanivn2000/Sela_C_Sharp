using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace GraphD
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph();
            var paths = g.FindAllPaths(2, 5);
        }
        /*
        static void Main_Hash(string[] args)
        {
            int size = 100000, n;
            Hash_SeparateChaining<string, int> h = new Hash_SeparateChaining<string, int>(size);
            Random r = new Random();
            int cnt = 0;

            for (int i = 0; i < size; i++)
            {
                try
                {
                    n = r.Next();
                    h.Add( n.ToString(), n);
                }
                catch(ArgumentException)
                {
                    cnt++;
                }
            }
            h.Add( "1", 1);
        }
        */

        /*
        static void Main_bst(string[] args)
        {            

            //BST<Glass> bst = new BST<Glass>();
            //bst.Add(new Glass("My big pink mug", "Porcelain", 450, 25.9F));
            //bst.Add(new Glass("L plastic cup", "plastic", 220, 1.2F));
            //bst.Add(new Glass("disposable cup", "paper", 200, 0.25F));
            //bst.Add(new Glass("green mug", "Porcelain", 370, 10.0F));
            //bst.Add(new Glass("simple glass", "glass", 180, 3.5F));
            //bst.Add(new Glass("cup", "aluminum", 250, 8.20F));
            //bst.Add(new Glass("beer mug", "glass", 800, 30.0F));
            //bst.Add(new Glass("XL plastic cup", "plastic", 320, 2.2F));
            //bst.Add(new Glass("S plastic cup", "plastic", 120, .90F));

            //bst.ScanInOrder(Console.WriteLine);
            ////bst.ScanInOrder(Glass.UpdatePrice);
            //bst.ScanInOrder((g) => g.capacity -= 100);
            //Console.WriteLine("\n\n\n");
            //bst.ScanInOrder(Console.WriteLine);


            Random r = new Random();
            BST<int> intBst = new BST<int>();
            int size = 1000000;
            for (int i = 0; i < size; i++)
            {
                //intBst.Add(r.Next(size * 5));
                intBst.Add(i);
            }

            Console.WriteLine(intBst.GetDepth());

        }
        */


        /*
        static void Main__(string[] args)
        {
            Stack_List<string> stack1 = new Stack_List<string>();
            stack1.Push("A");
            stack1.Push("B");
            stack1.Push("C");
            Console.WriteLine(stack1); // C  B  A


            string item;
            if (stack1.Pop(out item)) //C
            {
                Console.WriteLine(item);
            }

            if (stack1.Pop(out item)) // B
            {
                Console.WriteLine(item);
            }

            stack1.Push("D");
            Console.WriteLine(stack1); // D, A
        }
        */
        /*
        static void Main_lists(string[] args)
        {
            //Linked_List<int> lst1 = new Linked_List<int>();
            //lst1.AddFirst(1);
            //lst1.AddLast(2);

            //int cnt;
            //bool ifFloorExists = lst1.GetAt(2, out cnt);
            ////ifFloorExists - true/false
            ////cnt - value of iten at position nm. 2


            //Linked_List<string> lst2 = new Linked_List<string>();
            //lst2.AddFirst("aa");

            Linked_List<double> barsList = new Linked_List<double>();
            Linked_List<char> letters = new Linked_List<char>();

        }
        */
        /*
        static void Main_sorts(string[] args)
        {
            int size = 1000000;
            Random r = new Random();
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(size * 5);
                //  Console.Write($"{arr[i]} ");
            }
            DateTime startTime = DateTime.Now;
            Sorts.QuickSort(arr); //NlonN
            Console.WriteLine("=================================\n");
            Sorts.QuickSort(arr); //N^2
            DateTime endTime = DateTime.Now;
            Console.WriteLine("\n\n");
            TimeSpan delta = endTime.Subtract(startTime);
            Console.WriteLine($"total time {delta.TotalMilliseconds}");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //}

        }
        */

        
        
    }
}

