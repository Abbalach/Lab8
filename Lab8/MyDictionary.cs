using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class MyDictionary<Tkey, TValue> : IMyDictionary<Tkey, TValue>
    {
        public TValue this[Tkey key] 
        {
            get 
            {
                foreach (var item in list)
                {
                    if (item.Key.Equals(key))
                    {
                        return item.Value;
                    }
                }
                return default;
            } 

            set
            {
                for (int i = 0; i < Count; i++)
                {
                    if (list[i].Key.Equals(key))
                    {
                        list[i] = new KeyValuePair<Tkey, TValue>(key, value);
                    }
                }
            }
        }
        public MyDictionary()
        {
            list = new MyList<KeyValuePair<Tkey, TValue>>();
        }

        public MyDictionary(IEnumerable<KeyValuePair<Tkey, TValue>> enumerable)
        {
            list = new MyList<KeyValuePair<Tkey, TValue>>();
            foreach (var item in enumerable)
            {
                Add(item);
            }
        }

        private MyList<KeyValuePair<Tkey,TValue>> list { get; set; }

        public ICollection<Tkey> Keys
        {
            get 
            {
                List<Tkey> tkeys = new List<Tkey>();
                foreach (var item in list)
                {
                    tkeys.Add(item.Key);
                }
                return tkeys;
            } 
        }

        public ICollection<TValue> Values
        {
            get
            {
                List<TValue> tvalues = new List<TValue>();
                foreach (var item in list)
                {
                    tvalues.Add(item.Value);
                }
                return tvalues;
            }
        }

        public int Count
        { 
            get 
            {
                return list.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return list.IsReadOnly;
            }
        }



        public void Add(Tkey key, TValue value)
        {
            list.Add(new KeyValuePair<Tkey, TValue>(key, value));
        }

        public void Add(KeyValuePair<Tkey, TValue> item)
        {
            list.Add(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(KeyValuePair<Tkey, TValue> item)
        {
            return list.Contains(item);
        }

        public void CopyTo(KeyValuePair<Tkey, TValue>[] array, int arrayIndex)
        {
            int i = arrayIndex;
            foreach (var item in list)
            {
                array[i] = item;
                i++;
            }
        }

        public IEnumerator<KeyValuePair<Tkey, TValue>> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Remove(KeyValuePair<Tkey, TValue> item)
        {
            return list.Remove(item);
        }
    }
}
