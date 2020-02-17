using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Factory
{
    public class LightThemeButton : IButtonComponent
    {
        public void doSomething()
        {
            Console.WriteLine("Ima LightTheme Button");
        }
    }
}
