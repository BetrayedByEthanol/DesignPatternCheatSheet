using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.CreationPatterns.FluentInterface
{
    public interface IWriteData
    {
        void toFile(string data);
        void toServer(string data);
    }
}
