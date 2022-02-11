using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public static class MyListExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.Count];
            int i = 0;
            foreach (var item in list)
            {
                array[i] = item;
                i++;
            }

            return array;
        }
    }
}
