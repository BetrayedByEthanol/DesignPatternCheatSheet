using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.State
{
    public class OrderConfirmedState : IOrderState
    {
        private Order order { get; set; }
        public OrderConfirmedState(Order order)
        {
            this.order = order;
        }
        public IOrderState cancelOrder()
        {
            Console.WriteLine("Order canceled ");
            return new OrderUnorderedState(order);
        }

        public IOrderState next()
        {
            Console.WriteLine("Order has been shipped");
            return new OrderShippedState(order);
        }
    }
}
