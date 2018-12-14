using static HomeworkLibrary.Helpers;

namespace Task1
{
    /// <summary>
    /// Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
    /// </summary>
    /// <author>
    /// Горшков Илья
    /// </author>
    class Program
    {
        static void Main(string[] args)
        {
            var firstname = Question("Введите ваше имя");
            var lastname = Question("Введите вашу фамилию");
            var age = int.Parse(Question("Введите ваш возраст"));
            var height = double.Parse(Question("Введите ваш рост"));
            var weight = double.Parse(Question("Введите ваш вес"));

//            используя склеивание
            Print("Имя: " + firstname + "; Фамилия: " + lastname + "; Возраст: " + age + "; Рост: " + height +
                  "; Вес: " + weight);

//            используя форматированный вывод
            Print(string.Format("Имя: {0}; Фамилия: {1}; Возраст: {2}; Рост: {3}; Вес: {4}", firstname, lastname, age, height, weight));

//            используя вывод со знаком $
            Print($"Имя: {firstname}; Фамилия: {lastname}; Возраст: {age}; Рост: {height}; Вес: {weight}");

            Pause();
        }
    }
}