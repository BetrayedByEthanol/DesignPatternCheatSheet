using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Repository
{
    public class RepositoryExample
    {
        public void test()
        {
            UnitOfWork unit = new UnitOfWork("dbContext");
            Console.WriteLine(unit.quotes.getQuote());
            unit.save();
            unit.Dispose();
        }
    }
}
