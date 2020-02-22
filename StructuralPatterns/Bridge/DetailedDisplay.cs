using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.StructuralPatterns.Bridge
{
    public class DetailedDisplay : DisplayType
    {
        public DetailedDisplay(IMediaType mediaType) : base(mediaType)
        {
        }
    }
}
