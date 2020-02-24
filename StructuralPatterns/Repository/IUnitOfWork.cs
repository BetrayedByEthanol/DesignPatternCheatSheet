using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IAuthorCollection authors { get; }
        IQuoteCollection quotes { get; }
        public void save();
    }
}
