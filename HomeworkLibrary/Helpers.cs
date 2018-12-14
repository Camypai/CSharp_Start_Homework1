using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLibrary
{
    public class Helpers
    {
        public static void Print(string message)
        {
            Console.WriteLine(message);
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

        //        public static void Pause()
        //        {
        //            Console.ReadKey();
        //        }

        public static void Pause(string message = "Для завершения программы нажмите любую клавишу...")
        {
            Console.Write(message);
            Console.ReadKey();
        }
    }
}
