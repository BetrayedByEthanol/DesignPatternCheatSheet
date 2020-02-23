using DesignPatternCheatSheet.StructuralPatterns.Flyweight;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Flyweight
{
    public class FlyweightExample
    {
        public void test()
        {
            List<CustomComponent> components = new List<CustomComponent>();
            ComponentFactory componentFactory = new ComponentFactory();

            for(int i = 0; i < 100000 ; i++)
            {
                components.Add(componentFactory.getComponent("rando Color","rando content"));
            }


        }
    }
}
