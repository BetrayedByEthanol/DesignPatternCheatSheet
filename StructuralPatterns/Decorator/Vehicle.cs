using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Decorator
{
    public abstract class Vehicle
    {
        public void drive()
        {
            Console.WriteLine("Ima driving");
        }

        public abstract int getNumberOfWheels();

        public abstract int getCost();
    }
}
