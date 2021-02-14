using System;

namespace HW03.Calculator
{
    public class Calculator
    {
        /// <summary>
        /// Returns result a + b
        /// </summary>
        /// <returns></returns>
        public int Sum(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Returns result a - b
        /// </summary>
        /// <returns></returns>
        public int Diff(int a, int b)
        {
            return a - b;
        }
        /// <summary>
        /// Returns result a * b
        /// </summary>
        /// <returns></returns>
        public int Mult(int a, int b)
        {
            return a * b;
        }
        /// <summary>
        /// Returns result a / b
        /// </summary>
        /// <returns></returns>
        public int Quote(int a, int b)
        {
            return a / b;
        }
        /// <summary>
        /// Returns result a % b
        /// </summary>
        /// <returns></returns>
        public double QuoteRest(int a, int b)
        {
            return a % b;
        }
        /// <summary>
        ///  Returns result Pi * r * r
        /// </summary>
        /// <returns></returns>
        public double Square(int r)
        {
            return Math.PI * r * r;
        }
    }
}
