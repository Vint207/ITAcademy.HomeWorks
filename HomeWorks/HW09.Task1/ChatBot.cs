using System.Collections.Generic;
using static HW09.Task1.Phrases;
using static HW09.Task1.Validation;
using static System.Console;

namespace HW09.Task1
{
    class ChatBot 
    {
        //private static List<User> userBase = new();
        public string botName;

        public ChatBot() { botName = "Гробик"; }

        public ChatBot(string n) { botName = n; }

        public void Greeting()
        {
            WriteLine($"{Phrase("Greet")}. Ты зарегистрирован? (Оветь \"Да\" или \"Нет\")");

            switch (ReadLine().ToUpper())
            {
                case "ДА":
                    WriteLine("Введи свое имя. (Используй только буквы)");
                    string name;
                    CheckInfo("Name", out name);
                    WriteLine("Введи пароль. (6 цифр)");
                    string password;
                    CheckInfo("Pasport", out password);
                    foreach (User item in UserBase.user)
                    { if (item.name.Equals(name) && item.password.Equals(password)) { item.GetInfo(); } }
                    break;

                case "НЕТ":
                    User user = new();
                    UserBase.user.Add(user);
                    Registration(user);
                    Chat(user);
                    break;
            } 
        }

        private void Registration(User user)
        {
            WriteLine($"Давай создадим аккаунт.");
            WriteLine($"Звать меня {botName}. А тебя как будем звать? (Используй только буквы)");
            CheckInfo("Name", out user.name);
            WriteLine($"{Phrase("Greet")}, {user.name}.");
            WriteLine("Придумай пароль аккаунта. (6 цифр)");
            CheckInfo("Pasport", out user.password);
            WriteLine($"Пароль {user.password} {Phrase("Prove")}.");
            WriteLine($"{user.name}, теперь ты зарегистрирован в системе.");
        }

        private void Chat(User user)
        {
            WriteLine($"{user.name}, введи 7 цифр номера билета:");
            CheckInfo("Ticket", out user.ticket);
            WriteLine($"Номер билета {user.ticket} {Phrase("Prove")}.");
            WriteLine($"{user.name}, введи 6 цифр номера паспорта:");
            CheckInfo("Pasport", out user.pasport);
            WriteLine($"Номер паспорта {user.pasport} {Phrase("Prove")}.");
            WriteLine($"{user.name}, у тебя есть багаж? (Оветь \"Да\" или \"Нет\")");
            CheckInfo("Baggage", out user.baggage);
        }
    }
}
