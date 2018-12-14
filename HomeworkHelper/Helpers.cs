using System;

namespace HomeworkHelper
{
    public static class Helpers
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

        public static void Main(string[] args)
        {

        }
    }
}
