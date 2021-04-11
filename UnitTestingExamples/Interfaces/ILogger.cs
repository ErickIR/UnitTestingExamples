using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingExamples.Interfaces
{
    public interface ILogger
    {
        public void Log(string message, LogType logType);
        
    }

    public enum LogType
    {
        Debug,
        Info,
        Error,
    }
}
