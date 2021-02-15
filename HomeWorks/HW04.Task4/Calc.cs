﻿using static System.Console;

namespace HW04.Task4
{
    public static class Calc
    {
        /// <summary>
        /// Check input sum or difference of two input numbers if it is a numbers. 
        /// Prove the sum or difference and offer a hint
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

        point:

            WriteLine("Введите + или - :");
            switch (ReadLine())
            {
                case "+":
                    WriteLine("Введите сумму чисел:");
                    while (!double.TryParse(ReadLine(), out buffer) || buffer != (numb1 + numb2))
                    {
                        WriteLine("Почти угадал...");
                        WriteLine($"Попробуй число больше {numb1 + numb2 - 3} и меньше {numb1 + numb2 + 3}");
                    }
                    WriteLine("Угадал!");
                    break;

                case "-":
                    WriteLine("Введите разность чисел:");
                    while (!double.TryParse(ReadLine(), out buffer) || buffer != (numb1 - numb2))
                    {
                        WriteLine("Почти угадал...");
                        WriteLine($"Попробуй число больше {numb1 - numb2 - 3} и меньше {numb1 - numb2 + 3}");
                    }
                    WriteLine("Угадал!");
                    break;

                default:
                    goto point;      //Возврат к вводу оператора, если он неверный
            }
        }
    }
}
