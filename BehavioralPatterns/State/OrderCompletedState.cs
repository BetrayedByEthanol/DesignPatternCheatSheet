using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.State
{
    public class OrderCompletedState : IOrderState
    {
        private Order order { get; set; }
        public OrderCompletedState(Order order)
        {
            this.order = order;
        }
        public IOrderState cancelOrder()
        {
            Console.WriteLine("Order Complete can't cancel");
            return this;
        }

        public IOrderState next()
        {
            Console.WriteLine("Order is complete");
            return this;
        }
    }
}
