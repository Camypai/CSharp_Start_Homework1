using System;
using System.Linq;
using HomeworkLibrary;

namespace Homework5
{
    public static class Task4
    {
        public static readonly Helpers.MenuItem MenuItem = new Helpers.MenuItem
        {
            Id = new []{ConsoleKey.D4, ConsoleKey.NumPad4},
            Title = "Задание 4",
            Description = @"*Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
Например: badc являются перестановкой abcd",
            ItemMethod = Init
        };

        private static void Init()
        {
            var string1 = Helpers.Question("Введите набор символов 1");
            var string2 = Helpers.Question("Введите набор символов 2");

            Helpers.Print(!CheckAnagram(string1, string2)
                ? "Введённые наборы символов не являются анаграммой друг друга"
                : "Введённые наборы символов являются анаграммой друг друга");

            Helpers.Pause();
        }

        private static bool CheckAnagram(string string1, string string2)
        {
            var charArr1 = string1.ToCharArray();
            var charArr2 = string2.ToCharArray();

            var result = charArr1.All(q => charArr2.Any(w => w == q));

            return result;
        }
    }
}