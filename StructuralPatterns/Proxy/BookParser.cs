using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.StructuralPatterns.Proxy
{
    public class BookParser : IBookParser
    {
        public BookParser(Book book)
        {

        }

        public int getNumberPages() => 0;
        public int getNumberChapters() => 0;
        public string getAuthor() => "";
    }
}
