using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Factory
{
    public class SpecificDataManagerFactory : IDataManagerFactory
    {
        public IDataManager getDataManager(string type)
        {
            switch (type)
            {
                case "noSQL":
                    return new noSQLDataManager();
                case "SQL":
                    return new SQLDataManager();
                case "Textfile":
                    return new TextfileDataManager();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
