using DesignPatternCheatSheet.StructuralPatterns.Facade;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Facade
{
    public class FacadeExample
    {
        public void test() 
        {
            HouseFacade house = new HouseFacade();

            house.fixCircuits();
            house.fixPlumming();
            house.turnOnCentralHeating();
        }
    }
}
