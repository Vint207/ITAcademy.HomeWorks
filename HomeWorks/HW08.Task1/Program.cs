using System.Text;
using static System.Console;

namespace HW08.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1;          //Строка для ввода
            byte find;          //Стадия поиска символов в строке

            StringBuilder s = new StringBuilder();

            find = 1;

            WriteLine("Введите строку, содержащую ?:");
            s1 = ReadLine();
            while (s1.IndexOf('?') == -1) { WriteLine("Введите строку с ?:"); s1 = ReadLine(); };

            foreach (var item in s1)
            {
                switch (find)
                {
                    case 1:

                        if (item.Equals('?')) { find = 2; break; }
                        if (!item.Equals('!') && !item.Equals('.')) s.Append(item);
                        break;

                    case 2:

                        if (item.Equals(' ')) s.Append('_'); else s.Append(item);
                        break;
                }
            }
            WriteLine(s.ToString());
        }
    }
}
