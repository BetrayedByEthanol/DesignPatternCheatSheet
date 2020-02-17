using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Command
{
    public class DeactivateCommand : ICustomCommand
    {
        public event EventHandler CanExecuteChanged =  (sender, e) => {  };
        private Receiver receiver { get; set; }

        public DeactivateCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public bool CanExecute(object parameter)
        {
            return (receiver.active);
        }

        public void Execute(object parameter)
        {
            receiver.deactivate();
        }

        public void unexecute(object parameter)
        {
            receiver.activate();
        }
    }
}
