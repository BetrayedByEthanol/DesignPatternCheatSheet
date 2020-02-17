using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Singleton
{
    public class LogAThing
    {

        private static LogAThing instance;
        private LogAThing(string param)
        {

        }

        private LogAThing(int param)
        {

        }

        public static LogAThing createInstance(string param)
        {
            instance = new LogAThing(param);
            return instance;
        }

        public static LogAThing createInstance(int param)
        {
            instance = new LogAThing(param);
            return instance;
        }

        public static void disposeInstance()
        {
            instance = null;
        }

        public static LogAThing getInstance()
        {
            return instance;
        }
    }
}
