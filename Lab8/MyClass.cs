using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class MyClass<D>
    {
        //Не понятно надо ли делать ли по фактори патерну или просто "фактори" метод выполняющий нужную функцию. Так как абстрактный статичный метод не сделаешь, то выбрал второе
        //(может есть какие-то другие вариации патерна фактори, но гугол такого не выдал)  
        // Не знаю насколько уместна такая конструкция (подразумевается, что T и D один класс представляют), но как по-другому выразить фабрику любого! типа не знаю
        static public T FactoryMethod<T>() where T : D, new()
        {
            T copy = new T();
            return copy;
        }
    }
}
