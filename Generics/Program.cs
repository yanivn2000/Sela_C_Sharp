using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

/*
 * Introduction

Generic collection is the most important concept in .NET,
many of the programmers feel that Generic Collections are very complex,
but after reading this article you will feel easy and comfortable to use these Generics and Generic collection.

In this article I have explained both Generic and Generic collection using simple samples,
I hope this article will be useful in your daily life.

Problem with Array and ArrayList

Array:
1. Arrays are strongly typed (meaning that you can only put one type of object into it).
2. Limited to size (Fixed length).

ArrayList:
1. ArrayList are strongly typed.
2. Data can increase on need basis.
3. It will do the boxing and unboxing while processing (decrease the performance).

List (Generic Collection)
1. List are strongly typed.
2. Data can increase on need basis.
3. Don't incur overhead of being converted to and from type object.

Generic Collection:
A generic collection is strongly typed (you can store one type of objects into it) so that we can eliminate runtime type mismatches, it improves the performance by avoiding boxing and unboxing.
*/

namespace Generics
{

    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            // Compare Integer
            Check<int> obj1 = new Check<int>();
            bool Result = obj1.Compare(5, 7);
            // Compare String  
            Check<string> obj2 = new Check<string>();
            Result = obj2.Compare("Ramakrishna", "Ramakrishna");
            Console.WriteLine("Integer Comparison: {0}\nString Comparison: {1}", Result, Result);

            Something a1 = new Something("Yaniv");
            Something a2 = new Something("Yaniv");
            Check<Something> obj3 = new Check<Something>();
            Result = obj3.Compare(a1, a2);
            Console.WriteLine("Something Comparison: {0}", Result);

            Console.Read();
        }
        // Generic class to accept all types of data types
        class Check<T>
        {
            //T is the type (as if you wrote int, string, Somthing)
            private T data1;
            // Gerefic function to compare all data types  
            public bool Compare(T var1, T var2)
            {
                if (var1.Equals(var2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        class Check2
        {
            //T is the type (as if you wrote int, string, Somthing)
            private int data1;
            // Gerefic function to compare all data types  
            public bool Compare(int var1, int var2)
            {
                if (var1.Equals(var2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        //instead of:
        public bool Compare(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Something
    {
        public string _name { get; set; }
        public Something(string str)
        {
            _name = str;
        }
        public override bool Equals(Object obj)
        {
            return _name == ((Something)obj)._name ? true : false;
        }
    }
}
