using static HW09.Task1.Phrases;
using static HW09.Task1.Validation;
using static System.Console;

namespace HW09.Task1
{
    class ChatBot
    {
        public string botName;

        public ChatBot() { botName = "Гробик"; }

        public ChatBot(string n) { botName = n; }

        public void Greeting()
        {
            WriteLine($"{Phrase("Greet")}. Звать меня {botName}. Ты зарегистрирован?");
            
            switch (CheckInfo())
            {
                case true:
                    string name, password;
                    WriteLine("Введи свое имя, чтобы войти в аккаунт.");
                    CheckInfo("Name", out name);

                    WriteLine("Введи пароль. (6 цифр)");
                    CheckInfo("Pasport", out password);

                    foreach (User item in User.list)
                    {
                        if (item.name.Equals(name) && item.password.Equals(password))
                        {
                            WriteLine($"{item.name}, ты хочешь изменить данные профиля?)");
                            if (CheckInfo()) { Registration(item); Chat(item); }
                            else { item.GetInfo(); }
                        }
                    }
                    break;

                case false:
                    WriteLine($"Давай создадим аккаунт.");
                    User user = new();
                    User.list.Add(user);

                    Registration(user);
                    WriteLine($"{Phrase("Praise")}, {user.name}, теперь ты зарегистрирован в системе.");
                    Chat(user);
                    break;
            }
        }

        private void Registration(User user)
        {
            WriteLine($"Введи свое имя. (Используй только буквы)");
            CheckInfo("Name", out user.name);
            WriteLine($"{Phrase("Greet")}, {user.name}.");

            WriteLine("Придумай пароль аккаунта. (6 цифр)");
            CheckInfo("Pasport", out user.password);
            WriteLine($"Пароль {user.password} {Phrase("Prove")}.");
        }

        private void Chat(User user)
        {
            WriteLine($"{user.name}, введи 7 цифр номера билета:");
            CheckInfo("Ticket", out user.ticket);
            WriteLine($"Номер билета {user.ticket} {Phrase("Prove")}.");

            WriteLine($"{user.name}, введи 6 цифр номера паспорта:");
            CheckInfo("Pasport", out user.pasport);
            WriteLine($"Номер паспорта {user.pasport} {Phrase("Prove")}.");

            WriteLine($"{user.name}, у тебя есть багаж?");
            user.baggage = CheckInfo() ? "Есть": "Нет";

            if (user.baggage.Equals("Есть"))
            {
                WriteLine($"{user.name}, в багаже есть что-нибудь запрещенное?");
                user.contraband = CheckInfo() ? "Есть" : "Нет";
                if (user.contraband.Equals("Есть")) { WriteLine($"Я звоню копам!"); return; }
            }
            WriteLine($"{Phrase("Praise")}, {user.name}, можешь лететь!");
        }
    }
}
