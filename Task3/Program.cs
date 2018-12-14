using System;
using static HomeworkLibrary.Helpers;

namespace Task3
{
    /// <summary>
    /// Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
    /// Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
    /// </summary>
    /// <author>
    /// Горшков Илья
    /// </author>
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Question("Введите координату x для первой точки"));
            var y1 = double.Parse(Question("Введите координату у для первой точки"));
            var x2 = double.Parse(Question("Введите координату x для второй точки"));
            var y2 = double.Parse(Question("Введите координату у для второй точки"));

            var r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            // Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода
            var r2 = DistanceBetweenPoints(x1, y1, x2, y2);

            Print($"Расстояние между двумя введёнными точками равняется {r:f2}");
            Print($"Расстояние между двумя введёнными точками равняется {r2:f2}");

            Pause();
        }

        private static double DistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {
            var result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return result;
        }
    }
}