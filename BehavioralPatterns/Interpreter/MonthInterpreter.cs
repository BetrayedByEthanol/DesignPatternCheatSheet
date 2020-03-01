using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Interpreter
{
    public class MonthInterpreter : IDateInput
    {
        public void interpret(Date date)
        {
            int var;
            int.TryParse(date.expression.Substring(3, 2), out var);
            date.month = var;
        }
    }
}
