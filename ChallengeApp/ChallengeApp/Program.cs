
Employee Employee1 = new Employee("Marek", "Chodny", 20); 
Employee Employee2 = new Employee("Julia", "Mak", 33);
Employee Employee3 = new Employee("Damian", "Sokolik", 35);
Employee1.addScore(2);
Employee1.addScore(4);
Employee1.addScore(6);
Employee1.addScore(7);
Employee1.addScore(9);

Employee2.addScore(2);
Employee2.addScore(2);
Employee2.addScore(2);
Employee2.addScore(2);
Employee2.addScore(2);

Employee3.addScore(9);
Employee3.addScore(9);
Employee3.addScore(9);
Employee3.addScore(8);
Employee3.addScore(1);


List<Employee> employees = new List<Employee>()
{
    Employee1, Employee2, Employee3
};

int maxScore = -1;
Employee EwithMaxScore = null;

foreach (var employee in employees)
{
    if (employee.Sum > maxScore)
    {
        EwithMaxScore = employee;
    }
}
Console.WriteLine(EwithMaxScore.Name + " " + EwithMaxScore.Surname + " " + EwithMaxScore.Age + "lat, Uzyskany wynik: " + EwithMaxScore.Sum);

class Employee
{
    private List<int> score = new List<int>();

    public Employee(string name, string surname, int age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }

    public string Name { get; private set; }
    public string Surname { get; private set; }
    public int Age { get; private set; }

    public int Sum
    {
        get
        {
            return this.score.Sum();
        }
    }

    public void addScore(int points)
    {
        this.score.Add(points);
    }
}

