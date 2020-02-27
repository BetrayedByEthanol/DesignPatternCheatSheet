using DesignPatternCheatSheet.CreationPatterns.Prototype;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Prototype
{
    public class PrototypeExample
    {
        public void test()
        {
            Address original = new Address(new AddressData() { street = "skidrow", city = "dumpster" });
            Console.WriteLine("Original Address " + original.data.street + " in the " + original.data.city);
            Address shallowCopy = original.shallowCopy();
            Console.WriteLine("Shallow Address " + shallowCopy.data.street + " in the " + shallowCopy.data.city);
            Address deepCopy = original.Clone() as Address;
            Console.WriteLine("Deep Address " + deepCopy.data.street + " in the " + deepCopy.data.city);
            Console.WriteLine("changin original");
            original.data.city = "trash";
            Console.WriteLine("Original Address " + original.data.street + " in the " + original.data.city);
            Console.WriteLine("Shallow Address " + shallowCopy.data.street + " in the " + shallowCopy.data.city);
            Console.WriteLine("Deep Address " + deepCopy.data.street + " in the " + deepCopy.data.city);
            Console.WriteLine("changing shallow");
            shallowCopy.data.city = "bin";
            Console.WriteLine("Original Address " + original.data.street + " in the " + original.data.city);
            Console.WriteLine("Shallow Address " + shallowCopy.data.street + " in the " + shallowCopy.data.city);
            Console.WriteLine("Deep Address " + deepCopy.data.street + " in the " + deepCopy.data.city);
            Console.WriteLine("changing deep");
            deepCopy.data.city = "garbage";
            Console.WriteLine("Original Address " + original.data.street + " in the " + original.data.city);
            Console.WriteLine("Shallow Address " + shallowCopy.data.street + " in the " + shallowCopy.data.city);
            Console.WriteLine("Deep Address " + deepCopy.data.street + " in the " + deepCopy.data.city);

        }
    }
}
