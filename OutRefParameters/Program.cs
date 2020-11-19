using System;

namespace OutRefParameters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 13, num;
            bool res = doSomthingOut(a, out num);

            Console.WriteLine($"Result is {res}, num is {num}");

            int number = 10;
            Console.WriteLine($"num is {num}");
            doSomthingRef(ref number);
            Console.WriteLine($"num after doSomthingRef is {num}");

            //0x000400 ------> 0x556789
            FullName fullName;
            FillName(out fullName);
            Console.WriteLine($"Full name is {fullName}");
            ToUpper(ref fullName);
            Console.WriteLine($"Full name after ToUpper is {fullName}");



            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            UpdateArray(array);
            foreach (var item in array)
            {
                Console.WriteLine(item + ", ");
            }
            ReplaceArray(ref array);
            foreach (var item in array)
            {
                Console.WriteLine(item + ", ");
            }

        }
        public static void FillName(out FullName full_name)
        {
            full_name = new FullName("Yaniv", "Nuriel");
        }
        public static void ToUpper(ref FullName full_name)
        {
            //full_name 0x000660 ------> 0x556789
            full_name.UpperCase();
        }
        public static bool doSomthingOut(int x, out int num)
        {
            if (x > 10)
            {
                num = x * x;
                return true;
            }
            else
            {
                num = x;
                return false;
            }
        }
        public static void doSomthingRef(ref int num)
        {
            num *= num;
        }
        public static void UpdateArray(int []array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= array[i];
            }
        }
        public static void ReplaceArray(ref int[] array)
        {
            array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array.Length-i;
            }
        }
    }

    class FullName
    {
        private string _first_name;
        private string _last_name;
        public FullName(string first_name, string last_name)
        {
            _first_name = first_name;
            _last_name = last_name;
        }
        public void UpperCase()
        {
            _first_name = _first_name.ToUpper();
            _last_name = _last_name.ToUpper();
        }
        public override string ToString()
        {
            return $"{_first_name} {_last_name}";
        }
    }
}
