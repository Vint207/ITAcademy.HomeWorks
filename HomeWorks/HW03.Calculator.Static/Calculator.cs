using System;
using System.Collections.Generic;
using System.Text;

namespace HW03.Calculator.Static
{
    class Calculator
    {
        /// <summary>
        /// Returns result a + b
        /// </summary>
        /// <returns></returns>
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Returns result a - b
        /// </summary>
        /// <returns></returns>
        public static int Diff(int a, int b)
        {
            return a - b;
        }
        /// <summary>
        /// Returns result a * b
        /// </summary>
        /// <returns></returns>
        public static int Mult(int a, int b)
        {
            return a * b;
        }
        /// <summary>
        /// Returns result a / b
        /// </summary>
        /// <returns></returns>
        public static int Quote(int a, int b)
        {
            return a / b;
        }
        /// <summary>
        /// Returns result a % b
        /// </summary>
        /// <returns></returns>
        public static double QuoteRest(int a, int b)
        {
            return a % b;
        }
        /// <summary>
        ///  Returns result Pi * r * r
        /// </summary>
        /// <returns></returns>
        public static double Square(int r)
        {
            return Math.PI * r * r;
        }
    }
}
