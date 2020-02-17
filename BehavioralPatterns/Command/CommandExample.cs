using DesignPatternCheatSheet.BehavioralPatterns.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Command
{
    public class CommandExample
    {
        public void test()
        {
            Receiver receiver = new Receiver();

            RemoteControl remoteControl = new RemoteControl(new ActivateCommand(receiver), new DeactivateCommand(receiver));

            remoteControl.turnOn();

            remoteControl.trunOff();

            remoteControl.undo();

            remoteControl.undo();
        }
    }
}
