using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.StructuralPatterns.Flyweight
{
    public class CustomComponent : IComponent
    {
        private string color { get; set; }
        private string content { get; set; }

        public CustomComponent() { }
        public CustomComponent(string color, string content)
        {
            this.color = color;
            this.content = content;
        }

        public string displayText()
        {
            return this.content;
        }


    }
}
