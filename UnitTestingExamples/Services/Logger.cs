using System;
using UnitTestingExamples.Interfaces;

namespace UnitTestingExamples.Services
{
    public class Logger : ILogger
    {
        public void Log(string message, LogType logType)
        {
            Console.WriteLine($"{logType.ToString()}: {message}");
        }
    }
}
