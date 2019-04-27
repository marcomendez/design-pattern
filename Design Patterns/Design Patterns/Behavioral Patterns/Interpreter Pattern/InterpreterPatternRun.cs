using System;

namespace Design_Patterns.Behavioral_Patterns.Interpreter_Pattern
{
    public class InterpreterPatternRun
    {
        //Rule: Robert and John are male
        public static Expression getMaleExpression()
        {
            Expression robert = new TerminalExpression("Robert");
            Expression john = new TerminalExpression("John");
            return new OrExpression(robert, john);
        }

        //Rule: Julie is a married women
        public static Expression getMarriedWomanExpression()
        {
            Expression julie = new TerminalExpression("Julie");
            Expression married = new TerminalExpression("Married");
            return new AndExpression(julie, married);
        }

        public void run()
        {
            Console.WriteLine("************************** Interpreter pattern **********************************");
            Expression isMale = getMaleExpression();
            Expression isMarriedWoman = getMarriedWomanExpression();

            Console.WriteLine("John is male? " + isMale.interpret("John"));
            Console.WriteLine("Julie is a married women? " + isMarriedWoman.interpret("Married Julie"));
        }
    }
}
