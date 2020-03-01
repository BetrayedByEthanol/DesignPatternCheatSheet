using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Chain
{
    public class EmailHandler : ILoginHandler
    {
        public ILoginHandler nextHandler { get; set; }

        public List<string> emails { get; set; }

        public string handleLogin(string ip, string email, SecureString password)
        {
            emails = new List<string>();
            emails.Add("admin@server.com");
            if (emails.Contains(email)) return new PasswordHandler().handleLogin(ip, email, password); else return "User does not exist";
        }
    }
}
