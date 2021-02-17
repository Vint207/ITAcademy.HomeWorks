using System;
using static System.Console;

namespace LettersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;                         //Вводимая строка
            int count1, count2, count3, count4;  //Счетчики символов

            while (true)
            {
                WriteLine("Введите слово:");
                word = ReadLine();

                count1 = count2 = count3 = count4 = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    switch (word[i])
                    {
                        case 'a':
                            count1++;
                            break;

                        case 'A':
                            count2++;
                            break;

                        case 'а':
                            count3++;
                            break;

                        case 'А':
                            count4++;
                            break;

                        default:
                            break;
                    }
                }
                WriteLine($"\nБукв а в слове:\nлатинских a - {count1}\nлатинских А - {count2}");
                WriteLine($"кириллических a - {count3}\nкириллических А - {count4}\n");
            }
        }
    }
}