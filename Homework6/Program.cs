using HomeworkLibrary;

namespace Homework6
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
                Task3.MenuItem
            });
        }
    }
}