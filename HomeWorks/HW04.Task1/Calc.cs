using System;
using static System.Console;
using System.Threading;

namespace HW04.Task1
{
    public static class Calc
    {
        public static void Sum()
        {
            double numb1;
            double numb2;

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
            WriteLine($"\n{numb1} + {numb2} = {numb1 + numb2}"); 
        }
    }
}
