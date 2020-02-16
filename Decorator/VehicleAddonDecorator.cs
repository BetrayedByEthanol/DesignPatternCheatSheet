using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Decorator
{
    public abstract class VehicleAddonDecorator : Vehicle
    {
        public Vehicle vehicle { get; set; }
    }
}
