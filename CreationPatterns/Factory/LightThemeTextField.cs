using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Factory
{
    public class LightThemeTextField : ITextFieldComponent
    {
        public void getText(string text)
        {
            Console.WriteLine("new light theme text is " + text);
        }
    }
}
