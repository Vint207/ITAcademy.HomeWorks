using System.Reflection;
using static System.Console;

namespace HW09.Task1
{
    sealed class Program
    {
        static void Main()
        {

            while (true)
            {
                SushiBase sushiBase = new();
                sushiBase.baseChangedEvent += SushiBaseChanged;
                UserBase userBase = new();
                userBase.baseChangedEvent += UserBaseChanged;

                new ChatBot(userBase, sushiBase).Greeting();
                ReadLine();
            }
        }

        static void SushiBaseChanged(Sushi sushi)
        {
            MethodBase metod = MethodBase.GetCurrentMethod();
            switch (metod.Name)
            {
                case "AddItem":
                    WriteLine($"Добавлены суши {sushi.Name} - {sushi.Price} р");
                    break;
                case "DeleteItem":
                    WriteLine($"Удалены суши {sushi.Name} - {sushi.Price} р");
                    break;
                case "GetItem":
                    WriteLine($"Данные о суши {sushi.Name} - {sushi.Price} р просмотрены");
                    break;
            }
        }

        static void UserBaseChanged(User user)
        {
            MethodBase metod = MethodBase.GetCurrentMethod();
            switch (metod.Name)
            {
                case "AddItem":
                    WriteLine($"Добавлен пользователь {user.Name}");
                    break;
                case "DeleteItem":
                    WriteLine($"Удален пользователь {user.Name}");
                    break;
                case "GetItem":
                    WriteLine($"Данные о пользователе {user.Name} просмотрены");
                    break;
            }
        }
    }
}

