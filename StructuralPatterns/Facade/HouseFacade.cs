using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.StructuralPatterns.Facade
{
    public class HouseFacade
    {
        private Heating heating { get; set; }
        private Plumming plumming { get; set; }
        private ElectricWiring electricWiring { get; set; }

        public HouseFacade()
        {
            heating = new Heating();
            plumming = new Plumming();
            electricWiring = new ElectricWiring();
        }

        public void turnOnCentralHeating()
        {
            heating.turnOnHeating();
        }

        public void fixPlumming()
        {
            plumming.fix();
        }

        public void fixCircuits()
        {
            electricWiring.fixCircuit();
        }
    }
}
