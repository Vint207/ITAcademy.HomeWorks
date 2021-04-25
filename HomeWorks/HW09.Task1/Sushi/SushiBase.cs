using HW09.Task1.Interfaces;
using System;
using System.Collections.Generic;

namespace HW09.Task1
{
    class SushiBase : ICRUD<Sushi>
    {

        static Dictionary<Sushi, int> _sushiList = new()
        {
            { new Sushi("Сяке-Маке", 100), 99 },
            { new Sushi("Филадельфия", 100), 99 },
            { new Sushi("Суши-Кавасаки", 100), 99 },
            { new Sushi("Хонда-Ролл", 100), 99 },
            { new Sushi("Фукусима-Глоу", 100), 99 },
            { new Sushi("Субару-Импреза", 99999), 99 },
        };
        public event BaseChanged<Sushi> _baseChangedEvent;

        public SushiBase(BaseChanged<Sushi> del) { _baseChangedEvent = del; }

        public void AddItem(Sushi sushi)
        {
            foreach (var item in _sushiList)
            {
                if (item.Key.Name.Equals(sushi.Name))
                {
                    _sushiList[item.Key]++;
                    _baseChangedEvent?.Invoke(sushi);
                    break;
                }
            }
        }

        public void DeleteItem(Sushi sushi)
        {
            foreach (var item in _sushiList)
            {
                if (item.Key.Name.Equals(sushi.Name))
                {
                    _sushiList[item.Key]--;
                    _baseChangedEvent?.Invoke(sushi);
                    break;
                }
            }
        }

        public Sushi GetItem(Sushi sushi)
        {
            foreach (var item in _sushiList)
            {
                if (item.Key.Name.Equals(sushi.Name))
                {
                    _baseChangedEvent?.Invoke(sushi);
                    return item.Key;
                }
            }
            return null;
        }

        public void GetAllItems()
        {
            foreach (var item in _sushiList)
            {
                item.Key.GetInfo();
                Console.Write($" осталось {item.Value} \n");
            }
        }
    }
}
