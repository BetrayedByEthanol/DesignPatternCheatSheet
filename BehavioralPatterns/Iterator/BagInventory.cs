using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Iterator
{
    public class BagInventory<T> : IInventory<T>
    {
        public T[] items {get; set;}

        public BagInventory()
        {
            items = new T[10];
        }
        public IInventoryIterator<T> getIterator()
        {
            return new BagIterator<T>(this);
        }
    }
}
