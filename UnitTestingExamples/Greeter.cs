using System;
using UnitTestingExamples.Interfaces;

namespace UnitTestingExamples
{
    public class Greeter
    {
        private readonly ILogger _logger;
        
        public Greeter(ILogger logger)
        {
            _logger = logger;
        }

        public string Greet(string name, DateTime currentTime)
        {
            var cleanName = CleanName(name);
            
            string greeting = $"Hello {cleanName}";

            if (currentTime.Hour >= 6 && currentTime.Hour < 12)
                greeting = $"Good morning {cleanName}";
            if (currentTime.Hour >= 18 && currentTime.Hour < 22)
                greeting = $"Good evening {cleanName}";
            if (currentTime.Hour >= 22 || currentTime.Hour < 6)
                greeting = $"Good night {cleanName}";

            LogMethodCall(cleanName);
            return greeting;
        }

        private void LogMethodCall(string name) => _logger.Log($"Greeted {name}", LogType.Info);

        private string CleanName(string name)
        {
            var trimmedName = name.Trim();
            
            return char.ToUpper(trimmedName[0]) +
                trimmedName.Substring(1);
        }
    }
}
