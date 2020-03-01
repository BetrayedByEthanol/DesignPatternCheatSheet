using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Interpreter
{
    public class YearInterpreter : IDateInput
    {
        public void interpret(Date date)
        {
            int var;
            int.TryParse(date.expression.Substring(6, 4), out var);
            date.year = var;
        }
    }
}
