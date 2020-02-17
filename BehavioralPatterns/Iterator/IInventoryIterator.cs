using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Iterator
{
    public interface IInventoryIterator<T>
    {
        bool hasNext();
        void next();
        T current();
    }
}
