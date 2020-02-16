using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Decorator
{
    public class FancyTiresDecorator : VehicleAddonDecorator
    {
        public FancyTiresDecorator(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }
        public override int getCost()
        {
            return vehicle.getCost() + 2000; 
        }

        public override int getNumberOfWheels()
        {
            return vehicle.getNumberOfWheels();
        }
    }
}
