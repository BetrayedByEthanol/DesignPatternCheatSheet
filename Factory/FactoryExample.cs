using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Factory
{
    public class FactoryExample
    {
        public void test()
        {
            IDataManager dataManager = new DataManagerFactory().getDataManager("URI of the data");
            IDataManager dataManager1 = new SpecificDataManagerFactory().getDataManager("noSQL");
            dataManager.loadData();
            dataManager1.saveData();
        }
    }
}
