namespace HW._06.Task3
{
    public static class UserArray
    {
        /// <summary>
        /// Reverses an array of int
        /// </summary>
        /// <param name="a">reference to array of int</param>
        public static void Reverse(ref int[] a)
        {
            int buf, j; 

            j = a.Length - 1;
            for (int i = 0; i < j; i++, j--)
            {
                buf = a[i];
                a[i] = a[j];
                a[j] = buf;
            }
        }
    }
}
