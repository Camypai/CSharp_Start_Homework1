using HomeworkLibrary;

namespace Homework5
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
                Task4.MenuItem,
                Task5.MenuItem
            });
        }
    }
}