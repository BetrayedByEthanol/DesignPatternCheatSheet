using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Factory
{
    public interface IDataManagerFactory
    {
        public IDataManager getDataManager(string param);
    }
}
