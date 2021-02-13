using static System.Console;
using static System.Convert;

namespace HW03.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator Method = new Calculator();
            while (true)
            {
                int a, b, r;
                WriteLine("Сложение:");
                WriteLine("Введите a");
                a = ToInt32(ReadLine());
                WriteLine("Введите b");
                b = ToInt32(ReadLine());
                WriteLine($"\n    {a} + {b} = {Method.Sum(a, b)}\n");

                WriteLine("Вычитание:");
                WriteLine("Введите a");
                a = ToInt32(ReadLine());
                WriteLine("Введите b");
                b = ToInt32(ReadLine());
                WriteLine($"\n    {a} - {b} = {Method.Diff(a, b)}\n");

                WriteLine("Умножение:");
                WriteLine("Введите a");
                a = ToInt32(ReadLine());
                WriteLine("Введите b");
                b = ToInt32(ReadLine());
                WriteLine($"\n    {a} * {b} = {Method.Mult(a, b)}\n");

                WriteLine("Деление:");
                WriteLine("Введите a");
                a = int.Parse(ReadLine());
                WriteLine("Введите b");
                b = int.Parse(ReadLine());
                WriteLine($"\n    {a} / {b} = {Method.Quote(a, b)}\n");

                WriteLine("Остаток от деления:");
                WriteLine("Введите a");
                a = int.Parse(ReadLine());
                WriteLine("Введите b");
                b = int.Parse(ReadLine());
                WriteLine($"\n    {a} % {b} = {Method.QuoteRest(a, b)}\n");

                WriteLine("Площадь круга с радиусом r:");
                WriteLine("Введите r");
                r = int.Parse(ReadLine());
                WriteLine($"\n    S = {Method.Square(r)}");

                ReadLine();
                Clear();
            }
        }
    }
}


