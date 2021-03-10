using System.Collections.Generic;
using static System.Console;

namespace HW09.Task1
{
    class Program
    {
        public static List<UserInfo> userBase = new();
        //public static ArrayList userBase;

        static void Main()
        {
            while (true)
            {
                UserInfo user = new();
                userBase.Add(user);
                ChatBot chat = new();
                chat.Chat(user);
            }
        }
    }
}
