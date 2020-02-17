using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Decorator
{
    public class Car : Vehicle
    {

        public override int getCost()
        {
            return 30000;
        }

        public override int getNumberOfWheels()
        {
            return 4;
        }
    }
}
