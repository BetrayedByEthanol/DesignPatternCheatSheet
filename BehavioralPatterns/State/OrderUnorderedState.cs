using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.State
{
    public class OrderUnorderedState : IOrderState
    {
        private Order order { get; set; }
        public OrderUnorderedState(Order order)
        {
            this.order = order;
        }
        public IOrderState cancelOrder()
        {
            Console.WriteLine("Order hasnt been placed yet");
            return this;
        }

        public IOrderState next()
        {
            Console.WriteLine("Order placed, thank you for ordering some trash");
            return new OrderPlacedState(order);
        }
    }
}
