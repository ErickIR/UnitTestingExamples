using Moq;
using NUnit.Framework;
using System;
using UnitTestingExamples;
using UnitTestingExamples.Interfaces;

namespace Tests
{
    public class GreeterTests
    {
        Greeter sut;
        ILogger mockLogger;

        [SetUp]
        public void Setup()
        {
            // Arrange
            mockLogger = Mock.Of<ILogger>();
            sut = new Greeter(mockLogger);
        }

        [TestCase("Erick", "Hello Erick")]
        public void Greet_ReturnsHelloName(string name, string expectedMessage)
        {
            // Act
            var result = sut.Greet(name, new DateTime(2020, 01, 01, 15, 30, 0));
            // Assert
            Assert.AreEqual(expectedMessage, result);
        }

        [TestCase(" Jhon ", "Hello Jhon")]
        public void Greet_TrimsTheInput_WhenThereAreWhiteSpacesAtTheBeginningOrTheEnd(string name, string expectedMessage)
        {
            // Arrange
            // Act
            var result = sut.Greet(name, new DateTime(2020, 01, 01, 15, 30, 0));
            // Assert
            Assert.AreEqual(expectedMessage, result);
        }

        [TestCase("jane", "Hello Jane")]
        public void Greet_CapitalizesFirstLetter(string name, string expectedMessage)
        {
            // Act
            var result = sut.Greet(name, new DateTime(2020, 01, 01, 15, 30, 0));
            // Assert
            Assert.AreEqual(expectedMessage, result);
        }

        [TestCase("Jhon", "01/20/2012 08:45", "Good morning Jhon")]
        [TestCase("Jhon", "01/20/2012 21:45", "Good evening Jhon")]
        [TestCase("Jhon", "01/20/2012 23:45", "Good night Jhon")]
        [TestCase("Jhon", "01/20/2012 04:45", "Good night Jhon")]
        public void Greet_ReturnsProperGreeting_BasedOnTheTime(string name, DateTime date, string expectedMessage)
        {
            // Act
            var result = sut.Greet(name, date);
            // Assert
            Assert.AreEqual(expectedMessage, result);
        }

        [TestCase("Jane", "Hello Jane")]
        public void Greet_LogsEveryTimeItIsCalled(string name, string expectedMessage)
        {
            // Act
            var result = sut.Greet(name, new DateTime(2020, 01, 01, 15, 30, 0));
            // Assert
            Assert.AreEqual(expectedMessage, result);
            Mock.Get(mockLogger)
                .Verify(
                    x => x.Log(It.IsAny<string>(), It.IsAny<LogType>()), 
                    Times.Once
                );
        }
    }
}