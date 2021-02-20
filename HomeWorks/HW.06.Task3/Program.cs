﻿using System;
using static System.Console;
using System.Diagnostics;


namespace HW._06.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] a1 = new long[100_000_000];

            Random rand = new Random();

            for (int i = 0; i < a1.Length; i++)
            {
                a1[i] = rand.Next(0, 9);
            }

            WriteLine($"Массив до реверсии: {string.Join(' ', a1)}");       

            Stopwatch SWatch = new Stopwatch();

            SWatch.Start();
            UserArray.Reverse(a1);
            SWatch.Stop();

            WriteLine($"Массив после реверсии: {string.Join(' ', a1)}");

            TimeSpan ts = SWatch.Elapsed;

            string eTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

            WriteLine($"RunTime {eTime}");
        }
    }
}
