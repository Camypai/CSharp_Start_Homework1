using static HomeworkLibrary.Helpers;

namespace Task4
{

    /// <summary>
    /// Написать программу обмена значениями двух переменных
    /// </summary>
    /// <author>
    /// Горшков Илья
    /// </author>
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Question(@"Введите значение переменной ""a"""));
            var b = int.Parse(Question(@"Введите значение переменной ""b"""));

            // с использованием третьей переменной
            var c = a;
            a = b;
            b = c;

            Print($@"Значение переменной ""a"": {a}
Значение переменной ""b"": {b}");

            // без использования третьей переменной
            a += b;
            b = a - b;
            a -= b;

            Print($@"Значение переменной ""a"": {a}
Значение переменной ""b"": {b}");

            Pause();
        }
    }
}
