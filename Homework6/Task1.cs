using System;
using System.IO;
using HomeworkLibrary;

namespace Homework6
{
    /// <summary>
    /// Изменить программу вывода таблицы функции так, 
    /// чтобы можно было передавать функции типа double (double, double). 
    /// Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x) 
    /// </summary>
    /// <author>
    /// Горшков Илья
    /// </author>
    public static class Task1
    {
        public static readonly Helpers.MenuItem MenuItem = new Helpers.MenuItem
        {
            Id = new []{ConsoleKey.D1, ConsoleKey.NumPad1},
            Title = "Задание 1",
            Description = @"Изменить программу вывода таблицы функции так, 
чтобы можно было передавать функции типа double (double, double). 
Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x)",
            ItemMethod = Init
        };
        
        private delegate double Fun(double x, double y);

        private static void Init()
        {
            Helpers.Print("Пример с функцией a*x^2:");
            Table(MyFunc, 2, 5);
            
            Helpers.Print("Пример с функцией a*sin(x):");
            Table(MyFunc2, 2, 5);
            
            Helpers.Pause();
        }
        
        private static void Table(Fun F, double x, double a)
        {
            Helpers.Print("----- X ----- Y -----");
            while (x <= a)
            {
                Helpers.Print($"| {x,8:0.000} | {F(x, a),8:0.000} |");
                x += 1;
            }
            Helpers.Print("---------------------");
        }

        private static double MyFunc(double x, double a)
        {
            return a * (x*x);
        }
        
        private static double MyFunc2(double x, double a)
        {
            return a * Math.Sin(x);
        }
    }
}