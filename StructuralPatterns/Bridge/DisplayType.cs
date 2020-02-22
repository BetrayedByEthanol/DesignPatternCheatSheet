using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.StructuralPatterns.Bridge
{
    public abstract class DisplayType
    {
        public IMediaType mediaType { get; private set; }

        public DisplayType(IMediaType mediaType)
        {
            this.mediaType = mediaType;
        }

        public void display()
        {

        }
    }
}
