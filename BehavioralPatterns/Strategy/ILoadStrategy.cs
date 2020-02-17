using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Strategy
{
    public interface ILoadStrategy
    {
        public string loadData();
    }
}
