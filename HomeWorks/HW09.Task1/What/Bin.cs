using HW09.Task1.What;
using System;
using System.Collections;
using System.Collections.ObjectModel;

namespace HW09.Task1
{
    class Bin
    {
        internal static ObservableCollection<Sushi> itemList = new();

        internal void GetInfo(string name)
        {
            foreach (var item in itemList) { Console.WriteLine($"item\n"); }           
        }

        public IEnumerator GetEnumerator() => itemList.GetEnumerator();
    }
}
