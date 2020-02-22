using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.StructuralPatterns.Composite
{
    public class Todo : TaskList
    {
        private string action { get; set; }
        public Todo(string action)
        {
            this.action = action;
        }
        public string printList()
        {
            return action + "\n";
        }
    }
}
