using static HW09.Task1.Phrases;
using static HW09.Task1.Validation;
using static System.Console;

namespace HW09.Task1
{
    public sealed class User
    {

        internal Bin bin;

        public User() { bin = new(EventMethods.BinBaseChanged); }

        internal string Name { get; set; }
        internal string Password { get; set; }
        internal double Money { get; set; }

        internal void ChangingName()
        {
            Name = CheckInfo("Name");
            WriteLine($"{Phrase("Greet")}, {Name}.");
        }

        internal void ChangingPassword()
        {
            Password = CheckInfo("Password");
            WriteLine($"Пароль {Password} {Phrase("Prove")}.");
        }

        internal void GetInfo() => WriteLine($"Имя: {Name}\nПароль: {Password}\nБаланс: {Money}");
    }
}
