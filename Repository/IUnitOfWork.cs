using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IAuthorRepository authors { get; }
        IQuoteRepository quotes { get; }
        public void save();
    }
}
