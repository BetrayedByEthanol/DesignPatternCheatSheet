using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Singleton
{
    public class SingletonExcample
    {

        private static SingletonExcample instance;
        private SingletonExcample(string param)
        {

        }

        private SingletonExcample(int param)
        {

        }

        public static SingletonExcample createInstance(string param)
        {
            if(instance == null) instance = new SingletonExcample(param);
            return instance;
        }

        public static SingletonExcample createInstance(int param)
        {
            if (instance == null) instance = new SingletonExcample(param);
            return instance;
        }

        public static void disposeInstance()
        {
            instance = null;
        }

        public static SingletonExcample getInstance()
        {
            return instance;
        }
    }
}
