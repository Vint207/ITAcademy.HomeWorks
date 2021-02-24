using System.Text;
using System;
using static System.Console;

namespace HW07.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2, s3;
            byte find;
            char sign;


            WriteLine("Введите набор букв и цифр, добавив арифметический знак:");

            s1 = ReadLine();

            s2 = s3 = "";
            sign = ' ';
            find = 1;
            foreach (var item in s1)
            {
                switch (find)
                {
                    case 1:
                        if (char.IsDigit(item))
                        {
                            s2 = string.Concat(s2, item);
                        }
                        else if (item.Equals('+') || item.Equals('-') || item.Equals('8') || item.Equals('/'))
                        {
                            find = 2;
                            sign = item;
                        }
                        break;

                    case 2:
                        if (char.IsDigit(item))
                        {
                            s3 = string.Concat(s3, item);
                        }
                        break;
                }
            }

            switch (sign)
            {
                case '+':
                    WriteLine($"{s2} + {s3} = {Convert.ToDouble(s2) + Convert.ToDouble(s3)}");
                    break;

                case '-':
                    WriteLine($"{s2} - {s3} = {Convert.ToDouble(s2) - Convert.ToDouble(s3)}");
                    break;

                case '*':
                    WriteLine($"{s2} * {s3} = {Convert.ToDouble(s2) * Convert.ToDouble(s3)}");
                    break;

                case '/':
                    WriteLine($"{s2} / {s3} = {Convert.ToDouble(s2) / Convert.ToDouble(s3)}");
                    break;
            }     
        }
    }
}
