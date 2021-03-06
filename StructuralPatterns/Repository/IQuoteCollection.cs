﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Repository
{
    public interface IQuoteCollection : IRepository<string>
    {
        string getQuote();
    }
}
