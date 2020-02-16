using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Decorator
{
    public class DecoratorExample
    {
        public void test()
        {
            Vehicle car1 = new LeatherSeatDecorator(new Car());

            Console.WriteLine("Car with a leather seat costs: " + car1.getCost());
            car1 = new FancyTiresDecorator(car1);
            Console.WriteLine("Car with fancy tires and a leather seat costs: " + car1.getCost());
            car1 = ((VehicleAddonDecorator)car1).vehicle;
        }
    }
}
