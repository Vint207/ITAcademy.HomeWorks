using static HW09.Task1.Phrases;
using static HW09.Task1.Validation;
using static System.Console;

namespace HW09.Task1
{
    sealed class ChatBot
    {
        public string botName = "Гробик";
        UserBase _userBase;
        SushiBase _sushiBase;

        public ChatBot(UserBase userBase, SushiBase sushiBase)
        {
            _userBase = userBase;
            _sushiBase = sushiBase;
        }

        public void Greeting()
        {
            WriteLine($"{Phrase("Greet")}. Звать меня {botName}. Ты зарегистрирован?");

            if (CheckInfo()) { Intering(); }

            Registration();
        }

        void Intering()
        {
            string name, password;
            WriteLine("Введи свое имя, чтобы войти в аккаунт.");
            name = CheckInfo("Name");

            WriteLine("Введи пароль. (6 цифр)");
            password = CheckInfo("Password");

            User tempUser = _userBase.GetItem(new User() { Name = name, Password = password });

            if (tempUser != null)
            {
                WriteLine($"{tempUser.Name}, ты хочешь изменить данные профиля?)");
                if (CheckInfo()) { ChangingProfile(tempUser); }

                Chat(tempUser);
            }

            WriteLine("данный пользователь не зарегистрирован.");

            Greeting();
        }

        void Registration()
        {
            User user = new();

            WriteLine($"Давай создадим аккаунт.");

            WriteLine($"Введи свое имя. (Используй только буквы)");
            user.ChangingName();

            WriteLine("Придумай пароль аккаунта. (6 цифр)");
            user.ChangingPassword();

            _userBase.AddItem(user);
            WriteLine($"{Phrase("Praise")}, {user.Name}, теперь ты зарегистрирован в системе.");

            Chat(user);
        }

        void ChangingProfile(User user)
        {
            WriteLine($"Давай изменим данные аккаунта.");

            WriteLine($"Ты хочешь изменить имя?");
            if (CheckInfo())
            {
                WriteLine($"Введи новое имя. (Используй только буквы)");
                user.ChangingName();
            }

            WriteLine($"Ты хочешь изменить пароль?");
            if (CheckInfo())
            {
                WriteLine("Придумай новый пароль аккаунта. (6 цифр)");
                user.ChangingPassword();
            }

            Chat(user);
        }

        void Chat(User user)
        {
            WriteLine($"{user.Name}, хочешь заказать суши?");
            if (!CheckInfo()) { return; }

            WriteLine($"{Phrase("Praise")}, {user.Name}, какие суши ты хочешь?");

            _sushiBase.GetAllItems();
       


            //CheckInfo("Ticket", out user.ticket);
            //WriteLine($"Номер билета {user.ticket} {Phrase("Prove")}.");

            //WriteLine($"{user.name}, введи 6 цифр номера паспорта:");
            //CheckInfo("Pasport", out user.pasport);
            //WriteLine($"Номер паспорта {user.pasport} {Phrase("Prove")}.");

            //WriteLine($"{user.name}, у тебя есть багаж?");
            //user.baggage = CheckInfo() ? "Есть": "Нет";

            //if (user.baggage.Equals("Есть"))
            //{
            //    WriteLine($"{user.name}, в багаже есть что-нибудь запрещенное?");
            //    user.contraband = CheckInfo() ? "Есть" : "Нет";
            //    if (user.contraband.Equals("Есть")) { WriteLine($"Я звоню копам!"); return; }
            //}
            //WriteLine($"{Phrase("Praise")}, {user.name}, можешь лететь!");
        }
    }
}
