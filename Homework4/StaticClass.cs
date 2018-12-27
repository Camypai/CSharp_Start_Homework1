using System;
using System.IO;
using System.Linq;
using System.Text;
using HomeworkLibrary;

namespace Homework4
{
    public static class StaticClass
    {
        public static int FindPair(int[] array, int divider)
        {
            var countPair = 0;

            for (var i = 1; i < array.Length; i++)
            {
                if (array[i - 1] % divider == 0 && array[i] % divider != 0 ||
                    array[i] % divider == 0 && array[i - 1] % divider != 0)
                {
                    countPair++;
                }
            }

            return countPair;
        }

        public static int[] GetArrayFromFile(string path = @"/Storage/ArrayForTaskTwo.txt")
        {
            try
            {
                string stringFromFile;
                using (var sr = new StreamReader(path, Encoding.UTF8))
                {
                    stringFromFile = sr.ReadToEnd();
                }

                var result = stringFromFile.Split(' ').Select(int.Parse).ToArray();

                return result;
            }
            catch (FileNotFoundException ex)
            {
                throw new FileNotFoundException($"Файл не найден по указанному пути: {path}");
            }
        }
    }
}