using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLibrary
{
    /// <summary>
    /// Создать класс с методами, которые могут пригодиться в вашей учебе 
    /// </summary>
    /// <author>
    /// Горшков Илья
    /// </author>
    public class Helpers
    {
        public static void Print(string message = "", bool inLine = false)
        {
            if (!inLine)
            {
                Console.WriteLine(message);
                return;
            }

            Console.Write(message);
        }

        public static void Print(string message, int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine(message);
        }

        public static string Question(string question)
        {
            Console.Write($"{question}: ");
            return Console.ReadLine();
        }

        public static void Pause(string message = "Для завершения программы нажмите любую клавишу...") 
        {
            Console.Write(message);
            Console.ReadKey();
        }

        public static void Menu(IEnumerable<MenuItem> menuPoints)
        {
            do
            {
                Console.Clear();
                
                Print(@"Введите цифру, соответствующую заданию.
Для выхода из программы нажмите ""q""");
                foreach (var menuPoint in menuPoints)
                {
                    Console.WriteLine(menuPoint.Title);
                }

                Print("Номер задания: ", true);
                var input = Console.ReadKey();
                if (menuPoints.Any(q => q.Id.Any(k => k == input.Key)))
                {   
                    var item = menuPoints.FirstOrDefault(q => q.Id.Any(k => k == input.Key));
                    Print();
                    Print(item.Description);
                    item.ItemMethod();
                    continue;
                }

                if (input.Key == ConsoleKey.Q)
                {
                    break;
                }
                
            } while (true);
        }

        public class MenuItem
        {
            public IEnumerable<ConsoleKey> Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public Method ItemMethod { get; set; }

            public delegate void Method();
        }
    }
}