using System.Collections.Generic;

namespace HW09.Task1.Interfaces
{
    interface ICRUD<T>
    {

        static void AddItem(T item) { }

        static void DeleteItem(T item) { }
    }
}
