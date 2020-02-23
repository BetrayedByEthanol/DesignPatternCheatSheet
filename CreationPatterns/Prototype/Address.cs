using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DesignPatternCheatSheet.CreationPatterns.Prototype
{
    public class Address : IPrototype<Address>
    {
        public AddressData data { get; set; }
        public Address(AddressData data) 
        {
            this.data = data;
        }
        public object Clone()
        {
            Address addressForDeepCopy = this.MemberwiseClone() as Address;
            addressForDeepCopy.data = new AddressData() { city = data.city, street = data.street};
            return addressForDeepCopy;
        }

        public Address deepCopy()
        {
            return this.Clone() as Address;
        }

        public Address shallowCopy()
        {
            return (Address) this.MemberwiseClone();
        }


    }
}
