using System;

namespace Sets50150
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Set project");

            Sets set1 = new Sets(7, 30, 31, 301, 401);

            //int[] array = { 1, 2, 3, 55 };
            Sets set2 = new Sets(10, 30, 300, 400, 600, 2000);
            //Sets set2 = new Sets(array);
            Console.WriteLine("Set1:");
            Console.WriteLine(set1);
            Console.WriteLine("Set2:");
            Console.WriteLine(set2);

            set2.Union(set1);
            Console.WriteLine("Set2 after Union:");
            Console.WriteLine(set2);

            //Intersect
            Sets set3 = new Sets(1, 2, 3, 4, 5, 100, 201);
            //int[] array = { 1, 2, 3, 55 };
            Sets set4 = new Sets(3, 5, 100, 200);
            set3.Intersect(set4);
            Console.WriteLine("Set3 after Intersect:");
            Console.WriteLine(set3);

            //Subset
            Sets set5 = new Sets(1, 2, 3, 4, 5, 6, 7, 8, 9);
            //int[] array = { 1, 2, 3, 55 };
            Sets set6 = new Sets(3, 5, 7, 9);
            if (set5.Subset(set6)) Console.WriteLine("Set6 is a subset of Set5");
            else Console.WriteLine("Set6 is not a subset of Set5");
            if (set5.Subset(set2)) Console.WriteLine("Set2 is a subset of Set5");
            else Console.WriteLine("Set2 is not a subset of Set5");
        }
    }

    class Sets
    {
        bool[] _set;
        const int _size_set = 1001;
        string _name;
        //Empty constructor
        public Sets()
        {
            _set = new bool[_size_set];//create a new array of bool
            for (int i = 0; i < _size_set; i++)
            {
                _set[i] = false;
            }
        }
        public Sets(params int [] values) : this()
        {
            foreach (var value in values)
            {
                if (value >= _size_set || value < 0) continue;
                _set[value] = true;
            }
        }
        public override string ToString()
        {
            string str = "";
            int counter = 0;
            for (int i = 0; i < _size_set; i++)
            {
                if (_set[i])
                {
                    str += $"{i}\n";
                    counter++;
                }
            }
            str += $"Number of elements: {counter}";
            return str;
        }
        //union – a union operation that receives a set and unites it with the original set.i.e.
        //the set the operation was being done on will represent the union.For Example:
        //given sets s1, s2: s1.union(s2) will cause s1 to be the result of the union.
        public void Union(Sets obj)
        {
            //set the true values of set to this
            for (int i = 0; i < _size_set; i++)
            {
                //_set[i] = (_set[i] || obj._set[i]);
                if (obj._set[i])
                    _set[i] = true;
            }
        }
        //intersect – intersecting operation, that receives a set and performs set intersecting.
        //The set the operation was being done on will represent the intersection.
        public void Intersect(Sets obj)
        {
            //set the true values of set to this
            for (int i = 0; i < _size_set; i++)
            {
                _set[i] = (_set[i] && obj._set[i]);
            }
        }
        /*
         * - subset – an operation that receives a set and checks whether it represents a subset
        of the set.
        */
        public bool Subset(Sets obj)
        {
            for (int i = 0; i < _size_set; i++)
            {
                if (obj._set[i] == true && _set[i] == false)
                    return false;
            }
            return true;
        }
    }
}
