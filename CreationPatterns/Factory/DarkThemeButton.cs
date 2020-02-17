using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Factory
{
    public class DarkThemeButton : IButtonComponent
    {
        public void doSomething()
        {
            Console.WriteLine("Ima darkThemeButton");
        }
    }
}
