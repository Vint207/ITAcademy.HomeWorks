using HW09.Task1.Interfaces;
using System;
using System.Collections.Generic;

namespace HW09.Task1
{
    class SushiBase : ICRUD<Sushi>
    {
        static Dictionary<Sushi, int> sushiList = new()
        {
            { new Sushi("Сяке-Маке", 100), 1 },
            { new Sushi("Филадельфия", 100), 1 },
            { new Sushi("Суши-Кавасаки", 100), 1 },
            { new Sushi("Хонда-Ролл", 100), 1 },
            { new Sushi("Фукусима-Глоу", 100), 1 },
            { new Sushi("Субару-Импреза", 99999), 1 },
        };

        public delegate void SushiBaseChanged(Sushi sushi);
        public event SushiBaseChanged baseChangedEvent;

        public void AddItem(Sushi sushi)
        {
            foreach (var item in sushiList)
            {
                if (item.Key.Name.Equals(sushi.Name))
                {
                    sushiList[item.Key]++;
                    baseChangedEvent?.Invoke(sushi);
                    break;
                }
            }
        }

        public void DeleteItem(Sushi sushi)
        {
            foreach (var item in sushiList)
            {
                if (item.Key.Name.Equals(sushi.Name))
                {
                    sushiList[item.Key]--;
                    baseChangedEvent?.Invoke(sushi);
                    break;
                }
            }
        }

        public Sushi GetItem(Sushi sushi)
        {
            foreach (var item in sushiList)
            {
                if (item.Key.Equals(sushi.Name))
                {
                    baseChangedEvent?.Invoke(sushi);
                    return item.Key;
                }
            }
            return null;
        }

        public void GetAllItems()
        {
            foreach (var item in sushiList)
            {              
                item.Key.GetInfo();
                Console.Write($" осталось {item.Value} \n");
            }
        }
    }
}
