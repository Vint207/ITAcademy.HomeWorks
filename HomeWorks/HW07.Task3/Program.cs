using static System.Console;
using static System.Convert;


namespace HW07.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2, s3;  //Исходная и вспомогательные строки
            byte find;          //Стадия поиска чисел в строке
            char sign;          //Знак в строке

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
                        else if (item.Equals('+') || item.Equals('-') || item.Equals('*') || item.Equals('/'))
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
                    WriteLine($"{s2} + {s3} = {ToDouble(s2) + ToDouble(s3)}");
                    break;

                case '-':
                    WriteLine($"{s2} - {s3} = {ToDouble(s2) - ToDouble(s3)}");
                    break;

                case '*':
                    WriteLine($"{s2} * {s3} = {ToDouble(s2) * ToDouble(s3)}");
                    break;

                case '/':
                    WriteLine($"{s2} / {s3} = {ToDouble(s2) / ToDouble(s3)}");
                    break;
            }     
        }
    }
}
