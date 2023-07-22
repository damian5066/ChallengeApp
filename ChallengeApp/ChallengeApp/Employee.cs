
using System.Diagnostics;

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
            var doubleToFloat = (float)Math.Round(grade, 2);
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

        public void addGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.addGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.addGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.addGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.addGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.addGrade(20);
                    break;
                default:
                    Console.WriteLine("Wrong Letter");
                    break;
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

            switch(statistics.Average)
            {
                case var average when average >= 80:
                    statistics.averageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.averageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.averageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.averageLetter = 'D';
                    break;
                default:
                    statistics.averageLetter = 'E';
                    break;
            }
            return statistics;
        }

    }


}
