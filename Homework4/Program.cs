using HomeworkLibrary;

namespace Homework4
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
                Task1.MenuItem,
                Task2.MenuItem,
                Task3.MenuItem,
                Task4.MenuItem
            });
        }
    }
}