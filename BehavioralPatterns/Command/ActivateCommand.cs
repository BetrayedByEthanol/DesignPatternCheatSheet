using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Command
{
    public class ActivateCommand : ICustomCommand
    {
        public event EventHandler CanExecuteChanged = (sender, e) => { };
        private Receiver receiver { get; set; }

        public ActivateCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public bool CanExecute(object parameter)
        {
            return (!receiver.active);
        }

        public void Execute(object parameter)
        {
            receiver.activate();
        }

        public void unexecute(object parameter)
        {
            receiver.deactivate();
        }
    }
}
