using System;

namespace Sets50150
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Set project");

            Sets set1 = new Sets();

            //int[] array = { 1, 2, 3, 55 };
            Sets set2 = new Sets(10, 30, 3000, 3, 100, 2000, 102, 300);
            //Sets set2 = new Sets(array);
            Console.WriteLine(set2);

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
        public Sets( params int [] values) : this()
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
    }
}
