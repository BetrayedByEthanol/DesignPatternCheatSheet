using DesignPatternCheatSheet.BehavioralPatterns.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Mediator
{
    public class MediatorExample
    {
        public void test()
        {
            IMediator server = new Server();
            IPlayer player1 = new Player(server);
            IPlayer player2 = new Player(server);
            player1.findMatch();
            player2.findMatch();
        }
    }
}
