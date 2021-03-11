using static System.Console;
using static HW09.Task1.Phrases;

namespace HW09.Task1
{
    sealed class Validation 
    {

        internal static bool CheckInfo() => ConsoleWork.Chose();

        internal static void CheckInfo(string request, out string s)
        {
            s = ReadLine();
            while (s == "" || !Check(s, request, out s))
            { WriteLine($"{Phrase("Wrong1")} {Phrase("Wrong2")}"); s = ReadLine(); }
        }

        private static bool Check(string s, string request, out string buf)
        {
            buf = s;
            switch (request)
            {
                case "Name":
                    foreach (char i in s) if (!char.IsLetter(i)) { return false; }
                    break;

                case "Ticket":
                    foreach (char i in s) if (!char.IsDigit(i) || s.Length != 7) { return false; }
                    break;

                case "Pasport":
                    foreach (char i in s) if (!char.IsDigit(i) || s.Length != 6) { return false; }
                    break;
            }
            return true;
        }
    }
}
