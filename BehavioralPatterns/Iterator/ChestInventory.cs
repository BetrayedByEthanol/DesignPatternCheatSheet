using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Iterator
{
    public class ChestInventory<T> : IInventory<T>
    {
        public List<T> items { get; set; }

        public ChestInventory()
        {
            items = new List<T>();
        }
        public IInventoryIterator<T> getIterator()
        {
            return new ChestIterator<T>(this);
        }
    }
}
