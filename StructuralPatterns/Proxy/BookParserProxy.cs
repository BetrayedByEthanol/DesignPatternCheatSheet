using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.StructuralPatterns.Proxy
{
    public class BookParserProxy : IBookParser
    {
        private BookParser bookParser;
        private Book book;

        public BookParserProxy(Book book)
        {
            this.book = book;
        }

        public string getAuthor()
        {
            if (bookParser == null) bookParser = new BookParser(book);
            return bookParser.getAuthor();
        }

        public int getNumberChapters() 
        {
            if (bookParser == null) bookParser = new BookParser(book);
            return bookParser.getNumberChapters();
        }

        public int getNumberPages()
        {
            bookParser ??= new BookParser(book);
            return bookParser.getNumberPages();
        }
    }
}
