using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Mediator
{
    public interface IMediator
    {
        public void findMatch(IPlayer player);
    }
}
