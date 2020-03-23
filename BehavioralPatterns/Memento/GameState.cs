using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Memento
{
    public class GameState
    {
        public string text { get; set; }
        public GameState(string s)
        {
            this.text = s;
        }
    }
}
