using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HomeworkLibrary.Helpers;

namespace Task5
{
    /// <summary>
    /// Написать программу, которая выводит на экран ваше имя, фамилию и город проживания
    /// </summary>
    /// <author>
    /// Горшков Илья
    /// </author>
    class Program
    {
        static void Main(string[] args)
        {
            var firstname = Question("Введите ваше имя");
            var lastname = Question("Введите вашу фамилию");
            var city = Question("Введите ваш город проживания");

            Print($"Имя: {firstname}; Фамилия: {lastname}; Город: {city}");

            // Сделать задание, только вывод организуйте в центре экрана
            Console.SetCursorPosition(25, 13);
            Print($"Имя: {firstname}; Фамилия: {lastname}; Город: {city}");

            // Сделать задание б с использованием собственных методов 
            Print($"Имя: {firstname}; Фамилия: {lastname}; Город: {city}", 25, 13);

            Pause();
        }
    }
}