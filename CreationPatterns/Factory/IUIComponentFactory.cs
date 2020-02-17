using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Factory
{
    public interface IUIComponentFactory
    {
        public IButtonComponent getButton();
        public ITextboxComponent getTextbox();
        public ITextFieldComponent getTextField();
    }
}
