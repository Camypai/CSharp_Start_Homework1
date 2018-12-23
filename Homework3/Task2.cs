using System;
using System.Collections.Generic;
using HomeworkLibrary;

namespace Homework3
{
    
    /// <summary>
    /// С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
    /// Требуется подсчитать сумму всех нечётных положительных чисел. 
    /// Сами числа и сумму вывести на экран, используя tryParse 
    /// </summary>
    /// <author>
    /// Горшков Илья
    /// </author>
    public static class Task2
    {
        public static readonly Helpers.MenuItem MenuItem = new Helpers.MenuItem
        {
            Id = new[] {ConsoleKey.D2, ConsoleKey.NumPad2},
            Title = "Задание 2",
            Description =
                @"С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
Требуется подсчитать сумму всех нечётных положительных чисел. 
Сами числа и сумму вывести на экран, используя tryParse",
            ItemMethod = Init
        };

        private static void Init()
        {
            int num;
            var sum = 0;
            var numbers = new List<int>();
            do
            {
                var tryGetNum = int.TryParse(Helpers.Question("Введите число"), out num);
                if (tryGetNum)
                {
                    if (num % 2 <= 0) continue;
                    CalcSumOdd(num, ref sum, ref numbers);
                }
                else
                {
                    Helpers.Print("Введите целое число");
                }
            } while (num != 0);
            
            Helpers.Print();
            Helpers.Print($"Сумма введённых нечетных положительных чисел равна {sum}");
            Helpers.Print($"Нечётные положительные числа, которые вы ввели: {string.Join(", ", numbers)}");
            Helpers.Pause();
        }

        private static void CalcSumOdd(int num, ref int sum, ref List<int> numbers)
        {
            sum += num;
            numbers.Add(num);
        } 
    }
}