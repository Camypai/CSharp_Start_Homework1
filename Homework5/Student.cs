namespace Homework5
{
    public class Student
    {
        private string _lastname;
        private string _firstname;
        
        public string Lastname
        {
            get => _lastname;
            set
            {
                if (value.Length <= 20) _lastname = value;
            }
        }

        public string Firstname
        {
            get => _firstname;
            set
            {
                if (value.Length <= 20) _firstname = value;
            }
        }

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