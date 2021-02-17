using static System.Console;

namespace HW._05.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numb;  //Вводимое число
            uint sum;   //Сумма всех натуральных чисел <= numb

            while (true)
            {
                WriteLine("Введите натуральное число:");
                while (!uint.TryParse((ReadLine()), out numb))
                {
                    WriteLine("Введите натуральное число:");
                }

                sum = 0;

                for (uint i = 1; i < numb; i++)
                {
                    sum += i;
                    Write($"{i} + ");
                }

                Write($"{numb} = {numb + sum}\n\n");
            }
        }
    }
}