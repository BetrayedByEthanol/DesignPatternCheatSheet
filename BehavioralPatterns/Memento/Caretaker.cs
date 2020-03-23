using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Memento
{
    public class Caretaker
    {
        private List<Memento> mementos { get; set; }

        public Caretaker()
        {
            mementos = new List<Memento>();
        }

        public void addGameState(Memento memento)
        {
            mementos.Add(memento);
        }

        public Memento getGameState(int index)
        {
            return mementos[index];
        }
    }
}
