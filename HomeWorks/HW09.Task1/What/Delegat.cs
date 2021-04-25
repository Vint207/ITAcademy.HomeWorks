using System.Reflection;
using static System.Console;

namespace HW09.Task1
{
    public delegate void BaseChanged<in T>(T user);

    public static class EventMethods
    {

        public static void SushiBaseChanged(Sushi sushi)
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

        public static void UserBaseChanged(User user)
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

        public static void BinBaseChanged(Sushi sushi)
        {
            MethodBase metod = MethodBase.GetCurrentMethod();
            switch (metod.Name)
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
