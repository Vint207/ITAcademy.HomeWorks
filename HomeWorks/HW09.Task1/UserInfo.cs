﻿using static System.Console;

namespace HW09.Task1
{
    public class UserInfo
    {
        public string name = "Незнакомец";
        public string ticket = "Неизвестно";
        public string pasport = "Неизвестно";
        public string baggage = "Неизвестно";

        public void GetInfo()
        {
            WriteLine($"Имя: {name} \nНомер билета: {ticket} \nНомер паспорта: {pasport} \nБагаж: {baggage}");
        }
    }
}
