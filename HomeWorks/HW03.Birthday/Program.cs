using System;
using static System.Console;

namespace HW03.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int birthYear;
            int birthMonth;
            int curYear;
            int curMonth;

            WriteLine("Введите год рождения: ");
            birthYear = int.Parse(ReadLine());

            WriteLine("Введите месяц рождения: ");
            birthMonth = int.Parse(ReadLine());

            WriteLine("Введите текущий год: ");
            curYear = int.Parse(ReadLine());

            WriteLine("Введите текущий месяц: ");
            curMonth = int.Parse(ReadLine());

            if (curYear >= birthYear)
            {
                WriteLine($"Ваш возраст: \nлет: {curYear - birthYear} \nмесяцев: {curMonth - birthMonth}");
            }
            ReadLine();
        }
    }
}
