using static System.Console;
using static System.Convert;
using static HW03.Calculator.Static.Calculator;

namespace HW03.Calculator.Static
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int a, b, r;
                WriteLine("Сложение:");
                WriteLine("Введите a");
                a = ToInt32(ReadLine());
                WriteLine("Введите b");
                b = ToInt32(ReadLine());
                WriteLine($"\n    {a} + {b} = {Sum(a, b)}\n");

                WriteLine("Вычитание:");
                WriteLine("Введите a");
                a = ToInt32(ReadLine());
                WriteLine("Введите b");
                b = ToInt32(ReadLine());
                WriteLine($"\n    {a} - {b} = {Diff(a, b)}\n");

                WriteLine("Умножение:");
                WriteLine("Введите a");
                a = ToInt32(ReadLine());
                WriteLine("Введите b");
                b = ToInt32(ReadLine());
                WriteLine($"\n    {a} * {b} = {Mult(a, b)}\n");

                WriteLine("Деление:");
                WriteLine("Введите a");
                a = int.Parse(ReadLine());
                WriteLine("Введите b");
                b = int.Parse(ReadLine());
                WriteLine($"\n    {a} / {b} = {Quote(a, b)}\n");

                WriteLine("Остаток от деления:");
                WriteLine("Введите a");
                a = int.Parse(ReadLine());
                WriteLine("Введите b");
                b = int.Parse(ReadLine());
                WriteLine($"\n    {a} % {b} = {QuoteRest(a, b)}\n");

                WriteLine("Площадь круга с радиусом r:");
                WriteLine("Введите r");
                r = int.Parse(ReadLine());
                WriteLine($"\n    S = {Square(r)}");

                ReadLine();
                Clear();
            }
        }
    }
}
