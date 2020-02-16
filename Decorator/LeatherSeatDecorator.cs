using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Decorator
{
    public class LeatherSeatDecorator : VehicleAddonDecorator
    {
        public LeatherSeatDecorator(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }
        public override int getCost()
        {
            return vehicle.getCost() + 500;
        }

        public override int getNumberOfWheels()
        {
            return vehicle.getNumberOfWheels();
        }
    }
}
