using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Repository
{
    public interface IAuthorCollection : IRepository<string>
    {
        string getAuthor();
    }
}
