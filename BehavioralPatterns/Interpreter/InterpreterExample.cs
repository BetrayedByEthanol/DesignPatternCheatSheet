using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Interpreter
{
    public class InterpreterExample
    {
        public void test()
        {
            Date date = new Date();
            date.expression = "01.09.1939";

            new DayInterpreter().interpret(date);
            new MonthInterpreter().interpret(date);
            new YearInterpreter().interpret(date);
            Console.WriteLine("get day " + date.day);
            Console.WriteLine("get month " + date.month);
            Console.WriteLine("get year " + date.year);
        }
    }
}
