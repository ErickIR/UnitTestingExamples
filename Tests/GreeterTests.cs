using NUnit.Framework;

namespace Tests
{
    public class GreeterTests
    {
        [Test]
        public void Greet_SaysGoodMorning_WhenTimeIsBefore12PM()
        {
            // Arrange
            var sut = new Greeter();
            // Act
            var result = sut.Greet();
            // Assert
            Assert.AreEqual(result, "Good Morning");
        }
    }
}