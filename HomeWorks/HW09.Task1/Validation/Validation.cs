using System.Text.RegularExpressions;
using static HW09.Task1.Phrases;
using static System.Console;

namespace HW09.Task1
{
    sealed class Validation
    {

        /// <summary>
        /// Calls the console chose option method
        /// </summary>
        /// <returns></returns>
        internal static bool CheckInfo() => ConsoleWork.Chose();

        /// <summary>
        /// Call method Check that validates user's input
        /// </summary>
        /// <returns></returns>
        internal static void CheckInfo(string request, out string s)
        {
            s = ReadLine();
            while (s == "" || !Check(s, request, out s))
            { WriteLine($"{Phrase("Wrong1")} {Phrase("Wrong2")}"); s = ReadLine(); }
        }

        /// <summary>
        /// Validates user's input
        /// </summary>
        /// <returns></returns>
        private static bool Check(string s, string request, out string buf)
        {   
            buf = s;
            return request switch
            {
                "Name" => Regex.IsMatch(buf, @"^[a-w\|а-я]{1,12}$", RegexOptions.IgnoreCase),
                "Ticket" => Regex.IsMatch(buf, @"^[0-9]{7}$"),
                "Pasport" => Regex.IsMatch(buf, @"^[A-W]{2}[0-9]{5}$"),
                "Password" => Regex.IsMatch(buf, @"^[0-9\|a-w]{6}$", RegexOptions.IgnoreCase),
                _ => false
            };

        }
    }
}
