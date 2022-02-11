using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class MyList<T> : IMyList<T>
    {
        public int Count
        { 
            get
            {
                int counter = 0;
                foreach (var item in list)
                {
                    counter++;
                }
                return counter;
            }
        }
        public bool IsReadOnly { get { return false; } }

        //совершенно непонятно как имплементировать список, не используя список, ведь в массиве количество элементов ограничено.
        //Так что буду использовать этот класс просто как неограниченное по размеру хранилище переменных, стараясь по минимуму использовать функционал самого листа
        private List<T> list { get; set; }

        public T this[int index]
        {
            get
            {
                return list.ElementAt(index);
            }
            set
            {
                list[index] = value;
            }
        }

        public MyList()
        {
            list = new List<T>();
        }

        public MyList(IEnumerable<T> enumerable)
        {
            list = new List<T>();
            foreach (var item in enumerable)
            {
                Add(item);
            }
        }


        public int IndexOf(T item)
        {
            int counter = 0;
            foreach (var element in list)
            {
                if (element.Equals(item))
                {
                    return counter;
                }
                counter++;
            }
            return -1;
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Clear()
        {
            foreach (var item in list)
            {
                Remove(item);
            }
        }

        public bool Contains(T item)
        {
            foreach (var element in list)
            {
                if (element.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayindex)
        {
            for (int i = 0; i < array.Length - arrayindex; i++)
            {
                array[i] = this[i];
            }
        }

        public bool Remove(T item)
        {
            return list.Remove(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }


        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
