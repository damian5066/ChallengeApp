namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void GetIntValueReturnResult()
        {
            //arrange
            int number1 = 9;
            int number2 = 9;
            int number3 = 9;


            //act


            //assert
            Assert.AreEqual(number1, number2, number3);
        }

        [Test]
        public void GetDoubleValueReturnResult()
        {
            //arrange
            double doubleNumber1 = 9.2;
            double doubleNumber2 = 9.2;


            //act


            //assert
            Assert.AreEqual(doubleNumber1, doubleNumber2);
        }

        [Test]
        public void GetStringValueReturnResult()
        {
            //arrange
            string word1 = "Ejlalal";
            string word2 = "Ejlalal";


            //act


            //assert
            Assert.AreEqual(word1, word2);
        }

        [Test]
        public void GetUserShouldReturnDifferentObjects()
        {
            //arrange
            var employee1 = getEmployee("Adam", "Sowa", 45);
            var employee2 = getEmployee("Adam", "Lotos", 17);


            //act


            //assert
            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee getEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
