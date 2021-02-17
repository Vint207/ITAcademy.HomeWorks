using static System.Console;
using static System.ConsoleKey;

namespace HW04.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                WriteLine("\nНажмите w, a, s или d:");
                switch (ReadKey().Key)
                {
                    case W:
                        WriteLine("\nВверх\n");
                        break;

                    case A:
                        WriteLine("\nВлево\n");
                        break;
                    case S:
                        WriteLine("\nВниз\n");
                        break;

                    case D:
                        WriteLine("\nВправо\n");
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
