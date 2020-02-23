using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private string dbContext { get; set; }
        public IAuthorRepository authors { get; }
        public IQuoteRepository quotes { get;  }

        public UnitOfWork(string db)
        {
            authors = new AuthorRepository(db);
            quotes = new QuoteRepository(db);
        }
        public void Dispose() { }
         
        public void save() { }
    }
}
