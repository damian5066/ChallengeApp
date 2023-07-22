using ChallengeApp;

//Employee employee1 = new Employee("Marek", "Chodny", 20); 

//employee1.addGrade(2.65532);
//employee1.addGrade('a');
//employee1.addGrade("60");
//employee1.addGrade("90");
//employee1.addGrade("9");

//var statistics = employee1.GetStatistics();
//Console.WriteLine($"Average: {statistics.Average:N2}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");
//Console.WriteLine(statistics.averageLetter);

Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
var employee = new Employee("Adam", "Hanha", 24);

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    employee.addGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AverageGrade: {statistics.averageLetter}");