using System;

namespace Design_Patterns.Behavioral_Patterns.Chain_of_Responsability
{
    public abstract class AbstractLogger
    {
        public static int INFO = 1;
        public static int DEBUG = 2;
        public static int ERROR = 3;

        protected int level;

        //next element in chain or responsibility
        protected AbstractLogger nextLogger;

        public void setNextLogger(AbstractLogger nextLogger)
        {
            this.nextLogger = nextLogger;
        }

        public void logMessage(int level, string message)
        {
            if (this.level <= level)
            {
                write(message);
            }
            if (nextLogger != null)
            {
                nextLogger.logMessage(level, message);
            }
        }

        abstract protected void write(string message);
    }
}
