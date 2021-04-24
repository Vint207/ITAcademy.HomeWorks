using System.Collections.Generic;

namespace HW09.Task1.Interfaces
{
    interface ICRUD<T>
    {

        void AddItem(T item);

        void DeleteItem(T obj);

        T GetItem(string name);

    }
}
