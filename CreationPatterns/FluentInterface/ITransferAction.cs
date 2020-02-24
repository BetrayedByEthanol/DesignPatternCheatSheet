using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.CreationPatterns.FluentInterface
{
    public interface ITransferAction
    {
        IReadData download(string path);
        IWriteData upload(string path);
    }
}
