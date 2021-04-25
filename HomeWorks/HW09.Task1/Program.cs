using System.Reflection;
using static System.Console;

namespace HW09.Task1
{
    sealed class Program
    {

        static void Main()
        {                
            while (true)
            {
                new ChatBot().Greeting();
                ReadLine();
            }
        }
    }
}

