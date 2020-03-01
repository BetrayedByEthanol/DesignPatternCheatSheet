using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Chain
{
    public class UserDataHandler : ILoginHandler
    {
        public ILoginHandler nextHandler { get; set; }
        public string handleLogin(string ip, string email, SecureString password)
        {
            string userdata = "admin";
            return new LoginTokenHandler() { userdata = userdata }.handleLogin(ip, email, password);
        }
    }
}
