using static System.Console;

namespace HW09.Task1
{
    class ChatBot
    {
        private string name = "";
        private string ticket = "";
        private string pasport = "";
        private string baggage = "";

        public void Chat()
        {
            WriteLine("Здравствуйте. Представьтесь, пожалуйста:");
            Request("Name", out name);
            WriteLine($"Привет, {name}");

            WriteLine($"{name}, введи номер билета:");
            Request("Ticket", out ticket);
            WriteLine($"Номер билета {ticket} принят");

            WriteLine($"{name}, введи номер паспорта:");
            Request("Pasport", out pasport);
            WriteLine($"Номер паспорта {pasport} принят");

            WriteLine($"{name}, введи \"Да\", если у тебя есть багаж, и - \"Нет\", если нет:");
            Request("Baggage", out baggage);

            GetInfo();
        }

        public void GetInfo() => WriteLine($"Имя: {name} \nНомер билета: {ticket} \nНомер паспорта: {pasport} \nБагаж: {baggage}");

        void Request(string request, out string s)
        {
            s = "";
            while (!Validation.Check(ReadLine(), request, out s))
            {
                WriteLine("Некорректные данные. Повтори попытку:");
            }
        }
    }
}
