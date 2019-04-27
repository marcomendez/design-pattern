using System;

namespace Design_Patterns.Behavioral_Patterns.Chain_of_Responsability
{
    public class ErrorLogger : AbstractLogger
    {
        public ErrorLogger(int level)
        {
            this.level = level;
        }

        protected override void write(string message)
        {
           Console.WriteLine("Error Console::Logger: " + message);
        }
    }
}
