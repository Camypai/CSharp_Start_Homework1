using System;
using HomeworkLibrary;

namespace Homework2
{
    
    // <summary>
    // a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b).
    // б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
    // </summary>
    // <author>
    // Горшков Илья
    // </author>
    public static class Task7
    {
        public static readonly Helpers.MenuItem MenuItem = new Helpers.MenuItem
        {
            Id = new[] {ConsoleKey.D7, ConsoleKey.NumPad7},
            Title = "Задание 7",
            Description =
                @"a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.",
            ItemMethod = Init
        };

        private static void Init()
        {
            var a = int.Parse(Helpers.Question("Введите  первое число"));
            var b = int.Parse(Helpers.Question("Введите второе число"));
            
            PrintNumber(a,b);
            var sum = CalcSumNumber(a, b);
            Helpers.Print($"\nСумма чисел от {a} до {b} равна {sum}");
            Helpers.Pause();
        }

        private static void PrintNumber(int a, int b)
        {
            if (a > b) return;
            Helpers.Print($"{a} ", true);
            PrintNumber(++a, b);
        }

        private static int CalcSumNumber(int a, int b)
        {
            if (a > b) return 0;
            return a + CalcSumNumber(++a, b);
        }
    }
}