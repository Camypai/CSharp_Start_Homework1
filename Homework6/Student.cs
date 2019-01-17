namespace Homework6
{
    public class Student
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string University { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public string City { get; set; }
        public int Course { get; set; }
        public int Age { get; set; }
        public int Group { get; set; }

        public override string ToString()
        {
            return $"Имя: {Firstname} {Lastname}, Университет: {University}, Факультет: {Faculty}, Кафедра: {Department}, Город: {City}, Возраст: {Age}, Курс: {Course}, Группа: {Group}";
        }
    }
}