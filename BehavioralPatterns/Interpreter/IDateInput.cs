using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Interpreter
{
    public interface IDateInput
    {
        void interpret(Date date);
    }
}
