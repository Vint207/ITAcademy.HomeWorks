using System;
using static System.Console;

namespace HW09.Task1
{
    class ConsoleWork 
    {
        internal static bool Chose()
        {
            ConsoleKey key = ConsoleKey.DownArrow;
            CursorVisible = false;
            Write("Да   \nНет  ");
            SetCursorPosition(0, GetCursorPosition().Top - 1);
            while (true)
            {
                if (key.Equals(ConsoleKey.UpArrow))
                { if (Overwrite(key, ConsoleKey.DownArrow, true, 2, -1, out key)) { return true; } }
               
                if (key.Equals(ConsoleKey.DownArrow))
                { if (Overwrite(key, ConsoleKey.UpArrow, false, 1, 1, out key)) { return false; } }
            }
        }

        internal static bool Overwrite(ConsoleKey key, ConsoleKey nKey, bool write, byte rowOut, int rowIn, out ConsoleKey pKey)
        {
            pKey = key;
            ForegroundColor = ConsoleColor.Yellow;
            SetCursorPosition(0, GetCursorPosition().Top + rowIn);
            if (write) { Write("->Да "); } else { Write("->Нет"); }

            while (pKey != ConsoleKey.Enter && pKey != nKey) { pKey = ReadKey().Key; }

            ForegroundColor = ConsoleColor.White;
            if (pKey.Equals(ConsoleKey.Enter)) { SetCursorPosition(0, GetCursorPosition().Top + rowOut); CursorVisible = true; return true; }
          
            SetCursorPosition(0, GetCursorPosition().Top);
            if (write) { Write("Да   "); } else { Write("Нет  "); }
            return false;
        }
    }
}
