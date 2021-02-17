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
                while (!int.TryParse((ReadLine()), out numb))
                {
                    WriteLine("Введите именно число:");
                }

                WriteLine();

                for (int i = 1; i <= numb; i++)
                {
                    for (int j = 1; j <= numb; j++)
                    {
                        if (j >= i && j <= numb)
                        {
                            Write($"{i - (10 * (i / 10))} ");  //Вывод числа в чтроку и обрезка всех разрядов, кроме единичного
                        }
                        else if (j < i)
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
