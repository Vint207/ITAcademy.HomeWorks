using System.Text;
using System;
using static System.Console;

namespace HW07.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1;

            WriteLine("Введите стихотворение:");

            s1 = ReadLine();
            s1 = s1.Replace("O", "A");

            string[] s2 = s1.Split(';');

            WriteLine(string.Join(";\n", s2));
        }
    }
}
