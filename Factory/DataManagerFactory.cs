using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Factory
{
    public class DataManagerFactory : IDataManagerFactory
    {
        public IDataManager getDataManager(string uri)
        {
            EDataManagerTypes type = getDataManagerType(uri);
            switch (type) 
            {
                case (EDataManagerTypes.noSQL):
                    return new noSQLDataManager();
                case EDataManagerTypes.SQL:
                    return new SQLDataManager();
                case EDataManagerTypes.Textfile:
                    return new TextfileDataManager();
                default:
                    throw new MissingMemberException();
            }
        }

        private EDataManagerTypes getDataManagerType(string uri)
        {
            if (uri.Contains("27017")) return EDataManagerTypes.noSQL;
            if (uri.Contains("3306")) return EDataManagerTypes.SQL;
            if (uri.Contains("txt")) return EDataManagerTypes.Textfile;
            throw new NotSupportedException();
        }
    }
}
