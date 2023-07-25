using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new EmployeeInFile("Adam", "Hanha", 24, 'M');
employee.AddGrade(0.5f);
employee.AddGrade('A');
employee.AddGrade(89);
employee.AddGrade(40);
employee.AddGrade('c');
employee.AddGrade("91");

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");









//while (true)
//{
//    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
//    var input = Console.ReadLine();
//    if (input == "q")
//    {
//        break;
//    }

//    try
//    {
//        employee.AddGrade(input);

//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Exception catched {ex.Message}");
//    }
//}

//var statistics = employee.GetStatistics();
//Console.WriteLine($"Average: {statistics.Average}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");
//Console.WriteLine($"AverageGrade: {statistics.AverageLetter}");

//var supervisor = new Supervisor("Mariusz", "Chodny", 45, 'M');

//while (true)
//{
//    Console.WriteLine("Podaj kolejną ocenę kierownika: ");
//    var input = Console.ReadLine();
//    if (input == "q")
//    {
//        break;
//    }

//    try
//    {
//        supervisor.AddGrade(input);

//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Exception catched {ex.Message}");
//    }
//}

//var statistics = supervisor.GetStatistics();
//Console.WriteLine($"Average: {statistics.Average}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");
//Console.WriteLine($"AverageGrade: {statistics.AverageLetter}");