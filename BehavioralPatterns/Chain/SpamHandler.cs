using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Chain
{
    public class SpamHandler : ILoginHandler
    {
        public ILoginHandler nextHandler { get; set; }
        private static int attemps = 0;


        public string handleLogin(string ip, string email, SecureString password)
        {
            if (attemps > 10) return "too many attemps"; else return new EmailHandler().handleLogin(ip, email, password);
        }
    }
}
