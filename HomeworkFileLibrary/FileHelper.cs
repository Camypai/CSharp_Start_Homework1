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
                using (var sr = new StreamReader(path, Encoding.Default))
                {
                    return sr.ReadToEnd();
                }
            }
            catch
            {
                return null;
            }
        }
    }
}