using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryLINQ
{
    class MainClass
    {
        //********** VALUE **********//
        public class MyObject
        {
            public bool isValid;
            public int value;

            public MyObject(bool isValid, int value)
            {
                this.isValid = isValid;
                this.value = value;
            }

            public override string ToString()
            {
                return $"{value}";
            }
        }
        //********** KEY **********//
        public class ISBN
        {
            //31423432-52523322
            int lvalue;
            int rvalue;

            public ISBN(int lvalue, int rvalue)
            {
                this.lvalue = lvalue;
                this.rvalue = rvalue;
            }
            public override bool Equals(object obj)
            {
                return obj is ISBN iSBN &&
                       lvalue == iSBN.lvalue &&
                       rvalue == iSBN.rvalue;
            }
            //create integer key
            public override int GetHashCode()
            {
                int hashCode = -2100150737;
                hashCode = hashCode * -1521134295 + lvalue.GetHashCode();
                hashCode = hashCode * -1521134295 + rvalue.GetHashCode();
                return hashCode;
            }
            public override string ToString()
            {
                return $"{lvalue}-{rvalue}";
            }

        }
        public static void Main(string[] args)
        {
            Random rand = new Random();
            //create dictionary with ISBN key and MyObject value
            Dictionary<int, MyObject> dic = new Dictionary<int, MyObject>();

            bool isValid = true;
            for (int i = 0; i < 10; i++)
            {
                isValid = !isValid;
                ISBN isbn = new ISBN(rand.Next(1000000, 5000000), rand.Next(1000000, 5000000));
                int value = rand.Next(0, 100);
                Console.WriteLine($"isbn: {isbn}, value: {value}");
                dic[isbn.GetHashCode()] = new MyObject(isValid, value);
            }

            Console.Write("Please select an ISBN:");
            string input = Console.ReadLine();
            //"123421-1214134";
            string[] strA = input.Split('-');
            ISBN searchedISBN = new ISBN(int.Parse(strA[0]), int.Parse(strA[1]));
            MyObject objectFound = dic[searchedISBN.GetHashCode()];
            Console.WriteLine($"Searched item: {objectFound}");
            /*
            //LINQ
            //var matches = dic.Where(kvp => kvp.Value.isValid);
            //var matches = dic.Where(kvp => kvp.Value.value > 50);
            var matches = dic.Where(kvp => kvp.Value.isValid == true);
            foreach (var item in matches)
            {
                Console.WriteLine(item);
            }
            */

        }
    }
}
