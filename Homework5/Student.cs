namespace Homework5
{
    public class Student
    {
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public int Ball1 { get; set; }
        public int Ball2 { get; set; }
        public int Ball3 { get; set; }

        public int Average
        {
            get
            {
                var average = (Ball1 + Ball2 + Ball3) / 3;
                return average;
            }
        }

        public override string ToString()
        {
            return $"{Lastname} {Firstname} {Ball1} {Ball2} {Ball3} Средний балл: {Average}";
        }
    }
}