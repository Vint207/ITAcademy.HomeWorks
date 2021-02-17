using static System.Console;

namespace HW._05.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb; //Вводимое число

            while (true)
            {
                WriteLine("Введите число:");
                numb = int.Parse(ReadLine());

                WriteLine();

                for (int i = 1; i <= numb; i++)
                {
                    for (int j = 1; j <= numb + 1; j++)
                    {
                        if (j >= i && j <= numb)
                        {                           
                            Write($"{i - (10 * (i / 10))} ");
                        }
                        else
                        {
                            Write(" ");
                        }
                    }
                    WriteLine();
                }
            }
        }
    }
}