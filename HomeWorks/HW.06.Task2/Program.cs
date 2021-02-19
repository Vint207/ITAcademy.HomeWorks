using System;
using static System.Console;


namespace HW._06.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[10];
            int val, index;
            
            for (int i = 0; i < 9; i++)
            {
                WriteLine($"Введите целочисленный элемент массива номер {i + 1}");

                while (!int.TryParse(ReadLine(), out a1[i]))
                {
                    WriteLine("Вы ввели не целое число!");
                }
            }
            Clear();

            WriteLine($"Массив: {string.Join(' ', a1)}");

            WriteLine($"Введите целое число для вставки:");
            while (!int.TryParse(ReadLine(), out val))
            {
                WriteLine("Вы ввели не целое число!\nВведите целое число для вставки:");
            }

            WriteLine($"Введите номер позиции для вставки:");
            while (!int.TryParse(ReadLine(), out index))
            {
                WriteLine("Вы ввели не целое число!\nВведите целое число:");
            }

            WriteLine($"Введите 1, если хотите расширить массив:");
            if (ReadLine() == "1")
            {
                Array.Resize(ref a1, a1.Length + 1);
                SetToArray.SetVal(ref a1, index);
            }
            else
            {
                SetToArray.SetVal(ref a1, index);  
            }
 
            a1.SetValue(val, index);

            WriteLine($"Массив: {string.Join(' ', a1)}");
        }
    }
}
