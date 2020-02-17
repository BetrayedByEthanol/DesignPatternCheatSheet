using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Singleton
{
    public class SingletonExample
    {
        public void test()
        {
            LogAThing.createInstance("hallo");
            LogAThing halloLogger = LogAThing.getInstance();

            LogAThing.createInstance(42);
            LogAThing fourtytwoLogger = LogAThing.getInstance();
        }
    }
}
