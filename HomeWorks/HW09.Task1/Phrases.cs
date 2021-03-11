using System;

namespace HW09.Task1
{
    class Phrases
    {
        internal static readonly string[] Greeting = new string[] { "Привет", "Здравствуй", "Салют", "Будь здоров", "Как дела", "Hello", "Hi", "Что как",
        "Приетсвую тебя", "Хеллоу", "Хай", "Как сам", "Даров"};

        internal static readonly string[] Prove = new string[] { "принят", "учтен", "прошел обработку", "подтвержден", "одобрен", "валидирован", "подходит" };

        internal static readonly string[] WrongPhrase1 = new string[] {"Что?", "Не понял.", "Ерунду написал.", "Неразбериха какая-то!",
        "Не могу разобрать.", "Слишком мелко.", "Это на каком языке?", "Чего?", "Каво?", "Неправда!", "Не понимаю.", "Я догадываться должен?",
        "Это некорректный ввод.", "Данные введены неверно!", "Ошибка протокола.", "Ошибка контрольных сумм.", "Хаха, офигенно!", "Прикольно получилось!"};

        internal static readonly string[] WrongPhrase2 = new string[] { "Вводи по новой:", "Напиши еще раз:", "Повтори набор:", "Ты знаешь, что делать:",
        "Вводи опять:", "Давай по новой, Миша:", "Пиши сначала:", "Набирай аккуратнее:", "Повторяй:", "Давай еще раз:"};

        internal static readonly string[] Praise = new string[] { "Молодец", "Красавчик", "Все правильно", "Так держать", "Четко", "Отлично", "Хорошо" };

        internal static string Phrase(string s)
        {
            Random rand = new();
            switch (s)
            {
                case "Greet": return Greeting[rand.Next(0, Greeting.Length)];
                case "Prove": return Prove[rand.Next(0, Prove.Length)];
                case "Wrong1": return WrongPhrase1[rand.Next(0, WrongPhrase1.Length)];
                case "Wrong2": return WrongPhrase2[rand.Next(0, WrongPhrase2.Length)];
                case "Praise": return Praise[rand.Next(0, Praise.Length)];
            }
            return "???";
        }
    }
}
