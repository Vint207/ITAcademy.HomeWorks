using System;
using static System.Console;

namespace HW04.Task1
{
    public static class Calc
    {        
        /// <summary>
        /// Write sum of two input numbers if it is a numbers
        /// </summary>
        public static void Sum()
        {
            double numb1;          //Вводимое число 1   
            double numb2;          //Вводимое число 2

            WriteLine("Введите первое число:");
            while (!double.TryParse(ReadLine(), out numb1))    //Конвертация строки в число, если это возможно. Иначе повторить ввод  
            {
                WriteLine("Вы ввели не число!\nВведите число:");
            }

            WriteLine("Введите второе число:");
            while (!double.TryParse(ReadLine(), out numb2))
            {
                WriteLine("Вы ввели не число!\nВведите число:");
            }
            WriteLine($"\n{numb1} + {numb2} = {numb1 + numb2}"); 
        }
    }
}
