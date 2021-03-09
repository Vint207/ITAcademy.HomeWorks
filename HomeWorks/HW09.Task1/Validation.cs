namespace HW09.Task1
{
    class Validation
    {

        public static bool Check(string s, string request, out string buf)
        {
            buf = "Неизвестно";

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

                case "Baggage":
                    s = s.ToUpper();
                    if (s.Equals("ДА")) { s = "Есть"; }
                    else if (s.Equals("НЕТ")) { s = "Нет"; }
                    else { return false; }
                    break;
            }
            buf = s;
            return true;
        }
    }
}
