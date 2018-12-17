using System;
using HomeworkLibrary;

namespace Homework2
{
    public static class Task6
    {
        public static readonly Helpers.MenuItem MenuItem = new Helpers.MenuItem
        {
            Id = new[] {ConsoleKey.D6, ConsoleKey.NumPad6},
            Title = "Задание 6",
            Description =
                @"*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
«Хорошим» называется число, которое делится на сумму своих цифр. 

Реализовать подсчёт времени выполнения программы, используя структуру DateTime",
            ItemMethod = Init
        };

        private static void Init()
        {
            var start = DateTime.Now;
            var count = 0;
            
            for (var i = 1; i <= 1000000000; i++)
            {
                if (CheckGoodNumber(i))
                {
                    count++;
                }
            }

            var end = DateTime.Now;
            
            Helpers.Print($"Количество \"хороших\" цифр равняется {count}");
            Helpers.Print($"Время выполнения программы: {end - start:g}");
            Helpers.Pause();
        }

        private static bool CheckGoodNumber(int number)
        {
            var result = false;
            var _number = number;
            var sum = 0;

            do
            {
                sum += _number % 10;
                _number /= 10;
            } while (_number != 0);

            if (number % sum == 0)
            {
                result = true;
            }

            return result;
        }
    }
}