using HW09.Task1.What;
using System;

namespace HW09.Task1
{
    class Bin : InfoBase<Sushi>
    {

        internal void GetInfo(string name)
        {
            foreach (var item in itemList) { Console.WriteLine($"item\n"); }           
        }
    }
}
