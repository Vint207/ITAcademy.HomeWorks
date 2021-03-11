using System.Collections.Generic;
using static System.Console;

namespace HW09.Task1
{
    sealed class Program
    {
        static void Main()
        {
            while (true)
            {
                ChatBot bot = new();              
                bot.Greeting();
                ReadLine();
            }
        }
    }
}
