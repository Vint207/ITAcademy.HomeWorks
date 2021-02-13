using System;
using static System.Console;
using static System.Convert;

namespace HW04.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 90; i > 64; i--)    //От 90 до 65 - десятичные аналоги букв английского алфавита от Z до A в UniCode
            {
                WriteLine(ToChar(i));
            } 
        }
    }
}
