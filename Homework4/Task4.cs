using System;
using HomeworkArrayLibrary;
using HomeworkLibrary;

namespace Homework4
{
    /// <summary>
    /// *Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
    /// Создайте структуру Account, содержащую Login и Password. Использовать StreamReader 
    /// </summary>
    /// <author>
    /// Горшков Илья
    /// </author>
    public static class Task4
    {
        public static readonly Helpers.MenuItem MenuItem = new Helpers.MenuItem
        {
            Id = new[] {ConsoleKey.D4, ConsoleKey.NumPad4},
            Title = "Задание 4",
            Description =
                @"*Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
Создайте структуру Account, содержащую Login и Password. Использовать StreamReader.",
            ItemMethod = Init
        };

        private static void Init()
        {
            CheckAuth();
        }

        private static void CheckAuth()
        {
            var loginPassPairs = ArrayHelper.CreatePair("/Storage/ArrayForTaskFour.txt");

            foreach (var loginPassPair in loginPassPairs)
            {
                if (loginPassPair.login != "root" || loginPassPair.password != "GeekBrains") continue;
                Helpers.Print("Вы прошли авторизацию.");
                Helpers.Pause();
            }
        }
    }
}