using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Repository
{
    public class AuthorCollection : Repository<string>, IAuthorCollection
    {
        public AuthorCollection(string db) : base(db) { }
    public string getAuthor()
        {
            return "random author";
        }
    }
}
