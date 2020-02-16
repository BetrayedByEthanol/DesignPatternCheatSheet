using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Strategy
{
    public interface ISaveStrategy
    {
        public void save(string data);
    }
}
