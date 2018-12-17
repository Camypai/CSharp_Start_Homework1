using System;
using HomeworkLibrary;

namespace Homework2
{
    public static class Task2
    {
        public static readonly Helpers.MenuItem MenuItem = new Helpers.MenuItem
        {
            Id = new []{ConsoleKey.D2, ConsoleKey.NumPad2},
            Title = "Задание 2",
            Description = "Написать метод подсчета количества цифр числа",
            ItemMethod = Init
        };

        private static void Init()
        {
            var number = int.Parse(Helpers.Question("Введите число"));

            var result = CountFromNumber(number);
            
            Helpers.Print($"Количество цифр в числе {number}: {result}");
            Helpers.Pause();
        }

        private static int CountFromNumber(int number)
        {
            var result = 0;
            do
            {
                number /= 10;
                result++;
            } while (number != 0);

            return result;
        }
    }
}