using System;
using UnitTestingExamples.Services;

namespace UnitTestingExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a greeter demo. Write your name: ");
            string name = Console.ReadLine();
            
            var greeter = new Greeter(logger: new Logger());
            var greeting = greeter.Greet(name, DateTime.Now);
            Console.WriteLine(greeting);
        }
    }
}
