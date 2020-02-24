using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.CreationPatterns.FluentInterface
{
    public interface IReadData
    {
        string fromFile();
        string fromServer();

    }
}
