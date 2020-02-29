using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.State
{
    public interface IOrderState
    {
        public IOrderState next();
        public IOrderState cancelOrder();

    }
}
