using static System.Console;

namespace HW09.Task1
{
    class ChatBot : Phrases
    {
        public string botName;

        public ChatBot() { botName = "Гробик"; }

        public ChatBot(string n) { botName = n; }

        public void Chat()
        {
            UserInfo user = new();

            WriteLine($"{Phrase("Greet")}, {user.name}. Звать меня {botName}. А тебя как?");
            Validation.CheckInfo("Name", out user.name);
            WriteLine($"{Phrase("Greet")}, {user.name}.");

            WriteLine($"{user.name}, введи номер билета:");
            Validation.CheckInfo("Ticket", out user.ticket);
            WriteLine($"Номер билета {user.ticket} {Phrase("Prove")}.");

            WriteLine($"{user.name}, введи номер паспорта:");
            Validation.CheckInfo("Pasport", out user.pasport);
            WriteLine($"Номер паспорта {user.pasport} {Phrase("Prove")}.");

            WriteLine($"{user.name}, введи \"Да\", если у тебя есть багаж, и - \"Нет\", если нет:");
            Validation.CheckInfo("Baggage", out user.baggage);

            user.GetInfo();
        }
    }
}
