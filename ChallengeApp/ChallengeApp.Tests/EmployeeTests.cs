
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

            employee2.addGrade(9);
            employee2.addGrade(8);
            employee2.addGrade(7);
            employee2.addGrade(10);

            //act
            var statistics = employee.GetStatistics();

            var statistics2 = employee2.GetStatistics();


            //assert
            Assert.AreEqual(5, statistics.Average);
            Assert.AreEqual(10, statistics.Max);
            Assert.AreEqual(2, statistics.Min);

            Assert.AreEqual(8.5, statistics2.Average);
            Assert.AreEqual(10, statistics2.Max);
            Assert.AreEqual(7, statistics2.Min);
        }
    }
}


