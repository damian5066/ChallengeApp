using ChallengeApp;

Employee employee1 = new Employee("Marek", "Chodny", 20); 

employee1.addGrade(2);
employee1.addGrade(4);
employee1.addGrade(6);
employee1.addGrade(7);
employee1.addGrade(9);

var statistics = employee1.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");