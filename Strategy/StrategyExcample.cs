﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Strategy
{
    public class StrategyExcample
    {
        private ICreateStrategy createStrategy;
        private ILoadStrategy loadStrategy;
        private ISaveStrategy saveStrategy;
        public StrategyExcample(ICreateStrategy cs, ILoadStrategy ls, ISaveStrategy ss)
        {
            createStrategy = cs;
            loadStrategy = ls;
            saveStrategy = ss;
        }

        public void create(string data)
        {
            createStrategy.create(data);
        }

        public string load()
        {
            return loadStrategy.loadData();
        }

        public void save(string data)
        {
            saveStrategy.save(data);
        }
    }
}
