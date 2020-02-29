using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.State
{
    public class Order
    {

        private IOrderState state {get; set;}

        public Order()
        {
            this.state = new OrderUnorderedState(this);
        }
        
        public void next()
        {
            state = state.next();
        }

        public void cancel()
        {
            state = state.cancelOrder();
        }


    }
}
