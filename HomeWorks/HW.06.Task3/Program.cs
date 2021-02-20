using System;
using static System.Console;


namespace HW._06.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[10];

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                a1[i] = rand.Next(0, 9);
            }

            WriteLine($"Массив до реверсии: {string.Join(' ', a1)}");

            UserArray.Reverse(ref a1);

            WriteLine($"Массив после реверсии: {string.Join(' ', a1)}");
        }
    }
}
