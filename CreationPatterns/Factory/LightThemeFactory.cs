using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Factory
{
    public class LightThemeFactory : IUIComponentFactory
    {
        public IButtonComponent getButton()
        {
            return new LightThemeButton();
        }

        public ITextboxComponent getTextbox()
        {
            return new LightThemeTextbox();
        }

        public ITextFieldComponent getTextField()
        {
            return new LightThemeTextField();
        }
    }
}
