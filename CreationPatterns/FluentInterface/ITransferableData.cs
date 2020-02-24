using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.CreationPatterns.FluentInterface
{
    public interface ITransferableData
    {
        ITransferAction onData(string data);
        string connectionString { get; }
    }
}  
