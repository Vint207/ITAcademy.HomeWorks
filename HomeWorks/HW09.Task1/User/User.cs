using System;
using System.Collections.Generic;

namespace HW09.Task1
{
    sealed class User
    {

        internal Lazy<Bin> Bin = new();

        internal string Name { get; set; }
        internal string Password { get; set; }
        internal double Money { get; set; }

        internal void GetInfo() =>
            Console.WriteLine($"Имя: {Name}\nПароль: {Password}\nБаланс: {Money}");     
    }
}
