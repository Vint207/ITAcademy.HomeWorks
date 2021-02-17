using System;
using static System.DateTime;
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
            WriteLine($"{Now.Hour} : {Now.Minute} : {Now.Second}");

            switch (true)
            {
                case true when Now.Hour >= 8 & Now.Hour < 12:

                    WriteLine("Good morning, guys");
                    break;

                case true when Now.Hour >- 12 & Now.Hour < 15:

                    WriteLine("Good day, guys");
                    break;

                case true when Now.Hour >= 15 & Now.Hour < 22:

                    WriteLine("Good evening, guys");
                    break;

                default:
                    break;
            }
        }
    }
}
