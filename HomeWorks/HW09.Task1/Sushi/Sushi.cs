using System;

namespace HW09.Task1
{
    class Sushi
    {
        internal Sushi() { }
        internal Sushi(string name, double price) { Name = name; Price = price; }

        internal string Name { get; set; }
        internal double Price { get; set; }

        internal void GetInfo() => Console.Write($"{Name} - {Price} р");       
    }
}
