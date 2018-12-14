using static HomeworkLibrary.Helpers;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = double.Parse(Question("Введите вес в кг"));
            var h = double.Parse(Question("Введите рост в метрах"));

            Print($"Индекс массы тела при введённых параметрах составляет {m/(h*h)}");

            Pause();
        }
    }
}
