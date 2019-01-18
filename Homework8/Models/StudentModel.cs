using System.Collections.Generic;

namespace Homework8.Models
{
    public class StudentModel
    {
        public StudentModel()
        {
            
        }

        public StudentModel(IReadOnlyList<string> strings)
        {
            Firstname = strings[0];
            Lastname = strings[1];
            University = strings[2];
            Faculty = strings[3];
            Department = strings[4];
            Age = int.Parse(strings[5]);
            Course = int.Parse(strings[6]);
            Group = int.Parse(strings[7]);
            City = strings[8];
        }

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
