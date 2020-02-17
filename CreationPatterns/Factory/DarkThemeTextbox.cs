using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Factory
{
    public class DarkThemeTextbox : ITextboxComponent
    {
        public string readText()
        {
            return "read some Text";
        }
    }
}
