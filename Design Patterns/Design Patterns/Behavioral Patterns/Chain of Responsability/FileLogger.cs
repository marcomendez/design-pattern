using System;

namespace Design_Patterns.Behavioral_Patterns.Chain_of_Responsability
{
    public class FileLogger : AbstractLogger
    {
        public FileLogger(int level)
        {
            this.level = level;
        }

        protected override void write(String message)
        {
            Console.WriteLine("File::Logger: " + message);
        }
    }
}
