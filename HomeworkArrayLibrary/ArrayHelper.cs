using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using HomeworkLibrary;

namespace HomeworkArrayLibrary
{
    public static class ArrayHelper
    {
        public enum FillType
        {
            ToStep,
            ToRandom
        }

        public static int[] CreateArray(int size)
        {
            var array = new int[size];
            for (var i = 0; i < size; i++)
            {
                array[i] = new Random().Next(1, 101);
            }

            return array;
        }

        public static int[] CreateArray(int size, int start, int step)
        {
            var array = new int[size];
            for (var i = 0; i < size; i++)
            {
                array[i] = start;
                start += step;
            }

            return array;
        }

        public static int[] CreateArray(int size, FillType fillType, int start = 1, int step = 1)
        {
            var array = new int[size];

            switch (fillType)
            {
                case FillType.ToStep:
                    for (var i = 0; i < size; i++)
                    {
                        array[i] = start;
                        start += step;
                    }

                    break;
                case FillType.ToRandom:
                    for (var i = 0; i < size; i++)
                    {
                        array[i] = new Random().Next(1, 101);
                    }

                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(fillType), fillType, null);
            }

            return array;
        }

        public static int[] CreateArray(string fileName)
        {
            if (!File.Exists(fileName)) throw new FileNotFoundException("Файл не найден");

            var ss = File.ReadAllLines(fileName);
            var array = new int[ss.Length];

            for (var i = 0; i < ss.Length; i++)
            {
                array[i] = int.Parse(ss[i]);
            }

            return array;
        }

        public static IEnumerable<(string login, string password)> CreatePair(string path)
        {
            if (!File.Exists(path)) throw new FileNotFoundException("Файл не найден");

            var result = new List<(string login, string password)>();

            using (var sr = new StreamReader(path, Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();

                    if (line == null) continue;
                    result.Add((line.Split(':')[0], line.Split(':')[1]));
                }
            }

            return result;
        }

        public static int Max(IEnumerable<int> array)
        {
            return array.Max();
        }

        public static int Sum(IEnumerable<int> array)
        {
            return array.Sum();
        }

        public static int[] Inverse(IEnumerable<int> array)
        {
            return array.Select(q => -q).ToArray();
        }

        public static int[] Multi(int[] array, int number)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] *= number;
            }

            return array;
        }

        public static int MaxCount(int[] array)
        {
            var max = array.Max();

            return array.Count(q => q == max);
        }

        public static void Print(IEnumerable<int> array)
        {
            Helpers.Print(string.Join(", ", array));
        }
    }
}