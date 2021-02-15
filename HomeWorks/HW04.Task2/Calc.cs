using System;
using static System.Console;

namespace HW04.Task2
{
    class Calc
    {
        /// <summary>
        /// Check input sum of two input numbers if it is a numbers and prove the sum
        /// </summary>
        public static void Sum()
        {
            double numb1;       //Вводимое число 1
            double numb2;       //Вводимое число 2
            double buffer;      //Вспомогательная переменная

            WriteLine("Введите первое число:");
            while (!double.TryParse(ReadLine(), out numb1))   //Конвертация строки в число, если это возможно. Иначе повторить ввод  
            {
                WriteLine("Вы ввели не число!\nВведите число:");
            }

            WriteLine("Введите второе число:");
            while (!double.TryParse(ReadLine(), out numb2))
            {
                WriteLine("Вы ввели не число!\nВведите число:");
            }

            WriteLine("Введите сумму чисел:");
            while (!double.TryParse(ReadLine(), out buffer) ||
                   buffer != (numb1 + numb2))
            {
                WriteLine("Почти угадал...");
            }
            WriteLine("Угадал!");
        }
    }
}
