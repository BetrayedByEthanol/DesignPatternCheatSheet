using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Strategy
{
    public interface ICreateStrategy
    {
        public void create(string data);
    }
}
