namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
       
        private List<float> grades = new List<float>();

        public override event GradeAddedDelegate GradeAdded;

        public EmployeeInMemory(string name, string surname, int age, char sex)
            : base(name, surname, age, sex)
        {

        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddGrade(double grade)
        {
            var doubleToFloat = (float)Math.Round(grade, 2);
            this.AddGrade(doubleToFloat);
        }

        public override void AddGrade(long grade)
        {
            var longToFloat = (float)grade;
            this.AddGrade(longToFloat);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach(var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }

}
