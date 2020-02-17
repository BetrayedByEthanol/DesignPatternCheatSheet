using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Iterator
{
    public class BagIterator<T> : IInventoryIterator<T>
    {
        private BagInventory<T> inventory { get { return inventory; } set { inventory = value; } }
        private int index { get; set; }

        public BagIterator(BagInventory<T> iterable)
        {
            inventory = iterable;
            index = 0;
        }
        
        public T current()
        {
            return (inventory.items[index] != null) ? inventory.items[index] : default(T);
        }

        public bool hasNext()
        {
            return (index < 10);
            
        }

        public void next()
        {
            index++;
        }
    }
}
