using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Iterator
{
    public interface IInventory<T>
    {
        IInventoryIterator<T> getIterator();
    }
}
