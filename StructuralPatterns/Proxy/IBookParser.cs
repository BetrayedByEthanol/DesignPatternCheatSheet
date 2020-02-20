using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.StructuralPatterns.Proxy
{
    public interface IBookParser
    {

        public int getNumberPages();
        public int getNumberChapters();
        public string getAuthor();
    }
}
