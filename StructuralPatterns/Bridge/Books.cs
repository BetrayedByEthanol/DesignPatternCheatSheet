using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.StructuralPatterns.Bridge
{
    public class Books : IMediaType
    {

        public void read() { }

        public void startMedia()
        {
            read();
        }
    }
}
