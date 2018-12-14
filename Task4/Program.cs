using static HomeworkLibrary.Helpers;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Question(@"Введите значение переменной ""a"""));
            var b = int.Parse(Question(@"Введите значение переменной ""b"""));

            var c = a;
            a = b;
            b = c;

            Print($@"Значение переменной ""a"": {a}
Значение переменной ""b"": {b}");

            a += b;
            b = a - b;
            a -= b;

            Print($@"Значение переменной ""a"": {a}
Значение переменной ""b"": {b}");

            Pause();
        }
    }
}
