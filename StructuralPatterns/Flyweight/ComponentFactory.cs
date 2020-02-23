using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.StructuralPatterns.Flyweight
{
    public class ComponentFactory
    {
        private Dictionary<string, CustomComponent> components = new Dictionary<string, CustomComponent>();

        public CustomComponent getComponent(string color, string content)
        {
            CustomComponent cc;
            if (components.ContainsKey(color))
            {
                components.TryGetValue(color, out cc);
            }
            else
            {
                cc = new CustomComponent(color, content);
                components.Add(color, cc);
                
            }
            return cc;
        }
    }
}
