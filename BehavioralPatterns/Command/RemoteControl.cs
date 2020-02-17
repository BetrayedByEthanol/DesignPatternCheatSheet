using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Command
{
    public class RemoteControl
    {
        private ICustomCommand activate { get; set; }
        private ICustomCommand deactivate { get; set; }
        private List<ICustomCommand> commands { get; set; }

        public RemoteControl(ICustomCommand activate, ICustomCommand deactivate)
        {
            this.activate = activate;
            this.deactivate = deactivate;
            commands = new List<ICustomCommand>(); 
        }

        public void turnOn()
        {
            if (activate.CanExecute(null))
            {
                activate.Execute(null);
                commands.Add(activate);
            }
        }

        public void trunOff()
        {
            if (deactivate.CanExecute(null))
            {
                deactivate.Execute(null);
                commands.Add(deactivate);
            }
        }

        public void undo()
        {
            if(commands.Count > 0 )
            {
                commands[commands.Count - 1].unexecute(null);
                commands.RemoveAt(commands.Count - 1);
            }
        }
    }
}
