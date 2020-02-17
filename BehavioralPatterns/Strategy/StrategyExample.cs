using DesignPatternCheatSheet.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Strategy
{
    public class StrategyExample
    {
        public void test()
        {
            DataManager dataManagerSQLToNoSQL = new DataManager(new CreatenoSQLEntry(), new LoadSQLEntry(), new SaveNoSQLEntry());
            DataManager dataManagerTextToNoSQL = new DataManager(new CreatenoSQLEntry(), new LoadTextfileData(), new SaveNoSQLEntry());
            dataManagerSQLToNoSQL.save(dataManagerSQLToNoSQL.load());
            dataManagerTextToNoSQL.create(dataManagerTextToNoSQL.load());
        }
    }
}
