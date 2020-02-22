using DesignPatternCheatSheet.StructuralPatterns.Bridge;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Bridge
{
    public class BridgeExample
    {
        public void test()
        {
            CompactDisplay compactDisplayBooks = new CompactDisplay(new Books());
            CompactDisplay compactDisplayMusic = new CompactDisplay(new Music());
            CompactDisplay compactDisplayMovies = new CompactDisplay(new Movies());
            DetailedDisplay detailedDisplayBooks = new DetailedDisplay(new Books());
            DetailedDisplay detailedDisplayMusic = new DetailedDisplay(new Music());
            DetailedDisplay detailedDisplayMovies = new DetailedDisplay(new Movies());
            ListDisplay listDisplayBooks = new ListDisplay(new Books());
            ListDisplay listDisplayMusic = new ListDisplay(new Music());
            ListDisplay listDisplayMovies = new ListDisplay(new Movies());

            listDisplayMusic.mediaType.startMedia();
        }
    }
}
