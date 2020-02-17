using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Factory
{
    public class DarkThemeFactory : IUIComponentFactory
    {
        public IButtonComponent getButton()
        {
            return new DarkThemeButton();
        }

        public ITextboxComponent getTextbox()
        {
            return new DarkThemeTextbox();
        }

        public ITextFieldComponent getTextField()
        {
            return new DarkThemeTextField();
        }
    }
}
