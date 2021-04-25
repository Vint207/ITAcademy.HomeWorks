using System.Reflection;
using static System.Console;
using System.Runtime.CompilerServices;

namespace HW09.Task1
{
    public delegate void BaseChanged<in T>(T user, [CallerMemberName] string method = "");

    public static class EventMethods
    {

        public static void SushiBaseChanged(Sushi sushi, [CallerMemberName] string method = "")
        {
            switch (method)
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

        public static void UserBaseChanged(User user, [CallerMemberName] string method = "")
        {
                switch (method)
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

        public static void BinBaseChanged(Sushi sushi, [CallerMemberName] string method = "")
        {
            switch (method)
            {
                case "AddItem":
                    WriteLine($"В корзину добавлены суши {sushi.Name} - {sushi.Price} р");
                    break;
                case "DeleteItem":
                    WriteLine($"Из корзины удалены суши {sushi.Name} - {sushi.Price} р");
                    break;
                case "GetItem":
                    WriteLine($"Данные о суши {sushi.Name} - {sushi.Price} р просмотрены в корзине");
                    break;
            }
        }
    }
}
