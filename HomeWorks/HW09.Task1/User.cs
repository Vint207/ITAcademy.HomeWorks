using System.Collections.Generic;
using static System.Console;

namespace HW09.Task1
{
    public class User
    {
        public static List<User> list = new();

        public string name = "Незнакомец";
        public string password = "";
        public string ticket = "Неизвестно";
        public string pasport = "Неизвестно";
        public string baggage = "Неизвестно";
        public string contraband = "НЕТ";

        public void GetInfo()
        {
            WriteLine($"Имя: {name} \nНомер билета: {ticket} \nНомер паспорта: {pasport} \nБагаж: {baggage} \nБагаж: {contraband}");
        }
    }
}
