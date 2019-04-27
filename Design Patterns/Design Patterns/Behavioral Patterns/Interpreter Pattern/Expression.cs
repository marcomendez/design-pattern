using System;

namespace Design_Patterns.Behavioral_Patterns.Interpreter_Pattern
{
    public interface Expression
    {
         bool interpret(string context);
    }
}
