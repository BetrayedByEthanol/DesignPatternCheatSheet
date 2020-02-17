using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Factory
{
    public class DarkThemeButton : IButtonComponent
    {
        public Action action { get { return action; }  set { action = value; } }

        public void doSomething()
        {
            Console.WriteLine("Ima darkThemeButton");
        }

        public void performAction() 
        {
            action.Invoke();
        }
    }
}
