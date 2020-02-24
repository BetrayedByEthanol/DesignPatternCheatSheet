using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DesignPatternCheatSheet.Repository
{
    public class QuoteCollection : Repository<string>, IQuoteCollection
    {
        public QuoteCollection(string db) : base(db) { }
        public string getQuote()
        {
            return "get a random quote";
        }

    }
}
