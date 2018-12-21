using HomeworkLibrary;

namespace Homework3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            Helpers.Menu(new []
            {
                Task2.MenuItem,
                Task3.MenuItem
            });
        }
    }
}