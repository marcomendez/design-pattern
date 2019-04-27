using System;

namespace Design_Patterns.Behavioral_Patterns.Chain_of_Responsability
{
    public class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(int level)
        {
            this.level = level;
        }

        protected override void write(String message)
        {
             Console.WriteLine("Standard Console::Logger: " + message);
        }
    }
}
