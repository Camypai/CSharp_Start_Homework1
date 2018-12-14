using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HomeworkLibrary.Helpers;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstname = Question("Введите ваше имя");
            var lastname = Question("Введите вашу фамилию");
            var city = Question("Введите ваш город проживания");

            Print($"Имя: {firstname}; Фамилия: {lastname}; Город: {city}");
            Console.SetCursorPosition(25, 13);
            Print($"Имя: {firstname}; Фамилия: {lastname}; Город: {city}");
            Print($"Имя: {firstname}; Фамилия: {lastname}; Город: {city}", 25, 13);

            Pause();
        }
    }
}