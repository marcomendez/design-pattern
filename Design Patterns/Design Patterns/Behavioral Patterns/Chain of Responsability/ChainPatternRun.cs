using System;

namespace Design_Patterns.Behavioral_Patterns.Chain_of_Responsability
{
    public class ChainPatternRun
    {
        private static AbstractLogger getChainOfLoggers()
        {

            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.DEBUG);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);

            errorLogger.setNextLogger(fileLogger);
            fileLogger.setNextLogger(consoleLogger);

            return errorLogger;
        }

        public void run()
        {

            Console.WriteLine("************************** Chair pattern **********************************");
            AbstractLogger loggerChain = getChainOfLoggers();

            loggerChain.logMessage(AbstractLogger.INFO,
               "1 This is an information.");

            loggerChain.logMessage(AbstractLogger.DEBUG,
               "2 This is an debug level information.");

            loggerChain.logMessage(AbstractLogger.ERROR,
               "3 This is an error information.");
        }
    }
}
