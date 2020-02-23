using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.CreationPatterns.Prototype
{
    public interface IPrototype<T> : ICloneable
    {
        T shallowCopy();
        T deepCopy();

    }
}
