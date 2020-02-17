using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Factory
{
    public class LightThemeButton : IButtonComponent
    {
        public Action action { get { return action; } set { action = value; } }

        public void doSomething()
        {
            Console.WriteLine("Ima LightTheme Button");
        }
        public void performAction()
        {
            action.Invoke();
        }
    }
}
