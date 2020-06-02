using System;

namespace Sets50150
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Set project");

            Sets set1 = new Sets();

            int[] array = { 1, 2, 3, 55 };
            Sets set2 = new Sets(array);
            Console.WriteLine(set2);

        }
    }

    class Sets
    {
        bool[] _set;
        const int _size_set = 1001;
        //Empty constructor
        public Sets()
        {
            _set = new bool[_size_set];//create a new array of bool
            for (int i = 0; i < _size_set; i++)
            {
                _set[i] = false;
            }
        }
        public Sets(int [] values) : this()
        {
            foreach (var value in values)
            {
                _set[value] = true;
            }
        }
        public override string ToString()
        {
            string str = $"Array size {_size_set}: \n";
            for (int i = 0; i < _size_set; i++)
            {
                str += $"index {i}: {_set[i]}\n";
            }
            return str;
        }
    }
}
