using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Factory
{
    public interface IDataManager
    {
        public void saveData();
        public void loadData();
    }
}
