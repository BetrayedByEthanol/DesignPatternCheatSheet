using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatternCheatSheet.StructuralPatterns.Adapter
{
    public class RequestAdapter : Request
    {
        public override void sendRequest(string url)
        {
            new FTPRequest().sendFTPRequest(new StreamReader(url));
        }
    }
}
