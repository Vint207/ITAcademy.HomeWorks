using static System.Console;
using static HW09.Task1.Validation;
using static HW09.Task1.Phrases;
using System.Collections.Generic;
using System.Linq;

namespace HW09.Task1
{
    class ChatBot 
    {
        public string botName;
        //public UserInfo user;

        public ChatBot() { botName = "Гробик"; }

        public ChatBot(string n ) { botName = n; }

        public void Chat(UserInfo user)
        {      
            WriteLine($"{Phrase("Greet")}, {user.name}. Звать меня {botName}. А тебя как?");
            CheckInfo("Name", out user.name);
            WriteLine($"{Phrase("Greet")}, {user.name}.");

            WriteLine($"{user.name}, введи 7 цифр номера билета:");
            CheckInfo("Ticket", out user.ticket);
            WriteLine($"Номер билета {user.ticket} {Phrase("Prove")}.");

            WriteLine($"{user.name}, введи 6 цифр номера паспорта:");
            CheckInfo("Pasport", out user.pasport);
            WriteLine($"Номер паспорта {user.pasport} {Phrase("Prove")}.");

            WriteLine($"{user.name}, введи \"Да\", если у тебя есть багаж, и - \"Нет\", если нет:");
            CheckInfo("Baggage", out user.baggage);

            while (true)
            {
                WriteLine($"{user.name}, введи \"Хочу\", если хочешь узнать личные данные других пользователей");
                if (ReadLine().ToUpper() != "ХОЧУ") { break; }
                WriteLine("Вводи имя:");
                string name = ReadLine();
                foreach (UserInfo item in Program.userBase) if (item.name.Equals(name)) item.GetInfo();
            }
        }
    }
}
