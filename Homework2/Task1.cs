using System;
using System.Runtime.InteropServices.ComTypes;
using HomeworkLibrary;

namespace Homework2
{
    public static class Task1
    {
        public static readonly Helpers.MenuItem MenuItem = new Helpers.MenuItem
        {
            Id = new []{ConsoleKey.D1, ConsoleKey.NumPad1},
            Title = "Задание 1",
            Description = "Написать метод, возвращающий минимальное из трех чисел",
            ItemMethod = Init
        };


        private static void Init()
        {
            var a = int.Parse(Helpers.Question("Введите первое число"));
            var b = int.Parse(Helpers.Question("Введите второе число"));
            var c = int.Parse(Helpers.Question("Введите третье число"));

            var result = FindMinAsThree(a, b, c);
            
            Helpers.Print($"Минимальное число среди введённых: {result}");
            Helpers.Pause();
        }

        private static int FindMinAsThree(int a, int b, int c)
        {
            var result = b;
            
            if (a < b && a < c)
            {
                result = a;
            }
            else if (c < a && c < b)
            {
                result = c;
            }

            return result;
        }
    }
}