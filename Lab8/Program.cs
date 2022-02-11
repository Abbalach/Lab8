using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {

            int A = MyClass<int>.FactoryMethod<int>();                           
            Console.WriteLine(A);

            MyList<int> B = MyClass<MyList<int>>.FactoryMethod<MyList<int>>();
            Console.WriteLine(B);

            Console.ReadKey();
        }
    }
}
