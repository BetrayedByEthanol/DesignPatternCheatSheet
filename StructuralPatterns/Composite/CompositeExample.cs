using DesignPatternCheatSheet.StructuralPatterns.Composite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Composite
{
    public class CompositeExample
    {
        public void test()
        {
            TaskList onlyOneElement = new Todo("Get money");
            Console.WriteLine(onlyOneElement.printList());


            List<TaskList> subTasks = new List<TaskList>();
            subTasks.Add(new Todo("buy potatos"));
            subTasks.Add(new Todo("buy veggies"));
            subTasks.Add(new Todo("buy meat"));
            subTasks.Add(new Todo("buy more meat"));
            List<TaskList> anotherTask = new List<TaskList>();
            anotherTask.Add(new Todo("buy potato chip"));
            anotherTask.Add(new Todo("buy chocolate"));
            Task secondTask = new Task("buy snacks", anotherTask, 2);
            subTasks.Add(secondTask);
            TaskList taskList = new Task("Buy Food", subTasks, 1);
            subTasks.Add(new Todo("buy salt"));

            Console.WriteLine(taskList.printList());
        }
    }
}
