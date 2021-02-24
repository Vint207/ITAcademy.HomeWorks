using System.Text;
using System;
using static System.Console;

namespace HW07.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1;           //Вводимая строка
            int letters, signs;  //Количство букв знаков препинания

            WriteLine("Введите несколько слов через пробел:");

            s1 = ReadLine();

            Write("\nУдалено самое длинное слово:\n" + DeleteLongestWord(s1));
            WriteLine("\n");

            Write("Замена мест самого длинного и самого короткого слова:\n" + ReplaceWords(s1));
            WriteLine("\n");

            CountSymbols(s1, out letters, out signs);
            WriteLine("Количество букв в строке: " + letters);
            WriteLine("Количество знаков препинания в строке: " + signs);
            WriteLine("\n");

            WriteLine(string.Join("\n", StringToArrayWithSort(s1)));           
        }

        /// <summary>
        /// Returns string without longest word
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static string DeleteLongestWord(string s)
        {
            string[] s1 = s.Split(' ');

            for (int i = 0; i < s1.Length - 1; i++)
            {
                if (s1[i].Length > s1[i + 1].Length)
                {
                    string buf = s1[i + 1];
                    s1[i + 1] = s1[i];
                    s1[i] = buf;
                }
            }
            return s = string.Join(" ", s1, 0, s1.Length - 1);
        }

        /// <summary>
        /// Replases longest and shortest words in string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static string ReplaceWords(string s)
        {
            string[] s1 = s.Split(' ');

            int max, min;           //Номера самого длинного и короткого слова в массиве
            string temp1, temp2;    //Буферные переменные

            min = max = 0;

            temp1 = temp2 = s1[0];
            for (int i = 1; i <= s1.Length - 1; i++)
            {
                if (temp1.Length < s1[i].Length)
                {
                    max = i;
                    temp1 = s1[i];
                }

                if (temp2.Length > s1[i].Length)
                {
                    min = i;
                    temp2 = s1[i];
                }
            }

            string buf = s1[min];
            s1[min] = s1[max];
            s1[max] = buf;

            return s = string.Join(" ", s1, 0, s1.Length);
        }

        /// <summary>
        /// Returns amounts of letters and signs in string
        /// </summary>
        /// <param name="s"></param>
        /// <param name="letters"></param>
        /// <param name="signs"></param>
        static void CountSymbols(string s, out int letters, out int signs)
        {
            letters = 0;   //Количство букв
            signs = 0;     //Количство знаков препинания

            foreach (var item in s)
            {
                if (char.IsLetter(item))
                {
                    letters++;
                }
                else if (char.IsPunctuation(item))
                {
                    signs++;
                }
            }
        }

        /// <summary>
        /// Fills an array by substrings of string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static string[] StringToArrayWithSort(string s)
        {
            string[] s1 = s.Split(' ');

            for (int i = 0, j = s1.Length - 1; i < j; i++, j--)
            {
                for (int k = 0; k < s1.Length - 1; k++)
                {
                    if (s1[k].Length > s1[k + 1].Length)
                    {
                        string buf = s1[k + 1];
                        s1[k + 1] = s1[k];
                        s1[k] = buf;
                    }
                }
            }
            return s1;
        }
    }
}
