using System;
using static System.Console;

namespace HW._06.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[10];
            int[] a2 = new int[10];
            int[] a3 = new int[10];

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                a1[i] = rand.Next(0,9);

                WriteLine($"Введите целочисленный элемент массива номер {i+1}");

                while (!int.TryParse(ReadLine(), out a2[i]))
                {
                    WriteLine("Вы ввели не целое число!");
                }

                a3[i] = a1[i] + a2[i];
            }

            Clear();
           
            WriteLine($"Первый массив: {string.Join(' ', a1)}");
            WriteLine($"Второй массив: {string.Join(' ', a2)}");
            WriteLine($"Массив сумм: {string.Join(' ', a3)}");
        }
    }
}
