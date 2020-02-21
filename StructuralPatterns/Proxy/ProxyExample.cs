using DesignPatternCheatSheet.StructuralPatterns.Proxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Proxy
{
    public class ProxyExample
    {
        public void test()
        {
            BookParserProxy bookParser = new BookParserProxy(new Book());
        }
    }
}
