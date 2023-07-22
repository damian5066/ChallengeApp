
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

            employee.addGrade(5);
            employee.addGrade(10);
            employee.addGrade(2);
            employee.addGrade(3);

            employee2.addGrade(90);
            employee2.addGrade(80);
            employee2.addGrade(70);
            employee2.addGrade(100);

            //act
            var statistics = employee.GetStatistics();

            var statistics2 = employee2.GetStatistics();


            //assert
            Assert.AreEqual(5, statistics.Average);
            Assert.AreEqual(10, statistics.Max);
            Assert.AreEqual(2, statistics.Min);
            Assert.AreEqual('E', statistics.averageLetter);

            Assert.AreEqual(85, statistics2.Average);
            Assert.AreEqual(100, statistics2.Max);
            Assert.AreEqual(70, statistics2.Min);
            Assert.AreEqual('A', statistics2.averageLetter);

        }
    }
}


