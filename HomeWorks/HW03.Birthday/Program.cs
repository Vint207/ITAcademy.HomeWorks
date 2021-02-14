using static System.Console;

namespace HW03.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort birthYear;
            ushort birthMonth;
            ushort curYear;
            ushort curMonth;

            while (true)
            {
                WriteLine("Введите год рождения: ");
                birthYear = ushort.Parse(ReadLine());

                WriteLine("Введите месяц рождения: ");
                birthMonth = ushort.Parse(ReadLine());

                WriteLine("Введите текущий год: ");
                curYear = ushort.Parse(ReadLine());

                WriteLine("Введите текущий месяц: ");
                curMonth = ushort.Parse(ReadLine());

                if (curYear >= birthYear & birthMonth < 13 & curMonth < 13)
                {
                    WriteLine($"Ваш возраст: \nЛет: {curYear - birthYear} \nМесяцев: {curMonth - birthMonth}");
                }
                else
                {
                    WriteLine("Введенные даты некорректны");   
                }
                ReadLine();
                Clear();
            }
        }
    }
}
