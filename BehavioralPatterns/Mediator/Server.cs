using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Mediator
{
    public class Server : IMediator
    {
        private Queue<IPlayer> queue { get; set; }
        public Server()
        {
            queue = new Queue<IPlayer>();
        }
        public void findMatch(IPlayer player)
        {
            queue.Enqueue(player);
            if (queue.Count == 10) createMatch();
        }

        public void createMatch()
        {

        }
    }
}
