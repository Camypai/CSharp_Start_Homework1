using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HomeworkLibrary;

namespace Homework6
{
    /// <summary>
    /// Переделать программу Пример использования коллекций для решения следующих задач:
    /// а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
    /// б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
    /// в) отсортировать список по возрасту студента;
    /// г) *отсортировать список по курсу и возрасту студента; 
    /// </summary>
    /// <author>
    /// Горшков Илья
    /// </author>
    public static class Task3
    {
        public static readonly Helpers.MenuItem MenuItem = new Helpers.MenuItem
        {
            Id = new []{ConsoleKey.D3, ConsoleKey.NumPad3},
            Title = "Задание 3",
            Description = @"Переделать программу Пример использования коллекций для решения следующих задач:
а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
в) отсортировать список по возрасту студента;
г) *отсортировать список по курсу и возрасту студента;",
            ItemMethod = Init
        };

        private static void Init()
        {
            var students = GetStudentsFromFile($@"{Directory.GetCurrentDirectory()}/Students01.csv");
            
            Helpers.Print("Количество студентов на 5 и 6 курсах: ", true);
            Helpers.Print(students.Count(q => q.Course > 4 && q.Course <= 6).ToString());
            
            Helpers.Print("Количество студентов в возрасте от 18 до 20 лет на каком курсе учатся: ", true);
            Helpers.Print($"{students.Count(q => q.Age > 17 && q.Age <= 20).ToString()} студентов на {string.Join(",", students.Where(q => q.Age > 17 && q.Age <= 20).Select(q => q.Course))} курсах");
            
            Helpers.Print("Студенты отсортированы по возрасту:");
            foreach (var student in students.OrderBy(q => q.Age))
            {
                Helpers.Print(student.ToString());
            }
            
            Helpers.Print("Студенты отсортированы по курсу и возрасту:");
            foreach (var student in students.OrderBy(q => q.Course).ThenBy(q => q.Age))
            {
                Helpers.Print(student.ToString());
            }
            
            Helpers.Pause();
        }

        private static IEnumerable<Student> GetStudentsFromFile(string path)
        {
            var students = new List<Student>();

            using (var sr = new StreamReader(path))
            {
                do
                {
                    var stringStudent = sr.ReadLine().Split(';');
                    students.Add(new Student
                    {
                        Firstname = stringStudent[0],
                        Lastname = stringStudent[1],
                        University = stringStudent[2],
                        Faculty = stringStudent[3],
                        Department = stringStudent[4],
                        Age = int.Parse(stringStudent[5]),
                        Course = int.Parse(stringStudent[6]),
                        Group = int.Parse(stringStudent[7]),
                        City = stringStudent[8]
                    });
                } while (!sr.EndOfStream);
            }

            return students;
        }
    }
}