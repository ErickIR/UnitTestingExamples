using NUnit.Framework;
using UnitTestingExamples;

namespace Tests
{
    public class GreeterTests
    {
        [Test]
        public void Greet_SaysGoodMorning_WhenHourIsBetween5AMAnd12PM()
        {
            // Arrange
            var sut = new Greeter();
            // Act
            //var result = sut.Greet(new System.DateTime(2020, 01, 01, 6, 0, 0));
            var result = sut.Greet();
            // Assert
            Assert.AreEqual("Good Morning", result);
        }

        [Test]
        public void Greet_SaysGoodAfternoon_WhenHourIsBetween12PMAnd6Pm()
        {
            // Arrange
            var sut = new Greeter();
            // Act
            //var result = sut.Greet(new System.DateTime(2020, 01, 01, 15, 0,0));
            var result = sut.Greet();
            // Assert
            Assert.AreEqual("Good Afternoon", result);
        }

        [Test]
        public void Greet_SaysGoodNight_WhenHourIsPast6Pm()
        {
            // Arrange
            var sut = new Greeter();
            // Act
            //var result = sut.Greet(new System.DateTime(2020, 01, 01, 19, 0, 0));
            var result = sut.Greet();
            // Assert
            Assert.AreEqual("Good Night", result);
        }
    }
}