using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hash_Chaining
{
    public class HashLinkList<TKey, TValue>
    {
        LinkedList<Data>[] arr;
        // const double M = 1.3; //extra 30% space
        int items;
        int maxItems; //maxItems = 100, array size = 130

        public HashLinkList()
            : this(1024)
        {
            // Hash_SeparateChaining(1024); 
        }

        public HashLinkList(int maxItems)//hashCodeCalcDel ?
        {
            items = 0;
            arr = new LinkedList<Data>[maxItems];
            this.maxItems = maxItems;
        }

        //public double AverListSize()
        //{
        //    int totalSize = 0;
        //    int nonEmptyLists = 0;
        //    foreach (var item in arr)
        //    {

        //    }
        //}


        public bool GetValue(TKey key, out TValue value)//find value by key
        {
            int ind = CalcHashCode(key);

            if (arr[ind] != null)
            {
                foreach (Data d in arr[ind])
                {
                    if (d.key.Equals(key))
                    {
                        value = d.val;
                        return true;
                    }
                }
            }
            //Data d = arr[ind].First(d => d.key.Equals(key));
            //value = d.val;
            value = default(TValue);
            return false;
        }

        public void Add(TKey key, TValue value) //O(1)
        {
            //generate the index for the key
            int ind = CalcHashCode(key);
            //check if the ind is not null
            if (arr[ind] == null)
            {
                arr[ind] = new LinkedList<Data>(); //this is a first item for this ind
            }
            else
            {
                if (arr[ind].Any(d => d.key.Equals(key))) //try to add the same key! WRONG!
                {
                    throw new ArgumentException($"An item with the same key has already been added. Key: {key}");
                }
            }

            arr[ind].AddLast(new Data(key, value));//add to last in this ind
            items++;

            if (items > maxItems)
            {
                ReHash();//to do - add implemintation
            }
        }

        public bool Edit(TKey key, TValue value)
        {            int ind = CalcHashCode(key);            if (arr[ind] != null)            {                foreach (var item in arr[ind])                {                    if (item.key.Equals(key))                    {                        item.val = value;                        return true;                    }                }            }            return false;        } 
        public bool Delete(TKey key)
        {            int ind = CalcHashCode(key);            if (arr[ind] != null)            {                arr[ind].Remove(new Data(key, default));            }            return false;        }

        private void ReHash() //O(n)
        {
            items = 0;
            var tmp = arr;
            arr = new LinkedList<Data>[arr.Length * 2];

            foreach (LinkedList<Data> lst in tmp)
            {
                if (lst == null) continue;
                foreach (Data d in lst)
                {
                    Add(d.key, d.val);
                }

            }
        }

        private int CalcHashCode(TKey key)
        {
            int res = key.GetHashCode();
            //return res % arr.Length; // index: 0 - len-1
            return Math.Abs(res) % arr.Length; // index: 0 - len-1
        }

        class Data
        {
            public TKey key;
            public TValue val;

            public Data(TKey key, TValue val)
            {
                this.key = key;
                this.val = val;
            }

            public override bool Equals(object obj)
            {
                return obj is Data data &&
                       EqualityComparer<TKey>.Default.Equals(key, data.key);
            }
        }
    }
}
