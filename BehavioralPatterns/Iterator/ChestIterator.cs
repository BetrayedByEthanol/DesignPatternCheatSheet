using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Iterator
{
    public class ChestIterator<T> : IInventoryIterator<T>
    {
        public ChestInventory<T> inventory { get { return inventory; } set { inventory = value; } }
        private int index { get; set; }

        public ChestIterator(ChestInventory<T> inventory)
        {
            this.inventory = inventory;
            index = 0;
        }
        public T current()
        {
            return inventory.items[index];
        }

        public bool hasNext()
        {
            return (inventory.items.Count > index);
        }

        public void next()
        {
            index++;
        }
    }
}
