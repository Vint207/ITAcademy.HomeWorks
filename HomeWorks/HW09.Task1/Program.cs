using System.Collections.Generic;
using static System.Console;

namespace HW09.Task1
{
    sealed class Program
    {
        static void Main()
        {
            while (true)
            {

                SushiBase.itemList.Add(new Sushi("Сяке-Маке", 100));
                SushiBase.itemList.Add(new Sushi("Филадельфия", 100));
                SushiBase.itemList.Add(new Sushi("Суши-Кавасаки", 100));
                SushiBase.itemList.Add(new Sushi("Хонда-Ролл", 100));
                SushiBase.itemList.Add(new Sushi("Фукусима-Глоу", 100));
                SushiBase.itemList.Add(new Sushi("Субару-Импреза", 99999));            

                new ChatBot().Greeting();              
                ReadLine();

            }
        }
    }
}
