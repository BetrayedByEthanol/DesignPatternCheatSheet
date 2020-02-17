using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Iterator
{
    public class IteratorExample
    {
        public void test() 
        {
            BagInventory<string> bagInventory= new BagInventory<string>();
            BagIterator<string> bI = (BagIterator<string>)(bagInventory.getIterator());
            while(bI.hasNext())
            {
                Console.WriteLine(bI.current());
                bI.next();
            }

            ChestInventory<string> chestInventory = new ChestInventory<string>();
            ChestIterator<string> cI = (ChestIterator<string>)(chestInventory.getIterator());
            while (cI.hasNext())
            {
                Console.WriteLine(cI.current());
                cI.next();
            }
        }
    }
}
