using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Chain
{
    public class Server
    {
        public void login(string ip, string email, SecureString password)
        {
            Console.WriteLine(new SpamHandler().handleLogin(ip, email, password));
        }
    }
}
