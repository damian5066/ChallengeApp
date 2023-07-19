
namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void WhenEmployeeCollectScores_ShouldReturnCorrectResult()
        {
            //arrange

            var employee = new Employee("Damian", "Brzytwa", 20);
            employee.addScore(5);
            employee.addScore(10);
            employee.addScore(1);
            employee.addScore(7);

            //act
            var result = employee.Sum;

            //assert
            Assert.AreEqual(23, result);
        }
    


    [Test]
    public void WhenEmployeeSubtractScores_ShouldReturnCorrectResult()
    {
        //arrange

        var employee = new Employee("Damian", "Bajka", 20);
        employee.addScore(5);
        employee.addScore(10);
        employee.subtractScore(5);
        employee.subtractScore(10);

        //act
        var result = employee.Sum;

        //assert
        Assert.AreEqual(0, result);
    }
}
}