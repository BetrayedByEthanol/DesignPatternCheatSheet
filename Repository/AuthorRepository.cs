using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Repository
{
    public class AuthorRepository : Repository<string>, IAuthorRepository
    {
        public AuthorRepository(string db) : base(db) { }
    public string getAuthor()
        {
            return "random author";
        }
    }
}
