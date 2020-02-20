using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.StructuralPatterns.Proxy
{
    public class BookParserProxy : IBookParser
    {
        private BookParser bookParser;

        public BookParserProxy()
        {
            
        }

        public string getAuthor()
        {
            //bookParser new BookParser(new Book());
            return bookParser.getAuthor();
        }

        public int getNumberChapters() 
        {
            return bookParser.getNumberChapters();
        }

        public int getNumberPages()
        {
            return bookParser.getNumberPages();
        }
    }
}
