using System;

namespace HW._06.Task2
{
    public static class UserArray
    {
        /// <summary>
        /// Shifts right all elements of array from particular index
        /// </summary>
        /// <param name="a"> array of int </param>
        /// <param name="index"> Start index to shift </param>
        public static void Shift(int[] a, int index)
        {
            for (int i = a.Length-1; i > index; i--)
            {
                a[i] = a[i - 1];
            }
        }
    }
}
