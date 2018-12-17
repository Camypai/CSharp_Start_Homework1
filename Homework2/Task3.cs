using System;
using HomeworkLibrary;

namespace Homework2
{
    public static class Task3
    {
        public static readonly Helpers.MenuItem MenuItem = new Helpers.MenuItem
        {
            Id = new[] {ConsoleKey.D3, ConsoleKey.NumPad3},
            Title = "Задание 3",
            Description =
                "С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел",
            ItemMethod = Init
        };

        private static void Init()
        {
            var result = CountOddNumber();

            Helpers.Print($"Сумма всех введённых нечётных положительных чисел равна: {result}");
            Helpers.Pause();
        }

        private static int CountOddNumber()
        {
            int number;
            var result = 0;
            do
            {
                number = int.Parse(Helpers.Question("Введите число"));
                if (number % 2 != 0 && number > 0)
                    result += number;
            } while (number != 0);

            return result;
        }
    }
}