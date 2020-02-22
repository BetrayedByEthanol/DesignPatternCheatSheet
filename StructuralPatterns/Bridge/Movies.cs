using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.StructuralPatterns.Bridge
{
    public class Movies :  IMediaType
    {
        public void startMedia()
        {
            watch();
        }

        public void watch() { }
    }
}
