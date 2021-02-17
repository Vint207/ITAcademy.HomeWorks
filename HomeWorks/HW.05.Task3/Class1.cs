using System;
using static System.Console;

namespace HW._05.Task3
{
    public static class Greeting
    {
        /// <summary>
        /// Returns phrase depending on the current time
        /// </summary>
        public static void TimeHello()
        {
            WriteLine(DateTime.Now);

            int hour;

            hour = DateTime.Now.Hour;

            switch (true)
            {
                case true when hour >= 8 && hour < 12:

                    WriteLine("Good morning, guys");
                    break;

                case true when hour >= 12 && hour < 15:

                    WriteLine("Good day, guys");
                    break;

                case true when hour >= 15 && hour < 22:

                    WriteLine("Good evening, guys");
                    break;

                default:
                    break;
            }
        }
    }
}