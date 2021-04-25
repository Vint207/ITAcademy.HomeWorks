using System.Collections;
using System.Collections.Generic;

namespace HW09.Task1
{
    class Bin : SushiBase
    {

        Dictionary<Sushi, int> _sushiList;
        new event BaseChanged<Sushi> _baseChangedEvent;

        public Bin(BaseChanged<Sushi> del) : base (del)
        {
            _sushiList = new();
            _baseChangedEvent = del;
        }

        //public new void DeleteItem(Sushi sushi)
        //{
        //    foreach (var item in _sushiList)
        //    {
        //        if (item.Key.Name.Equals(sushi.Name))
        //        {
        //            _sushiList[item.Key]--;
        //            _baseChangedEvent?.Invoke(sushi);
        //            break;
        //        }
        //    }
        //}

        public IEnumerator GetEnumerator() => _sushiList.GetEnumerator();
    }
}
