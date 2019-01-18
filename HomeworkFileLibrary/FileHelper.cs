using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HomeworkFileLibrary
{
    public static class FileHelper
    {
        public static bool WriteFile(string path, string data)
        {
            try
            {
                using (var sw = new StreamWriter(path, false))
                {
                    sw.Write(data);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string GetFile(string path)
        {
            try
            {
                using (var sr = new StreamReader(path, Encoding.UTF8))
                {
                    return sr.ReadToEnd();
                }
            }
            catch
            {
                return null;
            }
        }

        public static IEnumerable<string[]> ParseCsvFile(string path)
        {
            var t = new List<string[]>();

            using (var sr = new StreamReader(path))
            {
                do
                {
                    var stringT = sr.ReadLine().Split(';');
                    t.Add(new[]
                    {
                        stringT[0],
                        stringT[1],
                        stringT[2],
                        stringT[3],
                        stringT[4],
                        stringT[5],
                        stringT[6],
                        stringT[7],
                        stringT[8]
                    });
                } while (!sr.EndOfStream);
            }

            return t;
        }
    }
}