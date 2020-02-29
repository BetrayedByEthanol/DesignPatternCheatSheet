using DesignPatternCheatSheet.BehavioralPatterns.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.State
{
    public class StateExample
    {
        public void test()
        {
            Order myOrder = new Order();

            myOrder.cancel();
            myOrder.next();
            myOrder.next();
            myOrder.cancel();
            myOrder.next();
            myOrder.next();
            myOrder.next();
            myOrder.next();
            myOrder.cancel();
        }
    }
}
