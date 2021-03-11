using System.Collections.Generic;
using static System.Console;

namespace HW09.Task1
{
    public sealed class User
    {
        public static List<User> list = new();

        public string name = "";
        public string password = "";
        public string ticket = "";
        public string pasport = "";
        public string baggage = "";
        public string contraband = "Нет";

        public void GetInfo()
        {
            WriteLine($"Имя: {name} \nНомер билета: {ticket} \nНомер паспорта: {pasport} \nБагаж: {baggage} \nКонтрабанда: {contraband}");
        }
    }
}
