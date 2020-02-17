using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Factory
{
    public interface IButtonComponent
    {
        public void doSomething();
        Action action { get; set; }
    }
}
