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

        public static SingletonExcample getInstance()
        {
            return instance;
        }
    }
}
