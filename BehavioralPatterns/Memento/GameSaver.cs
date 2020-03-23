using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Memento
{
    public class GameSaver
    {
        public GameState gameState { get; set; }

        public Memento saveGameState()
        {
            return new Memento(gameState);
        }

        public void loadGameState(Memento memento)
        {
            gameState = memento.gameState;

        }
    }
}
