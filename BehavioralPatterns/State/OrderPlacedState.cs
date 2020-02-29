using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.State
{
    public class OrderPlacedState : IOrderState
    {
        private Order order { get; set; }
        public OrderPlacedState(Order order)
        {
            this.order = order;
        }
        public IOrderState cancelOrder()
        {
            Console.WriteLine("returning to cart...");
            return new OrderUnorderedState(order);
        }

        public IOrderState next()
        {
            bool payed = true;
            Console.WriteLine("Checking payment....");
            if(payed) 
            { 
                Console.WriteLine("payment was ok"); 
                return new OrderConfirmedState(order); 
            } 
            else 
            { 
                Console.WriteLine("payment rejected..."); 
                return new OrderUnorderedState(order); 
            }
        }
    }
}
