using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    interface IMyList<T> : ICollection<T>
    {
        T this[int index] { get; set; }

        int IndexOf(T item);
    }
}
