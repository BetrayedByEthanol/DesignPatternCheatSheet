using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Factory
{
    public class FactoryExcample
    {
        public IDataManager getDataManager(EDataManagerTypes type)
        {
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
    }
}
