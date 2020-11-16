using System;
namespace SstNumberBoolArray
{
    public class Set
    {
        private int _set_counter;
        private bool[] _array;
        private int _size = 100;

        public Set()
        {
            _array = new bool[_size];
            _set_counter = 0;
        }
        public Set(int [] arrayInt)//arrayInt[0] = 66, array[1] = 5
        {
            _array = new bool[_size];
            foreach (int item in arrayInt)
            {
                if (IsInRange(item))
                {
                    _set_counter++;
                    _array[item] = true;
                }
            }
        }
        private bool IsInRange(int number)
        {
            return number >= 0 && number <= _size;
        }
        public bool IsExist(int number)
        {
            return _array[number];
        }
        public bool Insert(int number)
        {
            if (IsInRange(number)) {
                if (_array[number] == false) {
                    _set_counter++;
                    _array[number] = true;
                }
            }
            else
                return false;

            return true;
        }
        public bool Remove(int number)
        {
            if (IsInRange(number)){
                if (_array[number])
                {
                    _set_counter--;
                    _array[number] = false;
                }
            }
            else
                return false;
            return true;
        }
        public int[] GetSet()
        {
            int[] arrayInt = new int[_set_counter];
            
            for (int j = 0, i = 0; i < _size; i++)
            {
                if (_array[i] == true)
                    arrayInt[j++] = i;
            }
            return arrayInt;
        }
    }
}
