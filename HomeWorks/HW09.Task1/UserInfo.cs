using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW09.Task1
{
    class UserInfo
    {
        public string name = "Незнакомец";
        public string ticket;
        public string pasport;
        public string baggage;

        public void GetInfo()
        {
            WriteLine($"Имя: {name} \nНомер билета: {ticket} \nНомер паспорта: {pasport} \nБагаж: {baggage}");
        }
    }
}
