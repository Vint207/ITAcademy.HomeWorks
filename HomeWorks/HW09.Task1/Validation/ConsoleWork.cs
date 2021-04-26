using System;
using static System.Console;
using static System.ConsoleKey;

namespace HW09.Task1
{
    sealed class ConsoleWork
    {

        internal static bool Chose()
        {
            ConsoleKey temp, key = DownArrow;
            CursorVisible = false;
            bool result = false;
            SetCursorPosition(0, GetCursorPosition().Top + 1);
            while (true)
            {
                if (key == UpArrow)
                {
                    Overwrite1(key);
                    temp = ReadKey().Key;
                    if (temp == DownArrow) { key = temp; }
                    if (temp == Enter) { result = true; break; }
                }
                if (key == DownArrow)
                {
                    Overwrite1(key);
                    temp = ReadKey().Key;
                    if (temp == UpArrow) { key = temp; }
                    if (temp == Enter) { result = false; break; }
                }

            }
            SetCursorPosition(0, GetCursorPosition().Top + 1);
            CursorVisible = true;
            ForegroundColor = ConsoleColor.White;
            return result;
        }

        internal static void Overwrite1(ConsoleKey key)
        {
            switch (key)
            {
                case UpArrow:
                    SetCursorPosition(0, GetCursorPosition().Top - 1);
                    ForegroundColor = ConsoleColor.Yellow;
                    Write("->Да \n");
                    ForegroundColor = ConsoleColor.White;
                    Write("Нет  ");
                    break;

                case DownArrow:
                    SetCursorPosition(0, GetCursorPosition().Top - 1);
                    ForegroundColor = ConsoleColor.White;
                    Write("Да   \n");
                    ForegroundColor = ConsoleColor.Yellow;
                    Write("->Нет");
                    break;
            }
            ForegroundColor = ConsoleColor.Black;
        }
    }
}
