
namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnCorrectStatistics()
        {
            //arrange

            var employee = new Employee("Damian", "Brzytwa", 20);
            var employee2 = new Employee("Ola", "Oko", 23);

            employee.AddGrade(5);
            employee.AddGrade(10);
            employee.AddGrade(2);
            employee.AddGrade(3);

            employee2.AddGrade(90);
            employee2.AddGrade(80);
            employee2.AddGrade(70);
            employee2.AddGrade(100);

            //act
            var statistics = employee.GetStatistics();

            var statistics2 = employee2.GetStatistics();


            //assert
            Assert.AreEqual(5, statistics.Average);
            Assert.AreEqual(10, statistics.Max);
            Assert.AreEqual(2, statistics.Min);
            Assert.AreEqual('E', statistics.AverageLetter);

            Assert.AreEqual(85, statistics2.Average);
            Assert.AreEqual(100, statistics2.Max);
            Assert.AreEqual(70, statistics2.Min);
            Assert.AreEqual('A', statistics2.AverageLetter);

        }
    }
}


