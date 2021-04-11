using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingExamples
{
    public class Greeter
    {
        public string Greet()
        {
            var dateTime = DateTime.Now;
            if (dateTime.Hour > 5 && dateTime.Hour < 12)
                return "Good Morning";
            if (dateTime.Hour >= 12 && dateTime.Hour < 18)
                return "Good Afternoon";
            else
                return "Good Night";
        }
    }
}
