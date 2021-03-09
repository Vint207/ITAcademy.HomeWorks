using static System.Console;
using static HW09.Task1.Validation;
using static HW09.Task1.Phrases;

namespace HW09.Task1
{
    class ChatBot 
    {
        public string botName;

        public ChatBot() { botName = "Гробик"; }

        public ChatBot(string n) { botName = n; }

        public void Chat()
        {
            UserInfo user = new();

            WriteLine($"{Phrase("Greet")}, {user.name}. Звать меня {botName}. А тебя как?");
            CheckInfo("Name", out user.name);
            WriteLine($"{Phrase("Greet")}, {user.name}.");

            WriteLine($"{user.name}, введи номер билета:");
            CheckInfo("Ticket", out user.ticket);
            WriteLine($"Номер билета {user.ticket} {Phrase("Prove")}.");

            WriteLine($"{user.name}, введи номер паспорта:");
            CheckInfo("Pasport", out user.pasport);
            WriteLine($"Номер паспорта {user.pasport} {Phrase("Prove")}.");

            WriteLine($"{user.name}, введи \"Да\", если у тебя есть багаж, и - \"Нет\", если нет:");
            CheckInfo("Baggage", out user.baggage);

            user.GetInfo();
        }
    }
}
