using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using HomeworkLibrary;

namespace Homework5
{
    public static class Task5
    {
        public static readonly Helpers.MenuItem MenuItem = new Helpers.MenuItem
        {
            Id = new []{ConsoleKey.D5, ConsoleKey.NumPad5},
            Title = "Задание 5",
            Description = @"На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы.
В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
<Фамилия> <Имя> <оценки>, где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем из 15 символов,
<оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе.
<Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом.
Пример входной строки: Иванов Петр 4 5 3 
Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников.
Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.",
            ItemMethod = Init
        };

        private static void Init()
        {
            var students = CollectStudentFromFile(@"D:\Projects\CSharp_Start_Homework1\Homework5\files\students.txt", out var count);
            var stupedStudents = MinAverageStudents(students);
            Helpers.Print($"Всего учеников: {count}");
            Helpers.Print("Наименьший балл у:");
            foreach (var stupedStudent in stupedStudents)
            {
                Helpers.Print(stupedStudent.ToString());
            }
            Helpers.Pause();
        }

        private static IEnumerable<Student> CollectStudentFromFile(string path, out int count)
        {
            count = 0;
            var result = new List<Student>();
            using (var sr = new StreamReader(path, Encoding.Default))
            {
                var i = 0;
                while (!sr.EndOfStream)
                {
                    if (i == 0)
                    {
                        int.TryParse(sr.ReadLine(), out count);
                        i++;
                        continue;
                    } 
                    var arr = sr.ReadLine().Split(' ');
                    result.Add(new Student
                    {
                        Ball1 = int.Parse(arr[2]),
                        Ball2 = int.Parse(arr[3]),
                        Ball3 = int.Parse(arr[4]),
                        Firstname = arr[1],
                        Lastname = arr[0]
                    });
                }
            }

            return result;
        }

        private static IEnumerable<Student> MinAverageStudents(IEnumerable<Student> students)
        {
            var result = new List<Student>();
            result.AddRange(students.Where(q => q.Average == students.Min(w => w.Average)));

            return result;
        }
    }
}