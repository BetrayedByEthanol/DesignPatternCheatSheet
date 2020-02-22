using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.StructuralPatterns.Composite
{
    public class Task : TaskList
    {
        private string taskName { get; set; }
        private int level { get; set; }
        private List<TaskList> tasks { get; set; }
        
        public Task(string name, List<TaskList> tasks, int i)
        {
            level = i;
            taskName = name;
            this.tasks = tasks;
        }
        public string printList()
        {
            string list = "";
            list += taskName + "\n" ;
            
            foreach(TaskList tl in tasks)
            {
                for (int i = 0; i < level; i++) list += "\t";
                list += tl.printList();
            }
            return list;
        }
    }
}
