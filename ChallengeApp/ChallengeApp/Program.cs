using ChallengeApp;

Employee employee1 = new Employee("Marek", "Chodny", 20); 
Employee employee2 = new Employee("Julia", "Mak", 33);
Employee employee3 = new Employee("Damian", "Sokolik", 35);
employee1.addScore(2);
employee1.addScore(4);
employee1.addScore(6);
employee1.addScore(7);
employee1.addScore(9);

employee2.addScore(2);
employee2.addScore(2);
employee2.addScore(2);
employee2.addScore(2);
employee2.addScore(2);

employee3.addScore(9);
employee3.addScore(9);
employee3.addScore(9);
employee3.addScore(8);
employee3.addScore(1);


List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxScore = -1;
Employee employeeWithMaxScore = null;

foreach (var employee in employees)
{
    if (employee.Sum > maxScore)
    {
        employeeWithMaxScore = employee;
    }
}
Console.WriteLine(employeeWithMaxScore.Name + " " + employeeWithMaxScore.Surname + " " + employeeWithMaxScore.Age + "lat, Uzyskany wynik: " + employeeWithMaxScore.Sum);

