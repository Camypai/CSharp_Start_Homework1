using System;
using System.IO;
using System.Linq;
using HomeworkLibrary;

namespace Homework4
{
    public class CoolArray
    {
        private readonly int[] _array;
        private readonly Random _rnd = new Random();

        public enum FillType
        {
            ToStep,
            ToRandom
        }
        
        public CoolArray(int size)
        {
            _array = new int[size];
            for (var i = 0; i < size; i++)
            {
                _array[i] = _rnd.Next(1, 101);
            }
        }
        
        public CoolArray(int size, int start, int step)
        {
            _array = new int[size];
            for (var i = 0; i < size; i++)
            {
                _array[i] = start;
                start += step;
            }
        }

        public CoolArray(int size, FillType fillType, int start = 1, int step = 1)
        {
            _array = new int[size];
            
            switch (fillType)
            {
                case FillType.ToStep:
                    for (var i = 0; i < size; i++)
                    {
                        _array[i] = start;
                        start += step;
                    }
                    break;
                case FillType.ToRandom:
                    for (var i = 0; i < size; i++)
                    {
                        _array[i] = _rnd.Next(1, 101);
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(fillType), fillType, null);
            }
        }

        public CoolArray(string fileName)
        {
            if (File.Exists(fileName))
            {
                var ss = File.ReadAllLines(fileName);
                _array = new int[ss.Length];

                for (var i = 0; i < ss.Length; i++)
                {
                    _array[i] = int.Parse(ss[i]);
                }
            }
            else
            {
                Helpers.Print("Файл не найден");
            }
        }

        public int Max => _array.Max();

        public int Sum => _array.Sum();

        public int[] Inverse => _array.Select(q => -q).ToArray();

        public void Multi(int number)
        {
            for (var i = 0; i < _array.Length; i++)
            {
                _array[i] *= number;
            }
        }

        public int MaxCount
        {
            get
            {
                var max = _array.Max();

                return _array.Count(q => q == max);
            }
        }

        public int this[int i]
        {
            get => _array[i];
            set => _array[i] = value;
        }

        public void Print()
        {
            foreach (var item in _array)
            {
                Helpers.Print($"{item,4}", true);
            }
        }
        
        public static void Print(int[] array)
        {
            foreach (var item in array)
            {
                Helpers.Print($"{item,4}", true);
            }
        }
    }
}