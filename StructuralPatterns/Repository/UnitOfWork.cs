using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private string dbContext { get; set; }
        public IAuthorCollection authors { get; }
        public IQuoteCollection quotes { get;  }

        public UnitOfWork(string db)
        {
            authors = new AuthorCollection(db);
            quotes = new QuoteCollection(db);
        }
        public void Dispose() { }
         
        public void save() { }
    }
}
