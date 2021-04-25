using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace HW09.Task1.What
{
    class InfoBase<T> 
    {       
        internal static ObservableCollection<T> itemList = new();

        public IEnumerator GetEnumerator() => itemList.GetEnumerator();
    }
}
