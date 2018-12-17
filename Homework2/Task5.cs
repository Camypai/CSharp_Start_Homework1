using System;
using HomeworkLibrary;

namespace Homework2
{
    
    /// <summary>
    /// а) Написать программу, которая запрашивает массу и рост человека, 
    /// вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
    /// б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса. 
    /// </summary>
    /// <author>
    /// Горшков Илья
    /// </author>
    public static class Task5
    {
        public static readonly Helpers.MenuItem MenuItem = new Helpers.MenuItem
        {
            Id = new[] {ConsoleKey.D5, ConsoleKey.NumPad5},
            Title = "Задание 5",
            Description =
                @"а) Написать программу, которая запрашивает массу и рост человека, 
вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.

б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.",
            ItemMethod = Init
        };

        private static void Init()
        {
            var m = double.Parse(Helpers.Question("Введите массу в кг"));
            var h = double.Parse(Helpers.Question("Введите рост в метрах"));

            var index = CalcIndex(m, h);
            
            Helpers.Print($"Ваш индекс массы равен: {index:f2}");

            Helpers.Print(CheckIndexAndPrintStatus(index));
            Helpers.Pause();
            
        }

        private static double CalcIndex(double m, double h)
        {
            return m / (h * h);;
        }

        private static string CheckIndexAndPrintStatus(double index)
        {
            if (index >= 18.5 && index <= 24.99)
            {
                return "Ваш индекс массы в норме.";
            }

            if (index < 18.5)
            {
                return $"Для нормы веса вам необходимо набрать {(18.5 - index):f2} кг";
            }

            return $"Для нормы веса вам необходимо похудеть на {(index - 24.99):f2} кг";

        }
    }
}