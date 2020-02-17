using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Factory
{
    public class DarkThemeTextField : ITextFieldComponent
    {
        public void getText(string text)
        {
            Console.WriteLine("new dark theme text is " + text);
        }
    }
}
