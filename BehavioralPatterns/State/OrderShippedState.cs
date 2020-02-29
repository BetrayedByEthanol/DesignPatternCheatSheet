using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.State
{
    public class OrderShippedState : IOrderState
    {
        private Order order { get; set; }
        public OrderShippedState(Order order)
        {
            this.order = order;
        }
        public IOrderState cancelOrder()
        {
            Console.WriteLine("can no longer cancel order order already shipped");
            return this;
        }

        public IOrderState next()
        {
            Console.WriteLine("Order has been delivered...");
            return new OrderCompletedState(order);
        }
    }
}
