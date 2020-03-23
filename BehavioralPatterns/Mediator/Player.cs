using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Mediator
{
    public class Player : IPlayer
    {
        private IMediator server { get; set; }
        public Player(IMediator mediator)
        {
            server = mediator;
        }
        public void findMatch()
        {
            server.findMatch(this);
        }
    }
}
