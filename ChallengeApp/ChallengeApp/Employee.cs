
namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public void addGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }

        public void addGrade(double grade)
        {
            var doubleToFloat = (float)Math.Round(grade,2);
            this.addGrade(doubleToFloat);
        }
        public void addGrade(long grade)
        {
            var longToFloat = (float)grade;
            this.addGrade(longToFloat);
        }

        public void addGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.addGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }

        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;

            }
            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }


    }


}
