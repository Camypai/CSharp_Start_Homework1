using static HomeworkLibrary.Helpers;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstname = Question("Введите ваше имя");
            var lastname = Question("Введите вашу фамилию");
            var age = int.Parse(Question("Введите ваш возраст"));
            var height = double.Parse(Question("Введите ваш рост"));
            var weight = double.Parse(Question("Введите ваш вес"));

            Print("Имя: " + firstname + "; Фамилия: " + lastname + "; Возраст: " + age + "; Рост: " + height +
                  "; Вес: " + weight);
            Print(string.Format("Имя: {0}; Фамилия: {1}; Возраст: {2}; Рост: {3}; Вес: {4}", firstname, lastname, age, height, weight));
            Print($"Имя: {firstname}; Фамилия: {lastname}; Возраст: {age}; Рост: {height}; Вес: {weight}");

            Pause();
        }
    }
}