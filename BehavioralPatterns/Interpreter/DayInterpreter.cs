using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Interpreter
{
    public class DayInterpreter : IDateInput
    {
        public void interpret(Date date)
        {
            int var;
            int.TryParse(date.expression.Substring(0, 2), out var);
            date.day = var;
        }
    }
}
