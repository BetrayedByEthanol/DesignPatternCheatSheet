using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DesignPatternCheatSheet.BehavioralPatterns.Command
{
    public interface ICustomCommand : ICommand
    {
        void unexecute(object parameter);
    }
}
