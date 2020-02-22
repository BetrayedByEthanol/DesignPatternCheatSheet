using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.StructuralPatterns.Bridge
{
    public class Music : IMediaType
    {
        public void listen() { }

        public void startMedia()
        {
            listen();
        }
    }
}
