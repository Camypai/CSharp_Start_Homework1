using HomeworkLibrary;

namespace Homework2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            Helpers.Menu(new[]
            {
                Task1.MenuItem,
                Task2.MenuItem,
                Task3.MenuItem,
                Task4.MenuItem,
                Task5.MenuItem,
                Task6.MenuItem,
                Task7.MenuItem
            });
        }
    }
}