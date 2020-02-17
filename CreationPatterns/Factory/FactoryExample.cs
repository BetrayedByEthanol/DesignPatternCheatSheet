using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Factory
{
    public class FactoryExample
    {
        public void test()
        {
            IUIComponentFactory lightFactory = new LightThemeFactory();
            IUIComponentFactory darkFactory = new DarkThemeFactory();

            IButtonComponent lightButton = lightFactory.getButton();
            IButtonComponent darkButton = darkFactory.getButton();
            ITextboxComponent lightTextbox = lightFactory.getTextbox();
            ITextboxComponent darkTextbox = darkFactory.getTextbox();
            ITextFieldComponent lightTextField = lightFactory.getTextField();
            ITextFieldComponent darkTextField = darkFactory.getTextField();

        }
    }
}
