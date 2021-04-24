using HW09.Task1.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace HW09.Task1.What
{
    class InfoBase<T> //: ICRUD<T>
    {
        internal static List<T> itemList = new();

        //public void AddItem(T obj) => itemList.Add(obj); 

        //public void DeleteItem(T obj) => itemList.Remove(obj);

        //public T GetItem(string name) =>
            //itemList.Find(item => item.GetType().GetProperty("Name").Equals(name));

        public IEnumerator GetEnumerator() => itemList.GetEnumerator();
    }
}
