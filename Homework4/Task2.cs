using System;
using System.IO;
using HomeworkLibrary;

namespace Homework4
{
    /// <summary>
    /// Реализуйте задачу 1 в виде статического класса StaticClass;
    /// а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
    /// б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
    /// в) **Добавьте обработку ситуации отсутствия файла на диске 
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
                @"Реализуйте задачу 1 в виде статического класса StaticClass;
а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
в) **Добавьте обработку ситуации отсутствия файла на диске",
            ItemMethod = Init
        };

        private static void Init()
        {
            try
            {
                Helpers.Print(
                    $"Количество пар элементов массива равняется {StaticClass.FindPair(StaticClass.GetArrayFromFile(), 3)}");
            }
            catch (FileNotFoundException e)
            {
                Helpers.Print(e.Message);
            }
            catch (Exception e)
            {
                Helpers.Print(e.Message);
            }
            finally
            {
                Helpers.Pause();
            }
        }
    }
}