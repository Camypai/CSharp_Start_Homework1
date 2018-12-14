using static HomeworkLibrary.Helpers;

namespace Task2
{
    /// <summary>
    /// Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
    /// </summary>
    /// <author>
    /// Горшков Илья
    /// </author>
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
