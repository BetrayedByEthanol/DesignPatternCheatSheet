using DesignPatternCheatSheet.BehavioralPatterns.Chain;
using System;
using System.Collections.Generic;
using System.Net;
using System.Security;
using System.Text;

namespace DesignPatternCheatSheet.Chain
{
    public class ChainExample
    {
        public void test()
        {
            Server server = new Server();
            SecureString pw = new NetworkCredential("admin", "secretpassword").SecurePassword;

            server.login("127.0.0.1", "admin@server.com", pw);
        }
    }
}
