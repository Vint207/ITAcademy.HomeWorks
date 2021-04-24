using static HW09.Task1.Phrases;
using static HW09.Task1.Validation;
using static System.Console;

namespace HW09.Task1
{
    sealed class ChatBot
    {
        public string botName;

        public ChatBot() { botName = "Гробик"; }

        public ChatBot(string n) { botName = n; }

        public void Greeting()
        {
            WriteLine($"{Phrase("Greet")}. Звать меня {botName}. Ты зарегистрирован?");
            
            switch (CheckInfo())
            {
                case true:
                    string name, password;
                    WriteLine("Введи свое имя, чтобы войти в аккаунт.");
                    CheckInfo("Name", out name);

                    WriteLine("Введи пароль. (6 цифр)");
                    CheckInfo("Password", out password);

                    foreach (User user in UserBase.itemList)
                    {
                        if (user.Name.Equals(name) && user.Password.Equals(password))
                        {
                            WriteLine($"{user.Name}, ты хочешь изменить данные профиля?)");
                            if (CheckInfo()) 
                            { 
                                Registration(user);
                                Chat(user); 
                            }
                            break;
                        }
                    }
                    break;

                case false:
                    WriteLine($"Давай создадим аккаунт.");
                    User newUser = new();
                    UserBase.itemList.Add(newUser);

                    Registration(newUser);
                    WriteLine($"{Phrase("Praise")}, {newUser.Name}, теперь ты зарегистрирован в системе.");
                    Chat(newUser);
                    break;
            }
        }

        void Registration(User user)
        {
            string temp;
            WriteLine($"Введи свое имя. (Используй только буквы)");
            CheckInfo("Name", out temp);
            user.Name = temp;
            WriteLine($"{Phrase("Greet")}, {user.Name}.");

            WriteLine("Придумай пароль аккаунта. (6 цифр)");
            CheckInfo("Password", out temp);
            user.Password = temp;
            WriteLine($"Пароль {user.Password} {Phrase("Prove")}.");
        }

        void Chat(User user)
        {
            WriteLine($"{user.Name}, хочешь заказать суши?");
            while (!CheckInfo()) WriteLine($"{Phrase("Upset")} ладно.\nХочешь?");           
           

            foreach (var item in SushiBase.itemList) { item.GetInfo(); }

            WriteLine($"{Phrase("Praise")}, {user.Name}, какие суши ты хочешь?");

            //CheckInfo("Ticket", out user.ticket);
            //WriteLine($"Номер билета {user.ticket} {Phrase("Prove")}.");

            //WriteLine($"{user.name}, введи 6 цифр номера паспорта:");
            //CheckInfo("Pasport", out user.pasport);
            //WriteLine($"Номер паспорта {user.pasport} {Phrase("Prove")}.");

            //WriteLine($"{user.name}, у тебя есть багаж?");
            //user.baggage = CheckInfo() ? "Есть": "Нет";

            //if (user.baggage.Equals("Есть"))
            //{
            //    WriteLine($"{user.name}, в багаже есть что-нибудь запрещенное?");
            //    user.contraband = CheckInfo() ? "Есть" : "Нет";
            //    if (user.contraband.Equals("Есть")) { WriteLine($"Я звоню копам!"); return; }
            //}
            //WriteLine($"{Phrase("Praise")}, {user.name}, можешь лететь!");
        }
    }
}
