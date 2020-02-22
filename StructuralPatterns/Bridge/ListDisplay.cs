using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.StructuralPatterns.Bridge
{
    public class ListDisplay : DisplayType
    {
        public ListDisplay(IMediaType mediaType) : base(mediaType)
        {
        }
    }
}
