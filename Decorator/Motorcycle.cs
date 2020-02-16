using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Decorator
{
    public class Motorcycle : Vehicle
    {
        public override int getCost()
        {
            return 100;
        }

        public override int getNumberOfWheels()
        {
            return 2;
        }
    }
}
