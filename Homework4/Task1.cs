using System;
using HomeworkLibrary;

namespace Homework4
{
    /// <summary>
    /// Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
    /// Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива,
    /// в которых только одно число делится на 3 
    /// </summary>
    /// <author>
    /// Горшков Илья
    /// </author>
    public static class Task1
    {
        public static readonly Helpers.MenuItem MenuItem = new Helpers.MenuItem
        {
            Id = new[] {ConsoleKey.D1, ConsoleKey.NumPad1},
            Title = "Задание 1",
            Description =
                @"Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива,
в которых только одно число делится на 3",
            ItemMethod = Init
        };

        private static void Init()
        {
            Helpers.Print($"Количество пар элементов массива равняется {FindPairDevideByThree(CreateArray())}");
            Helpers.Pause();
        }

        private static int[] CreateArray()
        {
            var arr = new int[20000];
            var rand = new Random();

            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-10000, 10001);
            }

            return arr;
        }

        private static int FindPairDevideByThree(int[] array)
        {
            var countPair = 0;

            for (var i = 1; i < array.Length; i++)
            {
                if (array[i-1] % 3 == 0 && array[i] % 3 != 0 || array[i] % 3 == 0 && array[i-1] % 3 != 0)
                {
                    countPair++;
                }
            }

            return countPair;
        }
    }
}