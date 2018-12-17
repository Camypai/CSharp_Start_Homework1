using System;
using HomeworkLibrary;

namespace Homework2
{
    public static class Task4
    {
        public static readonly Helpers.MenuItem MenuItem = new Helpers.MenuItem
        {
            Id = new[] {ConsoleKey.D4, ConsoleKey.NumPad4},
            Title = "Задание 4",
            Description =
                @"Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
программа пропускает его дальше или не пропускает. 
С помощью цикла do while ограничить ввод пароля тремя попытками",
            ItemMethod = Init
        };

        private static void Init()
        {
            var count = 0;
            do
            {
                count++;
                var login = Helpers.Question("Введите логин");
                var password = Helpers.Question("Введите пароль");
                if (CheckAuth(login, password))
                {
                    break;
                }

                Helpers.Print("Логин или пароль введены неправильно.");
            } while (count < 3);

            Helpers.Print("Вы авторизованы.");
            Helpers.Pause();
        }

        private static bool CheckAuth(string login, string password)
        {
            var _login = "root";
            var _password = "GeekBrains";

            return _login.Equals(login) && _password.Equals(password);
        }
    }
}