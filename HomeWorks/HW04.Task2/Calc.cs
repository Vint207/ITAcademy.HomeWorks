using System;
using static System.Console;

namespace HW04.Task2
{
    class Calc
    {
        public static void Sum()
        {
            double numb1;       //Вводимое число 1
            double numb2;       //Вводимое число 2
            double buffer;      //Вспомогательная переменная

            WriteLine("Введите первое число:");
            while (double.TryParse(ReadLine(), out numb1) != true)   //Конвертация строки в число, если это возможно. Иначе повторить ввод  
            {
                WriteLine("Введите число:");
            }

            WriteLine("Введите второе число:");
            while (double.TryParse(ReadLine(), out numb2) != true)
            {
                WriteLine("Введите число:");
            }

            WriteLine("Введите сумму чисел:");
            while (double.TryParse(ReadLine(), out buffer) != true ||
                   buffer != (numb1 + numb2))
            {
                WriteLine("Почти угадал...");
            }
            WriteLine("Угадал!");
        }
    }
}
