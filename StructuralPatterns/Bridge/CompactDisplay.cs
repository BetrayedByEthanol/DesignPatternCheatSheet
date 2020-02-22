using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.StructuralPatterns.Bridge
{
    public class CompactDisplay : DisplayType
    {
        public CompactDisplay(IMediaType mediaType) : base(mediaType)
        {
        }
    }
}
