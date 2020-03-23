using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Memento
{
    public class Memento
    {
        public GameState gameState { get; private set; }

        public Memento(GameState gameState)
        {
            this.gameState = gameState;
        }


    }
}
